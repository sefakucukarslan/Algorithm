using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            string result = deneme.GetString("sefa", "sefa", "uras");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
