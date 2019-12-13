namespace Puint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnColor = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TFbrush = new System.Windows.Forms.RadioButton();
            this.TFrectangle = new System.Windows.Forms.RadioButton();
            this.TFcircle = new System.Windows.Forms.RadioButton();
            this.BREAK = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ToBox = new System.Windows.Forms.TextBox();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.ToD = new System.Windows.Forms.Button();
            this.FromD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(152, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 225);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.Color.Black;
            this.BtnColor.Location = new System.Drawing.Point(13, 58);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(116, 79);
            this.BtnColor.TabIndex = 3;
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(15, 402);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(114, 36);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размер кисти";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 376);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TFbrush
            // 
            this.TFbrush.AutoSize = true;
            this.TFbrush.Checked = true;
            this.TFbrush.Location = new System.Drawing.Point(15, 157);
            this.TFbrush.Name = "TFbrush";
            this.TFbrush.Size = new System.Drawing.Size(55, 17);
            this.TFbrush.TabIndex = 8;
            this.TFbrush.TabStop = true;
            this.TFbrush.Text = "Кисть";
            this.TFbrush.UseVisualStyleBackColor = true;
            this.TFbrush.CheckedChanged += new System.EventHandler(this.TFbrush_CheckedChanged);
            // 
            // TFrectangle
            // 
            this.TFrectangle.AutoSize = true;
            this.TFrectangle.Location = new System.Drawing.Point(15, 180);
            this.TFrectangle.Name = "TFrectangle";
            this.TFrectangle.Size = new System.Drawing.Size(105, 17);
            this.TFrectangle.TabIndex = 9;
            this.TFrectangle.Text = "Прямоугольник";
            this.TFrectangle.UseVisualStyleBackColor = true;
            this.TFrectangle.CheckedChanged += new System.EventHandler(this.TFbrush_CheckedChanged);
            // 
            // TFcircle
            // 
            this.TFcircle.AutoSize = true;
            this.TFcircle.Location = new System.Drawing.Point(15, 203);
            this.TFcircle.Name = "TFcircle";
            this.TFcircle.Size = new System.Drawing.Size(87, 17);
            this.TFcircle.TabIndex = 10;
            this.TFcircle.Text = "Окружность";
            this.TFcircle.UseVisualStyleBackColor = true;
            this.TFcircle.CheckedChanged += new System.EventHandler(this.TFbrush_CheckedChanged);
            // 
            // BREAK
            // 
            this.BREAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BREAK.Location = new System.Drawing.Point(640, 157);
            this.BREAK.Name = "BREAK";
            this.BREAK.Size = new System.Drawing.Size(148, 59);
            this.BREAK.TabIndex = 18;
            this.BREAK.Text = "Стоп";
            this.BREAK.UseVisualStyleBackColor = true;
            this.BREAK.Click += new System.EventHandler(this.BREAK_Click);
            // 
            // Pause
            // 
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Pause.Location = new System.Drawing.Point(637, 92);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(151, 59);
            this.Pause.TabIndex = 17;
            this.Pause.Text = "Пауза";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Start.Location = new System.Drawing.Point(640, 27);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(148, 59);
            this.Start.TabIndex = 16;
            this.Start.Text = "Стартуем";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(152, 207);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // ToBox
            // 
            this.ToBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ToBox.Location = new System.Drawing.Point(316, 117);
            this.ToBox.Multiline = true;
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(295, 84);
            this.ToBox.TabIndex = 14;
            this.ToBox.Text = "Куда копируем?";
            // 
            // FromBox
            // 
            this.FromBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FromBox.Location = new System.Drawing.Point(316, 27);
            this.FromBox.Multiline = true;
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(295, 84);
            this.FromBox.TabIndex = 13;
            this.FromBox.Text = "Что копируем?";
            // 
            // ToD
            // 
            this.ToD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ToD.Location = new System.Drawing.Point(152, 117);
            this.ToD.Name = "ToD";
            this.ToD.Size = new System.Drawing.Size(158, 84);
            this.ToD.TabIndex = 12;
            this.ToD.Text = "Загрузить в";
            this.ToD.UseVisualStyleBackColor = true;
            this.ToD.Click += new System.EventHandler(this.ToD_Click);
            // 
            // FromD
            // 
            this.FromD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FromD.Location = new System.Drawing.Point(152, 27);
            this.FromD.Name = "FromD";
            this.FromD.Size = new System.Drawing.Size(158, 84);
            this.FromD.TabIndex = 11;
            this.FromD.Text = "Загрузить из";
            this.FromD.UseVisualStyleBackColor = true;
            this.FromD.Click += new System.EventHandler(this.FromD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(149, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Выбор цвета";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BREAK);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.ToD);
            this.Controls.Add(this.FromD);
            this.Controls.Add(this.TFcircle);
            this.Controls.Add(this.TFrectangle);
            this.Controls.Add(this.TFbrush);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton TFbrush;
        private System.Windows.Forms.RadioButton TFrectangle;
        private System.Windows.Forms.RadioButton TFcircle;
        private System.Windows.Forms.Button BREAK;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox ToBox;
        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.Button ToD;
        private System.Windows.Forms.Button FromD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

