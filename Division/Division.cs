using System;

namespace Division
{
    public class Division : DivisionInterface
    {
        public decimal Result(decimal a, decimal b)
        {
            return a / b;
        }
        public int Result(int a, int b)
        {
            return a / b;
        }
    }
}
