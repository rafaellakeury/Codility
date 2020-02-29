using System;

namespace CodilityLessons.PrimesAndComposites
{
    public class MinPerimeterRectangle
    {
        public int Solution(int N)
        {
            long i = 1;
            long minPerimeter = Int32.MaxValue;

            while((i*i) <= N)
            {
                if((N % i) == 0 )
                {
                    long factor = N / i;
                    long minPerimeterCandidate = (factor + i) * 2;
                    if(minPerimeterCandidate < minPerimeter)
                    {
                        minPerimeter = minPerimeterCandidate;
                    }
                }
                i++;
            }

            return (int) minPerimeter;
        }
    }
}