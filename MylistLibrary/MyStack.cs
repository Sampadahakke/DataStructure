using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class MyStack<T> : MyLinkedList<T> where T : IComparable
    {
        public static MyStack<T> Queue()
        {
            return new  MyStack<T>();
        }

        //Method used to create list
        public void Push(T Data)
        {
            Add(Data);
        }

        public T Peek()
        {
            return Head.Data;
        }

        public new void Pop()
        {
            base.Pop();
        }


    }
}
