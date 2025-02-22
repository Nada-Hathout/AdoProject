using Shopping.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.BusinessLayer
{
    internal class Favourite
    {
        DbContext context;

        public Favourite(string connectionString)
        {
            context = new DbContext(connectionString);
        }
    }
}
