namespace RuiJieHacker
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hackerButton = new System.Windows.Forms.Button();
            this.macListBox = new System.Windows.Forms.ListBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.macTextBox = new System.Windows.Forms.TextBox();
            this.SetMacButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domainTextBox
            // 
            this.domainTextBox.Location = new System.Drawing.Point(97, 8);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(157, 21);
            this.domainTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(184, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your Domain:";
            // 
            // hackerButton
            // 
            this.hackerButton.Location = new System.Drawing.Point(184, 105);
            this.hackerButton.Name = "hackerButton";
            this.hackerButton.Size = new System.Drawing.Size(75, 23);
            this.hackerButton.TabIndex = 7;
            this.hackerButton.Text = "DoHacker";
            this.hackerButton.UseVisualStyleBackColor = true;
            this.hackerButton.Click += new System.EventHandler(this.hackerButton_Click);
            // 
            // macListBox
            // 
            this.macListBox.FormattingEnabled = true;
            this.macListBox.ItemHeight = 12;
            this.macListBox.Location = new System.Drawing.Point(12, 45);
            this.macListBox.Name = "macListBox";
            this.macListBox.Size = new System.Drawing.Size(155, 172);
            this.macListBox.TabIndex = 8;
            // 
            // generateButton
            // 
            this.generateButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.generateButton.Location = new System.Drawing.Point(184, 304);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Generate A Unique Mac For Me";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 161);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Set Your Mac Yourself";
            // 
            // macTextBox
            // 
            this.macTextBox.Location = new System.Drawing.Point(12, 261);
            this.macTextBox.Name = "macTextBox";
            this.macTextBox.Size = new System.Drawing.Size(141, 21);
            this.macTextBox.TabIndex = 13;
            // 
            // SetMacButton
            // 
            this.SetMacButton.Location = new System.Drawing.Point(184, 261);
            this.SetMacButton.Name = "SetMacButton";
            this.SetMacButton.Size = new System.Drawing.Size(75, 23);
            this.SetMacButton.TabIndex = 14;
            this.SetMacButton.Text = "SetMac";
            this.SetMacButton.UseVisualStyleBackColor = true;
            this.SetMacButton.Click += new System.EventHandler(this.SetMacButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 341);
            this.Controls.Add(this.SetMacButton);
            this.Controls.Add(this.macTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.macListBox);
            this.Controls.Add(this.hackerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.domainTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RuiJieHacker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hackerButton;
        private System.Windows.Forms.ListBox macListBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox macTextBox;
        private System.Windows.Forms.Button SetMacButton;
    }
}

