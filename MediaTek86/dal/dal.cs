using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using MediaTek86.Models;

namespace MediaTek86.dal
{
    public class dal
    {
        public List<Personnel> GetAllPersonnel()
        {
            List<Personnel> liste = new List<Personnel>();
            return liste;
        }
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