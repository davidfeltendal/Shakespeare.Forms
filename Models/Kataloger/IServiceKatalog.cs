using System.Collections;
using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface IServiceKatalog
    {
        Service HentYdelse(int id);
        IList<Servicelinje> HentServicelinjer(Ophold ophold);
        IList<Forplejning> HentForplejningListe();
        IList<Ophold> HentPatientOphold(string cpr);
    }
}