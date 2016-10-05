using System;
using System.Collections.Generic;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class LokaleKatalog : ILokaleKatalog
    {
        private readonly IDbConnectionFactory connectionFactory;

        public LokaleKatalog(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException("connectionFactory");
            }

            this.connectionFactory = connectionFactory;
        }

        public IList<Lokale> HentLokaler()
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT [Id], [Navn] FROM dbo.Lokaler;";

                using (IDataReader reader = command.ExecuteReader())
                {
                    var lokaler = new List<Lokale>();

                    while (reader.Read())
                    {
                        lokaler.Add(new Lokale(reader.GetInt32(0), reader.GetString(1)));
                    }

                    return lokaler;
                }
            }
        }
    }
}