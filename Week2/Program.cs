using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 454;
            int sq = num * num; 
            Console.WriteLine("The square of {0} is {1}", num, sq);
            Console.WriteLine("\n-----------------------------------------------------------\n");
            int a = 5, b = 9, c = 10, d = 7;
            int add = a + b + c + d;
            Console.WriteLine("The addition of {0}, {1}, {2} and {3} is {4}", a, b, c, d, add);
            Console.WriteLine("\n-----------------------------------------------------------\n");
            int e = 1, f = 2, g = 3;
            Console.WriteLine("Value of variables are {0}, {1} and {2}", a, b, c);
            Console.WriteLine("Reversed order of value of variables are {2}, {1} and {0}", a, b, c);
            Console.WriteLine("\n-----------------------------------------------------------\n");
            float num1 = 25, num2 = 30, num3 = 10, num4 = 8;

            float total = num1 + num2 + num3 + num4;
            Console.WriteLine("Total of {0}, {1}, {2} and {3} : {4}", num1, num2, num3, num4, total);
            float difference = ((num1 - num2) - num3) - num4;
            Console.WriteLine("Difference of {0}, {1}, {2} and {3} : {4}", num1, num2, num3, num4, difference);
            float product = num1 * num2 * num3 * num4;
            Console.WriteLine("Product of {0}, {1}, {2} and {3} : {4}", num1, num2, num3, num4, product);
            float div = num1 / (num2 / (num3 / num4));
            Console.WriteLine("Division of {0}, {1}, {2} and {3} : {4}", num1, num2, num3, num4, div);
            float mod = (num1 % num2) % (num3 % num4);
            Console.WriteLine("Modulus of {0}, {1}, {2} and {3} : {4}", num1, num2, num3, num4, mod);
            Console.Read();

        }
    }
}
