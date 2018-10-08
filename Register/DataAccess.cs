using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Register
{
    public class DataAccess
    {
        //skeleton of a list I was using to pull data, proved to be inefficient for my uses

        //public List<Grocery> GetGrocery(string lookUp)
        //{
        //    //How to connect to SQL Server

        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GroceriesDB")))
        //    {
        //        var output = connection.Query<Grocery>("dbo.Grocery_GetByLookUp @LookUp", new { LookUp = lookUp }).ToList();
        //        return output;

        //    }

        //    //using statement and curly braces close down the connection securely
        //}


        //Gets and sets grocery based on the lookUp field
        public Grocery GetGrocery(int lookUp)
        {
            Grocery matchingGrocery = new Grocery();
            using (SqlConnection myCnn = new SqlConnection(Helper.CnnVal("GroceriesDB"))) //Uses my helper class to connect to my database in sql server
            {
                //query that will run my stored procedure
                string oString = "dbo.Grocery_GetByLookUp @LookUp";
                SqlCommand oCmd = new SqlCommand(oString, myCnn);
                oCmd.Parameters.AddWithValue("@LookUp", lookUp);
                myCnn.Open(); //opens my connection
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        //assigns the values grabbed into their respective places
                        matchingGrocery.Name = oReader["Name"].ToString();
                        matchingGrocery.Price = (decimal)oReader["Price"];
                        matchingGrocery.Taxable = (bool)oReader["Taxable"];
                        matchingGrocery.Identification18 = (bool)oReader["Identification18"];
                        matchingGrocery.Identification21 = (bool)oReader["Identification21"];
                    }
                    //securely closes my connection
                    myCnn.Close();
                }
            }
            return matchingGrocery;
        }

    public Cashiers GetCashiers(int CashNumber)
        {
            Cashiers matchingCashier = new Cashiers();
            using (SqlConnection myCnn = new SqlConnection(Helper.CnnVal("GroceriesDB")))
            {
                string oString = "dbo.Cashier_GetByCashNumber @CashNumber";
                SqlCommand oCmd = new SqlCommand(oString, myCnn);
                oCmd.Parameters.AddWithValue("@CashNumber", CashNumber);
                myCnn.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        matchingCashier.Name = oReader["Name"].ToString();
                        matchingCashier.UserPassword = (int)oReader["UserPassword"];
                    }

                    myCnn.Close();
                }
            }
            return matchingCashier;
        }
        
    }
}
