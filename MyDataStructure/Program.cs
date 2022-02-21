using System;
using MylistLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============WELCOME TO DATA STRUCTURE===============");
            MyStack<int>stack = new MyStack<int>();
            Console.WriteLine( "Creating Stack");
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
            Console.ReadKey();
        }
    }
}
