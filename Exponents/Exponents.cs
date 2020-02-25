using System;

namespace Exponents
{
    public class Exponents : ExponentInterface
    {
        public double PowerOf(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
