using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class OrderedList<T> : MyLinkedList<T> where T : IComparable
    {
        public static OrderedList<T> List()
        {
            OrderedList<T> emptyList = new OrderedList<T>();
            return emptyList;
        }

        public new void Add(T data)
        {
            int index = 0;
            Node<T> temp = Head;
            while (temp != null)
            {
                if (temp.Data.CompareTo(data) > 0)
                    break;
                temp = temp.Next;
                index++;
            }
            Insert(index, data);
        }


    }

}
