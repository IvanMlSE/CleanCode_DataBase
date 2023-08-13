namespace CleanCode_DataBase
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
            this.passportTextbox = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passportTextbox
            // 
            this.passportTextbox.Location = new System.Drawing.Point(12, 12);
            this.passportTextbox.Name = "passportTextbox";
            this.passportTextbox.Size = new System.Drawing.Size(363, 20);
            this.passportTextbox.TabIndex = 0;
            // 
            // textResult
            // 
            this.textResult.AutoSize = true;
            this.textResult.Location = new System.Drawing.Point(160, 55);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(58, 13);
            this.textResult.TabIndex = 1;
            this.textResult.Text = "TextResult";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(83, 89);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(220, 109);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "checkButton";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.passportTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passportTextbox;
        private System.Windows.Forms.Label textResult;
        private System.Windows.Forms.Button checkButton;
    }
}

