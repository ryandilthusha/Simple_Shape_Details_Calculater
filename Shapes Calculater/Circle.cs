using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Shapes
{
    class Circle
    {
        public double radius;



        public Circle(double r)
        {
            this.radius = r;
        }



        public void calarea()
        {
            double area = 3.14 * this.radius * this.radius;
            Console.WriteLine("Area of Circle = " + area);
        }



        public void calperimeter()
        {
            double peri = 2 * 3.14 * this.radius;
            Console.WriteLine("Perimeter of Circle = " + peri);
        }
    }
}