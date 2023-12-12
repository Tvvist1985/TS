using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLib.Tests
{
    [TestClass]
    public class CalcSquareFigureTests
    {
        [TestMethod]
        public void GetSquareCurrentFigure_Circle_squareFigure_squareFigureReturned()
        {
            double radius = 10;
            double expected = 314.15927410125732;
           
            CalcSquareFigure calcSquareFigure = new CalcSquareFigure();
            calcSquareFigure.SetCurrentFigure(new CircleSquare(radius));
            double actual = calcSquareFigure.GetSquareCurrentFigure();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSquareCurrentFigure_Treangle_squareFigure_squareFigureReturned()
        {
            double a = 10;
            double b = 10;
            double c = 10;
            double expected = 43.301270189221931;

            CalcSquareFigure calcSquareFigure = new CalcSquareFigure();
            calcSquareFigure.SetCurrentFigure(new TriangleSquare(a,b,c));
            double actual = calcSquareFigure.GetSquareCurrentFigure();

            Assert.AreEqual(expected, actual);
        }
    }
}
