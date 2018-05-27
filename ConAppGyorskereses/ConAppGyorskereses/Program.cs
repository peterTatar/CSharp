using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGyorskereses
{
    class Program
    {
        static int[] Csere(int[] A, int a,int b)
        {
            int sv;
            sv = A[a];
            A[a] = A[b];
            A[b] = sv;
            return A;
        }
        static int[] Gyorsrendezés(int[] A,int k,int v)
        {
            int i,j,piv;
            i = k;
            j = v;
            piv=A[Convert.ToInt32(Math.Round(Convert.ToDouble((i+j)/2)))];
            while (i<=j)
            {
                while (A[i]<piv)
                {
                    i++;
                }
                while (A[j] > piv)
                {
                    j--;
                }
                if (i<=j)
                {
                    A = Csere(A, i, j);
                    i++;
                    j--;
                }
            }
            if (k<j)
            {
                A = Gyorsrendezés(A, k, j);
            }
            if (i<v)
            {
                A = Gyorsrendezés(A, i, v);
            }
            return A;
        }
        
        static void Main(string[] args)
        {
            int[] A = new int[] {0,3,4,3,5,8,3,6,11,0};
            A = Gyorsrendezés(A,1,A.Length-1);
            
            for (int i = 2; i < A.Length; i++)
            {
                Console.Write(A[i]+", ");

            }
            Console.ReadKey();
        }
    }
}
