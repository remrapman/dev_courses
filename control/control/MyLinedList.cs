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

        public void Deletion()
        {

        }
    }
}
