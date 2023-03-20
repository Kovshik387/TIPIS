using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace TIPIS
{
    internal class Lab2
    {
        public const System.Int32 N = 500;

        public int M { get; set; }

        Random RND = new Random();
        double mean = 2;
        double std = 5;

        public Lab2(int M)
        {
            this.M = M;
        }

        public virtual double GaussRandom(double mean, double std, Predicate<double> state)
            => this.GaussRandom<object>(mean, std, state);

        public double GaussRandom<T>(double mean, double std, Predicate<double> state,
            T param = default(T)) where T : class
        {
            double return_value = default;
            while (true)
            {
                return_value = MathNet.Numerics.Distributions.Normal.Sample(RND, mean, std);
                if (state.Invoke(return_value)) { break; }
            }
            return return_value;
        }

        public List<double> CalculateTask1(double mean, double std, double a)
        {

            var func_result = new List<double>();
            double k2 = Math.Exp(a), k1 = Math.Sqrt(std * (1.0 - k2 * k2));

            func_result.Add(this.GaussRandom(mean, std, (_) => true));
            for (int n = 1; n < this.M; n++)
            {
                func_result.Add(k1 * this.GaussRandom(mean, 1, (_) => true) + k2 * func_result[n - 1]);
            }
            return func_result;
        }
        public List<double> CalculateTask2(double b)
        {
                var Xn = this.CalculateTask1(0, 1, Math.Log(0.02));
                var Yn = new List<double>();

                for (int n = 1; n < this.M; n++) Yn.Add(2 * Xn[n] + b * Xn[n - 1]);
                return Yn;

        }

    }
}
