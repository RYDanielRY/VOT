using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35.CAPA_CONNECTION
{
    public class CD_Connection
    {
        static private string sqlConnection = "Data Source=GIGABYTE;Initial Catalog=TestUITWO;User ID=User1;Password=1234";
        private SqlConnection connection = new SqlConnection(sqlConnection);

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection ClosedConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
