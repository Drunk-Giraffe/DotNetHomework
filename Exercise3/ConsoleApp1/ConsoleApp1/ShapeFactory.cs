using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ShapeFactory
    {
        public Shape RandomGetShape(int num)
        {
            switch (num % 3)
            {
                case 0:
                    Random ra1 = new Random();
                    double a1 = ra1.Next(-10, 11);
                    double b1 = ra1.Next(-10, 11);
                    Rectangle rec = new Rectangle(a1, b1);
                    if (rec.IsLegal())
                    {
                        Console.WriteLine("成功创建长方形！边长分别为" + rec.a + "与" + rec.b);
                        return rec;
                    }
                    else
                        return null;
                case 1:
                    Random ra2 = new Random();
                    double a2= ra2.Next(-10,11);
                    Square squ = new Square(a2);
                    if (squ.IsLegal())
                    {
                        Console.WriteLine("成功创建正方形！边长为" + squ.a );
                        return squ;
                    }
                    else
                        return null;
                case 2:
                    Random ra3 = new Random();
                    double a3 = ra3.Next(-10,13);
                    double b3 = ra3.Next(-10, 13);
                    double c3 = ra3.Next(-10, 13);
                    Triangle tri = new Triangle(a3, b3,c3);
                    if (tri.IsLegal())
                    {
                        Console.WriteLine("成功创建三角形！边长分别为" + tri.a + "，" + tri.b+ "，"+tri.c);
                        return tri;
                    }
                    else
                        return null;
                default:
                    return null;
            }
        }
    }
}
