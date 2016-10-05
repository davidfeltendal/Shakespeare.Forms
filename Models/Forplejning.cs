namespace Shakespeare.Forms.Models
{
    public class Forplejning : Service
    {
        public Forplejning(int id, string navn, decimal pris) : base(id, navn, pris)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} ({1} per dag)", Navn, Pris.ToString("C2"));
        }
    }
}