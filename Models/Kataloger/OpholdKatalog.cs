using System;
using System.Collections.Generic;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    class OpholdKatalog : IOpholdKatalog
    {
        private readonly IDbConnectionFactory connectionFactory;

        public OpholdKatalog(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException("connectionFactory");
            }

            this.connectionFactory = connectionFactory;
        }

        public Ophold Hent(int id)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT O.[Id], O.[Start], O.[Slut], O.[PatientCpr], " +
                                      "S1.[Id], S1.[Navn], S1.[Pris], " +
                                      "S2.[Id], S2.[Navn], S2.[Pris], V.[AntalSenge] " +
                                      "FROM [dbo].[Ophold] AS O " +
                                      "JOIN [dbo].[Forplejninger] AS F ON F.[Id] = O.[ForplejningId] " +
                                      "JOIN [dbo].[Services] AS S1 ON S1.[Id] = F.[Id] " +
                                      "JOIN [dbo].[Værelser] AS V ON V.[Id] = O.[VærelseId] " +
                                      "JOIN [dbo].[Services] AS S2 ON S2.[Id] = V.[Id] " +
                                      "WHERE O.[Id] = @id;";
                
                IDbDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@id";
                parameter.DbType = DbType.Int32;
                parameter.Value = id;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow))
                {
                    while (reader.Read())
                    {
                        return new Ophold(
                            reader.GetInt32(0),
                            reader.GetDateTime(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            new Forplejning(reader.GetInt32(4),
                                            reader.GetString(5),
                                            reader.GetDecimal(6)),
                            new Værelse(reader.GetInt32(7),
                                        reader.GetString(8),
                                        reader.GetDecimal(9),
                                        reader.GetInt32(10)));
                    }
                }
            }

            return null;
        }

        public IList<Ophold> HentOpholdForPatient(string cpr)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT O.[Id], O.[Start], O.[Slut], O.[PatientCpr], " +
                                      "S1.[Id], S1.[Navn], S1.[Pris], " +
                                      "S2.[Id], S2.[Navn], S2.[Pris], V.[AntalSenge] " +
                                      "FROM [dbo].[Ophold] AS O " +
                                      "JOIN [dbo].[Forplejninger] AS F ON F.[Id] = O.[ForplejningId] " +
                                      "JOIN [dbo].[Services] AS S1 ON S1.[Id] = F.[Id] " +
                                      "JOIN [dbo].[Værelser] AS V ON V.[Id] = O.[VærelseId] " +
                                      "JOIN [dbo].[Services] AS S2 ON S2.[Id] = V.[Id] " +
                                      "WHERE O.[PatientCpr] = @cpr;";

                IDbDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@cpr";
                parameter.DbType = DbType.StringFixedLength;
                parameter.Value = cpr;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    var ophold = new List<Ophold>();

                    while (reader.Read())
                    {
                        ophold.Add(new Ophold(
                                       reader.GetInt32(0),
                                       reader.GetDateTime(1),
                                       reader.GetDateTime(2),
                                       reader.GetString(3),
                                       new Forplejning(reader.GetInt32(4),
                                                       reader.GetString(5),
                                                       reader.GetDecimal(6)),
                                       new Værelse(reader.GetInt32(7),
                                                   reader.GetString(8),
                                                   reader.GetDecimal(9),
                                                   reader.GetInt32(10))));
                    }

                    return ophold;
                }
            }
        }

        public Ophold OpretOphold(Patient patient, DateTime start, DateTime slut, Forplejning forplejning, Værelse værelse)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText =
                    "INSERT INTO [dbo].[Ophold]([Start], [Slut], [PatientCpr], [ForplejningId], [VærelseId]) " +
                    "VALUES(@start, @slut, @cpr, @forplejningId, @værelseId); " +
                    "SELECT SCOPE_IDENTITY();";

                // Start.
                IDbDataParameter startParameter = command.CreateParameter();
                startParameter.ParameterName = "@start";
                startParameter.DbType = DbType.DateTime;
                startParameter.Value = start;
                command.Parameters.Add(startParameter);

                // Slut.
                IDbDataParameter slutParameter = command.CreateParameter();
                slutParameter.ParameterName = "@slut";
                slutParameter.DbType = DbType.DateTime;
                slutParameter.Value = slut;
                command.Parameters.Add(slutParameter);

                // Patient-CPR.
                IDbDataParameter cprParameter = command.CreateParameter();
                cprParameter.ParameterName = "@cpr";
                cprParameter.DbType = DbType.StringFixedLength;
                cprParameter.Value = patient.Cpr;
                command.Parameters.Add(cprParameter);

                // Forplejning.
                IDbDataParameter forplejningIdParameter = command.CreateParameter();
                forplejningIdParameter.ParameterName = "@forplejningId";
                forplejningIdParameter.DbType = DbType.Int32;
                forplejningIdParameter.Value = forplejning.Id;
                command.Parameters.Add(forplejningIdParameter);

                // Værelse.
                IDbDataParameter værelseIdParameter = command.CreateParameter();
                værelseIdParameter.ParameterName = "@værelseId";
                værelseIdParameter.DbType = DbType.Int32;
                værelseIdParameter.Value = værelse.Id;
                command.Parameters.Add(værelseIdParameter);

                int id = Convert.ToInt32(command.ExecuteScalar().ToString());
                return new Ophold(id, start, slut, patient.Cpr, forplejning, værelse);
            }
        }

        public IList<Forplejning> HentForplejninger()
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT S.[Id], S.[Navn], S.[Pris] FROM [dbo].[Services] AS S " +
                                      "JOIN [dbo].[Forplejninger] AS F ON F.[Id] = S.[Id];";

                using (IDataReader reader = command.ExecuteReader())
                {
                    var forplejninger = new List<Forplejning>();

                    while (reader.Read())
                    {
                        forplejninger.Add(new Forplejning(
                                              reader.GetInt32(0),
                                              reader.GetString(1),
                                              reader.GetDecimal(2)));
                    }

                    return forplejninger;
                }
            }
        }

        public void SletOphold(Ophold ophold)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM dbo.Ophold WHERE [Id] = @opholdId;";

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
