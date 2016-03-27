using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home5
{
    class Sorter
    {
        private int[] SortArray;

        public Sorter (int[] array)
        {
            SortArray = array;
        }



        public void Print()
        {
            for (int i = 0; i < SortArray.Length; i++)
            {
                Console.WriteLine(SortArray[i]);
            }
        }

        public static void Swap(ref int c, ref int d)
        {
            int temp = c;
            c = d;
            d = temp;

        }

        public void BubbleSort()
        {
            bool wasSwap = true;
            while (wasSwap == true)
            {
                wasSwap = false;
                for (int i = 0; i < SortArray.Length - 1; i++)
                {
                    int b = i + 1;
                    if (SortArray[i] > SortArray[b])
                    {
                        Swap(ref SortArray[i], ref SortArray[b]);
                        wasSwap = true;
                    }
                }
            }
        }

        public void InsertionSort()
        {
            for (int i = 0; i < SortArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    int b = j - 1;
                    if (SortArray[b] > SortArray[j])
                    {
                        Swap(ref SortArray[b], ref SortArray[j]);
                    }
                }
            }
        }
    }
}
