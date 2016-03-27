using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int[] myarray = new int[a];
            string A = null;

            Random rand = new Random();


            for (int i = 0; i < a; i++)
            {
                myarray[i] = rand.Next(20);
            }

            Sorter Array = new Sorter(myarray);

            Console.WriteLine("Select Sort Method");
            Console.WriteLine("1 - Bubble Sort");
            Console.WriteLine("2 - Insertion Sort");
            Console.WriteLine("3 - Exit");
            A = Console.ReadLine();
            int SortMethod = Int32.Parse(A);

            switch (SortMethod)
            {

                case 1:
                    Console.WriteLine("Bubble Sort Selected");
                    Console.WriteLine("++++++++++++Before+++++++++++++");
                    Array.Print();
                    Array.BubbleSort();
                    Console.WriteLine("============After==============");
                    Array.Print();
                    break;

                case 2:
                    Console.WriteLine("Insertion Sort Selected");
                    Console.WriteLine("++++++++++++Before+++++++++++++");
                    Array.Print();
                    Array.InsertionSort();
                    Console.WriteLine("============After==============");
                    Array.Print();
                    break;

                case 3:
                    Console.WriteLine("You select EXIT. Good bye");
                    break;
            }
            Console.ReadLine();
        }
    }
}
