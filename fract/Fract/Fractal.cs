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
    /// Основной класс, который содержит данные необходимые для всех типов фракталов.
    /// </summary>
    public class Fractal
    {
        public Pen blackPen = new Pen(Color.Black, 1);
        public Pen whitePen = new Pen(Color.AntiqueWhite, 1);
        // Инструменты для отрисовки линий.
        public static int IterationSteps { get; set; }
        // Присваивание и последующее использование переменной в производных классах.
        public static int WidthOfPanel { get; set; }
        public static int HeightOfPanel { get; set; }
        public virtual void Draw(Graphics NewGraphics)
            // Переопределяемый метод отрисовки.
        {
            
        }
    }
}
