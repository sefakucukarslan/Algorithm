using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, flag;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i <= n; i++)
            {
                flag = 0;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
