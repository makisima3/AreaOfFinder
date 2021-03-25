using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaOfFinder;

namespace TestAreaOfFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region circle
            Console.WriteLine("Введите раудиус круга:");
            double r = Convert.ToDouble(Console.ReadLine());

            (double s, string figure) = AreaFinder.GetCircleArea(r);
            Console.WriteLine($"Площадь = {s}; Фигура: {figure}");
            #endregion

            #region triangle
            Console.WriteLine("\nВведите стороны треугольника:");

            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());

            (s, figure) = AreaFinder.GetTriangleArea(a, c, b);
            Console.WriteLine($"Площадь = {s}; Фигура: {figure}");
            #endregion

            #region unknown
            Console.WriteLine("\nВведите количество параметров:");
            int count = Convert.ToInt32(Console.ReadLine());

            double [] figureParams = new double[count];
            Console.WriteLine("Введите параметры по 1:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(i + ")");
                figureParams[i] = Convert.ToDouble(Console.ReadLine());
            }

            (s, figure) = AreaFinder.GetUnknownFigureArea(figureParams);
            Console.WriteLine($"Площадь = {s}; Фигура: {figure}");
            #endregion
            Console.ReadKey();
        }
    }
}
