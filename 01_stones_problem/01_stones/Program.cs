using System;

/*
** У вас есть несколько камней известного веса w1, …, wn. 
** Напишите программу, которая распределит камни в две кучи так, 
** что разность весов этих двух куч будет минимальной.

*** Исходные данные

** Ввод содержит количество камней n (1 ≤ n ≤ 20) 
** и веса камней w1, …, wn (1 ≤ wi ≤ 100 000) — целые, разделённые пробельными символами.

*** Результат

** Ваша программа должна вывести одно число — минимальную разность весов двух куч.
*/

namespace _01_stones
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine()), 
                sum = 0;
            string[] Str = Console.ReadLine().Split(' ');
            int[] stones = new int[Str.Length];
            for (int i = 0; i < amount; i++)
                {
                    stones[i] = int.Parse(Str[i]);
                    sum += stones[i];
                }

            int temp, left, ans = 10000000;
            for (int mask = 0, ind; mask < (1 << amount); mask++)
            {
                temp = mask;
                left = 0;
                ind = 0;
                while (temp > 0)
                {
                    left += stones[ind++] * (temp & 1);
                    temp >>= 1;
                }
                ans = Math.Min(ans, Math.Abs(sum - 2 * left));
            }

            Console.WriteLine(ans);

            Console.ReadKey();
        }
    }
}
