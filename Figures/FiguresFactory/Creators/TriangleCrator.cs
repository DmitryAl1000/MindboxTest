namespace Figures
{
    public class TriangleCrator : FigureCreator
    {
        public override ICalcArea Create()
        {
            Console.WriteLine($"Введите первую сторону треугольника");
            double a = ParseDoubleFromConsole();
            Console.WriteLine($"Введите вторую сторону треугольника");
            double b = ParseDoubleFromConsole();
            Console.WriteLine($"Введите третью сторону треугольника");
            double с = ParseDoubleFromConsole();

            return new Triangle(a, b, с);
        }
    }



}
