using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fig1;
using Fig2;
using Fig4;
using Fig5;




namespace Fig13
{
    public class TriangleBuilder
    {
        private Point pointA;
        private Point pointB;
        private Point pointC;
        private LineType lineType;
        private FillColor fillColor;

        public TriangleBuilder SetPointA(Point point)
        {
            pointA = point;
            return this;
        }

        public TriangleBuilder SetPointB(Point point)
        {
            pointB = point;
            return this;
        }

        public TriangleBuilder SetPointC(Point point)
        {
            pointC = point;
            return this;
        }

        public TriangleBuilder SetLineType(LineType type)
        {
            lineType = type;
            return this;
        }

        public TriangleBuilder SetFillColor(FillColor color)
        {
            fillColor = color;
            return this;
        }

        public Triangle CreateTriangle()
        {
            if (pointA == null || pointB == null || pointC == null)
                throw new InvalidOperationException("Three points must be set to create a triangle.");

            Triangle triangle = new Triangle(pointA, pointB, pointC, lineType, fillColor);
            Reset();
            return triangle;
        }

        private void Reset()
        {
            pointA = null;
            pointB = null;
            pointC = null;
            lineType = LineType.Solid;
            fillColor = FillColor.Red;
        }
    }
}
