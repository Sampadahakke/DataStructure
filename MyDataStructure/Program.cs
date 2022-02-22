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
            MyQueue<int> queue = new MyQueue<int>();

            Console.WriteLine("create a Queue of 56->30->70");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("Queue: ");
            queue.Display();
            Console.ReadKey();
            
        }

    }
}
