using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Сircle : GeometricalFigure, ICalcArea
    {
        public string FigureName { get; } = "Круг";

        double _radius;

        public Сircle(double radius)
        {
            this._radius = radius;
        }


        public double CalcArea()
        {
            CheckNegativeValues(_radius);
            //Pi*R^2
            return Math.PI * Math.Pow(_radius, 2);
        }

        public string MessegeCalcArea()
        {
            return $"{FigureName} имеет площадь: {CalcArea()}";
        }


    }
}
