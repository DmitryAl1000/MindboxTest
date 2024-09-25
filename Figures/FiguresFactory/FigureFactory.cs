using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Figures
{
    public class FigureFactory
    {
        List<string> _figuresNames = new List<string>();

        public int MenuIndicator { get; set; }


        public FigureFactory()
        {
            _figuresNames.Add("Треугольник");
            _figuresNames.Add("Круг");
            _figuresNames.Add("Квадрат");
        }
  
        public ICalcArea Create()
        {
            switch (MenuIndicator)
            {
                case 1:
                    var triangleCrator = new TriangleCrator();
                    return triangleCrator.CreateFromConsoleReadLine();
                case 2:
                    var circleCrator = new CircleCrator();
                    return circleCrator.CreateFromConsoleReadLine();
                case 3:
                    var SquereCrator = new SquereCrator();
                    return SquereCrator.CreateFromConsoleReadLine();

                default:
                    throw new Exception("Пункт меню не выбран или выбран несуществующий пункт меню");
            }
        }
        public void ChooceFigureFromMenu()
        {
            ShowMenu();
            MenuIndicator = ChooseMenuIndicator();
        }
        private int ChooseMenuIndicator()
        {
            do
            {
                int result = Parser.ParseIntFromConsole();
                if (result > 0 && result <= _figuresNames.Count)
                {
                    return result;
                }
                else
                    Console.WriteLine($"Такого пункта меню нет, попробуйте снова");
            } while (true);
        }
        private void ShowMenu()
        {
            Console.WriteLine($"Я Могу посчитать площади этих фигур. Выбирайте пункт меню:");
            for (int i = 0; i < _figuresNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{_figuresNames[i]}");
            }
        }
        
    }



}
