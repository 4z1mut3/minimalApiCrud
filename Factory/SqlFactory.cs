using System.Data;
using Microsoft.Data.SqlClient;

namespace MinimalApiCrud.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=BRNCSP010298\\SQLEXPRESS;Database=TesteDapper;Integrated Security=True;");

        }

    }
}