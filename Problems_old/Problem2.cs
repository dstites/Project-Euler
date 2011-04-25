using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem2
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
