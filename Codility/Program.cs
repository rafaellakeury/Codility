using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 6, 1, 4, 4 };
            var test = MaxCounters(5, array);
            Console.ReadLine();
        }

        //Iterations and loops
        public int Solution(int n)
        {
            var highestGap = 0;
            var binaryRepresentation = Convert.ToString(n, 2);

            int gapCount = 0;
            foreach (var ch in binaryRepresentation)
            {
                var number = Convert.ToInt32(ch.ToString());
                if (number.Equals(0))
                    gapCount++;
                else
                {
                    if (gapCount > highestGap)
                    {
                        highestGap = gapCount;
                    }
                    gapCount = 0;

                }
            }

            return highestGap;
        }

        //Arrays - cyclic rotation
        public int[] Solution(int[] A, int K)
        {
            if (A.Length > 0)
            {
                while (K > 0)
                {
                    var temp = A[A.Length - 1];
                    for (int i = A.Length - 1; i > 0; i--)
                    {

                        A[i] = A[i - 1]; //a[1] = a[0]
                    }
                    A[0] = temp;

                    K--;
                }
            }
            return A;
        }

        //Arrays - Odd occourrences
        public int solution(int[] A)
        {
            //int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            //a
            return A.Aggregate((x, y) => x ^ y);
        }

        //Frog jump
        public static int solution(int X, int Y, int D)
        {
            //Y-X = 75 / D
            double count = (double)(Y - X) / (double)D;
            return (int)Math.Ceiling(count);
        }

        //Missing element
        public int MissingElement(int[] A)
        {
            // 2 3 1 5 - 4 elementos: de 1 a 5 = 5 + 4 + 3 + 2 + 1 = 15
            // 2 + 3 + 1 + 5 = 11
            //
            long baseNumber = A.Length + 1;
            var totalSum = (baseNumber * (baseNumber + 1)) / 2;
            var missingElement = totalSum - A.Select(x => (long)x).Sum();
            return (int) missingElement; 
        }

        //Tape equilibrium
        public int TapeEquilibrium(int[] A)
        {
            long lower = 0, diff = 0, higher = A.Sum(), minDiff = Int64.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                lower += A[i];
                higher -= A[i];
                diff = Math.Abs(higher - lower);
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }
            return (int)minDiff;
        }

        //[4, 1, 3, 2]
        public static int Permutation(int[] A)
        {
			int length = A.Length;
			bool[] result = new bool[length];
			foreach(int element in A)
			{
				if (element > length)
				{
					return 0;
				}
				else if(result[element-1] == true)
				{
					return 0;
				}
				else 
				{
					result[element - 1] = true;
				}
					
			}
			return 1;
        }

		public static int FrogRiver(int X, int[] A)
		{
			//[1, 3, 1, 4, 2, 3, 5, 4]
			//[true, false, true, false, false]
			//counter = 2

			int counter = 0;
			bool[] result = new bool[X];
			foreach (int element in A)
			{
				if(result[element-1] == false)
				{
					result[element - 1] = true;
					counter++;
				}
				if (counter == X)
				{
					return Array.IndexOf(A, element);
				}
			}
			return -1;
		}

		public static int[] MaxCounters(int N, int[] A)
		{
			int[] counter = new int[N];
			int baseMinimum = 0;
			int possibleMinimum = 0;
			int index = 0;

			for (int i = 0; i < A.Length; i++)
			{
				index = A[i] - 1;

				if (index == N)
				{
					baseMinimum = possibleMinimum;
				}
				else
				{
					counter[index] = Math.Max(counter[index], baseMinimum);
					counter[index] += 1;

					if (possibleMinimum < counter[index])
					{
						possibleMinimum = counter[index];
					}
				}
			}

			for (int i = 0; i < counter.Length; i++)
			{
				counter[i] = Math.Max(counter[i], baseMinimum);
			}

			return counter;
		}

		//Missing integer
		public int MissingInteger(int[] A)
		{
			int result = 1;
			Dictionary<int, bool> found = new Dictionary<int, bool>();

			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] > 0 && !found.ContainsKey(A[i]))
				{
					found.Add(A[i], true);
				}
			}

			while (found.ContainsKey(result))
			{
				result++;
			}

			return result;
		}

		public int PassingCars(int[] A)
		{
			int count = 0;
			int multiply = 0;
			foreach (int car in A)
			{
				if (car == 0)
				{
					multiply = multiply + 1;
				}
				if (multiply > 0)
				{
					if (car == 1)
					{
						count = count + multiply;
						if (count > 1000000000)
						{
							return -1;
						}
					}
				}
			}
			return count;
		}

		public int[] GeonomicRangeQuery(String S, int[] P, int[] Q)
		{
			List<int> result = new List<int>();
			var nucleotidesDictionary = new Dictionary<string, int>()
			{
				{"A", 1},
				{"C", 2},
				{"G", 3},
				{"T", 4}
			};
			var dnaSequence = S.ToCharArray();
			var dnaSequenceValues = dnaSequence.Select(x => nucleotidesDictionary.First(y => y.Key.Equals(x.ToString())).Value)
				.ToArray();

			for (int i=0; i<P.Length; i++)
			{
				var pPosition = P[i];
				var qPosition = Q[i];
				var smaller = dnaSequenceValues[pPosition];
				for (int j = pPosition; j<=qPosition; j++)
				{
					if(smaller > dnaSequenceValues[j])
					{
						smaller = dnaSequenceValues[j];
					}
				}
				result.Add(smaller);
			}

			return result.ToArray();
		}
	}


}
