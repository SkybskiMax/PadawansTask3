using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a==0 && b==0)
            {
                throw new ArgumentException();
            }
            a = Math.Abs(a);
            b = Math.Abs(b);
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
