using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace TIPIS.Task3
{
    public class Logic
    {
        Random RND = new Random();
        double tau = 6.2831853071;
        double Primitive(double x) => -139.0 / (20 * Math.Pow(Math.E, 4 * tau)) + x / 5 + 139.0 / 20.0;
        public Dictionary<double, double> Task1(int a, int b)
        {
            double[] Y_n = new double[b + 1];

            var result = new Dictionary<double, double>();
            for (int x = 0; x <= b; x++)
            {
                var t = GaussRandom((_) => true);

                Y_n[x] = Newton(t);
                result.Add(t, Y_n[x]);
            }
            return result;/*.OrderBy((e) => e.Key)*/
            //  .Select((e) => new KeyValuePair<double, double>(e.Key, e.Value / b))
            //  .ToDictionary((e) => e.Key, (e) => e.Value);

            double Newton(double t)
            {
                return Primitive(t) - Primitive(0);
            }
            double GaussRandom(Predicate<double> state)
            {
                double retval = default;
                while (true)
                {
                    retval = MathNet.Numerics.Distributions.Normal.Sample(RND, a, b);
                    if (state.Invoke(retval)) { break; }
                }
                return retval;
            }
        }

        public Dictionary<double, double> Task2(double a, double b, int L, int N)
        {
            double[] s = new double[L], k = new double[L], x = new double[N], y = new double[N];
            var result = new Dictionary<double, double>();
            int i, p;

            for (i = 0; i < L; i++) { s[i] = 1.0 * i / L; x[i] = s[i]; }

            for (i = 0; i < L; i++) k[i] = s[L - i - 1];
            for (i = 2 * L; i < 3 * L; i++) x[i] = x[i] + s[i - 2 * L];
            for (i = 0; i < N; i++) x[i] = x[i] + GaussRandom((_) => true);
            
            // Согласованная фильтрация
            for (i = 0; i < N; i++)
            {
                y[i] = 0.0;
                for (p = 0; p < L; p++)
                {
                    if ((i - p) >= 0)
                        y[i] = y[i] + x[i - p] * k[p];
                }
                result.Add(x[i], y[i]);
            }
            return result;
            double GaussRandom(Predicate<double> state)
            {
                double retval = default;
                while (true)
                {
                    retval = MathNet.Numerics.Distributions.Normal.Sample(RND, a, b);
                    if (state.Invoke(retval)) { break; }
                }
                return retval;
            }
        }

        //public Dictionary<double, double> Task3(int M, int MM, int a, int b, int L, int N)
        public Dictionary<double, double> Task3(int MM, int N)
        {
            double porog = 0.95;
            double[] s = new double[N], k = new double[N], x = new double[N];

            // -----------------------------------------------------------------
            for (int i = 0; i < N; i++) s[i] = Math.Sin(-2.0 * Math.PI * i / N);
            for (int i = 0; i < N; i++) k[i] = s[N - 1 - i];

            var result = new Dictionary<double, double>();
            var d_prav = new double[MM];
            for (int n = 0; n < MM; n++)
            {
                var A = 0.2 + 0.05 * n;
                for (int j = 0; j < 200; j++)
                {
                    for (int i = 0; i < N; i++) x[i] = GaussRandom((_) => true) + A * s[i];
                    var z = Solg();
                    if (z >= porog) d_prav[n] += 1.0 / 200.0;
                }
                result.Add(A, d_prav[n]);
            }
            double Solg()
            {
                var sym = default(double);
                for (int i = 0; i < N; i++) sym = sym + x[i] * k[N - 1 - i];
                return sym;
            }

            return result;


            double GaussRandom(Predicate<double> state)
            {
            double retval = default;
            while (true)
            {
                retval = MathNet.Numerics.Distributions.Normal.Sample(RND, 0, 1);
                if (state.Invoke(retval)) break;
            }
                return retval;
            }
            
        }
    }
}

