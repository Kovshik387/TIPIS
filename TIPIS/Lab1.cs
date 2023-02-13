using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using MathNet;


namespace TIPIS
{
    public class Lab1
    {
        public class Task1
        {
            private readonly Random _random = new Random();

            private readonly int _plotnost = 30000; // Название говорит само за себя........

            public readonly int N;// Число отрезков

            /// <summary>
            /// 
            /// </summary>
            /// <param name="N">Число отрезков</param>
            /// <param name="M">Число экспериментов</param>
            public Task1(int N, long M)
            {
                this.N = N;
                this.M = M;
            }
            private readonly long M; // Число эксперементов

            private double[] f;

            public double[] CalculateTask1(double a = -2, double b = 7) // Массив для значений (оценка плотности)
            {
                double d = (b - a) / N; // величина отрезка случайнеой величины x

                f = new double[N];

                for (long m = 0; m < M; m++)
                {
                    double x = CalculateX((int)a,(int)b);
                    int n = (int)((x - a) / (b - a) * N);

                    f[n] = f[n] + 1;
                }

                for (int i = 0; i < N; i++) 
                    f[i] = f[i] / (M * d);

                return f;
            }

            public double CalculateX(int a , int b) // Вспомогательный метод для нахождения x'а
            {
                double x = _random.NextDouble();

                return a + (b - a) * x;
            }
        }

        public class Task2
        {
            private readonly Random _random = new Random();

            private readonly int N = default;
            private double[] result = default;

            public Task2(int N)
            {
                this.N = N;
            }

            public double[] CalculateTask2()
            {
                result = new double[N];

                for (int i = 0;i< N;i++)
                    result[i] = CalculateResult();

                return result;
            }

            private double CalculateResult()
            {
                double[] X = {   5, 25,     55,      7,  17,  19, 21};
                double[] P = {0.01, 0.02, 0.02,   0.05, 0.3, 0.3, 0.3};
                double e = _random.Next(30000) / 30000d;

                double result = X[X.Count() - 1];
                //double result = (double)default;

                for (int i = 0; i < X.Length; i++)
                {
                    if (e < P[i])
                    {
                        result = X[i]; break;
                    }
                }
                return result;
            }
        }

        public class Task3
        {
            private readonly Random _random = new Random();

            private readonly int N = default;
            private readonly long M = default;

            private double[] F;

            public Task3(int N, long M)
            {
                this.N = N; this.M = M;
            }

            public double[] CalculateResult()
            {
                int a = -7, b = 7;
                F = new double[this.N];
                double d = (double)(b - a) / N;
                
                var rand = new Task1(N,M);
                var calculate_random = rand.CalculateTask1(a, b);

                for (int i = 0;i < this.M;i++)
                {
                    var x = CalculateGaus(a,b);

                    int n = (int)((x - a) / (b - a) * N);
                    F[n] = F[n] + 1;
                }

                for (int i = 0; i < this.N;i++)
                {
                    F[i] = F[i] / (this.M * d);
                    F[i] += calculate_random[i];
                    Console.WriteLine(F[i]);
                }

                return F;
            }

            private double CalculateGaus(int a, int b)
            {
                var dispersia = 2;
                var std = 1;
                double x = default;

                while (true)
                {
                    x = MathNet.Numerics.Distributions.Normal.Sample(_random, dispersia,std);
                    if (x <= b && x >= a) break;
                }
                return x;
            }

        }
    }
}
