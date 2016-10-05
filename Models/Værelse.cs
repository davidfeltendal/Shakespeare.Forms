namespace Shakespeare.Forms.Models
{
    public class Værelse : Service
    {
        private readonly int antalSenge;

        public Værelse(int id, string navn, decimal pris, int antalSenge)
            : base(id, navn, pris)
        {
            this.antalSenge = antalSenge;
        }

        public int AntalSenge
        {
            get { return this.antalSenge; }
        }
    }
}