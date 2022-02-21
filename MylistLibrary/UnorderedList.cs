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
            Node <T> node = new Node<T>(Data);
            if (Head == null)
            Head = node;
            else
            {
                Node<T> temp = Head;
                while(temp.Next != null)
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
                Console.Write("\n" + temp.Data);
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

    }
}
