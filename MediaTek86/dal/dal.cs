using System.Configuration;
using System.Data.SqlClient;

namespace TonProjet.dal
{
    public class dal
    {
        private string connectionString;

        public dal()
        {
            connectionString = GetConnectionString();
        }
        public string GetConnectionString()
        {
            return "Data Source=(localdb) \\MSSQLLocalDB;Initial Catalog=MediaTek;Integrated Security=True";
        }
    }
}