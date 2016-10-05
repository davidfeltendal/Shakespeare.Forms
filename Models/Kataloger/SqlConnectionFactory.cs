using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Shakespeare.Forms.Models.Kataloger
{
    public class SqlConnectionFactory: IDbConnectionFactory
    {
        public IDbConnection Åbn()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
    }
}