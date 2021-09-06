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
    /// Класс по отрисовке Ковра Серпинского.
    /// </summary>
    public class Carpet : Fractal
        // Производный класс для отрисовки Ковра Серпинского.
    {
        public Carpet()
            // Конструктор для объявления переменной в форме.
        {

        }
        public override void Draw(Graphics NewGraphics)
            // Переопределенный метод отрисовки фрактала.
        {
            RectangleF sierpinskiCarpet = new RectangleF(0, 0, WidthOfPanel, HeightOfPanel);
            DrawCarpet(sierpinskiCarpet, 0, NewGraphics);
        }
        public void DrawCarpet(RectangleF sierpinskiCarpet, int count, Graphics NewGraphics)
        {
            if (count == IterationSteps)
            {
                NewGraphics.FillRectangle(Brushes.Black, sierpinskiCarpet);
                // Отрисовка квадрата на панель.
            }
            else
            {
                float width = sierpinskiCarpet.Width / 3;
                float height = sierpinskiCarpet.Height / 3;

                float x1 = sierpinskiCarpet.Left;
                float y1 = sierpinskiCarpet.Top;

                float x2 = x1 + width;
                float y2 = y1 + height;

                float x3 = x1 + 2f * width;
                float y3 = y1 + 2f * height;

                count++;
                // Счетчик для ограничения вызовов.

                RectangleF firstRect = new RectangleF(x1, y1, width, height);
                RectangleF secondRect = new RectangleF(x2, y1, width, height);
                RectangleF thirdRect = new RectangleF(x3, y1, width, height);
                RectangleF fourthRect = new RectangleF(x1, y2, width, height);
                RectangleF fifthRect = new RectangleF(x3, y2, width, height);
                RectangleF sixthRect = new RectangleF(x1, y3, width, height);
                RectangleF seventhRect = new RectangleF(x2, y3, width, height);
                RectangleF eighthRect = new RectangleF(x3, y3, width, height);

                DrawCarpet(firstRect, count, NewGraphics);
                DrawCarpet(secondRect, count, NewGraphics);
                DrawCarpet(thirdRect, count, NewGraphics);
                DrawCarpet(fourthRect, count, NewGraphics);
                DrawCarpet(fifthRect, count, NewGraphics);
                DrawCarpet(sixthRect, count, NewGraphics);
                DrawCarpet(seventhRect, count, NewGraphics);
                DrawCarpet(eighthRect, count, NewGraphics);
                // Рекурсия для отрисовки фрактала.
            }
        }
    }
}
