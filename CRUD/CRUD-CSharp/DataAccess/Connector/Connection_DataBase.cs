using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection_DataBase
    {
        //Credenciales para la conexión a base de datos
        private SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=Music;Integrated Security=True");

         public SqlConnection OpenConnection()
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;
        }

        public SqlConnection CloseConnection()
        {
            if (c.State == ConnectionState.Open) c.Close();
            return c;
        }
    }
}
