namespace Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkProxy = new System.Windows.Forms.CheckBox();
            this.btnCrawl = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNbr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkProxy);
            this.splitContainer1.Panel1.Controls.Add(this.btnCrawl);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.txtSeed);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPassword);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtUserName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrefix);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtNbr);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpLog);
            this.splitContainer1.Size = new System.Drawing.Size(771, 414);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkProxy
            // 
            this.chkProxy.AutoSize = true;
            this.chkProxy.Location = new System.Drawing.Point(503, 63);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Size = new System.Drawing.Size(97, 17);
            this.chkProxy.TabIndex = 5;
            this.chkProxy.Text = "don\'t use proxy";
            this.chkProxy.UseVisualStyleBackColor = true;
            this.chkProxy.CheckedChanged += new System.EventHandler(this.chkProxy_CheckedChanged);
            // 
            // btnCrawl
            // 
            this.btnCrawl.Location = new System.Drawing.Point(144, 101);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(207, 23);
            this.btnCrawl.TabIndex = 2;
            this.btnCrawl.Text = "Crawl";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(503, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(207, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Files";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(144, 11);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(207, 20);
            this.txtSeed.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "seed";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(503, 37);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "proxy password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(503, 11);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "proxy user name";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(144, 63);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(207, 20);
            this.txtPrefix.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "file name prefix";
            // 
            // txtNbr
            // 
            this.txtNbr.Location = new System.Drawing.Point(144, 37);
            this.txtNbr.Name = "txtNbr";
            this.txtNbr.Size = new System.Drawing.Size(207, 20);
            this.txtNbr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "max number of links";
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLog.Location = new System.Drawing.Point(0, 0);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(771, 281);
            this.grpLog.TabIndex = 20;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(765, 262);
            this.txtLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 414);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Crawler Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkProxy;
        private System.Windows.Forms.Button btnCrawl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
    }
}

