using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Showdata(101, "Miss Thailand", "5 thai Rd.");
        }
        static void Showdata(int id,string name,string address)
        {
            Console.WriteLine("Customer ID is {0}",id);
            Console.WriteLine("Customer name is {0}", name);
            Console.WriteLine("Customer address is {0}", address);
            Console.WriteLine();
        }
    }
}
