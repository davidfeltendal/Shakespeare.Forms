using System;
using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface IOpholdKatalog
    {
        Ophold Hent(int id);
        IList<Ophold> HentOpholdForPatient(string cpr);
        Ophold OpretOphold(Patient patient, DateTime start, DateTime slut, Forplejning forplejning, Værelse værelse);
        IList<Forplejning> HentForplejninger();
        void SletOphold(Ophold ophold);
    }
}
