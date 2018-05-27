using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyorsRendezesMaskep
{
    class Program
    {
        static int[] Csere(int[] A, int a, int b)
        {
            int sv;
            sv = A[a];
            A[a] = A[b];
            A[b] = sv;
            return A;
        }
        static int[] QuickSort(int[] A,int k,int v)
        {
            int pivot;
            
            pivot = Convert.ToInt32(Math.Round(Convert.ToDouble((k + v) / 2)));
            for (int i = k; i < v; i++)
            {
                

            }
            return A;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
