using System;
using System.Collections.Generic;
using System.Text;

namespace IsPrimeNumber
{
    internal class IsPrime
    {
        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
