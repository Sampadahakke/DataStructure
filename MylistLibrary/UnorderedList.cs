using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class UnorderedList<T> where T : IComparable<T> 
    {
        //Variables
        public Node<T> Head;

        //Initializing Variable With the help of Constructor
        public UnorderedList()
        {
            Head = null;
        }

        //Creates and Returns empty list
        public UnorderedList<T> List()
        {
            UnorderedList<T> emptyList = new UnorderedList<T>();
            return emptyList;
        }

        //Method used to create list
        public void Append(T Data)
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
                Console.Write(temp.Data+" ");
                temp = temp.Next;
            }
        }

        //Method used to add data in list
        public void Add(T Data)
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
        public void Insert(int pos, T data)
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
        public void Pop()
        {
            if (Head == null)
                return;
            else
                Head = Head.Next;
        }

        //Method used to delete last elememt
        public void PopLast()
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
    }
}

































