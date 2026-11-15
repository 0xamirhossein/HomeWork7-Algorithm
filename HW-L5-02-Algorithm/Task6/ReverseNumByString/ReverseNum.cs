using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseNumByString
{
    internal class ReverseNum
    {
        public static string ReverseNumber(int number)
        {
            bool isNegative = number < 0;
            string numStr = Math.Abs(number).ToString();
            char[] charArray = numStr.ToCharArray();
            if (isNegative)
            {
                return "-" + new string(charArray.Reverse().ToArray());
            }
            else
            {
                return new string(charArray.Reverse().ToArray());
            }
        }
    }
}
