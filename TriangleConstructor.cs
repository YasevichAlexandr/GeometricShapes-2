using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Fig1;
using Fig2;
using Fig3;
using Fig4;
using Fig5;
using Fig6;
using Fig7;
using Fig8;
using Fig9;
using Fig10;
using Fig11;
using Fig12;
using Fig13;
using Fig14;


namespace Fig12
{
    public class TriangleConstructor
    {
        public static Triangle CreateTriangle(Point pointA, Point pointB, Point pointC, LineType lineType, FillColor fillColor)
        {
            Triangle triangle;

            // Check the type of the triangle based on the given vertices
            double sideAB = CalculateDistance(pointA, pointB);
            double sideBC = CalculateDistance(pointB, pointC);
            double sideCA = CalculateDistance(pointC, pointA);

            if (IsEquilateralTriangle(sideAB, sideBC, sideCA))
            {
                triangle = new EquilateralTriangle(pointA, pointB, pointC, lineType, fillColor);
            }
            else if (IsIsoscelesTriangle(sideAB, sideBC, sideCA))
            {
                triangle = new IsoscelesTriangle(pointA, pointB, pointC, lineType, fillColor);
            }
            else if (IsRightTriangle(sideAB, sideBC, sideCA))
            {
                triangle = new RightTriangle(pointA, pointB, pointC, lineType, fillColor);
            }
            else
            {
                triangle = new ArbitraryTriangle(pointA, pointB, pointC, lineType, fillColor);
            }

            return triangle;
        }

        private static double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }

        private static bool IsPythagorean(double side1, double side2, double hypotenuse)
        {
            return Math.Abs(Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(hypotenuse, 2)) < double.Epsilon;
        }

        private static bool IsRightTriangle(double sideAB, double sideBC, double sideCA)
        {
            return IsPythagorean(sideAB, sideBC, sideCA) && IsPythagorean(sideBC, sideCA, sideAB) && IsPythagorean(sideCA, sideAB, sideBC);
        }

        private static bool IsEquilateralTriangle(double sideAB, double sideBC, double sideCA)
        {
            return Math.Abs(sideAB - sideBC) < double.Epsilon && Math.Abs(sideBC - sideCA) < double.Epsilon;
        }

        private static bool IsIsoscelesTriangle(double sideAB, double sideBC, double sideCA)
        {
            return (Math.Abs(sideAB - sideBC) < double.Epsilon) || (Math.Abs(sideBC - sideCA) < double.Epsilon) || (Math.Abs(sideCA - sideAB) < double.Epsilon);
        }

    }
}
