using Shopping.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.BusinessLayer
{
    public class Favourite
    {
        DbContext context;

        public Favourite(string connectionString)
        {
            context = new DbContext(connectionString);
        }
        public int addFav(int productID, int UserID)
        {
            string query = $"insert into Favorites([UserId],ProductId) values ({UserID},{productID})";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int deleteFav(int productID, int UserID)
        {
            string query = $"delete from Favorites where ProductId={productID} and UserId={UserID}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;

        }
    }
}
