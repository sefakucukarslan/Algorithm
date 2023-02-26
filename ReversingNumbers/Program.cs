using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rev = 0;

            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                rev = rev * 10;
                rev = rev + num % 10;
                num = num / 10;
            }

            Console.Write("Reversed number is = " + rev);

            Console.ReadLine();
        }
    }
}
