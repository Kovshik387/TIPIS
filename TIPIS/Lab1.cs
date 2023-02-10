using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    double x = CalculateX();
                    int n = (int)((x - a) / (b - a) * N);
                    f[n] = f[n] + 1;
                }

                for (int i = 0; i < N; i++)
                    f[i] = f[i] / (M * d);

                return f;
            }

            public double CalculateX(int a = -2, int b = 7) // Вспомогательный метод для нахождения x'а
            {
                double x = _random.Next(_plotnost) / (float)_plotnost;

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
                double[] X = {    5,    7,  17,  19,  21,   25, 55 };
                double[] P = { 0.01, 0.05, 0.3, 0.3, 0.3, 0.02, 0.02 };
                double e = _random.Next(30000) / 30000d;

                double result = X[X.Length - 1];

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

            private double CalculateGaus()
            {



                return default;
            }

        }
    }
}
