using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Shakespeare.Forms.Models;
using Shakespeare.Forms.Models.Kataloger;

namespace Shakespeare.Forms.Controllers
{
    public class PersonaleoplysningerController
    {
        private readonly IPersonaleKatalog personale;        

        public PersonaleoplysningerController(IPersonaleKatalog personale)
        {
            if (personale == null)
            {
                throw new ArgumentNullException("personale");
            }

            this.personale = personale;            
        }

        public IList<Speciale> HentSpecialer()
        {
            return this.personale.HentSpecialer();
        }

        public IList<Personale> HentPersonale(Speciale speciale)
        {
            if (speciale == null)
            {
                throw new ArgumentNullException("speciale");
            }

            IList<Personale> personer = this.personale.HentAlle();

            if (speciale.Id >= 0)
            {
                personer = personer.Where(p => p.Speciale.Id == speciale.Id).ToList();
            }

            return personer;
        }

        public IList<PersonaleBehandlingslinje> HentBehandlingslinjerForPerson(Personale person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("person");
            }

            return this.personale.HentBehandlingslinjerForPersonale(person);
        }

        public void GemPersonaleoplysninger(Personale person, Stream stream)
        {
            IList<PersonaleBehandlingslinje> behandlingslinjer = HentBehandlingslinjerForPerson(person);

            using (stream)
            {
                var serializer = new XmlSerializer(typeof (PersonaleBehandlingslinje[]));
                serializer.Serialize(stream, behandlingslinjer.ToArray());
            }
        }
    }
}