namespace GeometryProject
{
    public class Triangle : IShape
    {
        private double Side1;
        private double Side2;
        private double Side3;
        private double Height;

        public Triangle(double side1, double side2, double side3, double height)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Height = height;
        }

        public double CalculateArea()
        {
            return (Side1 * Height) / 2;
        }

        public double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}