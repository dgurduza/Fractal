using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fract
{
    /// <summary>
    /// Класс по отрисовке Множества Кантора.
    /// </summary>
    class SetOfCantor : Fractal
    {
        public int DistanceOfIteration { get; set; }
        public SetOfCantor()
        {

        }
        public override void Draw(Graphics gr)
        {
            PointF firstPointOfSet = new PointF(100, 50);
            PointF secondPointOfSet = new PointF(WidthOfPanel - 100, 50);
            DrawSetOfCantor(firstPointOfSet, secondPointOfSet, 0, gr);
        }
        public void DrawSetOfCantor(PointF firstPointOfSet, PointF secondPointOfSet, int count, Graphics gr)
        {
            gr.DrawLine(new Pen(Color.Black, 7F), firstPointOfSet, secondPointOfSet);

            PointF thirdPoint = new PointF(firstPointOfSet.X + (secondPointOfSet.X - firstPointOfSet.X) / 3, firstPointOfSet.Y + DistanceOfIteration);
            PointF fourthPoint = new PointF(secondPointOfSet.X - (secondPointOfSet.X - firstPointOfSet.X) / 3, secondPointOfSet.Y + DistanceOfIteration);

            firstPointOfSet.Y += DistanceOfIteration;
            secondPointOfSet.Y += DistanceOfIteration;
            count++;

            if (count < IterationSteps)
            {
                DrawSetOfCantor(firstPointOfSet, thirdPoint, count, gr);
                DrawSetOfCantor(fourthPoint, secondPointOfSet, count, gr);
            }
        }
    }
}
