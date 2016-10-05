using System.Data;

namespace Shakespeare.Forms.Models.Kataloger
{
    public interface IDbConnectionFactory
    {
        IDbConnection Åbn();
    }
}