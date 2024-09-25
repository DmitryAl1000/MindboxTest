namespace Figures
{
    public class CircleCrator : FigureCreator
    {
        public override ICalcArea Create()
        {
            Console.WriteLine($"Введите радиус круга");
            double r = ParseDoubleFromConsole();

            return new Сircle(r);
        }
    }



}
