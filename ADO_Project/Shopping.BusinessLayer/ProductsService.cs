using Shopping.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.BusinessLayer
{
   
    public class ProductsService
    {
        DbContext context;
        public ProductsService(String connectionString) {
            context = new DbContext(connectionString);
        }
        public DataTable getProduct()
        {
            String query = "select ProductId, ProductName,Price,CategoryId from Products";
            DataTable dt=context.ExecuteQuery(query);

            return dt;
        }

        public int AddProduct(string ProductName,decimal price,int CategoryId )
        {
            String query = $"Insert into Products (ProductName,Price,CategoryId) values ('{ProductName}','{price}','{CategoryId}')";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int UpdateProduct(string ProductName, decimal price, int CategoryId)
        {
            String query = $"Update Products set ProductName='{ProductName}',Price='{price}',CategoryId='{CategoryId}' ";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int DeleteProduct(int id)
        {
            String query = $"Delete from Products where ProductId='{id}'";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

    }
}
