using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string size = null;
            

            Console.WriteLine("Enter Array size");
            size = Console.ReadLine();
            a = Int32.Parse(size);

            int[] myarr = new int[a];


            EnterElements(myarr);

            int MAX = MaxElement(myarr);
            int MIN = MinElement(myarr);


            Console.WriteLine("MAX element is : " + MAX);
            Console.WriteLine("MIN element is : " + MIN);
            Console.ReadLine();
        }

        //MAX element definition
        static int MaxElement(int[] formax)
        {
           
            int max = formax[0];
            for (int i = 0; i < formax.Length; i++)
            {
                if (max < formax[i])
                {
                    max = formax[i];
                }
            }
            return max;
        }
        //MIN element definition
            static int MinElement(int[] formin)
        {
            int min = formin[0];
            for (int i = 0; i < formin.Length; i++) 
            {
                if (min > formin[i])
                {
                    min = formin[i];
                }
            }
            return min;
        }

         // Enter Array elements
         static void EnterElements(int[] forelements)   
         {
             int c = 0;
             string A = null;
             for (int i = 0; i < forelements.Length; i++)
             {
                 Console.WriteLine("Enter element " + ++c);
                 A = Console.ReadLine();
                 forelements[i] = Int32.Parse(A);
             }
                 

         }
            

    }
}
