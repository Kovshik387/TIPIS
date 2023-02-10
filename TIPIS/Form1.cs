using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TIPIS
{
    public partial class Form1 : Form
    {

        public void PrintChart()
        {
            chart1.Series.Clear();

            Series seriesOne = new Series()
            {
                Color = Color.Violet,
                Name = "1 График",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
            };
            Series seriesTwo = new Series() {
                Color = Color.Tomato, 
                Name = "2 График", 
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
            };

            var labOne = new Lab1.Task1(Convert.ToInt32(N1.Value),Convert.ToInt64(M1.Value));
            var labTwo = new Lab1.Task1(Convert.ToInt32(N1.Value), Convert.ToInt64(M2.Value));

            var arrayOne = labOne.CalculateTask1();

            var arrayTwo = labTwo.CalculateTask1();

            for (int i = 0; i < labOne.N;i++)
            {
                seriesOne.Points.Add(new DataPoint(i, arrayOne[i]));
                seriesTwo.Points.Add(new DataPoint(i, arrayTwo[i]));
            }

            chart1.Series.Add(seriesOne);
            chart1.Series.Add(seriesTwo);

        }

        public void PrintChartTwo()
        {
            chart2.Series.Clear();

            int n = Convert.ToInt32(Task2_N.Value);

            Series series = new Series()
            {
                Color = Color.Aqua,
                Name = "Моделирование дискретной\nслучайной величины",
                BorderWidth = 2,
                Tag = "X",
            };

            var Task = new Lab1.Task2(n);

            for (int i = 0; i < n;i++)
            {
                series.Points.Add(new DataPoint(i, Task.CalculateTask2()));
            }

            chart2.Series.Add(series);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateChart_Click(object sender, EventArgs e)
        {
            PrintChart();
        }

        private void PrintChart2_Click(object sender, EventArgs e)
        {
            PrintChartTwo();
        }
    }
}
