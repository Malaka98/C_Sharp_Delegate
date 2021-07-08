using System;

namespace C_Sharp_Delegate
{
    delegate int Cal(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Cal obj = Calculator.Add;
            Console.WriteLine(obj(50, 10));

            obj = Calculator.Div;
            Console.WriteLine(obj(50, 10));

            obj = Calculator.Mul;
            Console.WriteLine(obj(50, 10));

            obj = Calculator.Sub;
            Console.WriteLine(obj(50, 10));
        }
    }
}
