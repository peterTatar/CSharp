using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppBeszRend
{
    class Program
    {
        static int[] Csere(int[] A, int a, int b)
        {
            int c;
            c = A[a];
            A[a] = A[b];
            A[b] = c;
            return A;
        }
        static int[] Beszurasos(int[] A)
        {
            int i, sv;
            for (int j = 1; j < A.Length; j++)
            {
                i = j - 1;
                while ((i > -1) && (A[i] > A[i + 1]))
                {
                    sv = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = sv;
                    i = i - 1;
                }

            }
            return A;
        }
        
        static void Kiírtömb(int[] A)
        {
            Console.WriteLine();
            for (int j = 0; j < A.Length; j++)
            {
                Console.Write(A[j] + ", ");
            }
        }
        static void Main(string[] args)
        {
            //Tömb létrehozása és kiírása.
            int[] A = new int[] {3,5,1,7,2,1,4};
            int[] B = new int[] { 3, 5, 1, 7, 2, 1, 4 };


            Kiírtömb(A);
            A=Beszurasos(A);
            Kiírtömb(A);
            A=Csere(A, 0, 6);
            Kiírtömb(A);
            //B = Gyorsrendezés(B, 0, B.Length);
            //Kiírtömb(B);
            Console.ReadKey();
            }
        
    }
}
