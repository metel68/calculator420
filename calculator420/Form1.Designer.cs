namespace calculator420
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(0, 12);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 0;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(162, 12);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 1;
            this.B.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(302, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(293, 52);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(293, 81);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 4;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(293, 110);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 23);
            this.Mult.TabIndex = 5;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(293, 139);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 6;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 262);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
    }
}

