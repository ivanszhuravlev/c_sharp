using System;
using System.Collections.Generic;

namespace Pascal_Problems
{
    class Chapter_1
    {
        public static void Problem_1()
        {
            Console.WriteLine("Hello world");
        }

        public static void Problem_2(string[] line)
        {
            Console.WriteLine(line[2] + " " + line[1]+ " " + line[0]);
        }

        public static void Problem_3(int x)
        {
            Console.WriteLine(x * x);
        }

        public static void Problem_4(long x)
        {
            int result = (int) (x / 100 + (x % 100) / 10 * 10 + x % 10 * 100);
            Console.WriteLine(result);
        }

        public static int Problem_5(int x)
        {
            /*var stack = new Stack<int>();
            while (x > 0)
            {
                stack.Push(x % 2);
                x /= 2;
            }

            x = 0;

            foreach (int i in stack)
                x += i;*/

            int res = 0;

            res += x % 2;
            x /= 2;

            res += x % 2;
            x /= 2;

            res += x % 2;
            x /= 2;

            res += x;

            return res;
        }

        static void Main(string[] args)
        {
            double a = Chapter_3.Problem_50(40, 0.5);
            Console.WriteLine(a);
            //Chapter_3.Problem_49();
            Console.ReadKey();
        }
    }
}

