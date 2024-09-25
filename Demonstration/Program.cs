using Figures;
using Microsoft.Extensions.DependencyInjection;

string measure = "m2";

Console.WriteLine($"==== Вычисление, зная тип фигуры =====");
//треугольник
var triangle = new Triangle(4, 4 , 5);
var square = triangle.CalcArea();

Console.WriteLine(triangle.MessegeCalcArea() + measure);
Console.WriteLine($"Треугольник равносторонний: {triangle.IsItRightTriangle()}");
Console.WriteLine();
//Круг
var circle = new Сircle(10);
Console.WriteLine(circle.MessegeCalcArea() + measure);
Console.WriteLine();


Console.WriteLine($"==== Вычисление площади фигуры без знания типа фигуры =====");

var services = new ServiceCollection().AddTransient<IFigureCreator, CircleCrator >(); //пусть будет круг
var serviceProvider = services.BuildServiceProvider();
IFigureCreator? figureCreator = serviceProvider.GetService<IFigureCreator>();
ICalcArea figure = figureCreator.CreateFromConsoleReadLine(); // тут нас попросят ввести данные для фигуры в консоле
Console.WriteLine(figure.MessegeCalcArea() + measure);


Console.WriteLine($"==== Вычисление площади фигуры из списка =====");

//выбираем фигуру из списка заготовленных
FigureFactory figureFactory = new FigureFactory();
figureFactory.ChooceFigureFromMenu();
ICalcArea figureFromList = figureFactory.Create();

Console.WriteLine(figureFromList.MessegeCalcArea() + measure);