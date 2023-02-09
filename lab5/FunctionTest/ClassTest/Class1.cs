using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            MyDatabase mdb1 = new MyDatabase();
            mdb1.ShowCustomer();

            MyDatabase mdb2 = new MyDatabase(101, "Miss thailand", "5 thai Rd.");
            mdb2.ShowCustomer();
        }
    }
}
