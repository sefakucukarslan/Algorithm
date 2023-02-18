using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_4
{
    public class EnCokTekrarEdenKarakteriBulma
    {
        public char EnCokTekrarEdenKarakter(string str)
        {
            string s = str[0].ToString();
            int counter,max = 0;
            char enCokTekrarEdenKarakter = '\0';
            

            for (int i = 1; i < str.Length; i++)
            {
                if (!s.Contains(str[i]))
                {
                    s += str[i];
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (s[i] == str[j])
                    {
                        counter++;
                    }
                }
                if (max < counter)
                {
                    max = counter;
                    enCokTekrarEdenKarakter= s[i];
                }
            }
            return enCokTekrarEdenKarakter;
        }
    }
}
