namespace ЛР1
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
            this.btnCalculateEvenSum = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblFactorialResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateEvenSum
            // 
            this.btnCalculateEvenSum.Location = new System.Drawing.Point(44, 195);
            this.btnCalculateEvenSum.Name = "btnCalculateEvenSum";
            this.btnCalculateEvenSum.Size = new System.Drawing.Size(102, 30);
            this.btnCalculateEvenSum.TabIndex = 0;
            this.btnCalculateEvenSum.Text = "Рассчитать";
            this.btnCalculateEvenSum.UseVisualStyleBackColor = true;
            this.btnCalculateEvenSum.Click += new System.EventHandler(this.btnCalculateFactorial_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(46, 107);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.Text = "4";
            // 
            // lblFactorialResult
            // 
            this.lblFactorialResult.AutoSize = true;
            this.lblFactorialResult.Location = new System.Drawing.Point(188, 110);
            this.lblFactorialResult.Name = "lblFactorialResult";
            this.lblFactorialResult.Size = new System.Drawing.Size(59, 13);
            this.lblFactorialResult.TabIndex = 8;
            this.lblFactorialResult.Text = "Результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вычисление факториала числа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFactorialResult);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnCalculateEvenSum);
            this.Name = "Form1";
            this.Text = "БеловаЕкатеринаИвановна16вариантДКИП-482";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateEvenSum;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblFactorialResult;
        private System.Windows.Forms.Label label2;
    }
}

