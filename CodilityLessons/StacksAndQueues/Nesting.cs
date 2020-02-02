namespace CodilityLessons.StacksAndQueues
{
    public class Nesting
    {
        public int Solution(string S)
        {
            if(S == null) return 0;
            if(S.Length == 0) return 1;
            long startCount = 0;
            long endCount = 0;
            foreach(char element in S)
            {
                if(element.Equals('(')) startCount++;
                else endCount++;

                if(endCount > startCount) return 0;
            }
            if(startCount == endCount) return 1;
            return 0;
        }
    }
}