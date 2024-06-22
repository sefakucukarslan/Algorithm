using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            int c = deneme.RomanToInt("IX");
            Console.WriteLine(c);
            Console.ReadLine();

        }

    }
}
