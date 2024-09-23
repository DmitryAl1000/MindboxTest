namespace Figures
{
    public class Triangle : IGeometricalFigure
    {
        public double GetSquare(params double[] numbers)
        {
            if (!IsItTriangle(numbers))
            {
                // logger.log не треугольник
                return 0;
            }

            double halfPerimetr = numbers.Sum() / 2;

            //площать по трем сторонам формула Герона
            return Math.Sqrt(
                halfPerimetr *
                (halfPerimetr - numbers[0]) *
                (halfPerimetr - numbers[1]) *
                (halfPerimetr - numbers[3]));
        }

        private bool IsItTriangle(double[] numbers) 
        {
            if (numbers.Length == 3)
                return true;
            else
                return false;
        }



    }
}
