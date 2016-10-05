using System;
using System.Xml.Serialization;

namespace Shakespeare.Forms.Models
{
    /// <summary>
    /// En behandlingslinjeklasse, der har behandlingens navn og start/slut.
    /// Der er en internal constructor, da XmlSerializer kræver det for at serialisere
    /// til XML - det samme med public settere.
    /// </summary>
    public class PersonaleBehandlingslinje
    {
        public PersonaleBehandlingslinje(string behandling, DateTime start, DateTime slut)
        {
            Behandling = behandling;
            Start = start;
            Slut = slut;
        }

        internal PersonaleBehandlingslinje()
        {
            // XML serializer vil gerne have en parameterless constructor.
        }

        [XmlElement]
        public string Behandling { get; set; }

        [XmlElement]
        public DateTime Start { get; set; }

        [XmlElement]
        public DateTime Slut { get; set; }

        public double AntalTimer
        {
            get { return (Slut - Start).TotalHours; }
        }
    }
}