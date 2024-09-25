namespace Figures
{
    public abstract class FigureCreator
    {
        public abstract ICalcArea Create();

        protected double ParseDoubleFromConsole()
        {
            double result = 0;
            bool repete = true;
            do
            {
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    repete = false;
                }
                else
                    Console.WriteLine($"Не понимаю, попробуйте снова");
            } while (repete);


            return result;
        }
    }



}
