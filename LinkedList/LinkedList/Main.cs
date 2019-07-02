using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List l = new List(1);
            l.Add(0, 0);
            l.Add(2, 2);
            l.PrintAll();

            l.Remove(2);
            l.PrintAll();

            Console.Write(l.Search(2));
            Console.WriteLine(l.Search(1).Data);

            l.RemoveAll();
            l.PrintAll();
        }
    }
}