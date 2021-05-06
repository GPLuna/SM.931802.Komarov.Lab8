
namespace SM._931802.Komarov.Lab8
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.YNButton = new System.Windows.Forms.Button();
            this.BallButton = new System.Windows.Forms.Button();
            this.LAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(122, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Стоит ли выйти из комнаты?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YNButton
            // 
            this.YNButton.Location = new System.Drawing.Point(122, 210);
            this.YNButton.Name = "YNButton";
            this.YNButton.Size = new System.Drawing.Size(158, 37);
            this.YNButton.TabIndex = 1;
            this.YNButton.Text = "Да\\Нет";
            this.YNButton.UseVisualStyleBackColor = true;
            this.YNButton.Click += new System.EventHandler(this.YNButton_Click);
            // 
            // BallButton
            // 
            this.BallButton.Location = new System.Drawing.Point(505, 210);
            this.BallButton.Name = "BallButton";
            this.BallButton.Size = new System.Drawing.Size(158, 37);
            this.BallButton.TabIndex = 2;
            this.BallButton.Text = "Шар предсказаний";
            this.BallButton.UseVisualStyleBackColor = true;
            this.BallButton.Click += new System.EventHandler(this.BallButton_Click);
            // 
            // LAnswer
            // 
            this.LAnswer.AutoSize = true;
            this.LAnswer.Location = new System.Drawing.Point(119, 276);
            this.LAnswer.Name = "LAnswer";
            this.LAnswer.Size = new System.Drawing.Size(48, 17);
            this.LAnswer.TabIndex = 3;
            this.LAnswer.Text = "Ответ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LAnswer);
            this.Controls.Add(this.BallButton);
            this.Controls.Add(this.YNButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button YNButton;
        private System.Windows.Forms.Button BallButton;
        private System.Windows.Forms.Label LAnswer;
    }
}

