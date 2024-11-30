namespace Tyuiu.TiasinIA.Sprint6.Task2.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxviv_tia = new GroupBox();
            chart_tia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGrid_tia = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBoxstrtshaga_tia = new TextBox();
            textBoxtwo_tia = new TextBox();
            textBoxkon_tia = new TextBox();
            textBoxone_tia = new TextBox();
            buttonHelpClick_tia = new Button();
            groupBoxTask = new GroupBox();
            pictureBox1_tia = new PictureBox();
            buttonStrt_tia = new Button();
            groupBoxviv_tia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_tia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_tia).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).BeginInit();
            SuspendLayout();
            // 
            // groupBoxviv_tia
            // 
            groupBoxviv_tia.Controls.Add(chart_tia);
            groupBoxviv_tia.Controls.Add(dataGrid_tia);
            groupBoxviv_tia.Location = new Point(861, 12);
            groupBoxviv_tia.Name = "groupBoxviv_tia";
            groupBoxviv_tia.Size = new Size(687, 694);
            groupBoxviv_tia.TabIndex = 24;
            groupBoxviv_tia.TabStop = false;
            groupBoxviv_tia.Text = "Результат";
            // 
            // chart_tia
            // 
            chartArea1.Name = "ChartArea1";
            chart_tia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_tia.Legends.Add(legend1);
            chart_tia.Location = new Point(157, 39);
            chart_tia.Name = "chart_tia";
            chart_tia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_tia.Series.Add(series1);
            chart_tia.Size = new Size(510, 641);
            chart_tia.TabIndex = 1;
            chart_tia.Text = "График";
            // 
            // dataGrid_tia
            // 
            dataGrid_tia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_tia.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGrid_tia.Location = new Point(15, 39);
            dataGrid_tia.Name = "dataGrid_tia";
            dataGrid_tia.RowHeadersVisible = false;
            dataGrid_tia.RowHeadersWidth = 51;
            dataGrid_tia.Size = new Size(120, 641);
            dataGrid_tia.TabIndex = 0;
            // 
            // x
            // 
            x.HeaderText = "X";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.Width = 50;
            // 
            // y
            // 
            y.HeaderText = "F(x)";
            y.MinimumWidth = 6;
            y.Name = "y";
            y.Width = 50;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxstrtshaga_tia);
            groupBox1.Controls.Add(textBoxtwo_tia);
            groupBox1.Controls.Add(textBoxkon_tia);
            groupBox1.Controls.Add(textBoxone_tia);
            groupBox1.Location = new Point(29, 546);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 160);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxstrtshaga_tia
            // 
            textBoxstrtshaga_tia.Location = new Point(6, 86);
            textBoxstrtshaga_tia.Name = "textBoxstrtshaga_tia";
            textBoxstrtshaga_tia.ReadOnly = true;
            textBoxstrtshaga_tia.Size = new Size(147, 27);
            textBoxstrtshaga_tia.TabIndex = 19;
            textBoxstrtshaga_tia.Text = "Начало шага";
            // 
            // textBoxtwo_tia
            // 
            textBoxtwo_tia.Location = new Point(188, 119);
            textBoxtwo_tia.Name = "textBoxtwo_tia";
            textBoxtwo_tia.Size = new Size(147, 27);
            textBoxtwo_tia.TabIndex = 18;
            // 
            // textBoxkon_tia
            // 
            textBoxkon_tia.Location = new Point(188, 83);
            textBoxkon_tia.Name = "textBoxkon_tia";
            textBoxkon_tia.ReadOnly = true;
            textBoxkon_tia.Size = new Size(147, 27);
            textBoxkon_tia.TabIndex = 17;
            textBoxkon_tia.Text = "Конец шага";
            // 
            // textBoxone_tia
            // 
            textBoxone_tia.Location = new Point(6, 119);
            textBoxone_tia.Name = "textBoxone_tia";
            textBoxone_tia.Size = new Size(147, 27);
            textBoxone_tia.TabIndex = 13;
            // 
            // buttonHelpClick_tia
            // 
            buttonHelpClick_tia.BackColor = SystemColors.ControlDark;
            buttonHelpClick_tia.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_tia.Location = new Point(544, 631);
            buttonHelpClick_tia.Name = "buttonHelpClick_tia";
            buttonHelpClick_tia.Size = new Size(100, 75);
            buttonHelpClick_tia.TabIndex = 22;
            buttonHelpClick_tia.Text = "?";
            buttonHelpClick_tia.UseVisualStyleBackColor = false;
            buttonHelpClick_tia.Click += buttonHelpClick_tia_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1_tia);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(747, 528);
            groupBoxTask.TabIndex = 21;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            // 
            // pictureBox1_tia
            // 
            pictureBox1_tia.Image = (Image)resources.GetObject("pictureBox1_tia.Image");
            pictureBox1_tia.Location = new Point(17, 39);
            pictureBox1_tia.Name = "pictureBox1_tia";
            pictureBox1_tia.Size = new Size(642, 214);
            pictureBox1_tia.TabIndex = 1;
            pictureBox1_tia.TabStop = false;
            // 
            // buttonStrt_tia
            // 
            buttonStrt_tia.BackColor = SystemColors.MenuHighlight;
            buttonStrt_tia.Location = new Point(676, 629);
            buttonStrt_tia.Name = "buttonStrt_tia";
            buttonStrt_tia.Size = new Size(155, 77);
            buttonStrt_tia.TabIndex = 20;
            buttonStrt_tia.Text = "Выполнить";
            buttonStrt_tia.UseVisualStyleBackColor = false;
            buttonStrt_tia.Click += buttonStrt_tia_Click;
            buttonStrt_tia.MouseEnter += buttonStrt_tia_MouseEnter;
            buttonStrt_tia.MouseLeave += buttonStrt_tia_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 785);
            Controls.Add(groupBoxviv_tia);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelpClick_tia);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonStrt_tia);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт6|Таск2|Вариант7|Тясин И.А.";
            Load += FormMain_Load;
            groupBoxviv_tia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_tia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_tia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxviv_tia;
        private GroupBox groupBox1;
        private TextBox textBoxstrtshaga_tia;
        private TextBox textBoxtwo_tia;
        private TextBox textBoxkon_tia;
        private TextBox textBoxone_tia;
        private Button buttonHelpClick_tia;
        private GroupBox groupBoxTask;
        private PictureBox pictureBox1_tia;
        private Button buttonStrt_tia;
        private DataGridView dataGrid_tia;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tia;
    }
}
