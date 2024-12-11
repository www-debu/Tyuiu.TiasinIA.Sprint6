using Tyuiu.TiasinIA.Sprint6.Task4.V24.Lib;
namespace Tyuiu.TiasinIA.Sprint6.Task4.V24
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxviv_tia = new GroupBox();
            chart_tia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelpClick_tia = new Button();
            groupBoxTask = new GroupBox();
            button_Save_tia = new Button();
            pictureBox1_tia = new PictureBox();
            buttonStrt_tia = new Button();
            groupBox1 = new GroupBox();
            textBoxstrtshaga_tia = new TextBox();
            textBoxtwo_tia = new TextBox();
            textBoxkon_tia = new TextBox();
            textBoxone_tia = new TextBox();
            textBoxResult_tia = new TextBox();
            groupBoxviv_tia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_tia).BeginInit();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxviv_tia
            // 
            groupBoxviv_tia.Controls.Add(chart_tia);
            groupBoxviv_tia.Controls.Add(textBoxResult_tia);
            groupBoxviv_tia.Dock = DockStyle.Bottom;
            groupBoxviv_tia.Location = new Point(0, 343);
            groupBoxviv_tia.Name = "groupBoxviv_tia";
            groupBoxviv_tia.Size = new Size(1482, 610);
            groupBoxviv_tia.TabIndex = 33;
            groupBoxviv_tia.TabStop = false;
            groupBoxviv_tia.Text = "Результат";
            // 
            // chart_tia
            // 
            chart_tia.BorderlineColor = Color.DimGray;
            chartArea1.Name = "ChartArea1";
            chart_tia.ChartAreas.Add(chartArea1);
            chart_tia.Location = new Point(452, 26);
            chart_tia.Name = "chart_tia";
            chart_tia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            chart_tia.Series.Add(series1);
            chart_tia.Size = new Size(936, 555);
            chart_tia.TabIndex = 2;
            chart_tia.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции Sin(x)";
            chart_tia.Titles.Add(title1);
            // 
            // buttonHelpClick_tia
            // 
            buttonHelpClick_tia.BackColor = SystemColors.ControlDark;
            buttonHelpClick_tia.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_tia.Location = new Point(1205, 26);
            buttonHelpClick_tia.Name = "buttonHelpClick_tia";
            buttonHelpClick_tia.Size = new Size(87, 78);
            buttonHelpClick_tia.TabIndex = 32;
            buttonHelpClick_tia.Text = "?";
            buttonHelpClick_tia.UseVisualStyleBackColor = false;
            buttonHelpClick_tia.Click += buttonHelpClick_tia_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(button_Save_tia);
            groupBoxTask.Controls.Add(pictureBox1_tia);
            groupBoxTask.Controls.Add(buttonHelpClick_tia);
            groupBoxTask.Controls.Add(buttonStrt_tia);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1482, 301);
            groupBoxTask.TabIndex = 31;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            // 
            // button_Save_tia
            // 
            button_Save_tia.BackColor = SystemColors.ControlDark;
            button_Save_tia.FlatStyle = FlatStyle.Flat;
            button_Save_tia.Location = new Point(1205, 135);
            button_Save_tia.Name = "button_Save_tia";
            button_Save_tia.Size = new Size(256, 78);
            button_Save_tia.TabIndex = 35;
            button_Save_tia.Text = "Сохранить";
            button_Save_tia.UseVisualStyleBackColor = false;
            button_Save_tia.Click += button_Save_tia_Click;
            // 
            // pictureBox1_tia
            // 
            pictureBox1_tia.Image = (Image)resources.GetObject("pictureBox1_tia.Image");
            pictureBox1_tia.Location = new Point(0, 39);
            pictureBox1_tia.Name = "pictureBox1_tia";
            pictureBox1_tia.Size = new Size(661, 233);
            pictureBox1_tia.TabIndex = 1;
            pictureBox1_tia.TabStop = false;
            // 
            // buttonStrt_tia
            // 
            buttonStrt_tia.BackColor = SystemColors.MenuHighlight;
            buttonStrt_tia.Location = new Point(1309, 26);
            buttonStrt_tia.Name = "buttonStrt_tia";
            buttonStrt_tia.Size = new Size(152, 78);
            buttonStrt_tia.TabIndex = 30;
            buttonStrt_tia.Text = "Выполнить";
            buttonStrt_tia.UseVisualStyleBackColor = false;
            buttonStrt_tia.Click += buttonStrt_tia_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxstrtshaga_tia);
            groupBox1.Controls.Add(textBoxtwo_tia);
            groupBox1.Controls.Add(textBoxkon_tia);
            groupBox1.Controls.Add(textBoxone_tia);
            groupBox1.Location = new Point(713, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 160);
            groupBox1.TabIndex = 34;
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
            // textBoxResult_tia
            // 
            textBoxResult_tia.Location = new Point(26, 43);
            textBoxResult_tia.Multiline = true;
            textBoxResult_tia.Name = "textBoxResult_tia";
            textBoxResult_tia.ReadOnly = true;
            textBoxResult_tia.Size = new Size(256, 538);
            textBoxResult_tia.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxviv_tia);
            Controls.Add(groupBoxTask);
            MinimumSize = new Size(1500, 1000);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6|Таск4|Вариант24|Тясин И.А.";
            Load += FormMain_Load;
            groupBoxviv_tia.ResumeLayout(false);
            groupBoxviv_tia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_tia).EndInit();
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxviv_tia;
        private Button buttonHelpClick_tia;
        private GroupBox groupBoxTask;
        private PictureBox pictureBox1_tia;
        private Button buttonStrt_tia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tia;
        private GroupBox groupBox1;
        private TextBox textBoxstrtshaga_tia;
        private TextBox textBoxtwo_tia;
        private TextBox textBoxkon_tia;
        private TextBox textBoxone_tia;
        private Button button_Save_tia;
        private TextBox textBoxResult_tia;
    }
}
