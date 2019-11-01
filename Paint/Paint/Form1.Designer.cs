namespace Paint
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
            this.pencil = new System.Windows.Forms.RadioButton();
            this.rectangle = new System.Windows.Forms.RadioButton();
            this.circle = new System.Windows.Forms.RadioButton();
            this.BtColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(118, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 418);
            this.panel1.TabIndex = 0;
            // 
            // pencil
            // 
            this.pencil.AutoSize = true;
            this.pencil.Location = new System.Drawing.Point(12, 41);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(76, 17);
            this.pencil.TabIndex = 1;
            this.pencil.TabStop = true;
            this.pencil.Text = "Карандаш";
            this.pencil.UseVisualStyleBackColor = true;
            // 
            // rectangle
            // 
            this.rectangle.AutoSize = true;
            this.rectangle.Location = new System.Drawing.Point(12, 64);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(105, 17);
            this.rectangle.TabIndex = 2;
            this.rectangle.TabStop = true;
            this.rectangle.Text = "Прямоугольник";
            this.rectangle.UseVisualStyleBackColor = true;
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(12, 87);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(48, 17);
            this.circle.TabIndex = 3;
            this.circle.TabStop = true;
            this.circle.Text = "Круг";
            this.circle.UseVisualStyleBackColor = true;
            // 
            // BtColor
            // 
            this.BtColor.Location = new System.Drawing.Point(12, 110);
            this.BtColor.Name = "BtColor";
            this.BtColor.Size = new System.Drawing.Size(48, 97);
            this.BtColor.TabIndex = 0;
            this.BtColor.Text = "Цвет";
            this.BtColor.UseVisualStyleBackColor = true;
            this.BtColor.Click += new System.EventHandler(this.BtColor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(66, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 97);
            this.panel2.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 341);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(99, 38);
            this.clear.TabIndex = 4;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtColor);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.pencil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton pencil;
        private System.Windows.Forms.RadioButton rectangle;
        private System.Windows.Forms.RadioButton circle;
        private System.Windows.Forms.Button BtColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

