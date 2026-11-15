using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfDigits
{
    internal class Total
    {
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
