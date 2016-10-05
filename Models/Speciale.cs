namespace Shakespeare.Forms.Models
{
    public class Speciale
    {
        private readonly int id;
        private readonly string navn;

        public Speciale(int id, string navn)
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
            get { return this.navn; }
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Navn: {1}", Id.ToString(), Navn);
        }
    }
}