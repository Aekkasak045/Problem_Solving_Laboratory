using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStackTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { //To create a stack with maximum capacity 5
                ArrayStack mystack = new ArrayStack(5);
                //To push 5 elements onto the stack
                for (int i = 0; i < 5; i++)
                {
                    //To make a string "objN" where N ranges 0 to 4
                    string objToPush = "obj" + i;
                    //Display what we're doing
                    Console.WriteLine("pushing: {0}", objToPush);
                    //To push the object on the stack
                    mystack.push(objToPush);
                }
                //To pop all elements from the stack
                while (!mystack.isEmpty())
                { //To pop an object from the stack
                    string objPoped = (string)mystack.pop();
                    //Display what we're doing
                    Console.WriteLine("poping: {0}", objPoped);
                }
            }
    }
}
