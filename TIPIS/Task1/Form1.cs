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
        public void PrintChartOne()
        {
            chart1.Update();
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

            foreach (var item in arrayOne) seriesOne.Points.Add(new DataPoint(item.Key, item.Value));
            foreach (var item in arrayTwo) seriesTwo.Points.Add(new DataPoint(item.Key, item.Value));

            chart1.Series.Add(seriesOne);
            chart1.Series.Add(seriesTwo);

        }

        public void PrintChartTwo()
        {
            chart3.Images.Clear();
            chart2.Series.Clear();

            int n = Convert.ToInt32(Task2_N.Value);

            Series series = new Series()
            {
                Color = Color.Aqua,
                //Name = "Моделирование дискретной\nслучайной величины",
                BorderWidth = 2,
                Tag = "X",
            };

            var Task = new Lab1.Task2(n);

            var val = Task.CalculateResult().Values.ToList();
            var key = Task.CalculateResult().Keys.ToList();

            for (int i = 0; i < 7;i++)
            {
                series.Points.Add(new DataPoint(key[i], val[i] )) ;
            }

            chart2.Series.Add(series);

        }

        public void PrintChartThree()
        {
            chart3.Images.Clear();
            chart3.Series.Clear();

            int n = (int)Task3N.Value;
            int m = (int)Task3M.Value;
            Series series = new Series()
            {
                Color = Color.BlueViolet,
                BorderWidth = 2,
                ChartType = SeriesChartType.Line,
            };

            var Task = new Lab1.Task3(n, m);
            var result = Task.CalculateResult();

            foreach(var val in result) series.Points.Add(val.Value,val.Key);

            chart3.Series.Add(series);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateChart_Click(object sender, EventArgs e) => PrintChartOne();


        private void PrintChart2_Click(object sender, EventArgs e) => PrintChartTwo();

        private void Task3_Calculate_Click(object sender, EventArgs e) => PrintChartThree();

    }
}
