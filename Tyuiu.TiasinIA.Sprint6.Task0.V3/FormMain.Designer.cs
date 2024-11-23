namespace Tyuiu.TiasinIA.Sprint6.Task0.V3
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
            buttonStrt_tia = new Button();
            pictureBox1 = new PictureBox();
            groupBoxTask = new GroupBox();
            textBoxTask_tia = new TextBox();
            textBoxResult_tia = new TextBox();
            textBoxone_tia = new TextBox();
            buttonHelpClick_tia = new Button();
            textBoxd_tia = new TextBox();
            textBoxA_tia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxTask.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStrt_tia
            // 
            buttonStrt_tia.Location = new Point(810, 413);
            buttonStrt_tia.Name = "buttonStrt_tia";
            buttonStrt_tia.Size = new Size(155, 75);
            buttonStrt_tia.TabIndex = 0;
            buttonStrt_tia.Text = "Выполнить";
            buttonStrt_tia.UseVisualStyleBackColor = true;
            buttonStrt_tia.Click += buttonfst_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(758, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 93);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask_tia);
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Location = new Point(52, 34);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(930, 274);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // textBoxTask_tia
            // 
            textBoxTask_tia.Location = new Point(27, 38);
            textBoxTask_tia.Multiline = true;
            textBoxTask_tia.Name = "textBoxTask_tia";
            textBoxTask_tia.ReadOnly = true;
            textBoxTask_tia.Size = new Size(695, 212);
            textBoxTask_tia.TabIndex = 2;
            textBoxTask_tia.Text = "Вариант 3\r\nДано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // textBoxResult_tia
            // 
            textBoxResult_tia.Location = new Point(810, 380);
            textBoxResult_tia.Name = "textBoxResult_tia";
            textBoxResult_tia.ReadOnly = true;
            textBoxResult_tia.Size = new Size(155, 27);
            textBoxResult_tia.TabIndex = 3;
            // 
            // textBoxone_tia
            // 
            textBoxone_tia.Location = new Point(70, 395);
            textBoxone_tia.Name = "textBoxone_tia";
            textBoxone_tia.Size = new Size(147, 27);
            textBoxone_tia.TabIndex = 4;
            textBoxone_tia.KeyPress += textBoxone_tia_KeyPress;
            // 
            // buttonHelpClick_tia
            // 
            buttonHelpClick_tia.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_tia.Location = new Point(735, 438);
            buttonHelpClick_tia.Name = "buttonHelpClick_tia";
            buttonHelpClick_tia.Size = new Size(69, 50);
            buttonHelpClick_tia.TabIndex = 7;
            buttonHelpClick_tia.Text = "?";
            buttonHelpClick_tia.UseVisualStyleBackColor = true;
            buttonHelpClick_tia.Click += buttonHelpClick_tia_Click;
            buttonHelpClick_tia.KeyPress += textBoxone_tia_KeyPress;
            // 
            // textBoxd_tia
            // 
            textBoxd_tia.Location = new Point(52, 314);
            textBoxd_tia.Name = "textBoxd_tia";
            textBoxd_tia.ReadOnly = true;
            textBoxd_tia.Size = new Size(125, 27);
            textBoxd_tia.TabIndex = 8;
            textBoxd_tia.Text = "Вводд данных";
            textBoxd_tia.TextChanged += textBoxd_tia_TextChanged;
            // 
            // textBoxA_tia
            // 
            textBoxA_tia.Location = new Point(70, 362);
            textBoxA_tia.Name = "textBoxA_tia";
            textBoxA_tia.ReadOnly = true;
            textBoxA_tia.Size = new Size(147, 27);
            textBoxA_tia.TabIndex = 9;
            textBoxA_tia.Text = "Переменная X";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 548);
            Controls.Add(textBoxA_tia);
            Controls.Add(textBoxd_tia);
            Controls.Add(buttonHelpClick_tia);
            Controls.Add(textBoxone_tia);
            Controls.Add(textBoxResult_tia);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonStrt_tia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6|Таск0|Вариант3|Тясин И.А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStrt_tia;
        private PictureBox pictureBox1;
        private GroupBox groupBoxTask;
        private TextBox textBoxResult_tia;
        private TextBox textBoxone_tia;
        private Button buttonHelpClick_tia;
        private TextBox textBoxTask_tia;
        private TextBox textBoxd_tia;
        private TextBox textBoxA_tia;
    }
}
