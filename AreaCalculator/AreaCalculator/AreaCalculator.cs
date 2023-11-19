using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLib
{
    /// <summary>
    /// Класс для вычисления площадей
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Площадь круга</returns>
        /// <exception cref="ArgumentException">Неправильный аргумент. Радиус меньше нуля</exception>
        public double ColculateCircleShape(double radius)
        {
            if (radius < 0)//Проверка радиуса н акорректное значние
            {//Если значение меньше нуля,то выкинуть исключение
                throw new ArgumentException("Радиус должен быть больше нуля!");
            }
            //Вычисление площади по формуле PI * R^2
            return Math.PI * radius * radius;
        }
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <param name="a">Первая стороан треугольника</param>
        /// <param name="b">Вторая стороан треугольника</param>
        /// <param name="c">Третья стороан треугольника</param>
        /// <returns>Площадь треугольника</returns>
        /// <exception cref="ArgumentException">Неправильный аргумент. Или сторона треугольника на входе меньшу нуля,или одна сторона треугольника больше суммы двух других</exception>
        public double TringleShape(double a, double b, double c)
        {
            //Проверка на корректные значения сторон треугольнка
            if (a < 0 || b < 0 || c < 0)//Все стороны должны быть больше нуля
            {//Если хотя бы одна сторона меньше нуля,то выкинуть исключение
                throw new ArgumentException("Сторона трегольника должна быть больше нуля!");
            }
            //Проверка на корректные значения сторон треугольнка
            if (Math.Max(Math.Max(a, b), c) >= (a + b + c) - Math.Max(Math.Max(a, b), c))
            {//Если одна сторона больше суммы двух других, то выкинуть исключение
                throw new ArgumentException("Наибольшая сторона треугольника не может быть больше суммы двух других сторон!");
            }
            //Вычисление полумепериметра
            double p = (a + b + c) / 2.0;
            //Вычисление площадь по формуле Герона
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="a">Первая стороан треугольника</param>
        /// <param name="b">Вторая стороан треугольника</param>
        /// <param name="c">Третья стороан треугольника</param>
        /// <returns>Является ли</returns>
        /// <exception cref="ArgumentException">Неправильный аргумент. Или сторона треугольника на входе меньшу нуля,или одна сторона треугольника больше суммы двух других</exception>
        public bool isRightRriangle(double a, double b, double c)
        {
            //Проверка на корректные значения сторон треугольнка
            if (a < 0 || b < 0 || c < 0)//Все стороны должны быть больше нуля
            {//Если хотя бы одна сторона меньше нуля,то выкинуть исключение
                throw new ArgumentException("Сторона трегольника должна быть больше нуля!");
            }
            //Проверка на корректные значения сторон треугольнка
            if (Math.Max(Math.Max(a, b), c) >= (a + b + c) - Math.Max(Math.Max(a, b), c))
            {//Если одна сторона больше суммы двух других, то выкинуть исключение
                throw new ArgumentException("Наибольшая сторона треугольника не может быть больше суммы двух других сторон!");
            }
            //Вычисляем максимальную сторону
            double max = Math.Max(Math.Max(a, b), c);
            //Вычисляем минимальную сторону
            double min = Math.Min(Math.Min(a, b), c);
            //Вычисляем оставшующся сторону, которая равна сумме трёх сторон - максимальная сторона - минимальная
            double midle = (a + b + c) - min - max;
            //По обратной теореме пифагора проверяем является ли треугольник прямоугльным
            return (max * max) == ((midle * midle) + (min * min));
        }
    }
}
