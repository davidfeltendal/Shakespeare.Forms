namespace Shakespeare.Forms.Models.Kataloger
{
    public class OffentligPatientLæser : IPatientLæser
    {
        public Patient HentPatient(string cpr)
        {
            return new Patient(cpr, "Test", "Testesen", "Testvej 1", "1234", "Testby", "12345678");
        }
    }
}