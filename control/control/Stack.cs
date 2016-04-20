using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    class Stack<T>
    {

        MyLinkedList<T> StackData = new MyLinkedList<T>();
        
        public void Push(T Data)
        {
            StackData.Insertion(Data);
        }

        public T Pop()
        {
            return StackData.Deletion();
        }

        public T Peek()
        {
            return StackData.ShowElement();
        }
    }
}
