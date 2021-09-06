using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fract
{
    /// <summary>
    /// Класс по отрисовке фрактального дерева.
    /// </summary>
    class FractalTree : Fractal
    {
        public int Length = 250;
        public int TheFirstAngle { get; set; }
        public int TheSecondAngle { get; set; }
        public double CoefficientOfLength { get; set; }
        public FractalTree()
        {

        }
        public override void Draw(Graphics NewGraphics)
        {
            PointF firstPoint = new PointF(WidthOfPanel / 2, 0);
            // Получение начальной точки.
            DrawFractalTree(firstPoint, Length, 0, 0, NewGraphics);
        }
        public void DrawFractalTree(PointF firstPoint, int length, int angle, int count, Graphics NewGraphics)
        {
            float x1 = (float)(firstPoint.X + length * Math.Sin(angle * Math.PI * 2 / 360.0));
            float y1 = (float)(firstPoint.Y + length * Math.Cos(angle * Math.PI * 2 / 360.0));
            
            PointF secondPoint = new PointF(x1, y1);
            NewGraphics.DrawLine(blackPen, firstPoint.X, HeightOfPanel - firstPoint.Y, x1, HeightOfPanel - y1);
            // Отрисовка отрезков по точкам.

            count++;
            if (count < IterationSteps)
                // Выполнение рекурсии до того как счетчик станет равен числу шагов.
            {
                DrawFractalTree(secondPoint, (int)(length / CoefficientOfLength), angle + TheFirstAngle, count, NewGraphics);
                DrawFractalTree(secondPoint, (int)(length / CoefficientOfLength), angle - TheSecondAngle, count, NewGraphics);
            }
        }
    }
}
