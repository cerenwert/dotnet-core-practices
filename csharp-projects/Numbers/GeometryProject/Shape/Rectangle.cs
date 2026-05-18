namespace GeometryProject
{
    public class Rectangle : IShape
    {
        public double heigth { get; set; }
        public double width { get; set; }
        public Rectangle(double heigth, double width)
        {
            this.heigth = heigth;
            this.width = width;
        }
        public double CalculateArea()
        {
            return heigth * width;
        }
        public double CalculatePerimeter()
        {
            return 2 * (heigth + width);
        }
        
    }
}