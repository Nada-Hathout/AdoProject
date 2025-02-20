using Shopping.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.BusinessLayer
{
    
    public class categorieService
    {
        DbContext context;

        public categorieService(string connectionString)
        {
            context = new DbContext(connectionString);
        }

        public DataTable getCategories()
        {
            String query = "select CategoryId, CategoryName from Categories";
            DataTable dt = context.ExecuteQuery(query);

            return dt;
        }
       
        public int AddCategory(string CategoryName)
        {
            String query = $"Insert into Categories (CategoryName) values ('{CategoryName}')";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int UpdateCategory(string CategoryName)
        {
            String query = $"Update Categories set CategoryName='{CategoryName}' ";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int DeleteCategory(int id)
        {
            String query = $"Delete from Categories where CategoryId='{id}'";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }


    }
}
