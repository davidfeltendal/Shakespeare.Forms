using System;
using System.Collections.Generic;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class VærelseKatalog : IVærelseKatalog
    {
        private readonly IDbConnectionFactory connectionFactory;

        public VærelseKatalog(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException("connectionFactory");
            }

            this.connectionFactory = connectionFactory;
        }

        public IList<Værelse> HentLedigeVærelser(DateTime start, DateTime slut, int antalSenge)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText =
                    "SELECT S.[Id], S.[Navn], S.[Pris], V.[AntalSenge] FROM [dbo].[Værelser] AS V " +
                    "JOIN [dbo].[Services] AS S ON S.[Id] = V.[Id] " +
                    "WHERE V.[AntalSenge] = @antalSenge " +
                    "EXCEPT " +
                    "SELECT S.[Id], S.[Navn], S.[Pris], V.[AntalSenge] FROM [dbo].[Værelser] AS V " +
                    "JOIN [dbo].[Services] AS S ON S.[Id] = V.[Id] " +
                    "JOIN [dbo].[Ophold] AS O ON O.[VærelseId] = V.[Id] " +
                    "WHERE NOT (O.[Start] > CAST(@slut AS DATETIME) OR O.[Slut] < CAST(@start AS DATETIME));";

                IDbDataParameter antalSengeParameter = command.CreateParameter();
                antalSengeParameter.ParameterName = "@antalSenge";
                antalSengeParameter.DbType = DbType.Int32;
                antalSengeParameter.Value = antalSenge;
                command.Parameters.Add(antalSengeParameter);

                IDbDataParameter startParameter = command.CreateParameter();
                startParameter.ParameterName = "@start";
                startParameter.DbType = DbType.String;
                startParameter.Value = start.ToString("yyyy-MM-dd");
                command.Parameters.Add(startParameter);

                IDbDataParameter slutParameter = command.CreateParameter();
                slutParameter.ParameterName = "@slut";
                slutParameter.DbType = DbType.String;
                slutParameter.Value = slut.ToString("yyyy-MM-dd");
                command.Parameters.Add(slutParameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    var værelser = new List<Værelse>();

                    while (reader.Read())
                    {
                        værelser.Add(new Værelse(
                                         reader.GetInt32(0),
                                         reader.GetString(1),
                                         reader.GetDecimal(2),
                                         reader.GetInt32(3)));
                    }

                    return værelser;
                }
            }
        }

        public void TilknytTilServicelinje(Værelse værelse, Ophold ophold)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO dbo.Servicelinje([OpholdId],[Antal],[ServiceId]) VALUES (@OpholdId,1,@VærelseId);";

                IDbDataParameter opholdId = command.CreateParameter();
                opholdId.ParameterName = "@OpholdId";
                opholdId.DbType = DbType.Int32;
                opholdId.Value = ophold.Id;
                command.Parameters.Add(opholdId);

                IDbDataParameter værelseId = command.CreateParameter();
                værelseId.ParameterName = "@VærelseId";
                værelseId.DbType = DbType.Int32;
                værelseId.Value = værelse.Id;
                command.Parameters.Add(værelseId);

                command.ExecuteNonQuery();
            }
        }
    }
}
