using System;

namespace Multiplication
{
    public class Multiplication : MultiplicationInterface
    {
        public int Product(int a, int b)
        {
            if (a < b)
            {
                return Product(a, b);
            }
            else if (b != 0)
            {
                return (a + Product(a, b - 1));
            }
            else
            {
                return 0;
            }

        }

        public decimal Product(decimal a, decimal b)
        {
            return a * b; 
        }
    }
}
