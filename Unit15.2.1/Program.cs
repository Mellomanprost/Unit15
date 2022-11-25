using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
            
        }

        static long Factorial(int number)
        {
            var numbers = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                numbers.Add(i);
            }

            long result = numbers.Aggregate((x, y) => x * y);
            return result;
        }
    }
}
