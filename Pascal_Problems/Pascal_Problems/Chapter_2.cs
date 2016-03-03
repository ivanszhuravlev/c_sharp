using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Problems
{
    class Chapter_2
    {
        public static void Problem_6(int a, int b)
        {
            int res;

            if (a > b)
                res = a;
            else
                res = b;

            Console.WriteLine(res);
        }

        public static void Problem_7(int a, int b, int c)
        {
            int res;

            if (a > b)
            {
                if (a > c)
                    res = a;
                else
                    res = c;
            }
            else
            {
                if (b > c)
                    res = b;
                else
                    res = c;
            }

            Console.WriteLine(res);
        }
        
        public static void Problem_8(int n)
        {
            string res;

            switch (n)
            {
                case 1:
                    res = "Monday";
                    break;
                case 2: 
                    res = "Tuesday";
                    break;
                case 3: 
                    res = "Wednesday";
                    break;
                case 4: 
                    res = "Thursday";
                    break;
                case 5: 
                    res = "Friday";
                    break;
                case 6: 
                    res = "Saturday";
                    break;
                case 7: 
                    res = "Sunday";
                    break;
                default:
                    res = "There are only 7 days at week";
                    break;
            }

            Console.WriteLine(res);
        }

        public static string Problem_9(int x)
        {
            int half = x % 100;
            half = half % 10 * 10 + half / 10;

            if (half == x / 100)
                return x + " is a palendrome";
            else
                return x + " isn't a palendrome";
        }

        public static string Problem_10(int x)
        {
            int sum_left = x / 100 % 10 + x / 1000;
            int sum_right = x % 100 / 10 + x % 10;

            if (sum_left == sum_right)
                return x + " is lucky";
            else
                return x + " isn't lucky";
        }

        public static string Problem_11(byte x)
        {
            int a, b, c, d, origx = x;

            a = x % 2;
            x /= 2;

            b = x % 2;
            x /= 2;

            c = x % 2;
            x /= 2;

            d = x % 2;
            x /= 2;

            a = a * 8 + b * 4 + c * 2 + d;

            /*if (a == x)
                return "Binary representation of " + origx + " is a palendrome";
            else
                return "Binary representation of " + origx + " isn't a palendrome";*/
            return "Number " + x;
        }

        public static string Problem_12(int a, int b, int c)
        {
            Double D = b * b - 4 * a * c;
            Double x1, x2;

            if (D >= 0)
            {
                if (D != 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / 2 / a;
                    x2 = (-b - Math.Sqrt(D)) / 2 / a;
                    return "Roots: x1 = " + x1 + "; x2 = " + x2;
                }
                else
                {
                    x1 = -b / 2 / a;
                    return "Root: x = " + x1;
                }

            }
            else
                return "No roots";
            
        }
    }
}
