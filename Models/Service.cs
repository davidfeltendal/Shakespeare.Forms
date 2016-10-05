using System.ComponentModel;

namespace Shakespeare.Forms.Models
{
    public class Service
    {
        private readonly int id;
        private readonly string navn;
        private readonly decimal pris;

        public Service(int id, string navn, decimal pris)
        {
            this.id = id;
            this.navn = navn;
            this.pris = pris;
        }

        [Browsable(false)]
        public int Id
        {
            get { return this.id; }
        }

        public string Navn
        {
            get { return this.navn; }
        }

        public decimal Pris
        {
            get { return this.pris; }
        }
    }
}