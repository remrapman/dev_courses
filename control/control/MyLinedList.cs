using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    public class MyLinkedList<T> : Node<T>
    {
        //private T Data;
        public static Node<T> head;


        public void Insertion(T Data)
        {
            Node<T> Temp = new Node<T>();
            Temp.value = Data;
            Temp.next = head;
            head = Temp;
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public T Deletion()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Buffer is empty!");
                return default(T);
            }
            else
            {
                Node<T> temp = head;
                head = head.next;
                return temp.value;
            }
        }

        public T ShowElement()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Buffer is empty!");
                return default(T);
            }
            else
            {
                return head.value;
            }
        }

    }
}
