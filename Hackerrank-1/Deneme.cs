using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_1
{
    public class Deneme
    {
        public string GetString(string firstString, string secondString, string thirdString)
        {
            string result = "";
            bool firstBeforeSecond = CheckFirstStringWithSecondString(firstString, secondString);
            bool firstBeforeThird = CheckFirstStringWithSecondString(firstString, thirdString);
            bool secondBeforeThird = CheckFirstStringWithSecondString(secondString, thirdString);

            if (firstBeforeSecond && firstBeforeThird && secondBeforeThird)
            {
                result = firstString + secondString + thirdString;
            }
            if (firstBeforeSecond && firstBeforeThird && secondBeforeThird == false)
            {
                result = firstString + thirdString + secondString;
            }
            if (firstBeforeSecond == false && firstBeforeThird && secondBeforeThird)
            {
                result = secondString + firstString + thirdString;
            }
            if (firstBeforeSecond == false && firstBeforeThird == false && secondBeforeThird)
            {
                result = secondString + thirdString + firstString;
            }
            if (firstBeforeSecond && firstBeforeThird == false  && secondBeforeThird == false)
            {
                result = thirdString + firstString + secondString;
            }
            if(firstBeforeSecond == false && firstBeforeThird == false  && secondBeforeThird == false)
            {
                result = thirdString + secondString + firstString;
            }

            return result;

        }

        public bool CheckFirstStringWithSecondString(string firstString, string secondString)
        {
            int count = 0;

            if (firstString.Length <= secondString.Length)
            {
                count = firstString.Length;
            }
            else
            {
                count = secondString.Length;
            }

            for (int i = 0; i < count; i++)
            {
                if (firstString[i] > secondString[i])
                {
                    return false;
                }
                else if (firstString[i] < secondString[i])
                {
                    return true;
                }
            }
            return true;
        }
    }
}
