namespace MyLib
{
    public class CircleSquare : ISquareFigureStrategy
    {
        private const float PI = 3.141592653589f;
        private readonly double radius;
        public CircleSquare(double radius)
        {
            this.radius = radius;                
        }
        public double GetSquare()
        {
            return PI * radius * radius;
        }
    }
}
