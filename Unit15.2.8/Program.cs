using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15._2._8
{
    class Program
    {
        static List<int> Numbers = new List<int>();

        static void Main(string[] args)
        {
            while (true)
            {
                var input = Int32.TryParse(Console.ReadLine(), out int inputNumber);
                if (input)
                {
                    Numbers.Add(inputNumber);
                    Console.WriteLine();
                    Console.WriteLine($"Количество чисел: {Numbers.Count}");
                    Console.WriteLine($"Сумма чисел: {Numbers.Sum()}");
                    Console.WriteLine($"Наибольшее число: {Numbers.Max()}");
                    Console.WriteLine($"Наименьшее число: {Numbers.Min()}");
                    Console.WriteLine($"Среднее значение: {Numbers.Average()}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели не число!");
                }
            }
        }
    }
}
