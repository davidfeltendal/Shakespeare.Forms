using System;
using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface IJournalKatalog
    {
        IList<Journallinje> HentJournallinjerForPatient(string patientCpr);
        Journallinje IndsætJournallinje(string patientCpr, string tekst, DateTime dato);
        void TilknytJournallinjeMedBehandlingslinje(Journallinje journallinje, Behandlingslinje behandlingslinje);
    }
}