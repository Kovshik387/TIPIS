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
    public partial class Task3Form : Form
    {
        public Task3Form()
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

            var result = new TIPIS.Task3.Logic().Task1(0, 5);

            foreach (var item in result)
            {
                seriesOne.Points.Add(new DataPoint(item.Key,item.Value));
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

            var result = new Logic().Task2(0,0.5, (int)L_num.Value, (int)N_num.Value);
            foreach (var item in result) seriesTwo.Points.Add(new DataPoint(item.Key,item.Value));

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
