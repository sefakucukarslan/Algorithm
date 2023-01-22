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
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 50, 7, 23, 80, 34, 9, 41, 1, 67 };

            Array.Sort(arr);

            int x = 1;

            int result = BinarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);

            Console.ReadLine();
        }
    }
}
