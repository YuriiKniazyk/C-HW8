using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace HW8
{
    [Serializable]
    [DataContract]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Square))]
    public abstract class Shape : IComparable
    {
        [DataMember]
        [XmlAttribute]
        private readonly string _name;

        public string Name
        {
            get => _name;
            set => value = _name;
        }

        protected Shape(string name)
        {
            _name = name;
        }

        public Shape() { }
        
        public abstract double Area();
        public abstract double Perimeter();

        public virtual string Print()
        {
            return $"Name: {Name}";
        }

        public int CompareTo(object obj)
        {
            Shape shape = obj as Shape;
            Debug.Assert(shape != null, nameof(shape) + " != null");
            return Area().CompareTo(shape.Area());
        }
    }
}