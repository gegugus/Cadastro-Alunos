using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetornoAulasCSHarp
{
    public static class ConnBD
    {
        private static string connectionString =
            @"Server=.\BDSENAC;Database=CADASTROALUNOS;User Id=senaclivre;Password=senaclivre;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
