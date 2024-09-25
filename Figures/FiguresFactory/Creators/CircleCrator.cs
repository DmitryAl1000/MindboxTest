namespace Figures
{
    public class CircleCrator : IFigureCreator
    {
        public ICalcArea CreateFromConsoleReadLine()
        {
            Console.WriteLine($"Введите радиус круга");
            double r = Parser.ParseDoubleFromConsole();

            return new Сircle(r);
        }

    }






}
