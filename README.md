# Тестовые задания для MindBox
## Задание 1
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в compile-time
* Проверку на то, является ли треугольник прямоугольным


## Задание 2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.


SELECT ProductName, CategoryName  <br>
FROM <br>
(select Products.ProductName, Categorys.CategoryName from Products <br>
left JOIN Categorys on Products.CategoryId = Categorys.Id <br>
) as Products_Whith_Categorys <br>

UNION SELECT ProductName, CategoryName FROM <br>

(select Products.ProductName, Categorys.CategoryName from Products <br>
JOIN Categorys on Products.Id = Categorys.ProductId <br>
) as Categorys_Whith_Products <br>
