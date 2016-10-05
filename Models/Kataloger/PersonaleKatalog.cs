using System;
using System.Collections.Generic;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class PersonaleKatalog : IPersonaleKatalog
    {
        private readonly IDbConnectionFactory connectionFactory;

        public PersonaleKatalog(IDbConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public IList<Personale> HentAlle()
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT P.[Id], P.[Fornavn], P.[Efternavn], P.[Arbejdsplan], H.[Id], H.[Navn], S.[Id], S.[Navn] FROM [dbo].[Personale] AS P " +
                                      "JOIN [dbo].[Hospitaler] AS H ON H.[Id] = P.[HospitalId] " +
                                      "JOIN [dbo].[Specialer] AS S ON S.[Id] = P.[SpecialeId];";

                using (IDataReader reader = command.ExecuteReader())
                {
                    var personale = new List<Personale>();

                    while (reader.Read())
                    {
                        var hospital = new Hospital(reader.GetInt32(4), reader.GetString(5));
                        var speciale = new Speciale(reader.GetInt32(6), reader.GetString(7));

                        personale.Add(new Personale(
                                          reader.GetInt32(0),
                                          reader.GetString(1),
                                          reader.GetString(2),
                                          (Ugedage) reader.GetByte(3),
                                          hospital,
                                          speciale));
                    }

                    return personale;
                }
            }
        }

        public IList<Personale> HentSpecialister(Speciale speciale)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT P.[Id], P.[Fornavn], P.[Efternavn], P.[Arbejdsplan], H.[Id], H.[Navn] FROM [dbo].[Personale] AS P " +
                                      "JOIN [dbo].[Hospitaler] AS H ON H.[Id] = P.[HospitalId] " +
                                      "WHERE P.[SpecialeId] = @specialeId;";

                IDbDataParameter specialeId = command.CreateParameter();
                specialeId.ParameterName = "@specialeId";
                specialeId.DbType = DbType.Int32;
                specialeId.Value = speciale.Id;
                command.Parameters.Add(specialeId);

                using (IDataReader reader = command.ExecuteReader())
                {
                    var specialister = new List<Personale>();

                    while (reader.Read())
                    {
                        var hospital = new Hospital(reader.GetInt32(4), reader.GetString(5));

                        specialister.Add(new Personale(reader.GetInt32(0),
                                                       reader.GetString(1),
                                                       reader.GetString(2),
                                                       (Ugedage) reader.GetByte(3),
                                                       hospital,
                                                       speciale));
                    }

                    return specialister;
                }
            }
        }

        public void TilknytTilBehandlingslinje(Personale personale, Behandlingslinje behandlingslinje)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                //command.Transaction = transaction;
                command.CommandText = "INSERT INTO dbo.ErTilknyttet([BehandlingslinjeId], [PersonaleId]) " +
                                      "VALUES (@behandlingslinjeId, @personaleId);";

                // Behandlingslinje.
                IDbDataParameter behandlingslinjeId = command.CreateParameter();
                behandlingslinjeId.ParameterName = "@behandlingslinjeId";
                behandlingslinjeId.DbType = DbType.Int32;
                behandlingslinjeId.Value = behandlingslinje.Id;
                command.Parameters.Add(behandlingslinjeId);

                // Personale tilknyttet.
                IDbDataParameter personaleId = command.CreateParameter();
                personaleId.ParameterName = "@personaleId";
                personaleId.DbType = DbType.Int32;
                personaleId.Value = personale.Id;
                command.Parameters.Add(personaleId);

                command.ExecuteNonQuery();
            }
        }

        public IList<PersonaleBehandlingslinje> HentBehandlingslinjerForPersonale(Personale personale)
        {
            if (personale == null)
            {
                throw new ArgumentNullException("personale");
            }

            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT B.[Navn], BL.[Start], BL.[Slut] FROM [dbo].[Behandlingslinjer] AS BL " +
                                      "JOIN [dbo].[ErTilknyttet] AS ET ON ET.[BehandlingslinjeId] = BL.[Id] " +
                                      "JOIN [dbo].[Behandlinger] AS B ON B.[Id] = BL.[BehandlingId] " +
                                      "WHERE ET.[PersonaleId] = @personaleId;";

                IDbDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@personaleId";
                parameter.DbType = DbType.Int32;
                parameter.Value = personale.Id;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    var behandlingslinjer = new List<PersonaleBehandlingslinje>();

                    while (reader.Read())
                    {
                        behandlingslinjer.Add(new PersonaleBehandlingslinje(
                            reader.GetString(0),
                            reader.GetDateTime(1),
                            reader.GetDateTime(2)));
                    }

                    return behandlingslinjer;
                }
            }
        }

        public IList<Speciale> HentSpecialer()
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT [Id], [Navn] FROM [dbo].[Specialer];";

                using (IDataReader reader = command.ExecuteReader())
                {
                    var specialer = new List<Speciale>();

                    while (reader.Read())
                    {
                        specialer.Add(new Speciale(reader.GetInt32(0), reader.GetString(1)));
                    }

                    return specialer;
                }
            }
        }
    }
}