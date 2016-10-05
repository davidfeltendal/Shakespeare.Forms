using System;

namespace Shakespeare.Forms.Models
{
    public class Personale : IEquatable<Personale>
    {
        private readonly int id;
        private readonly string fornavn;
        private readonly string efternavn;
        private readonly Ugedage arbejdsplan;
        private readonly Hospital hospital;
        private readonly Speciale speciale;

        public Personale(int id, string fornavn, string efternavn, Ugedage arbejdsplan, Hospital hospital, Speciale speciale)
        {
            this.id = id;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.arbejdsplan = arbejdsplan;
            this.hospital = hospital;
            this.speciale = speciale;
        }

        public int Id
        {
            get { return id; }
        }

        public string Fornavn
        {
            get { return fornavn; }
        }

        public string Efternavn
        {
            get { return efternavn; }
        }

        public Hospital Hospital
        {
            get { return this.hospital; }
        }

        public Ugedage Arbejdsplan
        {
            get { return this.arbejdsplan; }
        }

        public Speciale Speciale
        {
            get { return this.speciale; }
        }

        public bool ArbejderPå(Ugedage ugedag)
        {
            return this.arbejdsplan.HasFlag(ugedag);
        }

        public bool KanArbejdeITidsrum(DateTime behandlingsdato)
        {
            DayOfWeek dayOfWeek = behandlingsdato.DayOfWeek;
            Ugedage ugedag = (Ugedage)Math.Pow(2, (int)dayOfWeek);
            return ArbejderPå(ugedag);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", Fornavn, Efternavn, Speciale.Navn);
        }

        public bool Equals(Personale other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return this.id == other.id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Personale) obj);
        }

        public override int GetHashCode()
        {
            return this.id;
        }
    }
}