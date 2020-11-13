using System;

namespace intboolif
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Int3()
        {
            int b = 4096;
            int kb = b / 1024;
            Console.WriteLine(kb);
        }

        static void Int6()
        {
            int number = 87;
            Console.WriteLine(number / 10);
            Console.WriteLine(number & 10);
        }

        static void Int9()
        {
            int number = 234;
            Console.WriteLine(number % 100);
        }

        static void Int12()
        {
            int number = 482;
            Console.WriteLine((number % 100) % 10 * 100 + ((number % 100) / 10) * 10 + (number / 100));
        }

        static void Int15()
        {
            int number = 986;
            int x = (number % 100) % 10;
            int y = ((number % 100) / 10);
            int z = number / 100;
            Console.WriteLine((y * 10) + (z / 10) + x);
        }

        static void Int18()
        {
            int n = 9876;
            int x = n / 1000;
            Console.WriteLine(x);
        }

        static void Int21()
        {
            int n = 10001;
            Console.WriteLine(n % 60);
        }

        static void Int24()
        {
            int k = 12;
            int x = k % 7;
            Console.WriteLine(x);
        }

        static void Int27()
        {
            int k = 14;
            int Fday = 7;
            Console.WriteLine((k - Fday) % 7);
        }

        static void Int30()
        {
            int year = 1354;

        }

        static bool Bool3()
        {
            int number = 12;
            return number % 2 == 2;
        }

        static bool Boolean6()
        {
            int a = 34;
            int b = 982;
            int c = 21;
            return a < b && a < c;
        }

        static bool Boolean9()
        {
            int a = 84;
            int b = 56;
            return a % 2 == 1 || b % 2 == 1;
        }

        static bool Boolean12()
        {
            int a = 347;
            int b = 214;
            int c = 939;
            return a > 0 && b > 0 && c > 0;
        }

        static bool Bool15()
        {
            int a = 245;
            int b = 2;
            int c = 75;
            return a > 0 || b > 0 | c > 0;
        }

        static bool Bool18()
        {
            int a = 234;
            int b = 3;
            int c = 94;
            return a == b || b == c || a == c;
        }

        static bool Bool21()
        {
            int number = 299;
            int a = number % 10;
            int b = number / 10 % 10;
            int c = number % 10;
            return a < b && b < c;
        }

        static bool Bool24()
        {
            int a = 4;
            int b = -6;
            int c = 13;
            int d = b * b - 4 * a * c;
            return d >= 0;
        }

        static bool Bool27()
        {
            int x = -38;
            int y = -237;
            return x < 0 && y > 0 || x < 0 && y < 0;
        }

        static bool Bool30()
        {
            int a = 5;
            int b = 10;
            int c = 32;
            return (a + b) == (b + c) && (a + c) == (a + b);
        }

        static void If1()
        {
            int n = 24;
            if (n > 0)
                n += 1;
            else
                n -= 1;
        }

        static void If3()
        {
            int n = -5;
            if (n > 0)
                n += 1;
            else if (n < 0)
                n -= 2;
            else if (n = 0) ;
            n = 10;
            Console.WriteLine(n);
        }

        static void If6()
        {
            int a = 2324;
            int b = -132;
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }

        static void If9()
        {
            int a = 5;
            int b = 89;
            if (a < b)
                Console.WriteLine(b);
            else if (a > b)
                a = -a;
            Console.WriteLine(a);
        }

        static void If12()
        {
            int a = 3;
            int b = -8;
            int c = 234;
            if ((a < b) && (a < c))
            Console.WriteLine(a);

            if ((b < a) && (b < c))
            Console.WriteLine(b);

            if ((c < a) && (c < b))
            Console.WriteLine(c);
        }

        static void If15()
        {
            int a = 2323;
            int b = 87654;
            int c = 93;
            if (a < b && b < c)
            {
                int d = b + c;
                Console.WriteLine(d);
            }
        }

        static void If18()
        {
            int a = 3;
            int b = 432;
            int c = 423;

            if (a > c && b > c && a == b) Console.WriteLine("c - 3");
            if (a > b && c > b && a == c) Console.WriteLine("b - 2");
            if (b > a && c > a && b == c) Console.WriteLine("a - 1");
        }

        static void If21()
        {
            int x = 2;
            int y = 5;

            if (x == 0 && y == 0) Console.WriteLine(0);
            if (y == 0 && x > 0) Console.WriteLine(1);
            if (x == 0 && y > 0) Console.WriteLine(2);
        }

        static void If24()
        {
            double x = 2;
            double f;

            if (x > 0) f = 2 * Math.Sin(x);
            if (x <= 0) f = 6 - x;
        }

        static void If27()
        {
            int x = -32;
            int f;

            if (x < 0) f = 0;
            if (x >= 0 && x < 1  x >= 2 && x < 3) f = 1;
            if (x >= 1 && x < 2  x >= 3 && x < 4) f = -1;
        }
    }
}
