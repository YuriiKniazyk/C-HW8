using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

                //bin
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Res.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, shapes);
                stream.Close();

                stream = new FileStream("Res.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Shape> shapes2 = formatter.Deserialize(stream) as List<Shape>;
                stream.Close();
               

                //xml
                XmlSerializer xml = new XmlSerializer(typeof(List<Shape>));
                Stream stream1 = new FileStream("xml.xml", FileMode.Create);
                xml.Serialize(stream1, shapes);
                stream1.Close();

                stream1 = new FileStream("xml.xml", FileMode.Open);
                List<Shape> shapes3 = xml.Deserialize(stream1) as List<Shape>;
                Console.WriteLine(shapes3);
                stream1.Close();

                //json
                Stream file = new FileStream("J.json", FileMode.Create);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Shape>));
                ser.WriteObject(file, shapes);

                file.Position = 0;
                List<Shape> p2 = ser.ReadObject(file) as List<Shape>;
                foreach (var shape in p2)
                {
                    Console.WriteLine(shape.Print());
                }
                file.Close();

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
