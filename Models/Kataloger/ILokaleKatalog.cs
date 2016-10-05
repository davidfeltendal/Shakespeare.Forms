using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface ILokaleKatalog
    {
        IList<Lokale> HentLokaler();
    }
}