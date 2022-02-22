using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class QueueList<T> : MyLinkedList<T> where T : IComparable
    {
        public static QueueList<T> Queue()
        {
            return new  QueueList<T>();
        }

        //Method used to create list
        public void Enqueue(T Data)
        {
            Append(Data);
        }

        public T Peek()
        {
            return Head.Data;
        }

        public new void Dequeue()
        {
            base.Pop();
        }


    }
}
