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
            int[] nums = { 1, 2, 3, 4 };
            Deneme deneme = new Deneme();
            int result =  deneme.ContainsDuplicate(nums);
            int c = deneme.RomanToInt("IX");
            Console.WriteLine(c);
            Console.ReadLine();

        }

    }
}
