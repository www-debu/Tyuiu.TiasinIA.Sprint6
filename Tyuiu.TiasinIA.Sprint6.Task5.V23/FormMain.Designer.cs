namespace Tyuiu.TiasinIA.Sprint6.Task5.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask = new GroupBox();
            textBox1 = new TextBox();
            button_Save_tia = new Button();
            pictureBox1_tia = new PictureBox();
            buttonHelpClick_tia = new Button();
            buttonStrt_tia = new Button();
            textBoxResult_tia = new TextBox();
            chart_tia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_tia).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Controls.Add(button_Save_tia);
            groupBoxTask.Controls.Add(pictureBox1_tia);
            groupBoxTask.Controls.Add(buttonHelpClick_tia);
            groupBoxTask.Controls.Add(buttonStrt_tia);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1519, 293);
            groupBoxTask.TabIndex = 32;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 260);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 36;
            textBox1.Text = "Вывод данных";
            // 
            // button_Save_tia
            // 
            button_Save_tia.BackColor = SystemColors.ControlDark;
            button_Save_tia.FlatStyle = FlatStyle.Flat;
            button_Save_tia.Location = new Point(1040, 199);
            button_Save_tia.Name = "button_Save_tia";
            button_Save_tia.Size = new Size(147, 78);
            button_Save_tia.TabIndex = 35;
            button_Save_tia.Text = "Сохранить";
            button_Save_tia.UseVisualStyleBackColor = false;
            // 
            // pictureBox1_tia
            // 
            pictureBox1_tia.Image = (Image)resources.GetObject("pictureBox1_tia.Image");
            pictureBox1_tia.Location = new Point(22, 26);
            pictureBox1_tia.Name = "pictureBox1_tia";
            pictureBox1_tia.Size = new Size(1295, 153);
            pictureBox1_tia.TabIndex = 1;
            pictureBox1_tia.TabStop = false;
            // 
            // buttonHelpClick_tia
            // 
            buttonHelpClick_tia.BackColor = SystemColors.ControlDark;
            buttonHelpClick_tia.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_tia.Location = new Point(1206, 199);
            buttonHelpClick_tia.Name = "buttonHelpClick_tia";
            buttonHelpClick_tia.Size = new Size(87, 78);
            buttonHelpClick_tia.TabIndex = 32;
            buttonHelpClick_tia.Text = "?";
            buttonHelpClick_tia.UseVisualStyleBackColor = false;
            buttonHelpClick_tia.Click += buttonHelpClick_tia_Click;
            // 
            // buttonStrt_tia
            // 
            buttonStrt_tia.BackColor = SystemColors.MenuHighlight;
            buttonStrt_tia.Location = new Point(882, 199);
            buttonStrt_tia.Name = "buttonStrt_tia";
            buttonStrt_tia.Size = new Size(152, 78);
            buttonStrt_tia.TabIndex = 30;
            buttonStrt_tia.Text = "Выполнить";
            buttonStrt_tia.UseVisualStyleBackColor = false;
            buttonStrt_tia.Click += buttonStrt_tia_Click;
            // 
            // textBoxResult_tia
            // 
            textBoxResult_tia.Location = new Point(22, 299);
            textBoxResult_tia.Multiline = true;
            textBoxResult_tia.Name = "textBoxResult_tia";
            textBoxResult_tia.ReadOnly = true;
            textBoxResult_tia.Size = new Size(224, 619);
            textBoxResult_tia.TabIndex = 36;
            // 
            // chart_tia
            // 
            chartArea2.Name = "ChartArea1";
            chart_tia.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_tia.Legends.Add(legend2);
            chart_tia.Location = new Point(265, 299);
            chart_tia.Name = "chart_tia";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_tia.Series.Add(series2);
            chart_tia.Size = new Size(1242, 619);
            chart_tia.TabIndex = 37;
            chart_tia.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 930);
            Controls.Add(chart_tia);
            Controls.Add(textBoxResult_tia);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт6|Таск5|Вариант23|Тясин И.А.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_tia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask;
        private Button button_Save_tia;
        private PictureBox pictureBox1_tia;
        private Button buttonHelpClick_tia;
        private Button buttonStrt_tia;
        private TextBox textBoxResult_tia;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tia;
    }
}
