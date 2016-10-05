namespace Shakespeare.Forms.Models
{
    public class Hospital
    {
        private readonly int id;
        private readonly string navn;

        public Hospital(int id, string navn)
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

        public override string ToString()
        {
            return string.Format("Id: {0}, Navn: {1}", Id.ToString(), Navn);
        }
    }
}