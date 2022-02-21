﻿using System;
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
            Console.WriteLine("\nCreating A New List - 56,30,70");
            list.Append(56);
            list.Append(30);
            list.Append(70);
            Console.WriteLine("Inserting 40 after 30");
            list.Insert(list.Index(30) + 1, 40);
            list.Display();
            Console.WriteLine("Removing 40 after 30");
            Console.WriteLine("\nSearch result for 40:" + " " + list.Search(40));
            list.Remove(40);
            Console.WriteLine("Size:" + " " + list.Size());
            Console.ReadKey()


            /*Console.WriteLine("Inserting 40 after 30");
            list.Insert(list.Index(30) + 1, 40);
            list.Display();
            *//*  Console.WriteLine("\nSearch result for 30:"+" " + list.Search(30));
              Console.WriteLine("\nSearch result for 90:"+" " + list.Search(90));*//*
            Console.ReadKey()*/;

            


            //Console.WriteLine("\nDeleting last element");
            //list.PopLast();
            //list.Display();
            //Console.ReadKey();

            //Console.WriteLine("Adding 56,30,70 to list");
            //list.Add(76);
            //list.Add(30);
            //list.Add(56);
            //list.Display();
            //Console.ReadKey();

            //Console.WriteLine("Inserting 30 between 56 and 70");
            //list.Append(56);
            //list.Append(70);
            //list.Insert(1, 30);
            //list.Display();
            //Console.ReadKey();


        }
    }
}
