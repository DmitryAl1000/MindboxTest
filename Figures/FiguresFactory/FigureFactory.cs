using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class FigureFactory
    {
        List<string> _figuresNames = new List<string>();
        int _menuIndicator;

        public FigureFactory()
        {
            _figuresNames.Add("Треугольник");
            _figuresNames.Add("Круг");
            _figuresNames.Add("Квадрат");
        }

        public ICalcArea Create()
        {
            switch (_menuIndicator)
            {
                case 1:
                    var triangleCrator = new TriangleCrator();
                    return triangleCrator.Create();
                case 2:
                    var circleCrator = new CircleCrator();
                    return circleCrator.Create();
                case 3:
                    var SquereCrator = new SquereCrator();
                    return SquereCrator.Create();

                default:
                    throw new Exception("Выбран несуществующий пункт меню");
            }
        }

        private int ParseIntFromConsole()
        {
            int result = 0;
            bool repete = true;
            do
            {
                if (int.TryParse(Console.ReadLine(), out result))
                    repete = false;
                else
                    Console.WriteLine($"Не понимаю что тут написано, попробуйте снова");
            } while (repete);


            return result;
        }
        private int ChooseMenuIndicator()
        {
            do
            {
                int result = ParseIntFromConsole();
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
        public void ChooceFigureFromMenu()
        {
            ShowMenu();
            _menuIndicator = ChooseMenuIndicator();
        }
    }



}
