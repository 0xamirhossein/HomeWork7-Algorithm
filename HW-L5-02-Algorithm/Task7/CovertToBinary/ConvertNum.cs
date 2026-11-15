using System;
using System.Collections.Generic;
using System.Text;

namespace CovertToBinary
{
    internal class ConvertNum
    {
        public static string ConvertToBinary(int number)
        {
            // only for positive numbers 
            // for negative we use 2's complement
            if (number == 0)
                return "0";
            int temp = Math.Abs(number);
            string binary = "";
            while (temp > 0)
            {
                int remainder = temp % 2;
                binary += remainder.ToString();
                temp /= 2;
            }
            return binary.ToString();
        }
    }
}
