using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class UnorderedList<T> : MyLinkedList<T> where T : IComparable
    {
        //Variables
        public Node<T> Head;

       
       //Creates and Returns empty list
        public static UnorderedList<T> List()
        {
            UnorderedList<T> emptyList = new UnorderedList<T>();
            return emptyList;
        }

        //Method used to create list
        public new void Append(T Data)
        {
            base.Append(Data);
        }

        //Method used to add data in list
        public new void Add(T Data)
        {
            base.Add(Data); 
        }

        //Method used to insert 30 between 56 and 76
        public new void Insert(int pos, T data)
        {
           base.Insert(pos, data);  
        }

        //Method used to delete first element
        public new void Pop()
        {
            base.Pop();
        }

        //Method used to delete last elememt
        public new void PopLast()
        {
            base.PopLast();

        }

    }
}

































