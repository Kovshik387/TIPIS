using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TIPIS.Task3;
using static TIPIS.Task3.Logic;

namespace TIPIS
{
    public partial class Task4Form : Form
    {
        public Task4Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series seriesOne = new Series()
            {
                Color = Color.Tomato,
                Name = "m_rek",
                ChartType = SeriesChartType.FastLine,
                BorderWidth = 4,
            };

            Series seriesTwo = new Series()
            {
                Color = Color.Green,
                Name = "m_ist",
                ChartType = SeriesChartType.FastLine,
                BorderWidth = 4,
            };

            var result = new Task4.Logic((int)this.N1.Value).Task1();

            foreach (var item in result)
            {
                seriesOne.Points.Add(new DataPoint(item.Item1,item.Item2));
                seriesTwo.Points.Add(new DataPoint(item.Item1,item.Item3));
            }

            chart1.Series.Add(seriesOne);
            chart1.Series.Add(seriesTwo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            Series seriesOne = new Series()
            {
                Color = Color.Tomato,
                Name = "m_rek",
                ChartType = SeriesChartType.FastLine,
                BorderWidth = 4,
            };

            Series seriesTwo = new Series()
            {
                Color = Color.Green,
                Name = "m_ist",
                ChartType = SeriesChartType.FastLine,
                BorderWidth = 4,
            };

            var result = new Task4.Logic((int)this.N_num.Value).Task3();
            
            foreach (var item in result)
            {
                seriesOne.Points.Add(new DataPoint(item.Item1, item.Item2));
                seriesTwo.Points.Add(new DataPoint(item.Item1, item.Item3));
            }
            chart2.Series.Add(seriesOne);
            chart2.Series.Add(seriesTwo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart3.Series.Clear();
            Series seriesThree = new Series()
            {
                Color = Color.Tomato,
                Name = "График",
                ChartType = SeriesChartType.FastLine,
                BorderWidth = 4,
            };

            var result = new Logic().Task3((int)numericUpDown1.Value,(int)numericUpDown2.Value);
            foreach (var item in result) seriesThree.Points.Add(new DataPoint(item.Key, item.Value));
            chart3.Series.Add(seriesThree);
        }
    }
    
}
