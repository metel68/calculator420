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
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Cuntize = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(331, 38);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.ComputeTwo);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(331, 67);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 4;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.ComputeTwo);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(331, 96);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 23);
            this.Mult.TabIndex = 5;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.ComputeTwo);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(331, 125);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 6;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.ComputeTwo);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(224, 12);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(182, 20);
            this.Result.TabIndex = 9;
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(135, 38);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(75, 23);
            this.Abs.TabIndex = 10;
            this.Abs.Text = "abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.ComputeOne);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(135, 67);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.ComputeOne);
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
            this.SecondValue.Location = new System.Drawing.Point(118, 12);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(100, 20);
            this.SecondValue.TabIndex = 13;
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(135, 97);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 14;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.ComputeOne);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(135, 126);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 15;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.ComputeOne);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(135, 184);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 16;
            this.Arccos.Text = "arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.ComputeOne);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(12, 38);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 23);
            this.Sqrt.TabIndex = 17;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.ComputeOne);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(135, 155);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 23);
            this.Arcsin.TabIndex = 18;
            this.Arcsin.Text = "arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.ComputeOne);
            // 
            // Arctan
            // 
            this.Arctan.Location = new System.Drawing.Point(135, 213);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(75, 23);
            this.Arctan.TabIndex = 19;
            this.Arctan.Text = "arctan";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.ComputeOne);
            // 
            // Cuntize
            // 
            this.Cuntize.Location = new System.Drawing.Point(12, 242);
            this.Cuntize.Name = "Cuntize";
            this.Cuntize.Size = new System.Drawing.Size(394, 23);
            this.Cuntize.TabIndex = 20;
            this.Cuntize.Text = "Сделать чего-нить";
            this.Cuntize.UseVisualStyleBackColor = true;
            this.Cuntize.Click += new System.EventHandler(this.SendUser);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(331, 183);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(75, 23);
            this.Root.TabIndex = 21;
            this.Root.Text = "root";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.ComputeTwo);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(331, 154);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(75, 23);
            this.Pow.TabIndex = 22;
            this.Pow.Text = "pow";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.ComputeTwo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 271);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Cuntize);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
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
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Cuntize;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Pow;
    }
}

