using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess
{
    public class DbContext
    {
        SqlConnection con;
        public DbContext(string connectionString) { 
        con=new SqlConnection(connectionString);
        }

        //select(disconnected mode)
        public DataTable ExecuteQuery(string commandText)
        {
            SqlCommand command=new SqlCommand(commandText, con);
            SqlDataAdapter adapter=new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        //insert,update,delete (connected mode)
        public int ExecuteNonQuery(string commandText)
        {
            
            SqlCommand command = new SqlCommand(commandText, con);
            int affectedRows = 0;
            try
            {
                
                con.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return affectedRows;

        }
    }
}
