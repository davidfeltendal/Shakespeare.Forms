using System;

namespace Shakespeare.Forms.Models
{
    public class Journallinje
    {
        public Journallinje(int id, string tekst, DateTime dateTime, Journallinjekilde kilde)
        {
            Id = id;
            Tekst = tekst;
            DateTime = dateTime;
            Kilde = kilde;
        }

        public Journallinje()
        {
            // Tom constructor til deserialisering.
        }

        public int Id { get; set; }
        public string Tekst { get; set; }
        public DateTime DateTime { get; set; }
        public Journallinjekilde Kilde { get; set; }
    }
}