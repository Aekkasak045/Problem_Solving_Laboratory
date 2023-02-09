using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueueTest
{
    public class ArrayQueue
    {
        protected object[] data;
        protected int end, start;
        /**
        * Construct a new queue given the capacity
*/
        public ArrayQueue(int capacity)
        {
            //Actual capacity is 1 more than required
            //This makes it easier to detect if queue is full.
            data = new object[capacity + 1];
            //End and start both point to 0 (queue is empty)
            end = start = 0;
        }
        /**
        * Check whether this queue is empty
*/
        public bool isEmpty()
        {
            //A queue is empty if both end and
            //start point to the same location
            return end == start;
        }
        /**
        *Insert an object into the queue
*/
        public void enqueue(object o)
        {
            //Get next insert position
            int n = (end + 1) % data.Length;
            //Will this insert overflow the queue?
            if (n != start)
                data[end = n] = o;
        }
        /**
        * Remove an object from the queue
*/
        public object dequeue()
        {
            //Check if queue is empty
            if (isEmpty())
                return null;
            //Adjust start of queue pointer
            start = (start + 1) % data.Length;
            //Get object to be returned
            object o = data[start];
            //Null out memory location
            data[start] = null;
            //Return object we got
            return o;
        }
    }
}
