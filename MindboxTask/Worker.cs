using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask
{
    public static class Worker
    {
        /* 
         Вычисление площади круга по заданному радиусу
        */
        public static double Suqare(double radius)
        {
            IFigure figure = new Circle(radius);
            return figure.GetSquare();
        }

        /* 
         Вычисление площади треугольника по трём сторонам
        */
        public static double Square(double a, double b, double c) 
        { 
            IFigure figure = new Triangle(a, b, c);
            return figure.GetSquare();
        }

        /*
         Проверка яляется ли треугольник прямоугольным
        */
        public static bool IsRectangular(double a, double b, double c)
        {
            var Sides = new List<double>() { a, b, c };
            Sides.Sort();
            if (Math.Pow(Sides[2], 2) == Math.Pow(Sides[0],2) + Math.Pow(Sides[1],2))
                return true;
            else return false; 
        }
    }
}
