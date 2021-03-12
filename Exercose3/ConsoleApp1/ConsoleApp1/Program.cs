using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            double AreaSum = 0;
            int Sum = 0;
            Random ra = new Random();
            ShapeFactory sf = new ShapeFactory();
            while(Sum<=10)
            {
                Shape sh = sf.RandomGetShape(ra.Next(1,10001));
                if (sh != null)
                {
                    Sum++;
                    AreaSum += sh.GetArea();
                }
            }
            Console.WriteLine("十个形状面积之和为："+AreaSum);
        }
    }
}
