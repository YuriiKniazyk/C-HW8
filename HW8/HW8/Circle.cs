namespace HW8
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        const double PI = 3.14;

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

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