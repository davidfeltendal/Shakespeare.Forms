namespace Shakespeare.Forms.Models
{
    public class Lokale
    {
        private int id;
        private string navn;

        public Lokale(int id, string navn)
        {
            this.id = id;
            this.navn = navn;
        }

        public int Id
        {
            get { return id; }
        }

        public string Navn
        {
            get { return navn; }
        }
    }
}