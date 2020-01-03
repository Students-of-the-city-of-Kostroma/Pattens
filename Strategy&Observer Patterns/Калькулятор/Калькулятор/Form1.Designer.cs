namespace Калькулятор
{
	partial class CalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.StartCap = new System.Windows.Forms.Button();
            this.EndCap = new System.Windows.Forms.Button();
            this.CSB = new System.Windows.Forms.Button();
            this.DrawPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 54;
            // 
            // DrawPanel
            // 
            this.DrawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.DrawPanel.Controls.Add(this.StartCap);
            this.DrawPanel.Controls.Add(this.EndCap);
            this.DrawPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DrawPanel.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(1919, 1080);
            this.DrawPanel.TabIndex = 68;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // StartCap
            // 
            this.StartCap.BackColor = System.Drawing.Color.White;
            this.StartCap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.StartCap.FlatAppearance.BorderSize = 5;
            this.StartCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartCap.Location = new System.Drawing.Point(834, 500);
            this.StartCap.Name = "StartCap";
            this.StartCap.Size = new System.Drawing.Size(50, 50);
            this.StartCap.TabIndex = 73;
            this.StartCap.Text = "N";
            this.StartCap.UseVisualStyleBackColor = false;
            this.StartCap.Click += new System.EventHandler(this.StartCap_Click);
            // 
            // EndCap
            // 
            this.EndCap.BackColor = System.Drawing.Color.White;
            this.EndCap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.EndCap.FlatAppearance.BorderSize = 5;
            this.EndCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EndCap.Location = new System.Drawing.Point(896, 500);
            this.EndCap.Name = "EndCap";
            this.EndCap.Size = new System.Drawing.Size(50, 50);
            this.EndCap.TabIndex = 72;
            this.EndCap.Text = "N";
            this.EndCap.UseVisualStyleBackColor = false;
            this.EndCap.Click += new System.EventHandler(this.EndCap_Click);
            // 
            // CSB
            // 
            this.CSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.CSB.Enabled = false;
            this.CSB.FlatAppearance.BorderSize = 0;
            this.CSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CSB.ForeColor = System.Drawing.SystemColors.Control;
            this.CSB.Location = new System.Drawing.Point(442, 2);
            this.CSB.Name = "CSB";
            this.CSB.Size = new System.Drawing.Size(1, 1);
            this.CSB.TabIndex = 66;
            this.CSB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CSB.UseVisualStyleBackColor = false;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(958, 562);
            this.Controls.Add(this.CSB);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-1, -1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CalcForm";
            this.Text = "MD - Simple Graphics";
            this.SizeChanged += new System.EventHandler(this.CalcForm_SizeChanged);
            this.DrawPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button CSB;
        private System.Windows.Forms.Button StartCap;
        private System.Windows.Forms.Button EndCap;
    }
}

