using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppBuborek
{
    class Program
    {
        static int[] Buborekrendezes(int[] A)
        {
            int sv,j,i;
            for (i = A.Length; i >0; i--) 
            {
                for (j = 0; j < i-1; j++)
                {
                    if (A[j]>A[j+1])
                    {
                        sv = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = sv;
                    }
                }
            }
            return A;
        }

        static void Main(string[] args)
        {
            int[] A = new int[] { 4, 5, 8, 2, 1, 3, 2, 6 };
            int[] B;
            B = Buborekrendezes(A);
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(A[i] + ", ");
            }
            Console.ReadKey();
            
        }
    }
}
