using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
** Вам надо написать программу, которая определяет по заданному разбиению избирателей на группы 
** минимальное количество сторонников партии, достаточное, при некотором распределении их по группам, 
** для принятия любого решения. 

*** Исходные данные

** В первой строке записано нечётное число K — количество групп избирателей (1 ≤ K ≤ 101). 
** Во второй строке через пробел записаны K нечётных чисел, которые задают количество избирателей в группах. 
** Население острова не превосходит 9999 человек.

*** Результат

** Выведите минимальное количество сторонников партии, способное решить исход голосования.
*/

namespace _02_democracy
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            string[] Str = Console.ReadLine().Split(' ');
            int[] groups = new int[Str.Length];
            for (int i = 0; i < K; i++)
            {
                groups[i] = int.Parse(Str[i]);
            }

            Array.Sort(groups);

            int res = 0;

            for (int i = 0; i < K / 2 + 1; i++)
            {
                res += groups[i] / 2 + 1;
            }

            Console.WriteLine(res);
        }
    }
}
