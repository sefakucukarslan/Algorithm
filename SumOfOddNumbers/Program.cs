using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sumOfAddNumbers = SumOfAddNumbers(arr);

            Console.WriteLine("Tek sayıların toplamı: " + sumOfAddNumbers);

            Console.ReadLine();
        }

        public static int SumOfAddNumbers(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
