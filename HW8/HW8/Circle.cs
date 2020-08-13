using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace HW8
{
    [Serializable]
    [DataContract]
    public class Circle : Shape
    {
        [DataMember]
        [XmlAttribute]
        public double Radius { get; set; }
        const double PI = 3.14;

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public Circle() { }
        public override double Area()
        {
            return PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * PI * Radius;
        }

        public override string Print()
        {
            return $"Name: {Name}, Area= {Area()}, Perimeter= {Perimeter()}";
        }
    }
}