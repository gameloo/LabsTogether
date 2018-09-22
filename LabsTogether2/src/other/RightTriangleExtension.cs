using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTogether2.src.other
{
    /// <summary>
    /// Расширение прямоугольный треугольник.
    /// </summary>
    public static class RightTriangleExtension
    {
        /// <summary>
        /// Поиск площади прямоугольного треугольника, через катеты.
        /// </summary>
        /// <param name="k1">Катет.</param>
        /// <param name="k2">Катет.</param>
        public static double СalculateS(this Triangle triangle, double k1, double k2)
        {
            if (k1 <= 0 || k2 <= 0) throw new ArgumentException();
            return 0.5 * k1 * k2;
        }

        /// <summary>
        /// Поиск площади прямоугольного треугольника, через катет и острый угол.
        /// </summary>
        /// <param name="k">Катет.</param>
        /// <param name="angle">Острый угол.</param>
        public static double СalculateS(this Triangle triangle, double k, double angle, bool angleIsRad)
        {
            if (k <= 0 || angle <= 0 || angle >= 90) throw new ArgumentException();
            if (angleIsRad) return 0.5 * 0.5 * Math.Pow(k, 2) * Math.Tan(angle);
            else return 0.5 * 0.5 * Math.Pow(k, 2) * Math.Tan(angle * Math.PI / 180);
        }

        /// <summary>
        /// Поиск площади прямоугольного треугольника, через гипотенузу и любой из острых углов.
        /// </summary>
        /// <param name="g">Гипотенуза.</param>
        /// <param name="angle">Острый угол.</param>
        public static double СalculateS1(this Triangle triangle, double g, double angle, bool angleIsRad)
        {
            if (g <= 0 || angle <= 0 || angle >= 90) throw new ArgumentException();
            if (angleIsRad) return 0.25 * g * Math.Sin(2 * angle);
            else return 0.25 * g * Math.Sin(2 * angle * Math.PI / 180);
        }

    }
}
