namespace CodilityLessons.PrimesAndComposites
{
    public class CountFactors
    {
        public int Solution(int N)
        {
            long i = 1;
            long result = 0;
            while((i*i) < N)
            {
                if((N % i) == 0 )
                    result += 2;
                i++;
            }
            if((i*i) == N)
                result += 1;

            return (int)result;
        }
    }
}