using System;
using System.Collections.Generic;
using System.Text;

namespace EgyptianGCD
{
    internal class FindGCD
    {
        public static int GCD(int a, int b)
        {
            int tempA = Math.Abs(a);
            int tempB = Math.Abs(b);

            if (tempA == 0 || tempB == 0)
            {
                return Math.Max(tempA, tempB);
            }

            while (tempA != tempB)
            {
                if (tempA > tempB)
                {
                    tempA -= tempB;
                }
                else
                {
                    tempB -= tempA;
                }
            }

            return tempA;
        }
    }
}