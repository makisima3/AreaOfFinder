using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFinder
{/// <summary>
/// Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
/// Дополнительно к работоспособности оценим:
/// Юнит-тесты -
/// Легкость добавления других фигур +
/// Вычисление площади фигуры без знания типа фигуры +
/// Проверку на то, является ли треугольник прямоугольным +
/// </summary>
    public class AreaFinder
    {
        //Учитывая что есть метод "распознающий" фигуру
        //первые два должны быть private
        //но для того что бы была возможность вызвать их отдель
        //они public

        public static (double, string) GetCircleArea(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2), "Круг");
        }

        public static (double, string) GetTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)), "Прямоугольный треугольник");
            }
            else
            {
                return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)), "Не прямоугольный треугольник");
            }
        }

        /// <summary>
        /// Не совсем понятно как должно быть реализванно распознование
        /// </summary>
        /// <returns></returns>
        public static (double, string) GetUnknownFigureArea(params double[] parameters)
        {
            if (parameters.Length == 1)
            {
                return (GetCircleArea(parameters[0]));
            }
            else if (parameters.Length == 3)
            {
                double a = parameters[0], b = parameters[1], c = parameters[2];

                if (a + b > c && a + c > b && b + c > a)
                {
                    return GetTriangleArea(a, b, c);
                }
                else
                {
                    return (-1, "Фигура с 3 сторономи не явзяющаяся треугольником еще не добавлена");
                }
            }

            return (-1, "Фигура с таким кол-вом сторон еще не добавлена");
        }
    }
}
