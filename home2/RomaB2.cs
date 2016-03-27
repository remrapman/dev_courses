using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int i = 0;
            for (i = 1; i < 101; i++)
            {
                a = i;
                if ((a % 3 == 0) && (a % 5 == 0))
                {
                Console.WriteLine("FizzBuzz");
                }
                else if (a % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            Console.ReadLine();
        }
    }
}
