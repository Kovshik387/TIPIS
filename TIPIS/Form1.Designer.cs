namespace TIPIS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.N1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.M1 = new System.Windows.Forms.NumericUpDown();
            this.M2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateChart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PrintChart2 = new System.Windows.Forms.Button();
            this.Task2_N = new System.Windows.Forms.NumericUpDown();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Task3_Calculate = new System.Windows.Forms.Button();
            this.Task3N = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Task3M = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Task2_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Task3N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Task3M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(663, 403);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // N1
            // 
            this.N1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.N1.Location = new System.Drawing.Point(678, 21);
            this.N1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(120, 20);
            this.N1.TabIndex = 1;
            this.N1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 График:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число отрезков";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Чило экспериментов";
            // 
            // M1
            // 
            this.M1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.M1.Location = new System.Drawing.Point(678, 73);
            this.M1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.M1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(120, 20);
            this.M1.TabIndex = 5;
            this.M1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // M2
            // 
            this.M2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.M2.Location = new System.Drawing.Point(678, 148);
            this.M2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.M2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(120, 20);
            this.M2.TabIndex = 10;
            this.M2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Чило экспериментов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "2 График:";
            // 
            // CreateChart
            // 
            this.CreateChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateChart.Location = new System.Drawing.Point(678, 372);
            this.CreateChart.Name = "CreateChart";
            this.CreateChart.Size = new System.Drawing.Size(126, 37);
            this.CreateChart.TabIndex = 11;
            this.CreateChart.Text = "Построить";
            this.CreateChart.UseVisualStyleBackColor = true;
            this.CreateChart.Click += new System.EventHandler(this.CreateChart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 444);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.CreateChart);
            this.tabPage1.Controls.Add(this.M2);
            this.tabPage1.Controls.Add(this.N1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.M1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1 Задание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PrintChart2);
            this.tabPage2.Controls.Add(this.Task2_N);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2 Задание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PrintChart2
            // 
            this.PrintChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintChart2.Location = new System.Drawing.Point(705, 389);
            this.PrintChart2.Name = "PrintChart2";
            this.PrintChart2.Size = new System.Drawing.Size(105, 23);
            this.PrintChart2.TabIndex = 2;
            this.PrintChart2.Text = "Построить";
            this.PrintChart2.UseVisualStyleBackColor = true;
            this.PrintChart2.Click += new System.EventHandler(this.PrintChart2_Click);
            // 
            // Task2_N
            // 
            this.Task2_N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Task2_N.Location = new System.Drawing.Point(705, 363);
            this.Task2_N.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Task2_N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Task2_N.Name = "Task2_N";
            this.Task2_N.Size = new System.Drawing.Size(105, 20);
            this.Task2_N.TabIndex = 1;
            this.Task2_N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(6, 6);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(693, 406);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Task3_Calculate);
            this.tabPage3.Controls.Add(this.Task3N);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.Task3M);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(816, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "7 Задание";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Task3_Calculate
            // 
            this.Task3_Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Task3_Calculate.Location = new System.Drawing.Point(679, 390);
            this.Task3_Calculate.Name = "Task3_Calculate";
            this.Task3_Calculate.Size = new System.Drawing.Size(133, 23);
            this.Task3_Calculate.TabIndex = 15;
            this.Task3_Calculate.Text = "Построить";
            this.Task3_Calculate.UseVisualStyleBackColor = true;
            this.Task3_Calculate.Click += new System.EventHandler(this.Task3_Calculate_Click);
            // 
            // Task3N
            // 
            this.Task3N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Task3N.Location = new System.Drawing.Point(682, 72);
            this.Task3N.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Task3N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Task3N.Name = "Task3N";
            this.Task3N.Size = new System.Drawing.Size(120, 20);
            this.Task3N.TabIndex = 13;
            this.Task3N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Число отрезков";
            // 
            // Task3M
            // 
            this.Task3M.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Task3M.Location = new System.Drawing.Point(679, 23);
            this.Task3M.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Task3M.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Task3M.Name = "Task3M";
            this.Task3M.Size = new System.Drawing.Size(120, 20);
            this.Task3M.TabIndex = 12;
            this.Task3M.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Чило экспериментов";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart3.Legends.Add(legend5);
            this.chart3.Location = new System.Drawing.Point(3, 7);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(670, 406);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Task2_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Task3N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Task3M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown N1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown M1;
        private System.Windows.Forms.NumericUpDown M2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateChart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button PrintChart2;
        private System.Windows.Forms.NumericUpDown Task2_N;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.NumericUpDown Task3N;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Task3M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Task3_Calculate;
    }
}

