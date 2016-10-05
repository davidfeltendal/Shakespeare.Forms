using System;

namespace Shakespeare.Forms.Models
{
    public class Ophold
    {
        private readonly int id;
        private readonly DateTime start;
        private readonly DateTime slut;
        private readonly string patientCpr;
        private readonly Forplejning forplejning;
        private readonly Værelse værelse;

        public Ophold(int id, DateTime start, DateTime slut, string patientCpr, Forplejning forplejning, Værelse værelse)
        {
            this.id = id;
            this.start = start;
            this.slut = slut;
            this.patientCpr = patientCpr;
            this.forplejning = forplejning;
            this.værelse = værelse;
        }

        public int Id
        {
            get { return this.id; }
        }

        public DateTime Start
        {
            get { return this.start; }
        }

        public DateTime Slut
        {
            get { return this.slut; }
        }

        public string PatientCpr
        {
            get { return this.patientCpr; }
        }

        public Forplejning Forplejning
        {
            get { return this.forplejning; }
        }

        public Værelse Værelse
        {
            get { return this.værelse; }
        }

        public int AntalTimer
        {
            get { return (int) (Slut - Start).TotalHours; }
        }
    }
}
