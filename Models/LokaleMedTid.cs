using System.ComponentModel;

namespace Shakespeare.Forms.Models
{
    public class LokaleMedTid
    {
        private readonly Lokale lokale;
        private readonly bool[] tider;

        public LokaleMedTid(Lokale lokale)
        {
            this.lokale = lokale;
            this.tider = new bool[24];
        }

        public bool this[int index]
        {
            get { return this.tider[index]; }
            set { this.tider[index] = value; }
        }

        [Browsable(false)]
        public int Length
        {
            get { return this.tider.Length; }
        }

        [Browsable(false)]
        public Lokale Lokale
        {
            get { return this.lokale; }
        }
    }
}