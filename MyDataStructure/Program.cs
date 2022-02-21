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

            UnorderedList<int> list = new UnorderedList<int>();
            //Console.WriteLine("Creating A New List - 56,30,70");
            //list.Append(56);
            //list.Append(30);
            //list.Append(70);
            //list.Display();
            //Console.ReadKey();

            Console.WriteLine("Adding 56,30,70 to list");
            list.Add(76);
            list.Add(30);
            list.Add(56);
            list.Display();
            Console.ReadKey();
        }
    }
}
