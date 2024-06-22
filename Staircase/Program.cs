using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            StairCases(n);

            Console.ReadLine();
        }
        public static void StairCases(int n)
        {
            for (int i = 0; i < n; i++)
            {
                //for (int j = n - 1; j > i; j--)
                //{
                //    Console.Write(" ");
                //}                Allta ki döngü ile aynı sonucu verecektir.
                for (int j = i; j < n - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
