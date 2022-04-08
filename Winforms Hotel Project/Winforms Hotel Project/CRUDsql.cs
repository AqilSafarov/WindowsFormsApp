using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Hotel_Project
{
    public static class CRUDsql
    {
        public static int MethExecCommand(string pathDb, string query, SqlParameter[] sqlParameter)
        {
            SqlConnection con = new SqlConnection(pathDb);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            foreach (var item in sqlParameter)
            {
                command.Parameters.Add(item);
            }
            int nonQuery = command.ExecuteNonQuery();
            con.Close();

            return nonQuery;
        }

    }
}
