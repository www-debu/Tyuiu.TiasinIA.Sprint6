namespace Tyuiu.TiasinIA.Sprint6.Task1.V16
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
            buttonHelpClick_tia = new Button();
            textBoxone_tia = new TextBox();
            textBoxResult_tia = new TextBox();
            groupBoxTask = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxR_tia = new TextBox();
            buttonStrt_tia = new Button();
            groupBox1 = new GroupBox();
            textBoxstrtshaga_tia = new TextBox();
            textBoxtwo_tia = new TextBox();
            textBoxkon_tia = new TextBox();
            groupBoxviv_tia = new GroupBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxviv_tia.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelpClick_tia
            // 
            buttonHelpClick_tia.BackColor = SystemColors.ControlDark;
            buttonHelpClick_tia.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_tia.Location = new Point(544, 631);
            buttonHelpClick_tia.Name = "buttonHelpClick_tia";
            buttonHelpClick_tia.Size = new Size(100, 75);
            buttonHelpClick_tia.TabIndex = 14;
            buttonHelpClick_tia.Text = "?";
            buttonHelpClick_tia.UseVisualStyleBackColor = false;
            buttonHelpClick_tia.Click += buttonHelpClick_tia_Click;
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
            textBoxResult_tia.Location = new Point(0, 0);
            textBoxResult_tia.Name = "textBoxResult_tia";
            textBoxResult_tia.Size = new Size(100, 27);
            textBoxResult_tia.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(747, 528);
            groupBoxTask.TabIndex = 11;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 215);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxR_tia
            // 
            textBoxR_tia.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxR_tia.Location = new Point(42, 39);
            textBoxR_tia.Multiline = true;
            textBoxR_tia.Name = "textBoxR_tia";
            textBoxR_tia.ReadOnly = true;
            textBoxR_tia.ScrollBars = ScrollBars.Vertical;
            textBoxR_tia.Size = new Size(370, 608);
            textBoxR_tia.TabIndex = 18;
            textBoxR_tia.TextChanged += textBoxResult_tia_TextChanged;
            // 
            // buttonStrt_tia
            // 
            buttonStrt_tia.BackColor = SystemColors.ActiveCaption;
            buttonStrt_tia.Location = new Point(676, 629);
            buttonStrt_tia.Name = "buttonStrt_tia";
            buttonStrt_tia.Size = new Size(155, 77);
            buttonStrt_tia.TabIndex = 10;
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
            groupBox1.Location = new Point(29, 546);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 160);
            groupBox1.TabIndex = 17;
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
            textBoxtwo_tia.KeyPress += textBoxtwo_tia_KeyPress;
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
            // groupBoxviv_tia
            // 
            groupBoxviv_tia.Controls.Add(textBoxR_tia);
            groupBoxviv_tia.Location = new Point(861, 12);
            groupBoxviv_tia.Name = "groupBoxviv_tia";
            groupBoxviv_tia.Size = new Size(519, 694);
            groupBoxviv_tia.TabIndex = 19;
            groupBoxviv_tia.TabStop = false;
            groupBoxviv_tia.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 740);
            Controls.Add(groupBoxviv_tia);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelpClick_tia);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonStrt_tia);
            Name = "FormMain";
            Text = "Спринт6|Таск1|Вариант16|Тясин И.А.";
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxviv_tia.ResumeLayout(false);
            groupBoxviv_tia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonHelpClick_tia;
        private TextBox textBoxone_tia;
        private TextBox textBoxResult_tia;
        private GroupBox groupBoxTask;
        private PictureBox pictureBox1;
        private Button buttonStrt_tia;
        private GroupBox groupBox1;
        private TextBox textBoxkon_tia;
        private TextBox textBoxtwo_tia;
        private TextBox textBoxstrtshaga_tia;
        private TextBox textBoxR_tia;
        private GroupBox groupBoxviv_tia;
    }
}
