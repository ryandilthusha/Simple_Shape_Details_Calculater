using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Shape Name : ");
            String sname = Console.ReadLine();



            Console.WriteLine("Which Operation : ");
            String op = Console.ReadLine();



            if (sname == "Circle")
            {
                Console.WriteLine("Enter Radius : ");
                double rad = double.Parse(Console.ReadLine());



                Circle c = new Circle(rad);

                c.calarea();
                c.calperimeter();


            }
            else if (sname == "Square")
            {


            }



            Console.ReadKey();
        }
    }
}