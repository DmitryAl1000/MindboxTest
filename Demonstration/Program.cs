using Figures;


string unitOfMeasurement = "m2";

//треугольник
var triangle = new Triangle(4, 4 , 5);
var square = triangle.CalcArea();

Console.WriteLine(triangle.MessegeCalcArea());
Console.WriteLine();

Console.WriteLine($"Треугольник равносторонний: {triangle.IsItRightTriangle()}");
Console.WriteLine();


//Круг
var circle = new Сircle(10);
Console.WriteLine(circle.MessegeCalcArea());
Console.WriteLine();


//выбираем фигуру из заготовленных
FigureFactory figureFactory = new FigureFactory();
figureFactory.ChooceFigureFromMenu();
ICalcArea figure = figureFactory.Create();

Console.WriteLine(figure.MessegeCalcArea());



