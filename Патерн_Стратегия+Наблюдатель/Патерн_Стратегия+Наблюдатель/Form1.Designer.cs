namespace Патерн_Стратегия_Наблюдатель
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.cbStartCapLine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEndCapLine = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(119, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(569, 443);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // cbStartCapLine
            // 
            this.cbStartCapLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartCapLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStartCapLine.FormattingEnabled = true;
            this.cbStartCapLine.Items.AddRange(new object[] {
            "->",
            "-|>",
            "-"});
            this.cbStartCapLine.Location = new System.Drawing.Point(12, 46);
            this.cbStartCapLine.Name = "cbStartCapLine";
            this.cbStartCapLine.Size = new System.Drawing.Size(101, 24);
            this.cbStartCapLine.TabIndex = 1;
            this.cbStartCapLine.SelectedIndexChanged += new System.EventHandler(this.cbStartCapLine_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "End";
            // 
            // cbEndCapLine
            // 
            this.cbEndCapLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndCapLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEndCapLine.FormattingEnabled = true;
            this.cbEndCapLine.Items.AddRange(new object[] {
            "->",
            "-|>",
            "-"});
            this.cbEndCapLine.Location = new System.Drawing.Point(12, 118);
            this.cbEndCapLine.Name = "cbEndCapLine";
            this.cbEndCapLine.Size = new System.Drawing.Size(101, 24);
            this.cbEndCapLine.TabIndex = 4;
            this.cbEndCapLine.SelectedIndexChanged += new System.EventHandler(this.cbEndCapLine_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 467);
            this.Controls.Add(this.cbEndCapLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStartCapLine);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ComboBox cbStartCapLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEndCapLine;
    }
}

