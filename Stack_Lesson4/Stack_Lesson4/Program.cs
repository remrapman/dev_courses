using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] myarr = new int[size];
            int top = 0;
            string Action = null;
            bool WantExit = false;

            while (WantExit == false)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Select Action Type");
                Console.WriteLine("1 - Push");
                Console.WriteLine("2 - Pop");
                Console.WriteLine("3 - Peak");
                Console.WriteLine("4 - Exit");
                Action = Console.ReadLine();
                int Act = Int32.Parse(Action);


                switch (Act)
                {
                    case 1:
                        if (IsFull(top, size) == true)
                        {
                            Console.WriteLine("!!!Array is full, we can not Push new element!!!");
                        }
                        else
                        {
                            string A = null;
                            Console.WriteLine("Enter Your Number:");
                            A = Console.ReadLine();
                            int NewValue = Int32.Parse(A);
                            Push(myarr, top, NewValue);
                            top++;
                        }
                        break;

                    case 2:
                        if (IsEmpty(top) == true)
                        {
                            Console.WriteLine("!!!----------Array is empty----------!!!");
                        }
                        else
                        {
                            Pop(myarr, top);
                            top--;
                        }
                        break;

                    case 3:
                        Peek(myarr, top);
                        break;
                    case 4:
                        WantExit = true;
                        break;

                }
            }
            Console.ReadLine();
        }


        static void Push(int[] arrayFORpush, int top, int Value)
        {

            arrayFORpush[top] = Value;

        }

        static void Pop(int[] arrayFORpop, int b)
        {
                Console.WriteLine("Your Number is:" + arrayFORpop[b - 1]);
                arrayFORpop[b - 1] = 0;
        }

        static bool IsEmpty(int top)
        {
            if (top == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsFull(int top, int size)
        {
            if (top == size)
            {
                return true;
            }
            return false;
        }

        static void Peek(int[] arrayFORpop, int b)
        {
            Console.WriteLine("Your Number is:" + arrayFORpop[b - 1]);
        }
    }
}
