namespace Fract
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawTree = new System.Windows.Forms.Button();
            this.Coefficient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondAngle = new System.Windows.Forms.TextBox();
            this.StartDraw = new System.Windows.Forms.Button();
            this.CheckNum = new System.Windows.Forms.Button();
            this.CheckAngle = new System.Windows.Forms.Button();
            this.CheckSecondAngle = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.EnterSteps = new System.Windows.Forms.Label();
            this.Iteration = new System.Windows.Forms.ListBox();
            this.CochCurve = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Carpet = new System.Windows.Forms.Button();
            this.Set = new System.Windows.Forms.Button();
            this.SetDistance = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.TextBox();
            this.CheckDistance = new System.Windows.Forms.Button();
            this.DrawSet = new System.Windows.Forms.Button();
            this.ViewRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawTree
            // 
            this.DrawTree.BackColor = System.Drawing.Color.Azure;
            this.DrawTree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DrawTree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DrawTree.Location = new System.Drawing.Point(50, 12);
            this.DrawTree.Name = "DrawTree";
            this.DrawTree.Size = new System.Drawing.Size(216, 43);
            this.DrawTree.TabIndex = 0;
            this.DrawTree.Text = "ДЕРЕВО\r\n";
            this.DrawTree.UseVisualStyleBackColor = false;
            this.DrawTree.Click += new System.EventHandler(this.DrawTree_Click);
            // 
            // Coefficient
            // 
            this.Coefficient.Location = new System.Drawing.Point(182, 61);
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Size = new System.Drawing.Size(84, 31);
            this.Coefficient.TabIndex = 2;
            this.Coefficient.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Коэффициент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "1) Угол наклона:";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(182, 98);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(84, 31);
            this.Angle.TabIndex = 5;
            this.Angle.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "2) Угол наклона:";
            // 
            // SecondAngle
            // 
            this.SecondAngle.Location = new System.Drawing.Point(182, 136);
            this.SecondAngle.Name = "SecondAngle";
            this.SecondAngle.Size = new System.Drawing.Size(84, 31);
            this.SecondAngle.TabIndex = 7;
            this.SecondAngle.Visible = false;
            // 
            // StartDraw
            // 
            this.StartDraw.BackColor = System.Drawing.Color.Coral;
            this.StartDraw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartDraw.Location = new System.Drawing.Point(86, 186);
            this.StartDraw.Name = "StartDraw";
            this.StartDraw.Size = new System.Drawing.Size(148, 34);
            this.StartDraw.TabIndex = 8;
            this.StartDraw.Text = "Нарисовать!";
            this.StartDraw.UseVisualStyleBackColor = false;
            this.StartDraw.Visible = false;
            this.StartDraw.Click += new System.EventHandler(this.StartDraw_Click);
            // 
            // CheckNum
            // 
            this.CheckNum.BackColor = System.Drawing.Color.Red;
            this.CheckNum.Location = new System.Drawing.Point(272, 61);
            this.CheckNum.Name = "CheckNum";
            this.CheckNum.Size = new System.Drawing.Size(30, 31);
            this.CheckNum.TabIndex = 9;
            this.CheckNum.Text = "✓";
            this.CheckNum.UseVisualStyleBackColor = false;
            this.CheckNum.Visible = false;
            this.CheckNum.Click += new System.EventHandler(this.CheckNum_Click);
            // 
            // CheckAngle
            // 
            this.CheckAngle.BackColor = System.Drawing.Color.Red;
            this.CheckAngle.Location = new System.Drawing.Point(272, 98);
            this.CheckAngle.Name = "CheckAngle";
            this.CheckAngle.Size = new System.Drawing.Size(30, 31);
            this.CheckAngle.TabIndex = 9;
            this.CheckAngle.Text = "✓";
            this.CheckAngle.UseVisualStyleBackColor = false;
            this.CheckAngle.Visible = false;
            this.CheckAngle.Click += new System.EventHandler(this.CheckAngle_Click);
            // 
            // CheckSecondAngle
            // 
            this.CheckSecondAngle.BackColor = System.Drawing.Color.Red;
            this.CheckSecondAngle.Location = new System.Drawing.Point(272, 135);
            this.CheckSecondAngle.Name = "CheckSecondAngle";
            this.CheckSecondAngle.Size = new System.Drawing.Size(30, 32);
            this.CheckSecondAngle.TabIndex = 9;
            this.CheckSecondAngle.Text = "✓";
            this.CheckSecondAngle.UseVisualStyleBackColor = false;
            this.CheckSecondAngle.Visible = false;
            this.CheckSecondAngle.Click += new System.EventHandler(this.CheckSecondAngle_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.AutoScroll = true;
            this.DrawPanel.AutoSize = true;
            this.DrawPanel.BackColor = System.Drawing.Color.Coral;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawPanel.Location = new System.Drawing.Point(323, 25);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(1401, 746);
            this.DrawPanel.TabIndex = 10;
            // 
            // EnterSteps
            // 
            this.EnterSteps.AutoSize = true;
            this.EnterSteps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterSteps.Location = new System.Drawing.Point(22, 739);
            this.EnterSteps.Name = "EnterSteps";
            this.EnterSteps.Size = new System.Drawing.Size(280, 32);
            this.EnterSteps.TabIndex = 0;
            this.EnterSteps.Text = "Количество итераций:";
            // 
            // Iteration
            // 
            this.Iteration.FormattingEnabled = true;
            this.Iteration.ItemHeight = 25;
            this.Iteration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.Iteration.Location = new System.Drawing.Point(50, 797);
            this.Iteration.Name = "Iteration";
            this.Iteration.Size = new System.Drawing.Size(216, 29);
            this.Iteration.TabIndex = 12;
            this.Iteration.SelectedIndexChanged += new System.EventHandler(this.Iteration_SelectedIndexChanged);
            // 
            // CochCurve
            // 
            this.CochCurve.BackColor = System.Drawing.Color.Azure;
            this.CochCurve.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CochCurve.Location = new System.Drawing.Point(50, 256);
            this.CochCurve.Name = "CochCurve";
            this.CochCurve.Size = new System.Drawing.Size(216, 45);
            this.CochCurve.TabIndex = 0;
            this.CochCurve.Text = "Кривая Коха";
            this.CochCurve.UseVisualStyleBackColor = false;
            this.CochCurve.Click += new System.EventHandler(this.CochCurve_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.Azure;
            this.Triangle.Location = new System.Drawing.Point(50, 335);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(216, 66);
            this.Triangle.TabIndex = 13;
            this.Triangle.Text = "Треугольник Серпинского";
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Carpet
            // 
            this.Carpet.BackColor = System.Drawing.Color.Azure;
            this.Carpet.Location = new System.Drawing.Point(50, 436);
            this.Carpet.Name = "Carpet";
            this.Carpet.Size = new System.Drawing.Size(216, 50);
            this.Carpet.TabIndex = 14;
            this.Carpet.Text = "Ковер Серпинского";
            this.Carpet.UseVisualStyleBackColor = false;
            this.Carpet.Click += new System.EventHandler(this.Carpet_Click);
            // 
            // Set
            // 
            this.Set.BackColor = System.Drawing.Color.Azure;
            this.Set.Location = new System.Drawing.Point(50, 521);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(216, 47);
            this.Set.TabIndex = 15;
            this.Set.Text = "Множество Кантора";
            this.Set.UseVisualStyleBackColor = false;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // SetDistance
            // 
            this.SetDistance.AutoSize = true;
            this.SetDistance.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SetDistance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetDistance.Location = new System.Drawing.Point(12, 586);
            this.SetDistance.Name = "SetDistance";
            this.SetDistance.Size = new System.Drawing.Size(295, 25);
            this.SetDistance.TabIndex = 6;
            this.SetDistance.Text = "Расстояние между итерациями:";
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(102, 625);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(84, 31);
            this.Distance.TabIndex = 7;
            this.Distance.Visible = false;
            // 
            // CheckDistance
            // 
            this.CheckDistance.BackColor = System.Drawing.Color.Red;
            this.CheckDistance.Location = new System.Drawing.Point(192, 624);
            this.CheckDistance.Name = "CheckDistance";
            this.CheckDistance.Size = new System.Drawing.Size(30, 32);
            this.CheckDistance.TabIndex = 9;
            this.CheckDistance.Text = "✓";
            this.CheckDistance.UseVisualStyleBackColor = false;
            this.CheckDistance.Visible = false;
            this.CheckDistance.Click += new System.EventHandler(this.CheckDistance_Click);
            // 
            // DrawSet
            // 
            this.DrawSet.BackColor = System.Drawing.Color.Coral;
            this.DrawSet.Location = new System.Drawing.Point(86, 678);
            this.DrawSet.Name = "DrawSet";
            this.DrawSet.Size = new System.Drawing.Size(148, 34);
            this.DrawSet.TabIndex = 16;
            this.DrawSet.Text = "Нарисовать!";
            this.DrawSet.UseVisualStyleBackColor = false;
            this.DrawSet.Visible = false;
            this.DrawSet.Click += new System.EventHandler(this.DrawSet_Click);
            // 
            // ViewRules
            // 
            this.ViewRules.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ViewRules.Location = new System.Drawing.Point(86, 863);
            this.ViewRules.Name = "ViewRules";
            this.ViewRules.Size = new System.Drawing.Size(148, 82);
            this.ViewRules.TabIndex = 17;
            this.ViewRules.Text = "ПРАВИЛА РАБОТЫ";
            this.ViewRules.UseVisualStyleBackColor = false;
            this.ViewRules.Click += new System.EventHandler(this.ViewRules_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1827, 1050);
            this.Controls.Add(this.ViewRules);
            this.Controls.Add(this.DrawSet);
            this.Controls.Add(this.CheckDistance);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.SetDistance);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.Carpet);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.CochCurve);
            this.Controls.Add(this.Iteration);
            this.Controls.Add(this.EnterSteps);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.CheckSecondAngle);
            this.Controls.Add(this.CheckAngle);
            this.Controls.Add(this.CheckNum);
            this.Controls.Add(this.StartDraw);
            this.Controls.Add(this.SecondAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coefficient);
            this.Controls.Add(this.DrawTree);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Угол наклона:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawTree;
        private System.Windows.Forms.TextBox Coefficient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecondAngle;
        private System.Windows.Forms.Button StartDraw;
        private System.Windows.Forms.Button CheckNum;
        private System.Windows.Forms.Button CheckAngle;
        private System.Windows.Forms.Button CheckSecondAngle;
        public System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Label EnterSteps;
        private System.Windows.Forms.ListBox Iteration;
        private System.Windows.Forms.Button CochCurve;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Carpet;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Label SetDistance;
        private System.Windows.Forms.TextBox Distance;
        private System.Windows.Forms.Button CheckDistance;
        private System.Windows.Forms.Button DrawSet;
        private System.Windows.Forms.Button ViewRules;
    }
}

