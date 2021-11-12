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
            ulong T = ulong.Parse(Console.ReadLine());
            ulong res = 0;
            ulong add = 0;

            ulong i = 1;
            while (true)
            {
                if (add >= T)
                {
                    res--;
                    break;
                }
                add += i;
                res++;
                i++;
            }

            Console.WriteLine($"{res}");
        }
    }
}