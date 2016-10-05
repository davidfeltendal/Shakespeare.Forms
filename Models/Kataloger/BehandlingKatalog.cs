using System;
using System.Collections.Generic;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class BehandlingKatalog : IBehandlingKatalog
    {
        private readonly IDbConnectionFactory connectionFactory;

        public BehandlingKatalog(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException("connectionFactory");
            }

            this.connectionFactory = connectionFactory;
        }

        public IList<Behandlingslinje> HentBehandlingslinjerForDato(DateTime dato)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT BL.[Id], BL.[OpholdId], BL.[LokaleId], BL.[Start], BL.[Slut], B.[Id], B.[Navn], B.[Pris] FROM [dbo].[Behandlingslinjer] AS BL " +
                                      "JOIN [dbo].[Behandlinger] AS B ON B.[Id] = BL.[BehandlingId] " +
                                      "WHERE DAY(BL.[Start]) = @dag AND " +
                                      "Month(BL.[Start]) = @måned AND " +
                                      "Year(BL.[Start]) = @år;";

                // Datoparametre.
                // Dag.
                IDbDataParameter dag = command.CreateParameter();
                dag.ParameterName = "@dag";
                dag.DbType = DbType.Int32;
                dag.Value = dato.Day;
                command.Parameters.Add(dag);

                // Måned.
                IDbDataParameter måned = command.CreateParameter();
                måned.ParameterName = "@måned";
                måned.DbType = DbType.Int32;
                måned.Value = dato.Month;
                command.Parameters.Add(måned);

                // År.
                IDbDataParameter år = command.CreateParameter();
                år.ParameterName = "@år";
                år.DbType = DbType.Int32;
                år.Value = dato.Year;
                command.Parameters.Add(år);

                using (IDataReader reader = command.ExecuteReader())
                {
                    var behandlingslinjer = new List<Behandlingslinje>();

                    while (reader.Read())
                    {
                        behandlingslinjer.Add(new Behandlingslinje(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetDateTime(3),
                            reader.GetDateTime(4),
                            new Behandling(reader.GetInt32(5), reader.GetString(6), reader.GetDecimal(7))));
                    }

                    return behandlingslinjer;
                }
            }
        }

        public IList<Behandlingslinje> HentBehandlingslinjerForOphold(int id)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT BL.[Id], BL.[OpholdId], BL.[LokaleId], BL.[Start], BL.[Slut], B.[Id], B.[Navn], B.[Pris] FROM [dbo].[Behandlingslinjer] AS BL " +
                                      "JOIN [dbo].[Behandlinger] AS B ON B.[Id] = BL.[BehandlingId] " +
                                      "WHERE BL.[OpholdId] = @id";
                IDbDataParameter linjeId = command.CreateParameter();
                linjeId.ParameterName = "@id";
                linjeId.DbType = DbType.Int32;
                linjeId.Value = id;
                command.Parameters.Add(linjeId);

                using (IDataReader reader = command.ExecuteReader())
                {
                    var behandlingslinjer = new List<Behandlingslinje>();

                    while (reader.Read())
                    {
                        behandlingslinjer.Add(new Behandlingslinje(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetDateTime(3),
                            reader.GetDateTime(4),
                            new Behandling(reader.GetInt32(5), reader.GetString(6), reader.GetDecimal(7))));
                    }

                    return behandlingslinjer;
                }
            }
        }

        public IList<Operation> HentOperationer()
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT B.[Id], B.[Navn], B.[Pris] FROM dbo.Behandlinger AS B " +
                                      "JOIN dbo.Operationer AS O ON B.Id = O.Id;";

                using (IDataReader reader = command.ExecuteReader())
                {
                    var operationer = new List<Operation>();

                    while (reader.Read())
                    {
                        operationer.Add(new Operation(
                                            reader.GetInt32(0),
                                            reader.GetString(1),
                                            reader.GetDecimal(2)));
                    }

                    return operationer;
                }
            }
        }

        public IList<Genoptræning> HentGenoptræninger()
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT B.[Id], B.[Navn], B.[Pris] FROM dbo.Behandlinger AS B " +
                                      "JOIN dbo.Genoptræninger AS G ON B.Id = G.Id;";

                using (IDataReader reader = command.ExecuteReader())
                {
                    var genoptræninger = new List<Genoptræning>();

                    while (reader.Read())
                    {
                        genoptræninger.Add(new Genoptræning(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDecimal(2)));
                    }

                    return genoptræninger;
                }
            }
        }

        public Behandlingslinje OpretBehandling(Ophold ophold, Behandling behandling, Lokale lokale, DateTimeOffset start, DateTimeOffset slut)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO dbo.Behandlingslinjer([OpholdId], [BehandlingId], [LokaleId], [Start], [Slut]) " +
                                      "VALUES (@opholdId, @behandlingId, @lokaleId, @start, @slut); " +
                                      "SELECT SCOPE_IDENTITY();";

                // Ophold ID.
                IDbDataParameter opholdIdParameter = command.CreateParameter();
                opholdIdParameter.ParameterName = "@opholdId";
                opholdIdParameter.DbType = DbType.Int32;
                opholdIdParameter.Value = ophold.Id;
                command.Parameters.Add(opholdIdParameter);

                // Behandling ID.
                IDbDataParameter behandlingIdParameter = command.CreateParameter();
                behandlingIdParameter.ParameterName = "@behandlingId";
                behandlingIdParameter.DbType = DbType.Int32;
                behandlingIdParameter.Value = behandling.Id;
                command.Parameters.Add(behandlingIdParameter);

                // Lokale ID.
                IDbDataParameter lokaleIdParameter = command.CreateParameter();
                lokaleIdParameter.ParameterName = "@lokaleId";
                lokaleIdParameter.DbType = DbType.Int32;
                lokaleIdParameter.Value = lokale.Id;
                command.Parameters.Add(lokaleIdParameter);

                // Start.
                IDbDataParameter startParameter = command.CreateParameter();
                startParameter.ParameterName = "@start";
                startParameter.DbType = DbType.DateTimeOffset;
                startParameter.Value = start;
                command.Parameters.Add(startParameter);

                // Slut.
                IDbDataParameter slutParameter = command.CreateParameter();
                slutParameter.ParameterName = "@slut";
                slutParameter.DbType = DbType.DateTimeOffset;
                slutParameter.Value = slut;
                command.Parameters.Add(slutParameter);

                int id = Convert.ToInt32(command.ExecuteScalar().ToString());
                return new Behandlingslinje(id, ophold.Id, lokale.Id, start, slut, behandling);
            }
        }

        public void SletBehandlingslinje(Ophold ophold)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM dbo.Behandlingslinjer WHERE [OpholdId] = @opholdId;";

                IDbDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@opholdId";
                parameter.DbType = DbType.Int32;
                parameter.Value = ophold.Id;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

            }
        }
    }
}
