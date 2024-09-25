using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public static class Parser
    {
        const string ERROR_MESSAGE_DOUBLE = $"Данные не распознаны как дробное число";
        const string ERROR_MESSAGE_INT = $"Данные не распознаны как целое число";

        public static double ParseDoubleFromConsole()
        {
            double result = 0;
            bool repete = true;
            do
            {
                var readLine = Console.ReadLine();
                bool isItParse = double.TryParse(readLine, out result);
                if (isItParse)
                {
                    repete = false;
                }
                else
                    Console.WriteLine(ERROR_MESSAGE_DOUBLE);
            } while (repete);
            return result;
        }

        public static int ParseIntFromConsole()
        {
            int result = 0;
            bool repete = true;
            do
            {
                var readLine = Console.ReadLine();
                bool isItParse = int.TryParse(readLine, out result);
                if (isItParse)
                    repete = false;
                else
                    Console.WriteLine(ERROR_MESSAGE_INT);
            } while (repete);


            return result;
        }



    }
}
