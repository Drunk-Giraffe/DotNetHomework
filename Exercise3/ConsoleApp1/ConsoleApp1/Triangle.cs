using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Triangle : Shape
    {
        public Triangle(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double GetArea()
        {
            return Math.Sqrt(((a + b + c) / 2) * ((b + c - a) / 2) * ((a + c - b) / 2) * ((a + b - c) / 2));
            throw new NotImplementedException();
        }
        public bool IsLegal()
        {
            return (a > 0) && (b > 0) && (c > 0) && ((a + b) > c) && ((a + c) > b) && (((c + b) > a));
            throw new NotImplementedException();
        }
    }
}
