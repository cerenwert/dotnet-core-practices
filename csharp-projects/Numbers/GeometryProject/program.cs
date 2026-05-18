using System.Security.Cryptography.X509Certificates;

namespace GeometryProject
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter the shape you want to calculate (Circle, Rectangle, Square):");
            string shapeType = Console.ReadLine()?.ToLower() ?? "";
            static double Readdouble(string message)
            {
                
                Console.WriteLine(message);
                double value;

                while (!double.TryParse(Console.ReadLine(), out value)) 
                {
                    Console.WriteLine("Invalid value!");
                }
                return value;
            }
            IShape shape;
            switch (shapeType)
            {
                case "circle":
                    double radius = Readdouble("Enter the radius of the circle:");
                    shape = new Circle(radius);
                    Console.WriteLine($"Area: {shape.CalculateArea()}");
                    Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
                    break;
                case "rectangle":
                    double height = Readdouble("Enter the height of the rectangle:"); 
                    double width = Readdouble("Enter the width of the rectangle:");
                    shape = new Rectangle(height, width);
                    Console.WriteLine($"Area: {shape.CalculateArea()}");
                    Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
                    break;
                case "square":
                    double sideLength = Readdouble("Enter the side length of the square:");
                    shape = new Square(sideLength);
                    Console.WriteLine($"Area: {shape.CalculateArea()}");
                    Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
                    break;
                case "triangle":
                    double side1 = Readdouble("Enter side 1:");
                    double side2 = Readdouble("Enter side 2:");
                    double side3 = Readdouble("Enter side 3:");
                    double triangleHeight = Readdouble("Enter height:");

                    shape = new Triangle(side1, side2, side3, triangleHeight);

                    Console.WriteLine($"Area: {shape.CalculateArea()}");
                    Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
                    break;
                
                default:
                    Console.WriteLine("Invalid shape type.");
                    return;
            }
        }
    }
    
}