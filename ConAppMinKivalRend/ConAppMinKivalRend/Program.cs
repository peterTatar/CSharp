using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMinKivalRend
{
    class Program
    {
        static int[] Minkival(int[] A)
        {
            int sv,mini;
            for (int j = 0; j < A.Length-1; j++)
            {
                mini = j;
                for (int i = j+1; i < A.Length; i++)
                {
                    if (A[mini]>A[i])
                    {
                        mini = i;
                    }
                }
                sv = A[j];
                A[j] = A[mini];
                A[mini] = sv;
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] A = new int[] {1,3,6,9,2,5,3};
            A = Minkival(A);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ", ");

            }
            Console.ReadKey();
        }
    }
}
