using System;

namespace Addition
{

    public class Addition : AdditionInterface
    {
        private dynamic Result;

        public dynamic Sum(dynamic a, dynamic b)
        {
            return a + b;
        }
        public dynamic Sum(dynamic arrayList)
        {
            Result = 0;
            foreach(dynamic i in arrayList)
            {
                Result += i;
            }
            return Result;

        }

    }
}
