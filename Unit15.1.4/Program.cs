using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            CountCommonChar("individual", "responsoble");
        }

        static void CountCommonChar(string word1, string word2)
        {
            var commonChar = word1.Intersect(word2);
            foreach (var item in commonChar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
