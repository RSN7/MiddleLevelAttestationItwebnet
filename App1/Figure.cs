using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Figure
    {
        public double Perimeter { get; }
        public string TypeFigure { get; }
        public Figure(Point point1, Point point2, Point point3)
        {
            double firstLine = calculateLine(point1, point2);
            double twoLine = calculateLine(point2, point3);
            double threeLine = calculateLine(point3, point1);

            Perimeter = сalculatePerimeter(firstLine, twoLine, threeLine);
            TypeFigure = "Треугольник";

        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {

            double firstLine = calculateLine(point1, point2);
            double twoLine = calculateLine(point2, point3);
            double threeLine = calculateLine(point3, point4);
            double fourLine = calculateLine(point4, point1);

            Perimeter = сalculatePerimeter(firstLine, twoLine, threeLine, fourLine);
            TypeFigure = "Четырехугольник";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            double firstLine = calculateLine(point1, point2);
            double twoLine = calculateLine(point2, point3);
            double threeLine = calculateLine(point3, point4);
            double fourLine = calculateLine(point4, point5);
            double fiveLine = calculateLine(point5, point1);
           
            Perimeter = сalculatePerimeter(firstLine, twoLine, threeLine, fourLine, fiveLine);
            TypeFigure = "Пятиугольник";

        }

        //метод для вычисления периметра
        private double сalculatePerimeter(params double[] lines) 
        {
            double result = 0;
            for (int i = 0; i<lines.Length; i++)
            {
                result += lines[i];
            }
            return Math.Round(result, 2);
        }

        //метод для вычисления длины стороны
        private double calculateLine(Point firstPoint, Point twoPoint)
        {
            double result = Math.Sqrt((twoPoint.X - firstPoint.X) * (twoPoint.X - firstPoint.X) +
                                         (twoPoint.Y - firstPoint.Y) * (twoPoint.Y - firstPoint.Y));
            return Math.Round(result, 2);
        }
    }
}
