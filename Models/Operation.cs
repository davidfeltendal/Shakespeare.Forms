namespace Shakespeare.Forms.Models
{
    public class Operation : Behandling
    {
        public Operation(int id, string navn, decimal pris)
            : base(id, navn, pris)
        {
        }
    }
}