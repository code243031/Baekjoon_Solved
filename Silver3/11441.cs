using System;
using System.Collections.Generic;
using System.Text;

using static System.Math;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new(),
                      add = new();

            int N = int.Parse(Console.ReadLine());

            string[] buf = Console.ReadLine().Split(" ");
            int res = 0;
            for (int i = 0; i < N; i++)
            {
                arr.Add(int.Parse(buf[i]));
                res += int.Parse(buf[i]);
                add.Add(res);
            }

            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                buf = Console.ReadLine().Split(" ");
                res = add[int.Parse(buf[1]) - 1]; // - add[int.Parse(buf[0]) - 1];

                if (int.Parse(buf[0]) != 1)
                {
                    res -= add[int.Parse(buf[0]) - 2];
                }

                Console.WriteLine(res);
            }
        }
    }
}