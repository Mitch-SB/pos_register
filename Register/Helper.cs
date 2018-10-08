
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public static class Helper
    {
        //connection string that connects to my database
        public static string CnnVal(string GroceriesDB)
        {
            return ConfigurationManager.ConnectionStrings[GroceriesDB].ConnectionString;
        }
    }
}
