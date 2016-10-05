using System;
using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface IVærelseKatalog
    {
        IList<Værelse> HentLedigeVærelser(DateTime start, DateTime slut, int antalSenge);
        void TilknytTilServicelinje(Værelse værelse, Ophold ophold);
    }
}
