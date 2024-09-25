using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public interface ICalcArea
    {
        public double CalcArea();
        public string MessegeCalcArea();
        public string FigureName { get; }
    }
}
