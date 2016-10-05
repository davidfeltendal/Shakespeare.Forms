using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class LokaleKatalogStub : ILokaleKatalog
    {
        public IList<Lokale> HentLokaler()
        {
            var lokaler = new List<Lokale>();

            for (int i = 1; i <= 10; i++)
            {
                lokaler.Add(new Lokale(i, "Lokale " + i.ToString()));
            }

            return lokaler;
        }
    }
}