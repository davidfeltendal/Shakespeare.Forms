using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using Shakespeare.Forms.Models;
using Shakespeare.Forms.Models.Kataloger;

namespace Shakespeare.Forms.Controllers
{
    public class OpretBehandlingController
    {
        private readonly Patient patient;
        private readonly IBehandlingKatalog behandlinger;
        private readonly IPersonaleKatalog personale;
        private readonly ILokaleKatalog lokaler;
        private readonly IJournalKatalog journal;
        private readonly IOpholdKatalog ophold;
        private readonly IVærelseKatalog værelser;

        private IList<Operation> operationer;
        private IList<Genoptræning> genoptræninger; 

        public OpretBehandlingController(
            Patient patient,
            IBehandlingKatalog behandlinger, 
            IPersonaleKatalog personale,
            ILokaleKatalog lokaler,
            IJournalKatalog journal,
            IOpholdKatalog ophold, 
            IVærelseKatalog værelser)
        {
            this.patient = patient;
            this.behandlinger = behandlinger;
            this.personale = personale;
            this.lokaler = lokaler;
            this.journal = journal;
            this.ophold = ophold;
            this.værelser = værelser;
        }

        public Patient Patient
        {
            get { return this.patient; }
        }

        public IList<Operation> HentOperationer()
        {
            return this.operationer ?? (this.operationer = this.behandlinger.HentOperationer());
        }

        public IList<Genoptræning> HentGenoptræninger()
        {
            return this.genoptræninger ?? (this.genoptræninger = this.behandlinger.HentGenoptræninger());
        }

        public void GemBehandling(Ophold ophold, Behandling behandling, Lokale lokale, DateTimeOffset start, DateTimeOffset slut, IList<Personale> tilknyttetPersonale)
        {
            using (var transactionScope = new TransactionScope())
            {
                Behandlingslinje behandlingslinje = this.behandlinger.OpretBehandling(ophold, behandling, lokale, start, slut);

                foreach (var person in tilknyttetPersonale)
                {
                    this.personale.TilknytTilBehandlingslinje(person, behandlingslinje);
                }

                Journallinje journallinje = this.journal.IndsætJournallinje(ophold.PatientCpr,
                    "Behandling: " + behandling.Navn, start.DateTime);
                this.journal.TilknytJournallinjeMedBehandlingslinje(journallinje, behandlingslinje);

                transactionScope.Complete();
            }
        }


        public IList<Speciale> HentSpecialer()
        {
            return this.personale.HentSpecialer();
        }

        public IList<Personale> HentPersonale()
        {
            return this.personale.HentAlle();
        }

        public IList<LokaleMedTid> HentLokalerMedTid(DateTime dato)
        {
            IList<LokaleMedTid> lokaler = this.lokaler.HentLokaler().Select(l => new LokaleMedTid(l)).ToList();
            IList<Behandlingslinje> behandlingslinjer = this.behandlinger.HentBehandlingslinjerForDato(dato);            

            foreach (Behandlingslinje behandlingslinje in behandlingslinjer)
            {
                // Find den række, der matcher lokale.                
                int lokaleId = behandlingslinje.LokaleId;
                LokaleMedTid lokale = lokaler.SingleOrDefault(lmt => lmt.Lokale.Id == lokaleId);

                if (lokale == null)
                {
                    continue;
                }

                int startIndex = behandlingslinje.Start.Hour;
                int slutIndex = behandlingslinje.Slut.Hour;

                for (int i = startIndex; i <= slutIndex; i++)
                {
                    lokale[i] = true;
                }
            }

            return lokaler;
        }

        public IList<Personale> PersonaleDerIkkeKanArbejdeITidsrum(DateTime behandlingsdato, IList<Personale> personale)
        {
            return personale.Where(p => !p.KanArbejdeITidsrum(behandlingsdato)).ToList();
        }

        public IList<Værelse> HentLedigeVærelser(DateTime start, DateTime slut, int antalSenge)
        {
            return this.værelser.HentLedigeVærelser(start, slut, antalSenge);
        }

        public IList<Forplejning> HentForplejninger()
        {
            return this.ophold.HentForplejninger();
        }

        public Ophold OpretOphold(DateTime start, DateTime slut, Forplejning forplejning, Værelse værelse)
        {
            return this.ophold.OpretOphold(this.patient, start, slut, forplejning, værelse);
        }
    }
}