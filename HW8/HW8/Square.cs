using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace HW8
{
    [Serializable]
    [DataContract]
    public class Square : Shape
    {
        [DataMember]
        [XmlAttribute]
        public double Side { get; set; }
        const double PI = 3.14;

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public Square() { }

        public override double Area()
        {
            return  Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        public override string Print()
        {
            return $"Name: {Name}, Area= {Area()}, Perimeter= {Perimeter()}";
        }
    }
}