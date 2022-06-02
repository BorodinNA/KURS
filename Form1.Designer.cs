
namespace KURS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.function = new System.Windows.Forms.TextBox();
            this.X0 = new System.Windows.Forms.TextBox();
            this.epsilon = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.number_point = new System.Windows.Forms.TextBox();
            this.left_border = new System.Windows.Forms.TextBox();
            this.right_border = new System.Windows.Forms.TextBox();
            this.legend = new System.Windows.Forms.TextBox();
            this.Xname = new System.Windows.Forms.TextBox();
            this.Yname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.function_chart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Функция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ε";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(3, 32);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(100, 20);
            this.function.TabIndex = 4;
            this.function.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.function_KeyPress);
            // 
            // X0
            // 
            this.X0.Location = new System.Drawing.Point(109, 32);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(38, 20);
            this.X0.TabIndex = 5;
            this.X0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X0_KeyPress);
            // 
            // epsilon
            // 
            this.epsilon.Location = new System.Drawing.Point(153, 32);
            this.epsilon.Name = "epsilon";
            this.epsilon.Size = new System.Drawing.Size(38, 20);
            this.epsilon.TabIndex = 6;
            this.epsilon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epsilon_KeyPress);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(59, 70);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 20);
            this.answer.TabIndex = 7;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 96);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(559, 343);
            this.zedGraphControl1.TabIndex = 8;
            // 
            // number_point
            // 
            this.number_point.Location = new System.Drawing.Point(6, 19);
            this.number_point.Name = "number_point";
            this.number_point.Size = new System.Drawing.Size(100, 20);
            this.number_point.TabIndex = 9;
            this.number_point.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_point_KeyPress);
            // 
            // left_border
            // 
            this.left_border.Location = new System.Drawing.Point(6, 45);
            this.left_border.Name = "left_border";
            this.left_border.Size = new System.Drawing.Size(100, 20);
            this.left_border.TabIndex = 10;
            this.left_border.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.left_border_KeyPress);
            // 
            // right_border
            // 
            this.right_border.Location = new System.Drawing.Point(6, 71);
            this.right_border.Name = "right_border";
            this.right_border.Size = new System.Drawing.Size(100, 20);
            this.right_border.TabIndex = 11;
            this.right_border.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.right_border_KeyPress);
            // 
            // legend
            // 
            this.legend.Location = new System.Drawing.Point(6, 13);
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(100, 20);
            this.legend.TabIndex = 12;
            // 
            // Xname
            // 
            this.Xname.Location = new System.Drawing.Point(6, 39);
            this.Xname.Name = "Xname";
            this.Xname.Size = new System.Drawing.Size(100, 20);
            this.Xname.TabIndex = 13;
            this.Xname.Text = "Х";
            // 
            // Yname
            // 
            this.Yname.Location = new System.Drawing.Point(6, 65);
            this.Yname.Name = "Yname";
            this.Yname.Size = new System.Drawing.Size(100, 20);
            this.Yname.TabIndex = 14;
            this.Yname.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.number_point);
            this.groupBox1.Controls.Add(this.left_border);
            this.groupBox1.Controls.Add(this.right_border);
            this.groupBox1.Location = new System.Drawing.Point(568, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 101);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Правая граница";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Левая граница";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество точек";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.legend);
            this.groupBox2.Controls.Add(this.Xname);
            this.groupBox2.Controls.Add(this.Yname);
            this.groupBox2.Location = new System.Drawing.Point(568, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ось Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ось X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Легенда";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(568, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 63);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Линии сетки";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Вкл/выкл";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // function_chart
            // 
            this.function_chart.Location = new System.Drawing.Point(568, 378);
            this.function_chart.Name = "function_chart";
            this.function_chart.Size = new System.Drawing.Size(231, 23);
            this.function_chart.TabIndex = 17;
            this.function_chart.Text = "Построить график";
            this.function_chart.UseVisualStyleBackColor = true;
            this.function_chart.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Решение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Сохранить график";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.function_chart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.epsilon);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.function);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Решение нелинейного уравнения методом Стеффенсена";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.TextBox epsilon;
        private System.Windows.Forms.TextBox answer;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox number_point;
        private System.Windows.Forms.TextBox left_border;
        private System.Windows.Forms.TextBox right_border;
        private System.Windows.Forms.TextBox legend;
        private System.Windows.Forms.TextBox Xname;
        private System.Windows.Forms.TextBox Yname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button function_chart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}

