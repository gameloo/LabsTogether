using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Media;

namespace LabsTogether2.src.other
{
    public class Triangle
    {
        private PointCollection pointCollection;
        private Point pointA;
        private Point pointB;
        private Point pointC;

        public double SizeAB { get; private set; }
        public double SizeBC { get; private set; }
        public double SizeCA { get; private set; }
        public double S
        {
            get
            {
                double p = (SizeAB + SizeBC + SizeCA) / 2;
                return Math.Sqrt(p * (p - SizeAB) * (p - SizeBC) * (p - SizeCA));
            }
        }

        public double P
        {
            get
            {
                return SizeAB + SizeBC + SizeCA;
            }
        }

        public Triangle()
        {
            pointCollection = new PointCollection() {
                new Point(0,0), new Point(100,0), new Point(50,75)
        };
        }

        public PointCollection CalculateCoordinatesPoints(double sizeAB, double sizeBC, double sizeCA)
        {
            if (sizeAB <= 0 || sizeBC <= 0 || sizeCA <= 0) throw new ArgumentException();

            pointA = new Point(0, 0);
            pointB = new Point(sizeAB, 0);
            pointC = new Point(0, 0);

            var rad1 = sizeCA;
            var rad2 = sizeBC;
            var c = (rad2 * rad2 - pointB.X * pointB.X - pointB.Y * pointB.Y - rad1 * rad1) / -2;
            var a = pointB.X * pointB.X + pointB.Y * pointB.Y;

            var b = -2 * pointB.Y * c;
            var e = c * c - rad1 * rad1 * pointB.X * pointB.X;
            var D = b * b - 4 * a * e;
            if (D <= 0) throw new ArgumentException();
            pointC.Y = (-b + Math.Sqrt(D)) / (2 * a);
            pointC.X = (c - pointC.Y * pointB.Y) / pointB.X;

            SizeAB = sizeAB;
            SizeBC = sizeBC;
            SizeCA = sizeCA;

            pointCollection.Clear();
            pointCollection.Add(pointA);
            pointCollection.Add(pointB);
            pointCollection.Add(pointC);
            return pointCollection;
        }
    }
}
