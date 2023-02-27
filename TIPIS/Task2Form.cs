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

namespace TIPIS
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series seriesOne = new Series()
            {
                Color = Color.Tomato,
                Name = "График",
                ChartType = SeriesChartType.FastLine,
                BorderWidth = 4,
            };

            var result = new Lab2((int)N1.Value).CalculateTask1(2,5,Math.Log(0.95));

            foreach (var ob in result)
            {
                seriesOne.Points.Add(ob);
            }

            chart1.Series.Add(seriesOne);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            Series seriesTwo = new Series()
            {
                Color = Color.Tomato,
                Name = "График",
                ChartType = SeriesChartType.FastLine,
                BorderWidth = 4,
            };

            var result = new Lab2((int)N2.Value).CalculateTask2(1); ;
            foreach (var item in result) seriesTwo.Points.Add(item);


            chart2.Series.Add(seriesTwo);
        }
    }
    
}
