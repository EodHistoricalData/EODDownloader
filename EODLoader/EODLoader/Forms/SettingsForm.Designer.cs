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
            this.proxyGroupBox = new System.Windows.Forms.GroupBox();
            this.checkPictureBox = new System.Windows.Forms.PictureBox();
            this.credentialsGroupBox = new System.Windows.Forms.GroupBox();
            this.proxyUserNameTextBox = new System.Windows.Forms.TextBox();
            this.proxyUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.credentialsCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proxyCheckButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proxyAddresstextBox = new System.Windows.Forms.TextBox();
            this.proxyCheckBox = new System.Windows.Forms.CheckBox();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.LoggingTab = new System.Windows.Forms.TabPage();
            this.logFileTextBox = new System.Windows.Forms.TextBox();
            this.logFileButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.OAuthTab.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.proxyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).BeginInit();
            this.credentialsGroupBox.SuspendLayout();
            this.LoggingTab.SuspendLayout();
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
            this.OAuthTab.Size = new System.Drawing.Size(340, 329);
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
            // proxyGroupBox
            // 
            this.proxyGroupBox.Controls.Add(this.checkPictureBox);
            this.proxyGroupBox.Controls.Add(this.credentialsGroupBox);
            this.proxyGroupBox.Controls.Add(this.credentialsCheckBox);
            this.proxyGroupBox.Controls.Add(this.label5);
            this.proxyGroupBox.Controls.Add(this.proxyCheckButton);
            this.proxyGroupBox.Controls.Add(this.label4);
            this.proxyGroupBox.Controls.Add(this.label1);
            this.proxyGroupBox.Controls.Add(this.proxyAddresstextBox);
            this.proxyGroupBox.Enabled = false;
            this.proxyGroupBox.Location = new System.Drawing.Point(6, 66);
            this.proxyGroupBox.Name = "proxyGroupBox";
            this.proxyGroupBox.Size = new System.Drawing.Size(320, 208);
            this.proxyGroupBox.TabIndex = 2;
            this.proxyGroupBox.TabStop = false;
            this.proxyGroupBox.Text = "Proxy server";
            // 
            // checkPictureBox
            // 
            this.checkPictureBox.ErrorImage = global::EODLoader.Properties.Resources.StatusError;
            this.checkPictureBox.Image = global::EODLoader.Properties.Resources.StatusOK;
            this.checkPictureBox.Location = new System.Drawing.Point(234, 176);
            this.checkPictureBox.Name = "checkPictureBox";
            this.checkPictureBox.Size = new System.Drawing.Size(16, 16);
            this.checkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.checkPictureBox.TabIndex = 7;
            this.checkPictureBox.TabStop = false;
            this.checkPictureBox.Visible = false;
            // 
            // credentialsGroupBox
            // 
            this.credentialsGroupBox.Controls.Add(this.proxyUserNameTextBox);
            this.credentialsGroupBox.Controls.Add(this.proxyUserPasswordTextBox);
            this.credentialsGroupBox.Controls.Add(this.label2);
            this.credentialsGroupBox.Controls.Add(this.label3);
            this.credentialsGroupBox.Enabled = false;
            this.credentialsGroupBox.Location = new System.Drawing.Point(6, 94);
            this.credentialsGroupBox.Name = "credentialsGroupBox";
            this.credentialsGroupBox.Size = new System.Drawing.Size(308, 73);
            this.credentialsGroupBox.TabIndex = 6;
            this.credentialsGroupBox.TabStop = false;
            this.credentialsGroupBox.Text = "Credentials";
            // 
            // proxyUserNameTextBox
            // 
            this.proxyUserNameTextBox.Location = new System.Drawing.Point(126, 21);
            this.proxyUserNameTextBox.Name = "proxyUserNameTextBox";
            this.proxyUserNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.proxyUserNameTextBox.TabIndex = 0;
            // 
            // proxyUserPasswordTextBox
            // 
            this.proxyUserPasswordTextBox.Location = new System.Drawing.Point(126, 47);
            this.proxyUserPasswordTextBox.Name = "proxyUserPasswordTextBox";
            this.proxyUserPasswordTextBox.Size = new System.Drawing.Size(168, 20);
            this.proxyUserPasswordTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // credentialsCheckBox
            // 
            this.credentialsCheckBox.AutoSize = true;
            this.credentialsCheckBox.Location = new System.Drawing.Point(25, 71);
            this.credentialsCheckBox.Name = "credentialsCheckBox";
            this.credentialsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.credentialsCheckBox.TabIndex = 5;
            this.credentialsCheckBox.Text = "With credentials";
            this.credentialsCheckBox.UseVisualStyleBackColor = true;
            this.credentialsCheckBox.CheckedChanged += new System.EventHandler(this.credentialsCheckBox_CheckedChanged);
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
            // proxyCheckButton
            // 
            this.proxyCheckButton.Location = new System.Drawing.Point(87, 173);
            this.proxyCheckButton.Name = "proxyCheckButton";
            this.proxyCheckButton.Size = new System.Drawing.Size(141, 23);
            this.proxyCheckButton.TabIndex = 3;
            this.proxyCheckButton.Text = "Check proxy connection";
            this.proxyCheckButton.UseVisualStyleBackColor = true;
            this.proxyCheckButton.Click += new System.EventHandler(this.proxyCheckButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP address/name";
            // 
            // proxyAddresstextBox
            // 
            this.proxyAddresstextBox.Location = new System.Drawing.Point(126, 29);
            this.proxyAddresstextBox.Name = "proxyAddresstextBox";
            this.proxyAddresstextBox.Size = new System.Drawing.Size(167, 20);
            this.proxyAddresstextBox.TabIndex = 0;
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
            // logFileTextBox
            // 
            this.logFileTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logFileTextBox.Location = new System.Drawing.Point(3, 21);
            this.logFileTextBox.Name = "logFileTextBox";
            this.logFileTextBox.ReadOnly = true;
            this.logFileTextBox.Size = new System.Drawing.Size(334, 20);
            this.logFileTextBox.TabIndex = 1;
            // 
            // logFileButton
            // 
            this.logFileButton.Location = new System.Drawing.Point(0, 49);
            this.logFileButton.Name = "logFileButton";
            this.logFileButton.Size = new System.Drawing.Size(92, 23);
            this.logFileButton.TabIndex = 0;
            this.logFileButton.Text = "Log file";
            this.logFileButton.UseVisualStyleBackColor = true;
            this.logFileButton.Visible = false;
            this.logFileButton.Click += new System.EventHandler(this.logFileButton_Click);
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
            this.proxyGroupBox.ResumeLayout(false);
            this.proxyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).EndInit();
            this.credentialsGroupBox.ResumeLayout(false);
            this.credentialsGroupBox.PerformLayout();
            this.LoggingTab.ResumeLayout(false);
            this.LoggingTab.PerformLayout();
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
        private System.Windows.Forms.TextBox proxyAddresstextBox;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage OAuthTab;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage LoggingTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button proxyCheckButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proxyUserPasswordTextBox;
        private System.Windows.Forms.TextBox proxyUserNameTextBox;
        private System.Windows.Forms.CheckBox proxyCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logFileButton;
        private System.Windows.Forms.TextBox logFileTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox credentialsCheckBox;
        private System.Windows.Forms.GroupBox credentialsGroupBox;
        private System.Windows.Forms.PictureBox checkPictureBox;
    }
}