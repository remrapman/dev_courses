using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    class Program
    {
       // static MyLinkedList<int> NewData = new MyLinkedList<int>();
        static Stack<int> NewData = new Stack<int>();
        Stack<int> StackPeek = new Stack<int>();
        static void Main(string[] args)
        {

            int Action = 0;
            while (Action != 4)
            {
                Console.WriteLine("Select Action:");
                Console.WriteLine("1 - Push");
                Console.WriteLine("2 - Pop");
                Console.WriteLine("3 - Peak");
                Console.WriteLine("4 - Exit");
                Action = Int32.Parse(Console.ReadLine());

                switch (Action)
                {
                    case 1:
                        Console.WriteLine("You select - Push");
                        EnterElement();
                        break;

                    case 2:
                        Console.WriteLine("You select - Pop");
                        break;

                    case 3:
                        Console.WriteLine("You select - Peek");
                        NewData.Peek();
                        
                        //Stack<int>.Peek();
                        break;

                    case 4:
                        Console.WriteLine("You select - Exit");
                        break;
                }
            }
            Console.ReadLine();
        }

        static Stack<int> EnterElement()
        {
            Console.WriteLine("Enter element");
            NewData.Push(Int32.Parse(Console.ReadLine()));
            return NewData;
        }

    }
}
