using System;
using System.Linq;

namespace Unit15._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = new int[] { 2, 5, 7, 8, 4 };
            Console.WriteLine(Average(numbers));
        }

        static double Average(int[] numbers)
        {
            //var averageNumbers = numbers.Average();
            // or

            var averageNumbers = numbers.Sum() / (double)numbers.Length;
            return averageNumbers;
        }
    }
}
