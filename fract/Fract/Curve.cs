using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fract
{
    /// <summary>
    /// Класс по отрисовке Кривой Коха.
    /// </summary>
    public class Curve : Fractal
    {
        public Curve()
        {

        }
        public override void Draw(Graphics gr)
        {
            DrawCurve(new PointF(WidthOfPanel / 2, 8 * HeightOfPanel / 5),
                    new PointF(0, 4 * HeightOfPanel / 5),
                    new PointF(WidthOfPanel, 4 * HeightOfPanel / 5),
                    IterationSteps, gr);
            // Вызов функции с одновременным получением точек.
        }
        public void DrawCurve(PointF firstPoint, PointF secondPoint, PointF thirdPoint, int count, Graphics gr)
        {
            if (count == IterationSteps)
            {
                gr.DrawLine(blackPen, secondPoint, thirdPoint);
                DrawCurve(secondPoint, thirdPoint, firstPoint, count - 1, gr);
            }
            else if (count > 0)
            {
                PointF fourthPoint = new PointF((secondPoint.X + 2 * firstPoint.X) / 3, (secondPoint.Y + 2 * firstPoint.Y) / 3);
                PointF fifthPoint = new PointF((2 * secondPoint.X + firstPoint.X) / 3, (firstPoint.Y + 2 * secondPoint.Y) / 3);
                PointF intermediatePoint = new PointF((secondPoint.X + firstPoint.X) / 2, (secondPoint.Y + firstPoint.Y) / 2);
                PointF centerPointOfTriangle = new PointF((4 * intermediatePoint.X - thirdPoint.X) / 3, (4 * intermediatePoint.Y - thirdPoint.Y) / 3);
                // Получение необходимых точек.

                gr.DrawLine(blackPen, fourthPoint, centerPointOfTriangle);
                gr.DrawLine(blackPen, fifthPoint, centerPointOfTriangle);
                gr.DrawLine(whitePen, fourthPoint, fifthPoint);
                // Отрисовка линий соответственно точкам.

                DrawCurve(fourthPoint, centerPointOfTriangle, fifthPoint, count - 1, gr);
                DrawCurve(centerPointOfTriangle, fifthPoint, fourthPoint, count - 1, gr);
                DrawCurve(firstPoint, fourthPoint, new PointF((2 * firstPoint.X + thirdPoint.X) / 3,
                    (2 * firstPoint.Y + thirdPoint.Y) / 3), count - 1, gr);
                DrawCurve(fifthPoint, secondPoint, new PointF((2 * secondPoint.X + thirdPoint.X) / 3,
                    (2 * secondPoint.Y + thirdPoint.Y) / 3), count - 1, gr);
                // Рекурсия.
            }
        }
    }
}
