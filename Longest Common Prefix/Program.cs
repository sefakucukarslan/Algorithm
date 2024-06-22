using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"flower", "flow", "flight"};

            LongestCommonPrefix(strs);
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];
            foreach (string str in strs)
            {
                int length = Math.Min(str.Length, prefix.Length);
                int i = 0;
                while (i < length && prefix[i] == str[i])
                {
                    i++;
                }

                prefix = prefix.Substring(0, i);
            }

            return prefix;
        }
    }
}
