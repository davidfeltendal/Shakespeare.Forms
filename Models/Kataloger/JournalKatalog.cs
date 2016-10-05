using System;
using System.Collections.Generic;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class JournalKatalog : IJournalKatalog
    {
        private readonly IDbConnectionFactory connectionFactory;

        public JournalKatalog(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException("connectionFactory");
            }

            this.connectionFactory = connectionFactory;
        }

        public IList<Journallinje> HentJournallinjerForPatient(string patientCpr)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT [Id], [Tekst], [DatoTid] FROM [dbo].[Journallinjer] " +
                                      "WHERE [PatientCpr] = @patientCpr;";

                // Patient-CPR-parameter.
                IDbDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@patientCpr";
                parameter.DbType = DbType.StringFixedLength;
                parameter.Value = patientCpr;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    var journallinjer = new List<Journallinje>();

                    while (reader.Read())
                    {
                        journallinjer.Add(new Journallinje(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            Journallinjekilde.Privat));
                    }

                    return journallinjer;
                }
            }
        }

        public Journallinje IndsætJournallinje(string patientCpr, string tekst, DateTime dato)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO [dbo].[Journallinjer]([Tekst], [DatoTid], [PatientCpr]) " +
                                      "VALUES(@tekst, @datoTid, @patientCpr); " +
                                      "SELECT SCOPE_IDENTITY();";

                // Tekst-parameter.
                IDbDataParameter tekstParamater = command.CreateParameter();
                tekstParamater.ParameterName = "@tekst";
                tekstParamater.DbType = DbType.String;
                tekstParamater.Value = tekst;
                command.Parameters.Add(tekstParamater);

                // DatoTid-parameter.
                IDbDataParameter datoTidParameter = command.CreateParameter();
                datoTidParameter.ParameterName = "@datoTid";
                datoTidParameter.DbType = DbType.DateTime;
                datoTidParameter.Value = dato;
                command.Parameters.Add(datoTidParameter);

                // PatientCpr-parameter.
                IDbDataParameter patientCprParameter = command.CreateParameter();
                patientCprParameter.ParameterName = "@patientCpr";
                patientCprParameter.DbType = DbType.StringFixedLength;
                patientCprParameter.Value = patientCpr;
                command.Parameters.Add(patientCprParameter);

                int id = Convert.ToInt32(command.ExecuteScalar().ToString());
                return new Journallinje(id, tekst, dato, Journallinjekilde.Privat);
            }
        }

        public void TilknytJournallinjeMedBehandlingslinje(Journallinje journallinje, Behandlingslinje behandlingslinje)
        {
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE [dbo].[Journallinjer] " +
                                      "SET [BehandlingslinjeId] = @behandlingslinjeId " +
                                      "WHERE [Id] = @id;";

                // BehandlingslinjeId-parameter.
                IDbDataParameter behandlingslinjeId = command.CreateParameter();
                behandlingslinjeId.ParameterName = "@behandlingslinjeId";
                behandlingslinjeId.DbType = DbType.Int32;
                behandlingslinjeId.Value = behandlingslinje.Id;
                command.Parameters.Add(behandlingslinjeId);

                // Id-parameter.
                IDbDataParameter idParameter = command.CreateParameter();
                idParameter.ParameterName = "@id";
                idParameter.DbType = DbType.Int32;
                idParameter.Value = journallinje.Id;
                command.Parameters.Add(idParameter);

                command.ExecuteNonQuery();
            }
        }
    }
}