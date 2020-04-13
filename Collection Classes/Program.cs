using System;
using System.Collections;

namespace Collection_Classes
{
    class Program
    {
        /*
         
            Collection is an alternate way of storing multiple variable number of elements or object.
            Like Stack, Queue, ArrayList, etc all of this are collection classes present in SYSTEM.COLLECTION Namespace.
            There is no type safety in collection classes i.e in a collection object of a queue we can store few integers and few strings.
            We need to type cast the elements while accessing it.
         */
        static void Main(string[] args)
        {
            Stack stack = new Stack(3);
            stack.Push(23);
            stack.Push(45);
            stack.Push(78);

            Console.WriteLine(Convert.ToString(stack.Pop()));

            Console.ReadKey();
        }

    }

}
