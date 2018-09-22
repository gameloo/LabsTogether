using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTogether2.src.other
{
    /// <summary>
    /// Расширение равносторонний треугольник.
    /// </summary>
    public static class EquilateralTriangleExtension
    {
        /// <summary>
        /// Поиск площади равностороннего треугольника, через сторону.
        /// </summary>
        /// <param name="side">Сторона треугольника.</param>
        public static double СalculateS(this Triangle triangle, double side)
        {
            if (side <= 0) throw new ArgumentException();
            return Math.Sqrt(3) * Math.Pow(side, 2) / 4;
        }

        /// <summary>
        /// Поиск площади равностороннего треугольника, через радиус вписанной окружности.
        /// </summary>
        /// <param name="r">Радиус вписанной окружности.</param>
        public static double СalculateS1(this Triangle triangle, double r)
        {
            if (r <= 0) throw new ArgumentException();
            return 3 * Math.Sqrt(3) * Math.Pow(r, 2);
        }

        /// <summary>
        /// Поиск площади равностороннего треугольника, через радиус описанной окружности.
        /// </summary>
        /// <param name="R">Радиус описанной окружности.</param>
        public static double СalculateS2(this Triangle triangle, double R)
        {
            if (R <= 0) throw new ArgumentException();
            return 3 * Math.Sqrt(3) * Math.Pow(R, 2) / 4;
        }
    }
}
