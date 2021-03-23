using System;

namespace App1
{
    /*
        1.	Создать классы Point и Figure. Класс Point должен содержать два
целочисленных поля. Создать конструктор, в теле которого проинициализируйте поля значениями аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. Создать два метода: 
●	Для расчета длины стороны многоугольника; 
●	Для расчета периметра многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point()
            {
                X = 1,
                Y = 1
            };

            Point point2 = new Point()
            {
                X = 1,
                Y = 3
            };

            Point point3 = new Point()
            {
                X = 2,
                Y = 1
            };

            Point point4 = new Point()
            {
                X = 3,
                Y = 4
            };

            Point point5 = new Point()
            {
                X = 2,
                Y = 1
            };

            Figure triangle = new Figure(point1, point2, point3);
            Console.WriteLine("Заданы точки для первой фигуры:");
            Console.WriteLine($"Первая: {point1.X};{point1.Y}");
            Console.WriteLine($"Вторая: {point2.X};{point2.Y}");
            Console.WriteLine($"Третья: {point3.X};{point3.Y}");

            Console.WriteLine($"Первая фигура - {triangle.TypeFigure} ее периметр: {triangle.Perimeter}");

            Figure quadrilateral = new Figure(point1, point2, point3, point4);
            Console.WriteLine("Заданы точки для второй фигуры:");
            Console.WriteLine($"Первая: {point1.X};{point1.Y}");
            Console.WriteLine($"Вторая: {point2.X};{point2.Y}");
            Console.WriteLine($"Третья: {point3.X};{point3.Y}");
            Console.WriteLine($"Третья: {point4.X};{point4.Y}");

            Console.WriteLine($"Вторая фигура - {quadrilateral.TypeFigure} ее периметр: {quadrilateral.Perimeter}");

            Figure pentagon = new Figure(point1, point2, point3, point4, point5);
            Console.WriteLine("Заданы точки для третьей фигуры:");
            Console.WriteLine($"Первая: {point1.X};{point1.Y}");
            Console.WriteLine($"Вторая: {point2.X};{point2.Y}");
            Console.WriteLine($"Третья: {point3.X};{point3.Y}");
            Console.WriteLine($"Третья: {point4.X};{point4.Y}");
            Console.WriteLine($"Третья: {point5.X};{point5.Y}");

            Console.WriteLine($"Третья фигура - {pentagon.TypeFigure} ее периметр: {pentagon.Perimeter}");
        }
    }
}
