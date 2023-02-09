using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueueTest
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Create a stack with maximum capacity 10
            ArrayQueue myqueue = new ArrayQueue(10);
            //Enqueue 10 elements onto the queue
            for (int i = 0; i < 10; i++)
            {
                //Make a string "objN" where N ranges 0 to 9
                string objToQueue = "obj" + i;
                //Display what we're doing
                Console.WriteLine("enqueueing: {0}", objToQueue);
                //Enqueue object onto the queue
                myqueue.enqueue(objToQueue);
            }
            //Dequeue all elements from the queue
            while (!myqueue.isEmpty())
            {
                //Dequeue object from the queue
                string objFromQueue = (string)myqueue.dequeue();
                //Display what we're doing
                Console.WriteLine("dequeued: {0}", objFromQueue);
            }
        }
    }
}
