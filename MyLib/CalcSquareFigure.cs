namespace MyLib
{
    public class CalcSquareFigure
    {
        private ISquareFigureStrategy squareFigure;

        public void SetCurrentFigure(ISquareFigureStrategy squareFigure)
            => this.squareFigure = squareFigure;
        public double GetSquareCurrentFigure()
            => squareFigure.GetSquare();
    }
}
