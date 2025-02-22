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
        public DataTable ProductDataFavoriteExist(int id)
        {
            string query = $"SELECT p.[ProductId],     p.[ProductName],    p.[Price],     c.[CategoryName] FROM Products p JOIN Categories c ON p.CategoryId = c.CategoryId WHERE  EXISTS (    SELECT 1     FROM Favorites f     WHERE f.ProductId = p.ProductId     AND f.UserId = {id});";
            DataTable dataTable = new DataTable();
            dataTable = context.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable dgv_Product()
        {

            String query = "select p.ProductId, p.ProductName,p.Price,c.CategoryName,p.CategoryId from Products p join Categories c on c.CategoryId=p.CategoryId";
            DataTable dt = context.ExecuteQuery(query);

            return dt;
        }

        public DataTable getAllProducts(int id)
        {

            string query = $"SELECT p.[ProductId],     p.[ProductName],    p.[Price],     c.[CategoryName] FROM Products p JOIN Categories c ON p.CategoryId = c.CategoryId WHERE NOT EXISTS (    SELECT 1     FROM Favorites f     WHERE f.ProductId = p.ProductId     AND f.UserId = {id});";
            DataTable dt = context.ExecuteQuery(query);

            return dt;
        }

        public int AddProduct(string ProductName,decimal price,int CategoryId )
        {
            String query = $"Insert into Products (ProductName,Price,CategoryId) values ('{ProductName}','{price}','{CategoryId}')";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int UpdateProduct(string ProductName, decimal price, int CategoryId, int id)
        {
            String query = $"Update Products set ProductName='{ProductName}',Price='{price}',CategoryId='{CategoryId}' where ProductId='{id}'";
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
