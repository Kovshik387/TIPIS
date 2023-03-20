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

            //private readonly int _plotnost = 30000; // Название говорит само за себя........

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

            public Dictionary<Double,Double> CalculateTask1(double a = -2, double b = 7) // Массив для значений (оценка плотности)
            {
                f = new double[N];
                double d = (b - a) / N;

                var range = Enumerable.Range(0, N).Select((e) => a + e * d).ToArray();

                for (long m = 0; m < M; m++)
                {
                    double x = CalculateX(a,b);
                    int n = (int)((x - a) / (b - a) * N);
                    f[n] += 1;
                }
                
                var f_result = new Dictionary<double, double>();

                for (int i = 0; i < N; i++)
                    f_result.Add(range[i], f[i] / (M* d));

                return f_result;
            }

            public double CalculateX(double a , double b) => a + (b - a) * _random.NextDouble(); // Вспомогательный метод для нахождения x'а

        }

        public class Task2
        {
            private readonly Random _random = new Random();

            private readonly int N = default;

            public Task2(int N)
            {
                this.N = N;
            }

            public Dictionary<Double,int> CalculateResult()
            {
                double[] X = {   5, 25,     55,      7,  17,  19, 21};
                double[] P = {0.01, 0.02, 0.02,   0.05, 0.3, 0.3, 0.3};

                var pairs = new Dictionary<Double, int>()
                {
                    {5,0 },{25,0 },{55,0},{7,0}, {17,0 },{19,0},{21,0}
                };

                double result = default;


                for (int j = 0; j< N;j++)
                {
                    for (int i = 0; i < X.Length; i++)
                    {
                        if (_random.NextDouble() < P[i])
                        {
                            if (X[i] == 55 || X[i] == 25) result = X[_random.Next(1, 3)];
                            else if (X[i] == 17 || X[i] == 19 || X[i] == 21) result = X[_random.Next(4, 7)];
                            else result = X[i];
                             

                            switch (result)
                            {
                                case 5: pairs[5]++; break;
                                case 25: pairs[25]++; break;
                                case 55: pairs[55]++; break;
                                case 7: pairs[7]++; break;
                                case 17: pairs[17]++; break;
                                case 19: pairs[19]++; break;
                                case 21: pairs[21]++; break;
                            }
                        }
                        if (result == default && i >= X.Length - 1) i -= 1;
                    }
                }

                return pairs;

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

            public Dictionary<Double,Double> CalculateResult(int a = 5,int b = 7)
            {
                var Task = new Task1(this.N,this.M);
                var result = Task.CalculateTask1(a, b);
                
                double d = (double)(b - a) / N;
                
                F = new double[this.N];

                for (int i = 0;i < this.M;i++)
                {
                    var x = CalculateGaus(a,b);

                    int n = (int)((x - a) / (b - a) * N);
                    F[n] = F[n] + 1;
                }

                for (int i = 0; i < this.N;i++)
                {
                    F[i] = F[i] / (this.M * d);
                    result[result.ElementAt(i).Key] += F[i];
                }

                return result;
            }

            private double CalculateGaus(int a, int b)
            {
                var dispersia = 2;
                var std = 1;
                double x;
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
