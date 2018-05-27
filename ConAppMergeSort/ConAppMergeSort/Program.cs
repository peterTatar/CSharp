using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMergeSort
{
    class Program
    {
        static int[] MergeSort(int[] A,int k,int v)
        {
            int m,j,i;
            int[] X=new int[] {0,0,0,0,0,0,0,0};
            if (k<v)
            {
                m=Convert.ToInt32(Math.Round(Convert.ToDouble((k + v) / 2)));
                MergeSort(A, k, m);
                MergeSort(A, m + 1, v);
                for ( i = k; i < m; i++)
                {
                    X[i] = A[i];
                }
                for ( i = m+1; i < v; i++)
                {
                    j = v + m + 1 - i;
                    X[j] = A[i];
                }
                i = k;
                j = v;
                for (int ke  = k; i < v; i++)
                {
                    if (X[i]<X[j])
                    {
                        A[ke] = X[i];
                        i++;
                    }
                    else
                    {
                        A[k] = X[j];
                        j--;
                    }
                }
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] B = new int[] {1,6,3,4,2,7,5,7};
            B = MergeSort(B, 0, B.Length);
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i]);

            }
            Console.ReadKey();
        }
    }
}
