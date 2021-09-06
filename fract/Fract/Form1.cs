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
    public partial class Form1 : Form
    {
        public static Graphics NewGraphics;
        // Создание графики для отрисовки на панели.
        FractalTree tree = new FractalTree();
        Triangle triangle = new Triangle();
        Carpet carpet1 = new Carpet();
        SetOfCantor set = new SetOfCantor();
        Curve curveCoch = new Curve();
        // Создание объектов каждого класса для работы с данными.
        /// <summary>
        /// Метод инициализации компонентов формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод прогрузки компонетов формы и данных.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            DrawPanel.Height = Size.Height - 200;
            DrawPanel.Width = Size.Width - 450;
            Fractal.WidthOfPanel = DrawPanel.Width;
            Fractal.HeightOfPanel = DrawPanel.Height;
            NewGraphics = DrawPanel.CreateGraphics();
            // Создание графики в панеле.
            MessageBox.Show("                                                  ПРИВЕТ!" + Environment.NewLine
                + Environment.NewLine +
                "Это программа для отрисовки фракталов. На выбор предоставляется пять видов фракталов:" + Environment.NewLine +
                "1) Фрактальное дерево(Кнопка\"ДЕРЕВО\"). Для отрисовки этого фрактала вам предстоит ввести коэффициент, определяющий отношение между отрезками разных итераций,"
                + Environment.NewLine + "и углы наклона отрезков.ВАЖНО!! Не забудьте выбрать количество итераций в соответствующем списке" + Environment.NewLine +
                "2) Кривая Коха. Для отрисовки этого фрактала вам нужно выбрать только количество итераций. Для данного фрактала количество ограничено до 9(включительно)"
                + Environment.NewLine +
                "3) Треугольник Серпинского. Для отрисовки этого фрактала вам нужно выбрать только количество итераций. Для данного фрактала количество ограничено до 10(включительно)"
                + Environment.NewLine +
                "4) Ковер Серпинского. Для отрисовки этого фрактала вам также нужно выбрать только количество итераций. Для данного фрактала количество ограничено до 10(включительно)"
                + Environment.NewLine +
                "5) Множество Кантора. Для отрисовки этого фрактала вам предоставляется выбор расстояния между отрезками разных итераций." +
                " Ввод расстояния ограниичен до 300 пикселей. Также НЕ ЗАБУДЬТЕ выбрать количество итераций (Выбор ограничен до 8 итераций включительно). Для того, чтобы  все итерации" +
                "вместились на панель, советую выбирать расстояние до 100 пикселей."
                + Environment.NewLine + "                                            КНОПКИ:" + Environment.NewLine +
                "1) Основные: Большие кнопки для выбора типа фракталов." + Environment.NewLine +
                "2) Красные кнопки с \"галочкой\". Это кнопки для проверки введенных значений. После изменения данных их нужно снова нажимать для повторной проверки и дальнейшей корректной работы."
                + Environment.NewLine + "3) Кнопки \"Нарисовать!\". Это кнопки для отрисовки фракталов, для которых требовался ввод пользовательских данных."
                + Environment.NewLine + "4) Список \"Количество итераций\". Для выбора количества нужно скроллить список и нажимать на выбранное число, иначе значение не будет выбрано.");
        }
        /// <summary>
        /// Керпка для начала отрисовки фрактального дерева.
        /// </summary>
        private void StartDraw_Click(object sender, EventArgs e)
        {
            if (Fractal.IterationSteps != 0)
            {
                NewGraphics.Clear(BackColor);
                // Очистка панели от прошлых отрисовок.
                tree.Draw(NewGraphics);
                // Вызов отрисовки.
            }
            else
            {
                MessageBox.Show("Вы не выбрали число итераций! Для продолжения выберите число в соответствующем списке.");
            }
        }
        /// <summary>
        /// Проверка введенного значения коэффициента.
        /// </summary>
        /// <returns>Возвращает верный ввод или нет(True или False)</returns>
        public bool CheckNums()
        {
            bool temp = false;
            double num;
            if (double.TryParse(Coefficient.Text, out num) && num > 1 && num < 2.1)
            {
                tree.CoefficientOfLength = num;
                temp = true;
            }
            else
            {
                MessageBox.Show("Неверно введено значение коэффициента! Повторите ввод снова.");
            }
            return temp;
        }
        /// <summary>
        /// Проверка введенного значения и присвоение значение первому углу.
        /// </summary>
        /// <returns>Верность ввода(True или False)</returns>
        public bool CheckTheFirstAngle()
        {
            bool temp = false;
            int angNum;
            if (int.TryParse(Angle.Text, out angNum) && angNum > 0 && angNum < 180)
            {
                tree.TheFirstAngle = angNum;
                temp = true;
            }
            else
            {
                MessageBox.Show("Неверно введено значение угла! Повторите ввод снова.");
            }
            return temp;
        }
        /// <summary>
        /// Проверка введенного значения и присвоение значение второму углу.
        /// </summary>
        /// <returns>Верность ввода(True или False)</returns>
        public bool CheckTheSecondAngle()
        {
            bool temp = false;
            int secAngNum;
            if (int.TryParse(SecondAngle.Text, out secAngNum) && secAngNum > 0 && secAngNum < 180)
            {
                tree.TheSecondAngle = secAngNum;
                temp = true;
            }
            else
            {
                MessageBox.Show("Неверно введено значение угла! Повторите ввод снова.");
            }
            return temp;
        }
        /// <summary>
        /// Кнопка для открытия доступа с переменными фрактального дерева.
        /// </summary>
        private void DrawTree_Click(object sender, EventArgs e)
        {
            Coefficient.Visible = true;
            CheckNum.Visible = true;
            // Появление кнопок на панели после выбора нужного фрактала.
        }
        /// <summary>
        /// Кнопка, вызывающая проверку введенного коэффициента.
        /// </summary>
        private void CheckNum_Click(object sender, EventArgs e)
        {
            if (CheckNums() == true)
                // Если проверка успешно выполнена открывается доступ для ввода остальных данных.
            {
                Angle.Visible = true;
                CheckAngle.Visible = true;
            }
        }
        /// <summary>
        ///  Кнопка, вызывающая проверку введенного значения первого угла.
        /// </summary>
        private void CheckAngle_Click(object sender, EventArgs e)
        {
            if (CheckTheFirstAngle() == true)
            {
                SecondAngle.Visible = true;
                CheckSecondAngle.Visible = true;
            }
        }
        /// <summary>
        /// Кнопка, вызывающая проверку введенного значения второго угла.
        /// </summary>
        private void CheckSecondAngle_Click(object sender, EventArgs e)
        {
            if (CheckTheSecondAngle() == true)
                // Если все данные успешно прошли проверку появляется кнопка отрисовки фрактала.
            {
                StartDraw.Visible = true;
            }
        }
        /// <summary>
        /// Получение от пользователя количества итераций.
        /// </summary>
        private void Iteration_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fractal.IterationSteps = Iteration.SelectedIndex + 1;
            // Получение количества итераций.
        }
        /// <summary>
        ///Кнопка вызова отрисовки Кривой Коха.
        /// </summary>
        private void CochCurve_Click(object sender, EventArgs e)
        {
            if (Fractal.IterationSteps != 0)
            {
                if (Fractal.IterationSteps < 10)
                    // Если данные соответствуют обоим условиям выполняется отрисовка выбранного фрактала.
                {
                    NewGraphics.Clear(BackColor);
                    curveCoch.Draw(NewGraphics);
                }
                else
                {
                    MessageBox.Show("Для быстрой и понятной отрисовки количество итераций для этого фрактала было ограничено до 9.");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали количество итераций! После выбора снова нажмите на кнопку, соответствующую выбранному фракталу.");
            }
        }
        /// <summary>
        /// Кнопка отрисовки Треугольника Серпинского.
        /// </summary>
        private void Triangle_Click(object sender, EventArgs e)
        {
            if (Fractal.IterationSteps != 0)
            {
                if (Fractal.IterationSteps < 11)
                {
                    NewGraphics.Clear(BackColor);
                    triangle.Draw(NewGraphics);
                }
                else
                {
                    MessageBox.Show("Для быстрой и понятной отрисовки количество итераций для этого фрактала было ограничено до 10.");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали количество итераций! После выбора снова нажмите на кнопку, соответствующую выбранному фракталу.");
            }
        }
        /// <summary>
        /// Кнопка отписовки Множества Кантора.
        /// </summary>
        private void Set_Click(object sender, EventArgs e)
        {
            Distance.Visible = true;
            CheckDistance.Visible = true;
            // При нажатии кнопки открывается доступ для ввода пользовательских данных.
        }
        /// <summary>
        /// Проверка введенного значения расстояние между отрезками разных итераций в Множестве Кантора.
        /// </summary>
        /// <returns>Верность ввода</returns>
        public bool CheckDistanceNum()
        {
            int tempNum;
            bool temp = false;
            if (int.TryParse(Distance.Text, out tempNum) && tempNum > 0 && tempNum < 300)
                // Проверка введенного расстояния и присваивание полю соответствующего класса фрактала.
            {
                set.DistanceOfIteration = tempNum;
                temp = true;
            }
            else
            {
                MessageBox.Show("Вы неверно ввели расстояние между отрисовками итераций! Введите число еще раз.");
            }
            return temp;
        }
        /// <summary>
        /// Кнопка отрисовки Множества Кантора.
        /// </summary>
        private void DrawSet_Click(object sender, EventArgs e)
        {
            if (Fractal.IterationSteps != 0)
            {
                if (Fractal.IterationSteps < 9)
                {
                    NewGraphics.Clear(BackColor);
                    set.Draw(NewGraphics);
                }
                else
                {
                    MessageBox.Show("Для быстрой и понятной отрисовки количество итераций для этого фрактала было ограничено до 8.");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали количество итераций! После выбора снова нажмите на кнопку, соответствующую выбранному фракталу.");
            }
        }
        /// <summary>
        /// Кнопка вызова проверки введенного значения расстояния.
        /// </summary>
        private void CheckDistance_Click(object sender, EventArgs e)
        {
            if (CheckDistanceNum() == true)
            {
                DrawSet.Visible = true;
            }
        }
        /// <summary>
        /// Кнопка отрисовки Ковра Серпинского.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Carpet_Click(object sender, EventArgs e)
        {
            if (Fractal.IterationSteps != 0)
            {
                if (Fractal.IterationSteps < 11)
                {
                    NewGraphics.Clear(BackColor);
                    carpet1.Draw(NewGraphics);
                }
                else
                {
                    MessageBox.Show("Для быстрой и понятной отрисовки количество итераций для этого фрактала было ограничено до 10.");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали количество итераций! После выбора снова нажмите на кнопку, соответствующую выбранному фракталу.");
            }
        }
        /// <summary>
        /// Кнопка для вывода правил работы с программой в МessageBox.
        /// </summary>
        private void ViewRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                                  ПРИВЕТ!"+Environment.NewLine 
                + Environment.NewLine +
                "Это программа для отрисовки фракталов. На выбор предоставляется пять видов фракталов:" + Environment.NewLine +
                "1) Фрактальное дерево(Кнопка\"ДЕРЕВО\"). Для отрисовки этого фрактала вам предстоит ввести коэффициент, определяющий отношение между отрезками разных итераций(Ограниченно от 1 до 2)," 
                + Environment.NewLine + "и углы наклона отрезков(Ограниченно от 0 до 180).ВАЖНО!! Не забудьте выбрать количество итераций в соответствующем списке" + Environment.NewLine +
                "2) Кривая Коха. Для отрисовки этого фрактала вам нужно выбрать только количество итераций. Для данного фрактала количество ограничено до 9(включительно)"
                + Environment.NewLine +
                "3) Треугольник Серпинского. Для отрисовки этого фрактала вам нужно выбрать только количество итераций. Для данного фрактала количество ограничено до 10(включительно)" 
                + Environment.NewLine +
                "4) Ковер Серпинского. Для отрисовки этого фрактала вам также нужно выбрать только количество итераций. Для данного фрактала количество ограничено до 10(включительно)"
                + Environment.NewLine +
                "5) Множество Кантора. Для отрисовки этого фрактала вам предоставляется выбор расстояния между отрезками разных итераций." + Environment.NewLine + 
                " Ввод расстояния ограниичен до 300 пикселей. Также НЕ ЗАБУДЬТЕ выбрать количество итераций(Выбор ограничен до 8 итераций включительно)"
                + Environment.NewLine +"                                            КНОПКИ:" + Environment.NewLine +
                "1) Основные: Большие кнопки для выбора типа фракталов." + Environment.NewLine +
                "2) Красные кнопки с \"галочкой\". Это кнопки для проверки введенных значений. После изменения данных их нужно снова нажимать для повторной проверки и дальнейшей корректной работы."
                + Environment.NewLine +"3) Кнопки \"Нарисовать!\". Это кнопки для отрисовки фракталов, для которых требовался ввод пользовательских данных."
                + Environment.NewLine +"4) Список \"Количество итераций\". Для выбора количества нужно скроллить список и нажимать на выбранное число, иначе значение не будет выбрано.");
        }
    }
}
