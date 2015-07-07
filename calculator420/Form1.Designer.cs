namespace Calculator
{
    partial class MainForm
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
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Abs = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.FirstValue = new System.Windows.Forms.TextBox();
            this.SecondValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(302, 51);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Compute);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(302, 80);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 4;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Compute);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(302, 109);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 23);
            this.Mult.TabIndex = 5;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Compute);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(302, 138);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 6;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Compute);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(302, 12);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 9;
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(124, 50);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(75, 23);
            this.Abs.TabIndex = 10;
            this.Abs.Text = "abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.Process);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(124, 79);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Process);
            // 
            // FirstValue
            // 
            this.FirstValue.Location = new System.Drawing.Point(12, 12);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(100, 20);
            this.FirstValue.TabIndex = 12;
            // 
            // SecondValue
            // 
            this.SecondValue.Location = new System.Drawing.Point(124, 12);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(100, 20);
            this.SecondValue.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 262);
            this.Controls.Add(this.SecondValue);
            this.Controls.Add(this.FirstValue);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Name = "MainForm";
            this.Text = "Calculator 420";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.TextBox FirstValue;
        private System.Windows.Forms.TextBox SecondValue;
    }
}

