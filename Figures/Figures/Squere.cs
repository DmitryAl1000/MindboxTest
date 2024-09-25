namespace Figures
{
    public class Squere : GeometricalFigure, ICalcArea
    {
        public string FigureName { get; } = "Квадрат";

        double _side;

        public Squere(double side)
        {
            this._side = side;
        }


        public double CalcArea()
        {
            CheckNegativeValues(_side);

            return _side*_side;
        }

        public string MessegeCalcArea()
        {
            return $"{FigureName} имеет площадь: {CalcArea()}";
        }


    }
}
