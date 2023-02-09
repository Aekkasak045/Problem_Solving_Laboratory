using ArrayQueueTest;
using ArrayStackTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLibDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayStack S = new ArrayStack(100);
            ArrayQueue Q = new ArrayQueue(100);
            int a = 0;
            int b = 1;
            int c = a + b;
            int temp;
            while (c < 10)
            {
                if ((c % 2) == 0)
                    S.push((int)c);
                else
                    Q.enqueue((int)c);
                a = b;
                b = c;
                c = a + b;
            }
            while (S.isEmpty() != true)
            {
                temp = (int)S.pop();
                Console.Write("{0} ", temp);
            }
            Console.WriteLine();
            while (Q.isEmpty() != true)
            {
                temp = (int)Q.dequeue();
                Console.Write("{0} ", temp);
            }
            Console.WriteLine();
        }
    }
}
