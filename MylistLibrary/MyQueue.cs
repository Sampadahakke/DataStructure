using System;

namespace MylistLibrary
{
    public class MyQueue<T> : MyLinkedList<T> where T : IComparable
    {
        public static MyQueue<T> Queue()
        {
            return new MyQueue<T>();
        }

        //Method used to create list
        public void Enqueue(T Data)
        {
            Append(Data);
        }

        public new void Dequeue()
        {
            base.Pop();
        }
    }
}
