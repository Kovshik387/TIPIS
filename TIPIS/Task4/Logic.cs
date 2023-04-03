using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TIPIS.Task4
{
    public class Logic
    {
        private readonly Random random = new Random();
        private readonly int N;

        private const int a = 0;
        private const int b = 1;

        public Logic(int N)
        {
            this.N = N;
        }
        
        double GaussRandom(Predicate<double> state)
        {
            double retval = default;
            while (true)
            {
                retval = MathNet.Numerics.Distributions.Normal.Sample(random, a, b);
                if (state.Invoke(retval)) { break; }
            }
            return retval;
        }
        // Item1 = y[], Item2 = m_rek[], Item3 = m_list
        public List<(double,double,double)> Task1()
        {
            double[] y = new double[N];
            double[] m_rek = new double[N];
            double[] m_ist = new double[N];
            int i;
            var result = new List<(double, double,double)>();

            for (i = 0; i < N; i++)
            {
                for (i = 1; i < N; i++) m_ist[i] = Math.Exp(0 * 0 / 2.0) / Math.Sqrt(2 * Math.PI);
                        
                for (i = 1; i < N; i++)
                {
                    y[i] = GaussRandom((_) => true); 
                    if (y[i] <= 0) y[i] = 0;
                    else y[i] = Math.Pow(y[i], 2);
                }

                m_rek[1] = y[1];
                
                for (i = 2; i < N; i++) m_rek[i] = (i - 1.0) / i * m_rek[i - 1] + 1.0 / i * y[i];

            }

            for (int k = 0; k < N; k++)
            {
                var item = (y[k] , m_rek[k], m_ist[k]);
                result.Add(item);
                Console.WriteLine($"y[{k}]= {y[k]}\nm_rek[{k}]= {m_rek[k]}\nm_ist[{k}]= {m_ist[k]}\n");
            }

            return result;
        }
    
        public List<(double,double,double)> Task3()
        {
            double[] y = new double[N];
            double[] m_rek = new double[N];
            double[] m_ist = new double[N];
            int i;
            var result = new List<(double, double, double)>();

            for (i = 0; i < N; i++)
            {
                for (i = 1; i < N; i++) m_ist[i] = Math.Exp(0 * 0 / 2.0) / Math.Sqrt(2 * Math.PI);

                for (i = 1; i < N; i++)
                {
                    y[i] = GaussRandom((_) => true);
                    Console.WriteLine("feee" + y[i]);
                    y[i] = Math.Pow(y[i], 2);
                }

                m_rek[1] = y[1];

                for (i = 2; i < N; i++) m_rek[i] = (i - 1.0) / i * m_rek[i - 1] + 1.0 / i * y[i];
            }

            for (int k = 0; k < N; k++)
            {
                var item = (y[k], m_rek[k], m_ist[k]);
                result.Add(item);
                Console.WriteLine($"y[{k}]= {y[k]}\nm_rek[{k}]= {m_rek[k]}\nm_ist[{k}]= {m_ist[k]}\n");
            }

            return result;
        }

    }

}
