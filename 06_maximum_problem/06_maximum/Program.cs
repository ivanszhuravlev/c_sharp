using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),
                max;
            int[] a;

            while (n != 0)
            {
                max = 0;
                a = new int[2 * n + 2];
                a[0] = 0;
                a[1] = 1;

                for (int i = 1; i <= n; i++)
                {
                    a[2 * i] = a[i];
                    a[2 * i + 1] = a[i] + a[i + 1];
                    if (a[i] > max)
                        max = a[i];
                }

                Console.WriteLine(max);

                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
