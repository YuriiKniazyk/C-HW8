using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shape> shapes = new List<Shape>
                {
                    new Circle("Circle1", 5),
                    new Circle("Circle2", 7),
                    new Circle("Circle3", 10),
                    new Circle("Circle4", 3.5),
                    new Circle("Circle5", 12.7),
                    new Square("Square1", 3),
                    new Square("Square2", 4.2),
                    new Square("Square3", 10),
                    new Square("Square4", 6),
                    new Square("Square5", 1.7)
                };

                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape.Print());
                }
                Console.WriteLine();
                Console.WriteLine();

                double maxPerimeter = shapes.Max(r => r.Perimeter());
                Console.WriteLine($"MaxPerimeter= {maxPerimeter}");
                foreach (var shape in shapes)
                {
                    if (shape.Perimeter() == maxPerimeter)
                    {
                        Console.WriteLine($"Name figure with max perimeter: {shape.Name}");
                    }
                    
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("The list after sort");
                shapes.Sort();
                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape.Print());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
