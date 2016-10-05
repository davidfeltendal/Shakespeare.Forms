using System;
using System.Collections.Generic;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface IBehandlingKatalog
    {
        Behandlingslinje OpretBehandling(Ophold ophold, Behandling behandling, Lokale lokale, DateTimeOffset start, DateTimeOffset slut);
        IList<Behandlingslinje> HentBehandlingslinjerForDato(DateTime dato);
        IList<Behandlingslinje> HentBehandlingslinjerForOphold(int id);

        IList<Operation> HentOperationer();
        IList<Genoptræning> HentGenoptræninger();
        void SletBehandlingslinje(Ophold ophold);
    }
}