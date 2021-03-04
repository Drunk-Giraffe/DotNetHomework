using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.WriteLine("结果为：");
            switch (c)
            {
                case '+':
                    Console.WriteLine(x + y);
                    break;
                case '-':
                    Console.WriteLine(x - y);
                    break;
                case '*':
                    Console.WriteLine(x * y);
                    break;
                case '/':
                    if (y != 0)
                        Console.WriteLine(x / y);
                    else
                        Console.WriteLine("除数不能为0，无法计算！");
                    break;
                default:
                    Console.WriteLine("不是合法的运算符！");
                    break;
            }
        }
    }
}