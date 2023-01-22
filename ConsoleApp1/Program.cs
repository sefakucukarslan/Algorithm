using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int LinearSearch(int[] arr, int x)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };

            int x = 7;

            var result = LinearSearch(arr, x);

            if (result == -1)
            {

            }


        }
    }
}
