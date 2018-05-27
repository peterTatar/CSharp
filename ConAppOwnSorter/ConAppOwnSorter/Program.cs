using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOwnSorter
{
    class Program
    {
        static int[] Csere(int[] Array, int a,int b) { int c; c = Array[a]; Array[a] = Array[b]; Array[b] = Array[c]; return Array; }
        static void Main(string[] args)
        {
            int[] unSortedArray = {2,3,6,4,7,1,22,3,2,8};
            int arrayLength = unSortedArray.Length;
            List<int> unSortedList = new List<int> { };
            unSortedList.AddRange(unSortedArray);
            
            if (arrayLength%2!=0)
            {

            }
            else
            {
                
            }

            for (int i = 0; i < arrayLength / 2 - 1; i++)
            {
                if (unSortedArray[i * 2] > unSortedArray[i * 2 + 1])
                {
                    unSortedArray = Csere(unSortedArray, unSortedArray[i / 2], unSortedArray[i / 2 + 1]);

                }
            }

            Console.ReadKey();
        }
    }
}
