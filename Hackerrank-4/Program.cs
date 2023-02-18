using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaabbbccdaabAAAAAAAAAA";

            EnCokTekrarEdenKarakteriBulma enCokTekrarEdenKarakteriBulma = new EnCokTekrarEdenKarakteriBulma();
            char c = enCokTekrarEdenKarakteriBulma.EnCokTekrarEdenKarakter(str);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
