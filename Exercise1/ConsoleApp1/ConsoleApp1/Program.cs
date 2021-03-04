using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个运算数：");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个运算数：");
            double y = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            char c = Console.ReadLine()[0];
            switch (c)
            {
                case '+':
                    Console.WriteLine("运算结果为："+ (x + y)); 
                    break;
                case '-':
                    Console.WriteLine("运算结果为：" + (x - y));
                    break;
                case '*':
                    Console.WriteLine("运算结果为：" + (x * y));
                    break;
                case '/':
                    if (y != 0)
                        Console.WriteLine("运算结果为：" + (x / y));
                    else
                        Console.WriteLine( "除数不能为0，无法计算！");
                    break;
                default:
                    Console.WriteLine("运算符不合法！");
                    break;
            }
        }
    }
}
