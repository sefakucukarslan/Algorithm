using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 1, 3, 9, 2, 7, 6, 4 };

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);
        }
    }
}
