namespace Figures
{
    public class SquereCrator : FigureCreator
    {
        public override ICalcArea Create()
        {
            Console.WriteLine($"Введите сторону квадрата");
            double r = ParseDoubleFromConsole();

            return new Squere(r);
        }
    }



}
