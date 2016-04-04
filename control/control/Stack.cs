using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    class Stack<T>
    {
        private T StackElement;
        public MyLinkedList<T> StackData;
        
        //public Stack(T data)
        //{
        //    StackData.value = data;
        //}

        public void Push(T Data)
        {
            StackData.Insertion(Data);
        }

        public T Pop()
        {
            return default(T);
        }

        public bool IsEmpty(int top)
        {
            if (top == 0)
            {
                return true;
            }
            return false;
        }

        public T Peek()
        {
            return
            StackData.value;
        }
    }
}
