using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeNumber
{
    internal class Check
    {
        public static bool IsPalindrome(int number)
        {
            if (number < 0 || (number % 10 == 0 && number != 0))
            {
                return false;
            }
            int reversed = 0;
            int temp = number;
            while (number > reversed)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            return number == reversed || number == reversed / 10;
        }


    }
}
