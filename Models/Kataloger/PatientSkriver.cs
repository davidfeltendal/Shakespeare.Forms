using System;
using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class PatientSkriver : IPatientSkriver
    {
        private readonly IDbConnectionFactory connectionFactory;

        public PatientSkriver(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException("connectionFactory");
            }

            this.connectionFactory = connectionFactory;
        }

        public void GemPatient(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException("patient");
            }
            
            using (IDbConnection connection = this.connectionFactory.Åbn())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO [dbo].[Patienter]([CPR]) " +
                                      "SELECT @cpr " +
                                      "WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Patienter] WHERE [CPR] = @cpr);";
                
                // CPR-parameter.
                IDbDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@cpr";
                parameter.DbType = DbType.StringFixedLength;
                parameter.Value = patient.Cpr;
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
            }
        }
    }
}