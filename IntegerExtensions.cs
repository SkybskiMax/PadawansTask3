using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            while(a!=0 && b!=0)
            {
                if (a>b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }
    }
}
