using System;
using Addition;
using Subtraction;
using Multiplication;
using Division;
using SquareRoot;
using Exponents;

namespace BasicCalculator
{
    public class BasicCalculator : AdditionInterface, SubtractionInterface, MultiplicationInterface, DivisionInterface, SqaureRootInterface, ExponentInterface 
    {
        Addition.Addition add = new Addition.Addition();
        public dynamic Sum(dynamic a, dynamic b)
        {
            return ((AdditionInterface)add).Sum(a, b);
        }

        public dynamic Sum(dynamic arrayList)
        {
            return ((AdditionInterface)add).Sum(arrayList);
        }        

        Subtraction.Subtraction subtract = new Subtraction.Subtraction();
        public int Subtract(int a, int b)
        {
            return subtract.Subtract(a,b);
        }

       
        Multiplication.Multiplication product = new Multiplication.Multiplication();
         public int Product(int a, int b)
         {
             return ((MultiplicationInterface)product).Product(a, b);
         }

        public decimal Product(decimal a, decimal b)
        {
            return ((MultiplicationInterface)product).Product(a, b);
        }

        Division.Division quotient = new Division.Division();
        public int Result(int a, int b)
        {
            return ((DivisionInterface)quotient).Result(a, b);
        }

        public decimal Result(decimal a, decimal b)
        {
            return ((DivisionInterface)quotient).Result(a, b);
        }

        
        SqaureRoot sqrt = new SqaureRoot();
        public dynamic SqaureRootofNumber(double a)
        {
            return ((SqaureRootInterface)sqrt).SqaureRootofNumber(a);
        }

        Exponents.Exponents pow = new Exponents.Exponents();
        public double PowerOf(double a, double b)
        {
            return ((ExponentInterface)pow).PowerOf(a, b);
        }
    }
}
