using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface IPersonaleKatalog
    {
        IList<Personale> HentAlle();
        IList<Personale> HentSpecialister(Speciale speciale);
        void TilknytTilBehandlingslinje(Personale personale, Behandlingslinje behandlingslinje);
        IList<PersonaleBehandlingslinje> HentBehandlingslinjerForPersonale(Personale personale);
        IList<Speciale> HentSpecialer();
    }
}