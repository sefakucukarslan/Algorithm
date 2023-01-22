using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
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
            int[] arr = { 2, 3, 4, 10, 40 };

            int x = 40;

            int result = LinearSearch(arr, x);

            if (result == -1)            
                Console.WriteLine("Element is not present in array");        
            else
                Console.WriteLine("Element is present at index: " + result);

            Console.ReadLine();
        }
    }
}
