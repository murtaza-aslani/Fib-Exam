using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int fib1 = 0, fib2 = 1;

            Console.Write(fib1 + "\t");
            Console.Write(fib2 + "\t");

            for (int i = 0; i < n; i++)
            {
                int fibNext = fib1 + fib2;
                Console.Write(fibNext + "\t");

                fib1 = fib2;
                fib2 = fibNext;
            }

            Console.ReadLine();
        }
    }

}
