using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class MyLinkedList<T> where T : IComparable
    {
        //Variables
        public Node<T> Head;

        //Initializing Variable With the help of Constructor
        public MyLinkedList()
        {
            Head = null;
        }

        //Method used to create list
        protected void Append(T Data)
        {
            Node<T> node = new Node<T>(Data);
            if (Head == null)
                Head = node;
            else
            {
                Node<T> temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = node;
            }
        }

        //Method used to display the list
        public void Display()
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }

        //Method used to add data in list
        protected void Add(T Data)
        {
            Node<T> node = new Node<T>(Data);
            if (Head == null)
                Head = node;
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        //Method used to insert 30 between 56 and 76
        protected void Insert(int pos, T data)
        {
            Node<T> temp = Head;
            if (pos < 0)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            if (pos == 0)
                Add(data);
            else
            {
                Node<T> node = new Node<T>(data);
                for (int i = 1; i < pos; i++)
                    temp = temp.Next;
                node.Next = temp.Next;
                temp.Next = node;
            }
        }

        //Method used to delete first element
        protected void Pop()
        {
            if (Head == null)
                return;
            else
                Head = Head.Next;
        }

        //Method used to delete last elememt
        protected void PopLast()
        {
            if (Head == null)
                return;
            if (Head.Next == null)
                Head = null;
            else
            {
                Node<T> temp = Head;
                while (temp.Next.Next != null)
                    temp = temp.Next;
                temp.Next = null;
            }

        }

        //Method used to search element
        public bool Search(T Data)
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                if (temp.Data.CompareTo(Data) == 0)
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        public int Index(T Data)
        {
            int index = 0;
            Node<T> temp = Head;
            while (temp != null)
            {
                if (temp.Data.CompareTo(Data) == 0)
                    return index;
                temp = temp.Next;
                index++;
            }
            return -1;
        }

        //Method used to remove element of list
        public void Remove(T Data)
        {
            if (Head == null)
                return;
            if (Head.Data.CompareTo(Data) == 0)
                Head = Head.Next;
            else
            {
                Node<T> temp = Head;
                while (temp != null)
                {
                    if (temp.Next.Data.CompareTo(Data) == 0)
                    {
                        temp.Next = temp.Next.Next;
                        return;
                    }
                    temp = temp.Next;
                }
            }
        }

        //Method used to  getting size of list
        public int Size()
        {
            int Size = 0;
            Node<T> temp = Head;
            while (temp != null)
            {
                temp = temp.Next;
                Size++;
            }
            return Size;
        }

        public bool IsEmpty()
        {
            if (Head == null)
                return true;
            return false;
        }
    }
}
