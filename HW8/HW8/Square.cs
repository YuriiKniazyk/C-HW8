namespace HW8
{
    public class Square : Shape
    {
        public double Side { get; set; }
        const double PI = 3.14;

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

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