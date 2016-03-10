using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
** Всё, что от вас требуется — найти сумму всех целых чисел, лежащих между 1 и N включительно. 

*** Исходные данные

** В единственной строке расположено число N, по модулю не превосходящее 10000.

*** Результат

** Выведите целое число — ответ задачи.
*/

namespace _05_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = Console.ReadLine();
            int N = int.Parse(Str),
                sum = 0;

            if (N > 0)
                for (int i = 1; i <= N; i++)
                    sum += i;
            else
                for (int i = 1; i >= N; i--)
                    sum += i;

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
