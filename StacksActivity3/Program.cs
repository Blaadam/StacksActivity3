using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksActivity3
{
    class Program
    {
        ////////////////////////////////////////////////////////////////////////////////
        // Stack class implemented with an array
        class Stack
        {
            static int StackPointer = -1;
            static int Max = 4;
            static string[] Contents = new string[4];

            // Add an item to the stack
            public bool Push(string Item)
            {
                if (StackPointer >= Max) {
                    return false;
                }

                StackPointer++;
                Contents[StackPointer] = Item;
                return true;
            }

            // Remove an item from the stack
            public string Pop()
            {
                if (StackPointer <= -1)
                {
                    return "";
                }

                string item = Contents[StackPointer];
                Contents[StackPointer] = null;
                StackPointer--;

                return item;
            }

            // Look at the top item in the stack without removing it
            public string Peek()
            {
                if (StackPointer <= -1)
                {
                    return "";
                }

                return Contents[StackPointer];
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        // Main program starts here
        static void Main(string[] args)
        {
            Stack MyStack = new Stack();

            // How to push to the stack (returns True on success or False on stack overflow)
            bool Action;
            Action = MyStack.Push("Craig");
            Action = MyStack.Push("Dave");

            // How to pop from the stack (stack underflow returns null)
            string Item;
            Item = MyStack.Pop();

            Console.ReadKey();
        }
    }
}
