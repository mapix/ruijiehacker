namespace IpSwitcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipListBox = new System.Windows.Forms.ListBox();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.currentIplabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip Address(es):";
            // 
            // ipListBox
            // 
            this.ipListBox.FormattingEnabled = true;
            this.ipListBox.ItemHeight = 12;
            this.ipListBox.Location = new System.Drawing.Point(12, 62);
            this.ipListBox.Name = "ipListBox";
            this.ipListBox.Size = new System.Drawing.Size(129, 160);
            this.ipListBox.TabIndex = 1;
            // 
            // SwitchButton
            // 
            this.SwitchButton.Location = new System.Drawing.Point(159, 159);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(58, 23);
            this.SwitchButton.TabIndex = 4;
            this.SwitchButton.Text = "Switch";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "IpSwitcher Use In NAT Network";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(159, 199);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(159, 62);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(58, 23);
            this.aboutButton.TabIndex = 8;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(159, 131);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(58, 22);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // currentIplabel
            // 
            this.currentIplabel.AutoSize = true;
            this.currentIplabel.Location = new System.Drawing.Point(12, 236);
            this.currentIplabel.Name = "currentIplabel";
            this.currentIplabel.Size = new System.Drawing.Size(95, 12);
            this.currentIplabel.TabIndex = 10;
            this.currentIplabel.Text = "Current IpAddr:";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(159, 92);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(58, 23);
            this.openButton.TabIndex = 11;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 260);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.currentIplabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.ipListBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "IpSwitcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ipListBox;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label currentIplabel;
        private System.Windows.Forms.Button openButton;
    }
}

