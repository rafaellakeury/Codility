using System.Collections.Generic;
using System.Linq;

namespace CodilityLessons.StacksAndQueues
{
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            //A é o tamanho
            //B é a direcao: 0 pra cima e 1 pra baixo
            List<int> upFishs = new List<int>();
            List<int> downFishs = new List<int>();
            for(int i = 0; i< A.Length; i++)
            {
                if(B[i] == 0)
                {
                    upFishs.Add(A[i]);
                    while(downFishs.Count > 0)
                    {
                        if(A[i] > downFishs.Last())
                        {
                            downFishs.RemoveAt(downFishs.Count-1);
                        }
                        else if(A[i] < downFishs.Last())
                        {
                            upFishs.RemoveAt(upFishs.Count-1);
                            break;
                        }
                        else
                        {
                            downFishs.RemoveAt(downFishs.Count-1);
                            upFishs.RemoveAt(upFishs.Count-1);
                            break;                            
                        }
                    }
                }
                else
                {
                    downFishs.Add(A[i]);
                }

            }
            return upFishs.Count + downFishs.Count;
        }
    }
}