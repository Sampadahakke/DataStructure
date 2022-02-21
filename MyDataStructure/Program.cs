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
            OrderedList<int> list = new OrderedList<int>();
            Console.WriteLine("Adding 56,30,70 in list");
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.ReadKey();
        }
    }
}
