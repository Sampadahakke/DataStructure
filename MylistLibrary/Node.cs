using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MylistLibrary
{
    public class Node<T>
    {
        //Initializing Variables
        public T Data;
        public Node<T> Next;

        //Constructor of class
        public Node(T Data)
        {
            this.Data = Data;
        }

    }
}
