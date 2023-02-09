using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public class MyDatabase
    {
        int customerID;
        string strName;
        string strAddress;

        public MyDatabase()
        {
            customerID = -1;
            strName = "unknow";
            strAddress = "unkown";
        }
        public MyDatabase(int id,string name, string address)
        {
            customerID = id;
            strName = name;
            strAddress = address;

        }
        public void ShowCustomer()
        {
            Console.WriteLine("Customer ID is {0}",customerID);
            Console.WriteLine("Customer name is {0}", strName);
            Console.WriteLine("Customer address is {0}", strAddress);
        }

    }

}
