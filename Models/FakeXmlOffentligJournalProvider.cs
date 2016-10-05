using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Shakespeare.Forms.Models
{
    public class FakeXmlOffentligJournalProvider : IOffentligJournalProvider
    {
        public IEnumerable<Journallinje> HentOffentligJournal(string cpr)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Data", "FakeOffentligJournal.xml");
            
            using (var stream = new FileStream(path, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof (Journallinje[]), new XmlRootAttribute("Journallinjer"));
                var journallinjer = serializer.Deserialize(stream) as Journallinje[];
                return journallinjer ?? new Journallinje[0];
            }
        }
    }
}