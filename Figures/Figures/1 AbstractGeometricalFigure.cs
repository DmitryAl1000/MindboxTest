using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class GeometricalFigure 
    {
        protected const string ERROR_MESSEGE_NEGATIVE_VALUE = "Одна или несколько из сторон имееют отрицательное или нулевое значение";
        

        protected void CheckNegativeValues(params double[] numbers)
        {
            if (!IsOneOfSidesHasNegativeValue(numbers))
                throw new ArgumentException(ERROR_MESSEGE_NEGATIVE_VALUE);
        }


        private bool IsOneOfSidesHasNegativeValue(double[] numbers)
        {
            foreach (var item in numbers)
            {
                if (item <= 0)
                    return false;
            }
            return true;
        }
    }
}
