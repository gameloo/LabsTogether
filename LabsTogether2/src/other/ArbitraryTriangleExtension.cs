using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTogether2.src.other
{
    /// <summary>
    /// Расширение произвольный треугольник.
    /// </summary>
    public static class ArbitraryTriangleExtension
    {
        /// <summary>
        /// Поиск площади произвольного треугольника, через сторону и высоту проведенную к ней.
        /// </summary>
        /// <param name="side">Сторона треугольника.</param>
        /// <param name="height">Высота проведенная к стороне.</param>
        public static double СalculateS(this Triangle triangle, double side, double height)
        {
            if (side <= 0 || height <= 0) throw new ArgumentException();
            return 0.5 * side * height;
        }

        /// <summary>
        /// Поиск площади произвольного треугольника, через две стороны и угол между ними.
        /// </summary>
        /// <param name="sideA">Сторона треугольника.</param>
        /// <param name="sideB">Сторона треугольника.</param>
        /// <param name="angle">Угол между сторонами.</param>
        /// <param name="angleIsRad">Угол в радианах.</param>
        public static double СalculateS(this Triangle triangle, double sideA, double sideB, double angle, bool angleIsRad)
        {
            if (sideA <= 0 || sideB <= 0 || angle <= 0) throw new ArgumentException();
            if (angleIsRad) return 0.5 * sideA * sideB * Math.Sin(angle);
            else return 0.5 * sideA * sideB * Math.Sin(angle * Math.PI / 180);
        }

        /// <summary>
        /// Поиск площади произвольного треугольника, через 3 стороны.
        /// </summary>
        /// <param name="sideA">Сторона треугольника.</param>
        /// <param name="sideB">Сторона треугольника.</param>
        /// <param name="sideC">Сторона треугольника.</param>
        public static double СalculateS(this Triangle triangle, double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0) throw new ArgumentException();
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        /// <summary>
        /// Поиск площади произвольного треугольника, через полупериметр и радиус вписанной окружности.
        /// </summary>
        /// <param name="halfP">Полупериметр.</param>
        /// <param name="r">Радиус вписанной окружности.</param>
        public static double СalculateS1(this Triangle triangle, double halfP, double r)
        {
            if (halfP <= 0 || r <= 0) throw new ArgumentException();
            return halfP * r;
        }

        /// <summary>
        /// Поиск площади произвольного треугольника, через произведение сторон и радиус описанной окружности.
        /// </summary>
        /// <param name="multiplySides">Произведение сторон.</param>
        /// <param name="r">Радиус описанной окружности.</param>
        public static double СalculateS2(this Triangle triangle, double multiplySides, double R)
        {
            if (multiplySides <= 0 || R <= 0) throw new ArgumentException();
            return multiplySides / (4 * R);
        }
    }
}
