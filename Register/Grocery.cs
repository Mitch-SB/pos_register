using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class Grocery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Taxable { get; set; }
        public int LookUp { get; set; }
        public bool Identification18 { get; set; }
        public bool Identification21 { get; set; }
        public int MyProperty { get; set; }

        //public string ScannedItem
        //{
        //    get
        //    {
        //        return $"{Name}  {Price}";
        //    }
        //}

    }
}
