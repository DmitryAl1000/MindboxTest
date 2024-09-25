

namespace Figures
{
    public class Triangle : GeometricalFigure, ICalcArea
    {
        public string FigureName { get; } = "Треугольник";

        private double _sideA;
        private double _sideB;
        private double _sideC;  



        public Triangle(double sideA, double sideB, double sideC)
        {
            this._sideA = sideA;
            this._sideB = sideB;
            this._sideC = sideC;
        }

        public double CalcArea()
        {
            CheckNegativeValues(_sideA, _sideB, _sideC);

            //площать по трем сторонам формула Герона
            double halfPerimetr = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(
                halfPerimetr *
                (halfPerimetr - _sideA) *
                (halfPerimetr - _sideB) *
                (halfPerimetr - _sideC));
        }

        public bool IsItRightTriangle()
        {
            if (_sideA == _sideB ||
                _sideA == _sideC ||
                _sideB == _sideC
                )
                return true;
            else
                return false;   
        }

        public string MessegeCalcArea()
        {
            return $"{FigureName} имеет площадь: {CalcArea()}";
        }
    }
}
