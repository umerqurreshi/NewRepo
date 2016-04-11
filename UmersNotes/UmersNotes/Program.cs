using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UmersNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{10, 20};

            Parallel.For(0, numbers.Count,
                  index =>
                  {
                      int newNum = numbers[index];

                      numbers.Add(newNum);
                  });

            Parallel.ForEach(numbers,
              index => {
                  Console.WriteLine(index);
              });

            Parallel.ForEach(numbers,  //Condensed version of the above foreach!!!
                Console.WriteLine);

            Console.ReadLine();
        }
    }
}
