using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    static class Global
    {
        private static decimal _cashInTill = 250M;
        private static decimal _couponsInTill = 0M;
        private static string _cashier;
        private static string _password;

        public static decimal CashInTill
        {
            get { return _cashInTill; }
            set { _cashInTill = value; }
        }
        
        public static decimal CouponsInTill
        {
            get { return _couponsInTill; }
            set { _couponsInTill = value; }
        }

        public static string Cashier
        {
            get { return _cashier; }
            set { _cashier = value; }
        }

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
