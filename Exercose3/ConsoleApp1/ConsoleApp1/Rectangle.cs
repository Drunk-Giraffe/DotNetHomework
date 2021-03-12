using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle:Shape
    {
        public Rectangle(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public double a { get; set; }
        public double b { get; set; }
        public double GetArea()
        {
            return a * b;
            throw new NotImplementedException();
        }

        public bool IsLegal()
        {
            return (a > 0) && (b > 0);
            throw new NotImplementedException();
        }
    }
}
