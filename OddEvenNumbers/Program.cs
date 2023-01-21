using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var evenNumbers = numbers.Where(x => x % 2 == 0);

            var oddNumbers = numbers.Where(x => x % 2 != 0);

            Console.WriteLine("Even numbers: ");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nOdd numbers: ");
            foreach (var number in oddNumbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}
