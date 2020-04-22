using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace euler_one
{
    class Program
    {
        /*
            If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            Find the sum of all the multiples of 3 or 5 below 1000.
            2 ms execution time
            Mac OS X Catalina
            16 GB RAM
            I9 9800
        */
        static void Main(string[] args)
        {

            Stopwatch watch = new Stopwatch();
            watch.Start();
            
            int limit = 1000;
            List<int> multipleFive = multipleList(5, limit);
            List<int> multipleThree = multipleList(3, limit);   

            HashSet<int> accumulatedMultiples = new HashSet<int>();
            int amount = 0;

            foreach(int num in multipleFive)
            {
                accumulatedMultiples.Add(num);
            }
        
            foreach(int num in multipleThree)
            {
                accumulatedMultiples.Add(num);
            }

            foreach (int num in accumulatedMultiples)
            {
                amount += num;
            }

            watch.Stop();

            Console.WriteLine("Result: {0}", amount);
            Console.WriteLine("Execution time: {0} ms", watch.ElapsedMilliseconds);
        }

        private static List<int> multipleList(int number, int limit)
        {
            List<int> multipleList = new List<int>();

            for(int i = 0; i < limit; i++)
            {
                if(isMultiple(i, number))
                {
                    multipleList.Add(i);
                }
            }

            return multipleList;
        }

        private static bool isMultiple(int number, int multiple)
        {
            return (number != 0) ? number % multiple == 0 : false;
        }
    }
}
