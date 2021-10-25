using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class shapes
    {
        public int Area(int l, int r)
        {
            return l * r;
        }
        public double Area(double h, double b)
        {
            return 0.5*b*h;
        }
        public double Area(double r)
        {
            double PI= 3.14;
            return PI * r * r;
        }
        public int Area(int s)
        {
            return s * s;
        }
        static void Main(string[] args)
        {
            shapes shape = new shapes();
            Console.WriteLine("Area of sqaure is:" + shape.Area(3));
            Console.WriteLine("Area of rectangle is " + shape.Area(3, 4));
            Console.WriteLine("Area of circle is "+shape.Area(2.37));
            Console.WriteLine("Area of triangle is "+shape.Area(12, 54));


        }
    }
}
