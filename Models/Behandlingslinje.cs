using System;

namespace Shakespeare.Forms.Models
{
    public class Behandlingslinje
    {
        private readonly int id;
        private readonly int opholdId;
        private readonly int lokaleId;
        private readonly DateTimeOffset start;
        private readonly DateTimeOffset slut;
        private readonly Behandling behandling;

        public Behandlingslinje(int id, int opholdId, int lokaleId, DateTimeOffset start, DateTimeOffset slut, Behandling behandling)
        {
            this.id = id;
            this.opholdId = opholdId;
            this.lokaleId = lokaleId;
            this.start = start;
            this.slut = slut;
            this.behandling = behandling;
        }

        public int Id
        {
            get { return id; }
        }

        public int OpholdId
        {
            get { return this.opholdId; }
        }

        public int LokaleId
        {
            get { return lokaleId; }
        }

        public DateTimeOffset Start
        {
            get { return start; }
        }

        public DateTimeOffset Slut
        {
            get { return slut; }
        }

        public int Antal
        {
            get { return 1; }
        }

        public decimal Subtotal
        {
            get { return Behandling.Pris * Convert.ToDecimal(Antal); }
        }

        public Behandling Behandling
        {
            get { return this.behandling; }
        }
    }
}