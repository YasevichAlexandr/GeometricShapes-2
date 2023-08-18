using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fig1;
using Fig2;
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



public class Program
{
    public static void Main(string[] args)
    {

        TriangleBuilder builder = new TriangleBuilder();
        Triangle triangle1 = builder.SetPointA(new Point(3,0)).SetPointB(new Point(0,0)).SetPointC(new Point(0,4)).SetLineType(LineType.Dashed).SetFillColor(FillColor.Red).CreateTriangle();
        Triangle triangle2 = builder.SetPointA(new Point(0, 0)).SetPointB(new Point(1, 0)).SetPointC(new Point(0.5, Math.Sqrt(3) / 2)).SetLineType(LineType.Dotted).SetFillColor(FillColor.Yellow).CreateTriangle();
        Triangle triangle3 = builder.SetPointA(new Point(0, 0)).SetPointB(new Point(4, 0)).SetPointC(new Point(2, 23)).SetLineType(LineType.Solid).SetFillColor(FillColor.Blue).CreateTriangle();
        /*Triangle[] triangles = new Triangle[]
        {
            new Triangle(new Point(3, 0), new Point(0, 0), new Point(0, 4), LineType.Dashed, FillColor.Green),
            new Triangle(new Point(0, 0), new Point(1, 0), new Point(0.5, Math.Sqrt(3) / 2), LineType.Dotted, FillColor.Yellow),
            new Triangle(new Point(0, 0), new Point(4, 0), new Point(2, 3), LineType.Dotted, FillColor.Yellow),
            new Triangle(new Point(0, 0), new Point(3, 0), new Point(1, 4), LineType.Solid, FillColor.Blue)
        };*/

        double totalTrArea = triangle1.CalculateArea() + triangle2.CalculateArea() + triangle3.CalculateArea();

        Rectangle rectangle = new Rectangle()
        {
            LineType = LineType.Solid,
            FillColor = FillColor.Yellow,
            TopLeft = new Point(1, 1),
            Width = 5,
            Height = 3
        };

        Circle circle = new Circle()
        {
            LineType = LineType.Dashed,
            FillColor = FillColor.Red,
            Center = new Point(3, 3),
            Radius = 2
        };

        //double totalTrianglesArea = CalculateTotalTrianglesArea(triangles);
        double rectangleArea = rectangle.CalculateArea();
        double circleArea = circle.CalculateArea();

        double TotalArea = totalTrArea + rectangleArea + circleArea;

        Console.WriteLine("Total Area: " + TotalArea);

        Console.ReadLine();
    }
    /*static double CalculateTotalTrianglesArea(Triangle[] triangles)
    {
        double totalTrianglesArea = 0;

        foreach (Triangle triangle in triangles)
        {
            totalTrianglesArea += triangle.CalculateArea();
        }

        return totalTrianglesArea;
    }*/
}
