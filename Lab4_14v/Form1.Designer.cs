namespace Lab4_14v
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
            this.TrB1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrB1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrB1
            // 
            this.TrB1.Location = new System.Drawing.Point(15, 27);
            this.TrB1.Name = "TrB1";
            this.TrB1.Size = new System.Drawing.Size(104, 45);
            this.TrB1.TabIndex = 0;
            this.TrB1.Scroll += new System.EventHandler(this.TrB1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Перевести";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "из метров в секунду в километры в час",
            "из километров в час в метры в секунду"});
            this.comboBox1.Location = new System.Drawing.Point(291, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(73, 6);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(143, 20);
            this.TB1.TabIndex = 4;
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(461, 82);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(75, 23);
            this.Calculate_Button.TabIndex = 5;
            this.Calculate_Button.Text = "Перевести";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Точность";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(84, 54);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(0, 13);
            this.L1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат:";
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(89, 95);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(0, 13);
            this.FinalLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(548, 117);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calculate_Button);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrB1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертатор";
            ((System.ComponentModel.ISupportInitialize)(this.TrB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FinalLabel;
    }
}

