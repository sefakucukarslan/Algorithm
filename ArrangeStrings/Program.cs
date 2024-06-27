using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li1= new List<string>();
            li1.Add("bcbb");
            li1.Add("abc");
            li1.Add("bbaa");
            li1.Add("aa");

            Console.WriteLine("Before sorting..");

            foreach (var item in li1)
            {
                Console.WriteLine(item);
            }

            MySortFunction(li1);

            Console.ReadLine();
        }

        public static void MySortFunction(List<string> li)
        {
            string temp;
            for(int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (string.Compare(li[i], li[j]) < 0)
                    {
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
                Console.WriteLine("..........................");
                foreach (var item in li)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("..........................");
            }
        }
    }
}
