using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStackTest
{
    public class ArrayStack
    {
        //Declare some properties
        protected object[] data;
        protected int pointer;
        /**
        * Construct a new stack given the capacity
*/
        public ArrayStack(int capacity)
        { //Initialize data array with given capacity
            data = new object[capacity];
            //Start with an empty stack
            pointer = 0;
        }
        /**
        * Check whether this stack is empty
*/
        public bool isEmpty()
        {
            return pointer == 0;
        }
        /**
        * Push an object onto the stack
*/
        public void push(object ob)
        {
            //Check if there is enough space
            if (pointer < data.Length)
                data[pointer++] = ob;
        }
        /**
        * Pop and object from the stack
*/
        public object pop()
        { //Check if stack is empty
            if (isEmpty())
                return null;
            //Get object to be returned
            object oo = data[--pointer];
            //Null out memory location
            data[pointer] = null;
            //Return object we got
            return oo;
        }
}
