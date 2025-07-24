namespace VK_autoposter
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.controlTab = new System.Windows.Forms.TabPage();
            this.loadSheetDataButton = new System.Windows.Forms.Button();
            this.groupTab = new System.Windows.Forms.TabPage();
            this.groupLinesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainTabs.SuspendLayout();
            this.controlTab.SuspendLayout();
            this.groupTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // test_setup
            // 
            this.test_setup.Location = new System.Drawing.Point(6, 6);
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
            this.TestText.Location = new System.Drawing.Point(8, 406);
            this.TestText.Name = "TestText";
            this.TestText.Size = new System.Drawing.Size(35, 13);
            this.TestText.TabIndex = 1;
            this.TestText.Text = "label1";
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(87, 9);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(100, 20);
            this.inputField.TabIndex = 2;
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.controlTab);
            this.mainTabs.Controls.Add(this.groupTab);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(763, 450);
            this.mainTabs.TabIndex = 3;
            // 
            // controlTab
            // 
            this.controlTab.Controls.Add(this.loadSheetDataButton);
            this.controlTab.Controls.Add(this.inputField);
            this.controlTab.Controls.Add(this.TestText);
            this.controlTab.Controls.Add(this.test_setup);
            this.controlTab.Location = new System.Drawing.Point(4, 22);
            this.controlTab.Name = "controlTab";
            this.controlTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlTab.Size = new System.Drawing.Size(755, 424);
            this.controlTab.TabIndex = 0;
            this.controlTab.Text = "Main";
            this.controlTab.UseVisualStyleBackColor = true;
            // 
            // loadSheetDataButton
            // 
            this.loadSheetDataButton.Location = new System.Drawing.Point(677, 6);
            this.loadSheetDataButton.Name = "loadSheetDataButton";
            this.loadSheetDataButton.Size = new System.Drawing.Size(75, 23);
            this.loadSheetDataButton.TabIndex = 3;
            this.loadSheetDataButton.Text = "Load";
            this.loadSheetDataButton.UseVisualStyleBackColor = true;
            this.loadSheetDataButton.Click += new System.EventHandler(this.loadSheetDataButton_Click);
            // 
            // groupTab
            // 
            this.groupTab.Controls.Add(this.groupLinesPanel);
            this.groupTab.Controls.Add(this.tableLayoutPanel1);
            this.groupTab.Location = new System.Drawing.Point(4, 22);
            this.groupTab.Name = "groupTab";
            this.groupTab.Padding = new System.Windows.Forms.Padding(3);
            this.groupTab.Size = new System.Drawing.Size(755, 424);
            this.groupTab.TabIndex = 1;
            this.groupTab.Text = "Send Info";
            this.groupTab.UseVisualStyleBackColor = true;
            // 
            // groupLinesPanel
            // 
            this.groupLinesPanel.AutoScroll = true;
            this.groupLinesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLinesPanel.Location = new System.Drawing.Point(3, 24);
            this.groupLinesPanel.Name = "groupLinesPanel";
            this.groupLinesPanel.Size = new System.Drawing.Size(749, 397);
            this.groupLinesPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 21);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(83, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Link";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(306, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Send Text";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(529, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.mainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabs.ResumeLayout(false);
            this.controlTab.ResumeLayout(false);
            this.controlTab.PerformLayout();
            this.groupTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test_setup;
        private System.Windows.Forms.Label TestText;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage controlTab;
        private System.Windows.Forms.TabPage groupTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadSheetDataButton;
        private System.Windows.Forms.FlowLayoutPanel groupLinesPanel;
    }
}

