namespace Shakespeare.Forms.Models
{
    public class V�relse : Service
    {
        private readonly int antalSenge;

        public V�relse(int id, string navn, decimal pris, int antalSenge)
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