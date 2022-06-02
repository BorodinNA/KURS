using System;
using System.IO;

namespace KURS
{
    class HEAD
    {
        Steffensen steffensen = new Steffensen();
        public static string pFunc;//переменная хранящая функцию
        public static double E;//переменная хранящая ε
        public static double X;//переменная хранящая начальное приближение
        public static int N;//переменная хранящая количество шагов
        public static double A;//переменная хранящая левую границу для построение графика
        public static double B;//переменная хранящая //переменная хранящая левую границу для построение графика
        public static bool error;//переменная для сбора ошибок
        public static void Get(string f, string eps, string x0)
        {
            if ((f != "") & (eps != "") & (x0 != ""))
            {
                error = false;
                pFunc = f;
                E = Convert.ToDouble(eps);
                X = Convert.ToDouble(x0);
                StreamWriter input = new StreamWriter("input.tmp", false);
                input.WriteLine("function: " + f);
                input.WriteLine("x0: " + x0);
                input.WriteLine("epsilon: " + eps);
                input.Close();
            }
            else error = true;
        }//получение данных для решение НЛУ

        public static void GetPoint(string n, string a, string b)
        {
            if((n!="")&(a!="")&(b!=""))
            {
                error = false;
                N = Convert.ToInt32(n);
                A = Convert.ToDouble(a);
                B = Convert.ToDouble(b);
            }
            else error = true;
        }//получение условий построения графика

        public double[,] PointGraf()
        {
            return steffensen.Point();
        }//точки для построения графика

        public double Answer()
        {
            StreamWriter input = new StreamWriter("input.tmp", true);
            X = steffensen.Method(X);
            input.WriteLine("answer: " + X);
            input.Close();
            return X;
        }//решение НЛУ

        public double[] PointAnswer()
        {
            double[] point = new double[2];
            point[0] = X;
            point[1] = Steffensen.func(X);
            return point;
        }//значения точки для нанесения на график
    }
}
