namespace EODLoader.Forms
{
    partial class SettingsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("OAuth");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General Preferences");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Logging");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsTreeView = new System.Windows.Forms.TreeView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.OAuthTab = new System.Windows.Forms.TabPage();
            this.tokenLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.LoggingTab = new System.Windows.Forms.TabPage();
            this.proxyGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.proxyCheckBox = new System.Windows.Forms.CheckBox();
            this.proxyCheckButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.logFileButton = new System.Windows.Forms.Button();
            this.logFileTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.OAuthTab.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.LoggingTab.SuspendLayout();
            this.proxyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTreeView
            // 
            this.settingsTreeView.Location = new System.Drawing.Point(12, 12);
            this.settingsTreeView.Name = "settingsTreeView";
            treeNode1.Name = "OAuthNode";
            treeNode1.Text = "OAuth";
            treeNode2.Name = "GeneralNode";
            treeNode2.Text = "General Preferences";
            treeNode3.Name = "LoggingNode";
            treeNode3.Text = "Logging";
            this.settingsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.settingsTreeView.Size = new System.Drawing.Size(156, 373);
            this.settingsTreeView.TabIndex = 1;
            this.settingsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.settingsTreeView_NodeMouseClick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.settingsTabControl);
            this.groupBox.Location = new System.Drawing.Point(176, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(360, 380);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "OAuth";
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.OAuthTab);
            this.settingsTabControl.Controls.Add(this.GeneralTab);
            this.settingsTabControl.Controls.Add(this.LoggingTab);
            this.settingsTabControl.Location = new System.Drawing.Point(6, 19);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(348, 355);
            this.settingsTabControl.TabIndex = 4;
            // 
            // OAuthTab
            // 
            this.OAuthTab.Controls.Add(this.tokenLinkLabel);
            this.OAuthTab.Controls.Add(this.tokenLabel);
            this.OAuthTab.Controls.Add(this.tokenTextBox);
            this.OAuthTab.Location = new System.Drawing.Point(4, 22);
            this.OAuthTab.Name = "OAuthTab";
            this.OAuthTab.Padding = new System.Windows.Forms.Padding(3);
            this.OAuthTab.Size = new System.Drawing.Size(332, 329);
            this.OAuthTab.TabIndex = 0;
            this.OAuthTab.Text = "OAuth";
            this.OAuthTab.UseVisualStyleBackColor = true;
            // 
            // tokenLinkLabel
            // 
            this.tokenLinkLabel.AutoSize = true;
            this.tokenLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tokenLinkLabel.Location = new System.Drawing.Point(279, 21);
            this.tokenLinkLabel.Name = "tokenLinkLabel";
            this.tokenLinkLabel.Size = new System.Drawing.Size(54, 13);
            this.tokenLinkLabel.TabIndex = 2;
            this.tokenLinkLabel.TabStop = true;
            this.tokenLinkLabel.Text = "Get token";
            this.tokenLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tokenLinkLabel_LinkClicked);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(6, 21);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(41, 13);
            this.tokenLabel.TabIndex = 1;
            this.tokenLabel.Text = "Token:";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Location = new System.Drawing.Point(53, 18);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(220, 20);
            this.tokenTextBox.TabIndex = 0;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.proxyGroupBox);
            this.GeneralTab.Controls.Add(this.proxyCheckBox);
            this.GeneralTab.Controls.Add(this.autoUpdateCheckBox);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(340, 329);
            this.GeneralTab.TabIndex = 1;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // LoggingTab
            // 
            this.LoggingTab.Controls.Add(this.logFileTextBox);
            this.LoggingTab.Controls.Add(this.logFileButton);
            this.LoggingTab.Location = new System.Drawing.Point(4, 22);
            this.LoggingTab.Name = "LoggingTab";
            this.LoggingTab.Size = new System.Drawing.Size(340, 329);
            this.LoggingTab.TabIndex = 2;
            this.LoggingTab.Text = "Logging";
            this.LoggingTab.UseVisualStyleBackColor = true;
            // 
            // proxyGroupBox
            // 
            this.proxyGroupBox.Controls.Add(this.label5);
            this.proxyGroupBox.Controls.Add(this.proxyCheckButton);
            this.proxyGroupBox.Controls.Add(this.label4);
            this.proxyGroupBox.Controls.Add(this.label3);
            this.proxyGroupBox.Controls.Add(this.label2);
            this.proxyGroupBox.Controls.Add(this.label1);
            this.proxyGroupBox.Controls.Add(this.textBox3);
            this.proxyGroupBox.Controls.Add(this.textBox2);
            this.proxyGroupBox.Controls.Add(this.textBox1);
            this.proxyGroupBox.Enabled = false;
            this.proxyGroupBox.Location = new System.Drawing.Point(6, 56);
            this.proxyGroupBox.Name = "proxyGroupBox";
            this.proxyGroupBox.Size = new System.Drawing.Size(320, 171);
            this.proxyGroupBox.TabIndex = 2;
            this.proxyGroupBox.TabStop = false;
            this.proxyGroupBox.Text = "Proxy server";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 0;
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(6, 10);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(160, 17);
            this.autoUpdateCheckBox.TabIndex = 1;
            this.autoUpdateCheckBox.Text = "Check for updates at startup";
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(209, 391);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP address/name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "and port number";
            // 
            // proxyCheckBox
            // 
            this.proxyCheckBox.AutoSize = true;
            this.proxyCheckBox.Location = new System.Drawing.Point(6, 33);
            this.proxyCheckBox.Name = "proxyCheckBox";
            this.proxyCheckBox.Size = new System.Drawing.Size(105, 17);
            this.proxyCheckBox.TabIndex = 1;
            this.proxyCheckBox.Text = "Use proxy server";
            this.proxyCheckBox.UseVisualStyleBackColor = true;
            this.proxyCheckBox.CheckedChanged += new System.EventHandler(this.proxyCheckBox_CheckedChanged);
            // 
            // proxyCheckButton
            // 
            this.proxyCheckButton.Location = new System.Drawing.Point(121, 140);
            this.proxyCheckButton.Name = "proxyCheckButton";
            this.proxyCheckButton.Size = new System.Drawing.Size(81, 23);
            this.proxyCheckButton.TabIndex = 3;
            this.proxyCheckButton.Text = "Check proxy";
            this.proxyCheckButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Example: localhost:2290";
            // 
            // logFileButton
            // 
            this.logFileButton.Location = new System.Drawing.Point(3, 19);
            this.logFileButton.Name = "logFileButton";
            this.logFileButton.Size = new System.Drawing.Size(92, 23);
            this.logFileButton.TabIndex = 0;
            this.logFileButton.Text = "Log file";
            this.logFileButton.UseVisualStyleBackColor = true;
            this.logFileButton.Click += new System.EventHandler(this.logFileButton_Click);
            // 
            // logFileTextBox
            // 
            this.logFileTextBox.Location = new System.Drawing.Point(101, 21);
            this.logFileTextBox.Name = "logFileTextBox";
            this.logFileTextBox.Size = new System.Drawing.Size(236, 20);
            this.logFileTextBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 422);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.settingsTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EODLoader Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox.ResumeLayout(false);
            this.settingsTabControl.ResumeLayout(false);
            this.OAuthTab.ResumeLayout(false);
            this.OAuthTab.PerformLayout();
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            this.LoggingTab.ResumeLayout(false);
            this.LoggingTab.PerformLayout();
            this.proxyGroupBox.ResumeLayout(false);
            this.proxyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView settingsTreeView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.LinkLabel tokenLinkLabel;
        private System.Windows.Forms.CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.GroupBox proxyGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage OAuthTab;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage LoggingTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button proxyCheckButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox proxyCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logFileButton;
        private System.Windows.Forms.TextBox logFileTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}