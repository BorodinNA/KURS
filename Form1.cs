using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace KURS
{
    public partial class Form1 : Form
    {
        HEAD head = new HEAD();
        public Form1()
        {
            InitializeComponent();
        }

        GraphPane MyPane;
        LineItem myCurve;
        LineItem myCurve2;


        private void button1_Click(object sender, EventArgs e)
        {
            HEAD.Get(function.Text, epsilon.Text, X0.Text);
            if(HEAD.error == true) MessageBox.Show("Обязателен ввод функции, начального приближения и ε");
            else 
            {
                string check = head.Answer().ToString();
                if (Steffensen.error == true) MessageBox.Show("Начальные условия не подходят");
                else
                {
                    answer.Text = check;
                    legend.Text = function.Text;
                }

            }
        }//расчет НЛУ

        private void button3_Click(object sender, EventArgs e)
        {
            HEAD.GetPoint(number_point.Text, left_border.Text, right_border.Text);
            if (HEAD.error == true) MessageBox.Show("Обязателен ввод количества точек и границ построения графика");
            else 
            {
                Graf();
            }
        }//кнопка строющая график

        public void Graf()
        {
            MyPane = zedGraphControl1.GraphPane;
            MyPane.Title.Text = "Метод Стеффенсена";
            MyPane.XAxis.Title.Text = Xname.Text;
            MyPane.YAxis.Title.Text = Yname.Text;
            MyPane.CurveList.Clear();
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            double[,] point = head.PointGraf();
            double xp;
            double yp;
            for (int i = 0; i < point.GetLength(1); i++)
            {
                xp = point[0, i];
                yp = point[1, i];
                list1.Add(xp, yp);
            }
            double[] answer = head.PointAnswer();
            list2.Add(answer[0], answer[1]);
            LineItem myCurve = MyPane.AddCurve(legend.Text, list1, Color.Blue, SymbolType.None);
            LineItem myCurve2 = MyPane.AddCurve("Решение", list2, Color.Red, SymbolType.Circle);
            myCurve2.Line.IsVisible = false;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            myCurve.Line.IsSmooth = true;
            if (checkBox1.Checked)
            {
                MyPane.XAxis.MajorGrid.IsVisible = true;
                MyPane.YAxis.MajorGrid.IsVisible = true;
            }
            else
            {
                MyPane.XAxis.MajorGrid.IsVisible = false;
                MyPane.YAxis.MajorGrid.IsVisible = false;
            }
        }//настройки графика и его построение

        private void button2_Click(object sender, EventArgs e)
        {
            zedGraphControl1.SaveAsBitmap();
        }//сохранение графика в виде изображения 

        private void X0_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) 
            {
                e.Handled = true;
            }
        }//можно вводить только цифры, клавишу BackSpace, минус и запятую

        private void epsilon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }//можно вводить только цифры, клавишу BackSpace и запятую

        private void function_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 94 && (e.KeyChar <= 96 || e.KeyChar >= 123)) 
            {
                e.Handled = true;
            }
        }//можно вводить только цифры, клавишу BackSpace, запятую, буквы английского алфавита и математические символы(кроме =)

        private void number_point_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }//можно вводить только цифры, клавишу BackSpace

        private void left_border_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }//можно вводить только цифры, клавишу BackSpace, минус и запятую

        private void right_border_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }//можно вводить только цифры, клавишу BackSpace, минус и запятую
    }
}
