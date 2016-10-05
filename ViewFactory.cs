using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Shakespeare.Forms.Controllers;
using Shakespeare.Forms.Models;
using Shakespeare.Forms.Models.Kataloger;
using Shakespeare.Forms.Views;

namespace Shakespeare.Forms
{
    public class ViewFactory : IViewFactory
    {
        private readonly IDbConnectionFactory connectionFactory;

        public ViewFactory(IDbConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public BehandlingForm SkabBehandlingForm(Patient patient)
        {
            IBehandlingKatalog behandlinger = new BehandlingKatalog(this.connectionFactory);
            IPersonaleKatalog personale = new PersonaleKatalog(this.connectionFactory);      
            ILokaleKatalog lokaler = new LokaleKatalog(this.connectionFactory);
            IJournalKatalog journaler = new JournalKatalog(this.connectionFactory);
            IOpholdKatalog ophold = new OpholdKatalog(this.connectionFactory);
            IVærelseKatalog værelser = new VærelseKatalog(this.connectionFactory);
            var controller = new OpretBehandlingController(patient, behandlinger, personale, lokaler, journaler, ophold, værelser);
            return new BehandlingForm(controller, false);
        }

        public BehandlingForm SkabBehandlingForm(Patient patient, Ophold o)
        {
            IBehandlingKatalog behandlinger = new BehandlingKatalog(this.connectionFactory);
            IPersonaleKatalog personale = new PersonaleKatalog(this.connectionFactory);
            ILokaleKatalog lokaler = new LokaleKatalog(this.connectionFactory);
            IJournalKatalog journaler = new JournalKatalog(this.connectionFactory);
            IOpholdKatalog ophold = new OpholdKatalog(this.connectionFactory);
            IVærelseKatalog værelser = new VærelseKatalog(this.connectionFactory);
            var controller = new OpretBehandlingController(patient, behandlinger, personale, lokaler, journaler, ophold, værelser);
            return new BehandlingForm(controller, true) { SelectedOphold = o };
        }

        public FakturaForm SkabFakturaForm()
        {
            IBehandlingKatalog behandlinger = new BehandlingKatalog(this.connectionFactory);
            IOpholdKatalog ophold = new OpholdKatalog(this.connectionFactory);
            var controller = new FakturaController(behandlinger, ophold);
            return new FakturaForm(this, controller);
        }

        public JournalForm SkabJournalForm(Patient patient)
        {
            string cpr = patient.Cpr;
            IJournalKatalog privatJournal = new JournalKatalog(this.connectionFactory);
            IOffentligJournalProvider offentligJournal = new FakeXmlOffentligJournalProvider();
            IEnumerable<Journallinje> privatJournallinjer = privatJournal.HentJournallinjerForPatient(cpr);
            IEnumerable<Journallinje> offentligJournalLinjer = offentligJournal.HentOffentligJournal(cpr);
            return new JournalForm(privatJournallinjer.Concat(offentligJournalLinjer));
        }

        public PatientForm SkabPatientForm()
        {
            IPatientLæser læser = new OffentligPatientLæser();
            IPatientSkriver skriver = new PatientSkriver(this.connectionFactory);
            var controller = new PatientController(læser, skriver);
            return new PatientForm(controller);
        }

        public PersonaleoplysningerForm SkabPersonaleoplysningerForm()
        {
            IPersonaleKatalog personale = new PersonaleKatalog(this.connectionFactory);
            var controller = new PersonaleoplysningerController(personale);
            return new PersonaleoplysningerForm(controller);
        }

        public FindTidligereOpholdForm SkabIndlæsFakturaForm(Patient patient)
        {
            IOpholdKatalog ophold = new OpholdKatalog(this.connectionFactory);
            return new FindTidligereOpholdForm(ophold.HentOpholdForPatient(patient.Cpr));
        }
    }
}