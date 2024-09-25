namespace Figures
{
    public class TriangleCrator : IFigureCreator
    {
        public ICalcArea CreateFromConsoleReadLine()
        {
            Console.WriteLine($"Введите первую сторону треугольника");
            double a = Parser.ParseDoubleFromConsole();
            Console.WriteLine($"Введите вторую сторону треугольника");
            double b = Parser.ParseDoubleFromConsole();
            Console.WriteLine($"Введите третью сторону треугольника");
            double с = Parser.ParseDoubleFromConsole();

            return new Triangle(a, b, с);
        }
    }



}
