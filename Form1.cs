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
            answer.Text = head.Answer().ToString();
            legend.Text = function.Text;
        }//расчет НЛУ

        private void button3_Click(object sender, EventArgs e)
        {
            HEAD.GetPoint(number_point.Text, left_border.Text, right_border.Text);
            Graf();
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
    }
}
