namespace Shakespeare.Forms.Models
{
    public class Patient
    {
        private readonly string cpr;
        private readonly string fornavn;
        private readonly string efternavn;
        private readonly string adresse;
        private readonly string postnr;
        private readonly string by;
        private readonly string tlf;

        public Patient(string cpr, string fornavn, string efternavn, string adresse, string postnr, string @by, string tlf)
        {
            this.cpr = cpr;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.adresse = adresse;
            this.postnr = postnr;
            this.@by = @by;
            this.tlf = tlf;
        }

        public string Cpr
        {
            get { return this.cpr; }
        }

        public string Fornavn
        {
            get { return this.fornavn; }
        }

        public string Efternavn
        {
            get { return this.efternavn; }
        }

        public string Adresse
        {
            get { return this.adresse; }
        }

        public string Postnr
        {
            get { return this.postnr; }
        }

        public string By
        {
            get { return this.@by; }
        }

        public string Tlf
        {
            get { return this.tlf; }
        }
    }
}