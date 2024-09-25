namespace Figures
{
    public class SquereCrator : IFigureCreator
    {
        public ICalcArea CreateFromConsoleReadLine()
        {
            Console.WriteLine($"Введите сторону квадрата");
            double r = Parser.ParseDoubleFromConsole();
            return new Squere(r);
        }
    }



}
