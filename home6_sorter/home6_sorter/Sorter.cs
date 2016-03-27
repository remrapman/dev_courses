using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home6_sorter
{
    class Sorter
    {
    private int[] SorterArray;

        public Sorter (int[] array)
    {
        SorterArray = array;
    }

        public void Print()
        {
            for (int i = 0; i < SorterArray.Length; i++)
            {
                Console.WriteLine(SorterArray[i]);
            }
        }

        public static int Swap(ref int c; ref int d)
    {
        int tmp = c;
        c = d;
        d = tmp;
    }
        public virtual void Sort(){}
    }
}
