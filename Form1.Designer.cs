﻿namespace VK_autoposter
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
            this.test_setup = new System.Windows.Forms.Button();
            this.TestText = new System.Windows.Forms.Label();
            this.inputField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test_setup
            // 
            this.test_setup.Location = new System.Drawing.Point(12, 12);
            this.test_setup.Name = "test_setup";
            this.test_setup.Size = new System.Drawing.Size(75, 23);
            this.test_setup.TabIndex = 0;
            this.test_setup.Text = "Test";
            this.test_setup.UseVisualStyleBackColor = true;
            this.test_setup.Click += new System.EventHandler(this.test_setup_Click);
            // 
            // TestText
            // 
            this.TestText.AutoSize = true;
            this.TestText.Location = new System.Drawing.Point(12, 64);
            this.TestText.Name = "TestText";
            this.TestText.Size = new System.Drawing.Size(35, 13);
            this.TestText.TabIndex = 1;
            this.TestText.Text = "label1";
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(12, 41);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(100, 20);
            this.inputField.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.TestText);
            this.Controls.Add(this.test_setup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test_setup;
        private System.Windows.Forms.Label TestText;
        private System.Windows.Forms.TextBox inputField;
    }
}

