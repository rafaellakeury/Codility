using System.Collections.Generic;

namespace CodilityLessons.Leader
{
    public class Equileader
    {
    public int Solution(int[] A)
    {
        int n = A.Length;
        int size = 0;
        Stack<int> s = new Stack<int>();

        for (int i=0; i<n; i++)
        {
            if(size == 0)
            {
                size +=1;
                s.Push(A[i]);
            }
            else
            {
                if (s.Peek() != A[i]) size -=1;
                else size +=1;
            }
        }
        int candidate = -1;
        if (size > 0) candidate = s.Peek();
        int count = 0;
        int leader= -1;

        for (int i=0; i<n; i++)
        {
         if (A[i] == candidate) count +=1;
         if (count > n/2) leader = candidate;
        }

        int equiLeaders = 0;
        int leaders = 0;

        for (int i=0; i<n; i++)
        {
            if (A[i] == leader) leaders++;
            if (leaders > (i+1)/2 && count-leaders > (n-1-i)/2) equiLeaders++;
        }

        return equiLeaders;
    }
    }
}