using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class UnorderedList<T> where T : IComparable<T>
    {
        public Node<T> Head;

        public UnorderedList()
        {
            Head = null;
        }

        public UnorderedList<T> List()
        {
            UnorderedList<T> emptyList = new UnorderedList<T>();
            return emptyList;
        }

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

        public void Display()
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                Console.Write("\n" + temp.Data);
                temp = temp.Next;
            }
        }
    }
}
