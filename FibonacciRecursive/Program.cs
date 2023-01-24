using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("The " + n + "th Fibonacci number is: " + Fibonacci(n));
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
