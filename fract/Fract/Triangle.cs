using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fract
{
    /// <summary>
    /// Класс содержащий информацию о Треугольнике Серпинского.
    /// </summary>
    public class Triangle : Fractal
    {
        public Triangle()
        {

        }
        public override void Draw(Graphics NewGraphics)
        {
            PointF triangleTop = new PointF(WidthOfPanel / 2, 0);
            PointF TriangleLeftPoint = new PointF(0, HeightOfPanel);
            PointF TriangleRightPoint = new PointF(WidthOfPanel, HeightOfPanel);
            // Координаты вершин треугольника.
            DrawTriangle(triangleTop, TriangleLeftPoint, TriangleRightPoint, 0, NewGraphics);
        }
        public void DrawTriangle(PointF triangleTop, PointF TriangleLeftPoint, PointF TriangleRightPoint, int count, Graphics NewGraphics)
        {
            if (count != IterationSteps)
            {
                PointF middleLeftSide = new PointF((triangleTop.X + TriangleLeftPoint.X) / 2F, (triangleTop.Y + TriangleLeftPoint.Y) / 2F);
                PointF middleRightSide = new PointF((triangleTop.X + TriangleRightPoint.X) / 2F, (triangleTop.Y + TriangleRightPoint.Y) / 2F);
                PointF middleTopSide = new PointF((TriangleLeftPoint.X + TriangleRightPoint.X) / 2F, (TriangleLeftPoint.Y + TriangleRightPoint.Y) / 2F);
                // Координаты середин отрезков.

                count++;

                DrawTriangle(triangleTop, middleLeftSide, middleRightSide, count, NewGraphics);
                DrawTriangle(middleLeftSide, TriangleLeftPoint, middleTopSide, count, NewGraphics);
                DrawTriangle(middleRightSide, middleTopSide, TriangleRightPoint, count, NewGraphics);
                // Рекурсивные вызовы метода для отрисовки.
            }
            else
            {
                PointF[] pointsArray = { triangleTop, TriangleRightPoint, TriangleLeftPoint };
                NewGraphics.FillPolygon(Brushes.Black, pointsArray);
                // Отрисовка треугольника.
            }
        }
    }
}
