using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MealOrder.Helpers
{
    public class ConexaoDB
    {

        public static SqlConnection GetSqlLocalConnection()
        {
            string connn = @"Server = (localdb)\MSSQLLocalDB; Database = myDataBase; Trusted_Connection = True;";
            return new SqlConnection(connn);        
        }
        
    }
}
