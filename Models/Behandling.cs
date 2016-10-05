namespace Shakespeare.Forms.Models
{
    public class Behandling
    {
        private int id;
        private string navn;
        private decimal pris;

        public Behandling(int id, string navn, decimal pris)
        {
            this.id = id;
            this.navn = navn;
            this.pris = pris;
        }

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