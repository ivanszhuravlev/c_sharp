using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*** Задание
** Составить программу, которая будет считывать введённое пятизначное число. 
** После чего, каждую цифру этого числа необходимо вывести в новой строке.
*/

namespace begginers_and_middle_problems
{
    class cppstudio
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int x = int.Parse(str),
                i = 1;
            double length = Math.Pow(10, (double)str.Length - 1);

            while (x != 0)
            {
                Console.WriteLine(i + " цифра равна " + x / (int) length);
                x %= (int) length;
                i++;
                length /= 10;
            }

            Console.ReadKey();
        }
    }
}
