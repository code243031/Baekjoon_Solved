#pragma warning disable 8600
#pragma warning disable 8602
#pragma warning disable 8604

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] buf = Console.ReadLine().Split(" ");
            decimal A = decimal.Parse(buf[0]),
                    B = decimal.Parse(buf[1]),
                    C = decimal.Parse(Console.ReadLine());

            if (A + B < (C * 2))
            {
                Console.WriteLine(A + B);
            }
            else
            {
                Console.WriteLine((C * 2) - (A + B));
            }
        }
    }
}
