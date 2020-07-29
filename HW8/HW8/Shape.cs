using System;
using System.Diagnostics;

namespace HW8
{
    public abstract class Shape : IComparable
    {
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