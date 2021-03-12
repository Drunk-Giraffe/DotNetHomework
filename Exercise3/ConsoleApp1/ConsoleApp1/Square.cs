using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Square : Shape
    {
        public Square(double a)
        {
            this.a = a;
        }
        public double a { get; set; }
        public double GetArea()
        {
            return Math.Pow(a,2);
            throw new NotImplementedException();
        }

        public bool IsLegal()
        {
            return (a > 0) ;
        }
    }
}
