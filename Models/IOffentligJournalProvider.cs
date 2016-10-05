using System.Collections.Generic;

namespace Shakespeare.Forms.Models
{
    public interface IOffentligJournalProvider
    {
        IEnumerable<Journallinje> HentOffentligJournal(string cpr);
    }
}