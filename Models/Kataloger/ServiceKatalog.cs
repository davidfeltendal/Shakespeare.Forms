using System;
using System.Collections.Generic;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class ServiceKatalog : IServiceKatalog
    {
        private readonly IDbConnectionFactory connectionFactory;

        public ServiceKatalog(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException("connectionFactory");
            }

            this.connectionFactory = connectionFactory;
        }

        public Service HentYdelse(int id)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT [Id], [Navn], [Pris] FROM [dbo].[Services] WHERE [Id] = @id;";

                // Id.
                IDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@id";
                parameter.DbType = DbType.Int32;
                parameter.Value = id;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Service(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDecimal(2));
                    }
                }
            }

            return null;
        }

        public IList<Servicelinje> HentServicelinjer(Ophold ophold)
        {
            List<Servicelinje> servicelinjer = new List<Servicelinje>();
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText =
                    "SELECT [Antal] [ServiceId] [OpholdId] FROM [dbo].[Servicelinje] WHERE [OpholdId] = @opholdId;";

                //Ophold
                IDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@opholdId";
                parameter.DbType = DbType.Int32;
                parameter.Value = ophold.Id;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        servicelinjer.Add(new Servicelinje());
                    }
                }
            }
            return servicelinjer; //skal joines med service så navne kommer med!!!...
        }

        public IList<Forplejning> HentForplejningListe()
        {
            List<Forplejning> forplejningsListe = new List<Forplejning>();
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT S.[Id], S.[Navn], S.[Pris] FROM [dbo].[Services] AS S " +
                                      "JOIN [dbo].[Forplejninger] AS F ON F.[Id] = S.[Id];";

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        forplejningsListe.Add(new Forplejning(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDecimal(2)));
                    }
                }
            }
            return forplejningsListe;
        }

        public IList<Ophold> HentPatientOphold(string cpr)
        {
            List<Ophold> opholdsListe = new List<Ophold>();
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText =
                    "SELECT o.[Id], o.[Start], o.[Slut], o.[PatientCpr], o.[ForplejningId], s.[Navn], s.[Pris] "+
                    "FROM [dbo].[Ophold] as o " +
                    "JOIN [dbo].[Forplejninger] as f on f.Id = o.ForplejningId "+
                    "JOIN [dbo].[Services] as s on s.Id = f.Id "+
                    "WHERE [PatientCpr] = @cpr;";

                IDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@cpr";
                parameter.DbType = DbType.StringFixedLength;
                parameter.Value = cpr;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        opholdsListe.Add(new Ophold(
                            reader.GetInt32(0),
                            reader.GetDateTime(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            new Forplejning(
                                reader.GetInt32(4),
                                reader.GetString(5),
                                reader.GetDecimal(6))));
                    }
                }
                return opholdsListe;
            }
            {
                
            }
        }
    }

}