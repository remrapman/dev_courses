using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int[] myarr = new int[size];
            int head = 0;
            int tail = 0;
            int count = 0;
            string Action = null;
            bool WantExit = false;

            while (WantExit == false)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Select Action Type");
                Console.WriteLine("1 - Enqueue");
                Console.WriteLine("2 - Dequeue");
                Console.WriteLine("3 - Exit");
                Action = Console.ReadLine();
                int Act = Int32.Parse(Action);

              
                switch (Act)
                {
                    case 1:
                        if (IsFull(count, size) == true)
                        {
                            Console.WriteLine("!!!Buffer is full, we can not Add new element!!!");
                        }
                        else
                        {
                            string A = null;
                            Console.WriteLine("Enter Your Number:");
                            A = Console.ReadLine();
                            int NewValue = Int32.Parse(A);
                            if (tail == size)
                            {
                                tail = 0;
                            }
                            Enqueue(myarr, tail, NewValue);
                            tail++;
                            count++;


                        }
                        break;

                    case 2:
                        if (IsEmpty(count) == true)
                        {
                            Console.WriteLine("!!!----------Buffer is empty----------!!!");
                        }
                        else
                        {
                            if (head == size)
                            {
                                head = 0;
                            }
                            Dequeue(myarr, head, size);
                            head++;
                            count--;

                        }
                        break;

                    case 3:
                        WantExit = true;
                        break;
                        
                }
                Print(myarr);
            }
            Console.ReadLine();
        }


        static void Enqueue(int[] arrayFORenqueue, int tail, int Value)
        {

            arrayFORenqueue[tail] = Value;

        }

        static void Dequeue(int[] arrayFORdequeue, int b, int size)
        {
            if (b == size)
            {
                b = 0;
            }
            Console.WriteLine("Your Number is: " + arrayFORdequeue[b]);
            arrayFORdequeue[b] = 0;
        }

        static bool IsEmpty(int count)
        {

            if (count == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsFull(int count, int size)
        {
            if (count == size) 
            {
                return true;
            }
            return false;
        }

        // Print
        static void Print(int[] arrayForPrint)
        {
            Console.WriteLine("=========Buffer=========");
            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                Console.WriteLine(arrayForPrint[i]);
            }
        }
    }
}
