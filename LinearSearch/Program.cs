using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinerSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.WriteLine("Number of elements");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("\n Enter the Array Elements\n");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("Enter key value\n");
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            for (int i = 0; i < x; i++)
            {
                if (a[i] == x2)
                {
                    Console.WriteLine("Element {0} found at location {1}\n", x2, i + 1);
                    //return;
                    Console.ReadLine();
                }
            }
            Console.WriteLine("NotFound");
            Console.ReadLine();
        }
    }
}