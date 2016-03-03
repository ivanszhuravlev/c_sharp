using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Problems
{
    class Chapter_3
    {
        public static void Problem_13(int n)
        {
            string numbers = "";

            for (int i = 0; i < n; i++)
            {
                numbers += i + 1 + " ";
            }

            Console.WriteLine(numbers);
        }

        public static int Problem_14(int n)
        {
            int res = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    res = i;
            }
            return res;
        }

        public static int Problem_15(int n)
        {
            int res = 1;
            for (int i = n-1; i > 1; i--)
            {
                if (n % i == 0)
                    res = i;
            }
            return res;
        }

        public static int Problem_16(int n)
        {
            int res = 0;
            for (int i = 1; i <= n; i++)
            { 
                if (n % i == 0)
                    res++;
            }
            return res;
        }

        public static bool Problem_17(int n)
        {
            bool is_prime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    is_prime = false;
            }
            return is_prime;
        }

        public static void Problem_18(int n)
        {
            string res = "";
            bool is_prime;

            for (int i = 1; i <= n; i++)
            {
                is_prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        is_prime = false;
                }
                if (is_prime)
                    res += i + " ";

            }

            Console.WriteLine(res);
        }

        public static void Problem_19(int n)
        {
            int cur_num = 1;
            string res = "";
            bool is_prime;

            while (n > 0)
            {
                is_prime = true;

                for (int i = 2; i < cur_num; i++)
                {
                    if (cur_num % i == 0)
                        is_prime = false;
                }

                if (is_prime)
                {
                    res += cur_num + " ";
                    n--;
                }
                cur_num++;

            }
            Console.WriteLine(res);
        }

        public static bool Problem_20(int n)
        {
            int res = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    res += i;
            }

            return (res == n);
        }

        public static bool Problem_21(int a, int b)
        {
            int sum_a = 0, sum_b = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                    sum_a += i;
            }

            for (int i = 1; i < b; i++)
            {
                if (b % i == 0)
                    sum_b += i;
            }

            return (sum_a == b && sum_b == a);
        }

        public static int Problem_22(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return a;
        }

        public static int Problem_23(int a, int b)
        {
            int product = a * b;

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return product / a;
        }

        public static int Problem_24(int x, int n)
        {
            int res = 1;

            for (int i = 1; i <= n; i++)
                res *= x;

            return res;
        }

        public static int Problem_25(int x, int n)
        {
            int k = 1;

            while (n != 1)
            {
                if (n % 2 != 0)
                    k *= x;
                x *= x;
                n /= 2;
            }

            return x * k;
        }

        public static void Problem_26(int n)
        {
            Double x1, x2;
            for (int a = 1; a < n; a++)
            {
                x1 = -1 + Math.Sqrt(a * a + 3);
                x2 = -1 - Math.Sqrt(a * a + 3);
                Console.WriteLine("a = " + a + "; x1 = " + x1 + "; x2 = " + x2);
            }
        }

        public static double Problem_27(int n, double x)
        {
            double res = 0;
            double a;

            for (int i = 1; i < n + 1; i++)
            {
                a = int.Parse(Console.ReadLine());
                res = res * x + a;
            }
            return res;
        }

        public static long Problem_28(int n)
        {
            long res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        public static int Problem_29(int n, int k)
        {
            int num = 1, denom = 1;

            for (int i = n; i >= n - k + 1; i--)
                num *= i;

            for (int i = 1; i <= k; i++)
                denom *= i;
            return num / denom;
        }

        public static void Problem_30(int n)
        {
            
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|      x     |     x^2    |     x^3    |");
            Console.WriteLine("|--------------------------------------|");

            for (int i = 1; i <= n; i++)
            {
                Console.Write("|" + String.Format("{0,7}", i));
                Console.Write(String.Format("{0,6}", "|"));

                Console.Write(String.Format("{0,7}", i * i));
                Console.Write(String.Format("{0,6}", "|"));

                Console.Write(String.Format("{0,7}", i * i * i));
                Console.Write(String.Format("{0,6}", "|"));

                Console.WriteLine();
            }
            Console.WriteLine("|--------------------------------------|");

        }

        public static int Problem_31(int n)
        {
            int res = 0;
            while (n != 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            return res;
        }

        public static bool Problem_32(int n)
        {
            int a, b, delta;

            b = n % 8;
            n /= 8;
            a = n % 8;
            n /= 8;
            delta = a - b;

            while (n != 0)
            {
                b = a;
                a = n % 8;
                n /= 8;
                if (delta * (a - b) <= 0)
                    break;
            }

            return (delta * (a - b) > 0);
        }

        public static string Problem_33(int n)
        {
            int pos = 2;
            string res = "";
            res += n + " = 1";

            while (n != 1)
            {
                if (n % pos == 0)
                {
                    res += " * " + pos;
                    n /= pos;
                }
                else
                    pos++;
            }

            return res;
        }

        public static int Problem_34(int a, int b)
        {
            int res = 0, rank = 1;

            while (a != 0)
            {
                res += rank * (b % 10);
                rank *= 10;
                b /= 10;
                res += rank * (a % 10);
                rank *= 10;
                a /= 10;
            }

            return res;
        }

        public static long Problem_35(int x, int n)
        {
            long res = 0;
            int rank = 1;

            while (x != 0)
            {
                res += rank * (x % n);
                x /= n;
                rank *= 10;
            }

            return res;
        }

        public static string Problem_36(int m, int n)
        {
            int min, mindiv = 1;

            if (m < n)
                min = m;
            else
                min = n;

            for (int i = 2; i <= min; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    mindiv = i;
                    break;
                }
            }

            if (mindiv != 1)
                return "" + mindiv;
            else
                return "No divisors";

        }

        public static bool Problem_37(int n)
        {
            int n_copy = n;
            int n_length = 0, left = 0, right = 0;

            while (n_copy != 0)
            {
                n_copy /= 10;
                n_length++;
            }

            for (int i = 0; i < n_length / 2; i++)
            {
                right +=  n % 10;
                n /= 10;
            }

            if (n_length % 2 != 0)
                n /= 10;

            for (int i = 0; i < n_length / 2; i++)
            {
                left += n % 10;
                n /= 10;
            }

            return left == right;
        }

        public static bool Problem_38(int n)
        {
            int n_copy = n;
            int n_length = 0, right = 0;

            while (n_copy != 0)
            {
                n_copy /= 10;
                n_length++;
            }

            for (int i = 0; i < n_length / 2; i++)
            {
                right *= 10;
                right += n % 10;
                n /= 10;
            }

            if (n_length % 2 != 0)
                n /= 10;

            return n == right;
        }

        public static bool Problem_39(int n)
        {
            while (n > 1)
            {
                if (n % 2 == 1)
                    break;
                n /= 2;
            }

            return n == 1;
        }

        public static void Problem_40()
        {
            int res = 1, x;
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0 && x != 0)
                    res *= x;
            } while (x != 0);

            if (res != 1)
                Console.WriteLine(res);
            else
                Console.WriteLine(0);
        }

        public static void Problem_41(int n)
        {
            int res = 1, x;
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x > 9 && x < 100 && x % n == 0)
                    res *= x;
            } while (x != 0);

            if (res != 1)
                Console.WriteLine(res);
            else
                Console.WriteLine(0);
        }

        public static void Problem_42()
        {
            int res = 0, x;
            bool is_prime;

            do
            {
                x = int.Parse(Console.ReadLine());

                is_prime = true;

                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                        is_prime = false;
                }

                if (is_prime && x != 0)
                    res++;
            } while (x != 0);

            Console.WriteLine(res);
        }

        public static bool Problem_43()
        {
            int a, b = 0, first = 1, last = 0;

            a = int.Parse(Console.ReadLine());

            if (a != 0)
                b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                last = a % 10;
                first = b;
                while (first > 9)
                    first /= 10;
                if (last != first)
                    break;
                a = b;
                b = int.Parse(Console.ReadLine());
            }

            return (last == first);
        }

        public static bool Problem_44()
        {
            int r, l, m;

            l = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());

            while (r != 0)
            {
                if ((m - l) * (m - r) <= 0)
                    break;
                l = m;
                m = r;
                r = int.Parse(Console.ReadLine());
            }

            if (r == 0)
                r = l;
           return (m - l) * (m - r) > 0;

        }

        public static bool Problem_45()
        {
            int a, b, delta;

            a = int.Parse(Console.ReadLine());
            if (a != 0)
                b = int.Parse(Console.ReadLine());
            else
                b = 0;
            delta = a - b;
            while (b != 0)
            {
                if (delta * (a - b) <= 0)
                    break;
                a = b;
                b = int.Parse(Console.ReadLine());
            }
            if (a == 0)
                b = 1;
            return b == 0;

        }

        public static void Problem_46(int n)
        {
            int f_0 = 0, f_1 = 1, f;

            for (int i = 2; i <= n; i++)
            {
                f = f_0 + f_1;
                f_0 = f_1;
                f_1 = f;
            }
            if (n == 0)
                f_1 = 0;
            Console.WriteLine(f_1);
        }

        public static void Problem_47(int n)
        {
            int f_0 = 0, f_1 = 1, f, sum = 1;

            for (int i = 2; i <= n; i++)
            {
                f = f_0 + f_1;
                sum += f;
                f_0 = f_1;
                f_1 = f;
            }
            if (n == 0)
                sum = 0;
            Console.WriteLine(sum);
        }

        public static void Problem_48(int n)
        {
            int f_0 = 0, f_1 = 1, f;
            Console.Write(f_0 + " ");

            if (n != 0)
                Console.Write(f_1 + " ");

            for (int i = 2; i <= n; i++)
            {
                f = f_0 + f_1;
                f_0 = f_1;
                f_1 = f;
                Console.Write(f_1 + " ");
            }
            
        }

        public static bool Problem_49()
        {
            int count, n;
            string line;

            line = Console.ReadLine();
            count = 0;
            n = line.Length;

            for (int i = 0; i < n; i++)
            {
                if (line[i] == char.Parse("("))
                    count++;
                if (line[i] == char.Parse(")"))
                    count--;
                if (count == -1)
                    break;
            }

            return count == 0;
        }

        public static double Problem_50(double x, double eps)
        {
            double exp = 1, p = 1;
            int n = 1;

            while (Math.Abs(p) >= eps)
            {
                p = p * x / n;
                exp += p;
                n++;
            }

            return exp;
        }
    }
}
