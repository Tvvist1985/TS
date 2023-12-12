namespace MyLib
{
    public class TriangleSquare : ISquareFigureStrategy
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public TriangleSquare(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public double GetSquare()
        {
            double halfPer = (a + b + c) / 2;
            double s = halfPer * ((halfPer - a) * (halfPer - b) * (halfPer - c));
           
            double t;
            double squareTriangle = s / 2;
            do
            {
                t = squareTriangle;
                squareTriangle = (t + (s / t)) / 2;
            }
            while ((t - squareTriangle) != 0);

            return squareTriangle;
        }
    }
}
