using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static int BinarySearch(int[] arr, int x)
        {
            int left = arr.Length - 1, right = 0;
            while (left >= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] < x)
                    right = mid + 1;
                else
                    left = mid - 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            Array.Sort(arr);
            int x = 3;
            int result = BinarySearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);

            Console.ReadLine();
        }
    }
}
