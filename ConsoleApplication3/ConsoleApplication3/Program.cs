using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List of type string. Add to it, remove from it, loop through it

            // Create list of type string and add some names. List will hold string variables
            List<string> myList = new List<string>
            {
                "Dan", "Rob", "Maikey"
            };

            // Another way to add more names to the List:
            myList.Add("Harold");
            // Our list should now have four names....time for a breakpoint! 
            // Put a break point on the line 'var names = myList'. Let the app hit the breakpoint and 
            // then press f10 and now hover over 'names'. Notice you will see 4 items like so:
            // [0], [1] ...etc...So, our first item in the list is indexed as [0], so if we do
            // myList[0] we will get a name. This is what we mean by ZERO based index. Indeed, arrays,
            // lists etc first element has index of ZERO.
            var names = myList;
            var name = myList[0]; /* Put break point here - run - press f10. */

            // Remove element from List like so:
            myList.Remove("Rob"); /* Put break point here - run - press f10. List has 3 names! */

            // Add element to START of the List...As we said, Lists start at ZEROth index, so the
            // Insert(..) methods first argument is the LOCATION in the list of where we want to add 
            // our new value. The 2nd argument is the actual value. So, this is saying. Add Claire 
            // to the zeroth index of myList, i.e. Add Claire to the START of the list.
            myList.Insert(0, "Claire");

           // Remove element at a specific index. Remove the name that is index position 1
            myList.RemoveAt(1);
            Console.ReadLine();
        }
    }
}
