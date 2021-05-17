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
            Console.WriteLine("-----------------------------------------------------------");
            int a = 5, b = 9, c = 10, d = 7;
            int add = a + b + c + d;
            Console.WriteLine("The addition of {0}, {1}, {2} and {3} is {4}", a, b, c, d, add);
            Console.Read();

        }
    }
}
