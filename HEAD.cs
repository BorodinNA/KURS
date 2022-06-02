using System;
using System.IO;

namespace KURS
{
    class HEAD
    {
        Steffensen steffensen = new Steffensen();
        public static string pFunc;
        public static double E;
        public static double X;
        public static int N;
        public static double A;
        public static double B;
        public static void Get(string f, string eps, string x0)
        {
            StreamWriter input = new StreamWriter("input.tmp", false);
            pFunc = f;
            E = Convert.ToDouble(eps);
            X = Convert.ToDouble(x0);
            input.WriteLine("function: "+f);
            input.WriteLine("x0: "+x0);
            input.WriteLine("epsilon: "+eps);
            input.Close();
        }//получение данных для решение НЛУ

        public static void GetPoint(string n, string a, string b)
        {
            N = Convert.ToInt32(n);
            A = Convert.ToDouble(a);
            B = Convert.ToDouble(b);
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
