using System;
using info.lundin.math;
using System.Collections.Generic;

namespace KURS
{
    class Steffensen
    {
        static ExpressionParser parser = new ExpressionParser();//переменная для парса строки в функцию
        public static bool error;//переменная для сбора ошибок
        public static double func(double x)
        {
            parser.Values.Add("x", x);
            double F = parser.Parse(HEAD.pFunc); ;
            parser.Values.Clear();
            return F;
        }//расчет функции

        public double Method(double x)
        {
            double X = x;
            double X0;
            do
            {
                X0 = X;
                X = X0 - func(X0) / (func(func(X0) + X0) / func(X0) - 1);
            }
            while (Math.Abs(X-X0)>HEAD.E);
            if (double.IsNaN(X)) error = true;
            else error = false;
            return X;
        }//решение НЛУ методом Стеффенсона

        public double[,] Point() 
        {
            double[,] point = new double[2,HEAD.N+1];
            point[0, 0] = HEAD.A;
            double h = (HEAD.B - HEAD.A) / HEAD.N;
            point[1, 0] = func(point[0, 0]);
            for (int i = 1; i<HEAD.N; i++)
            {
                point[0, i] = point[0, i-1] + h;
                point[1, i] = func(point[0, i]);
            }
            point[0, HEAD.N] = point[0, HEAD.N - 1] + h;
            point[1, HEAD.N] = func(point[0, HEAD.N]);
            return point;
        }//расчет точек для построения графика функции

    }
}
