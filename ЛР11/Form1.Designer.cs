namespace ЛР11
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
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateEvenSum
            // 
            this.btnCalculateEvenSum.Location = new System.Drawing.Point(50, 190);
            this.btnCalculateEvenSum.Name = "btnCalculateEvenSum";
            this.btnCalculateEvenSum.Size = new System.Drawing.Size(154, 22);
            this.btnCalculateEvenSum.TabIndex = 0;
            this.btnCalculateEvenSum.Text = "Рассчитать";
            this.btnCalculateEvenSum.UseVisualStyleBackColor = true;
            this.btnCalculateEvenSum.Click += new System.EventHandler(this.btnCalculateEvenSum_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(52, 124);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(152, 20);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Text = "1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(235, 131);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Результат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Найти сумму четных чисел числа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnCalculateEvenSum);
            this.Name = "Form1";
            this.Text = "БеловаЕкатеринаИвановна1вариантДКИП-482";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateEvenSum;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
    }
}

