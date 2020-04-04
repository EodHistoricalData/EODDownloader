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
            this.loggingPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.oAuthPanel = new System.Windows.Forms.Panel();
            this.tokenLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.proxyGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.loggingPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.generalPanel.SuspendLayout();
            this.oAuthPanel.SuspendLayout();
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
            this.groupBox.Controls.Add(this.loggingPanel);
            this.groupBox.Controls.Add(this.OutputPanel);
            this.groupBox.Controls.Add(this.generalPanel);
            this.groupBox.Controls.Add(this.oAuthPanel);
            this.groupBox.Location = new System.Drawing.Point(176, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(360, 380);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "OAuth";
            // 
            // loggingPanel
            // 
            this.loggingPanel.Controls.Add(this.label3);
            this.loggingPanel.Location = new System.Drawing.Point(283, 225);
            this.loggingPanel.Name = "loggingPanel";
            this.loggingPanel.Size = new System.Drawing.Size(58, 43);
            this.loggingPanel.TabIndex = 3;
            this.loggingPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.label2);
            this.OutputPanel.Location = new System.Drawing.Point(14, 225);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(78, 37);
            this.OutputPanel.TabIndex = 2;
            this.OutputPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // generalPanel
            // 
            this.generalPanel.Controls.Add(this.proxyGroupBox);
            this.generalPanel.Controls.Add(this.autoUpdateCheckBox);
            this.generalPanel.Controls.Add(this.label1);
            this.generalPanel.Location = new System.Drawing.Point(14, 19);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(282, 165);
            this.generalPanel.TabIndex = 1;
            this.generalPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // oAuthPanel
            // 
            this.oAuthPanel.Controls.Add(this.tokenLinkLabel);
            this.oAuthPanel.Controls.Add(this.tokenLabel);
            this.oAuthPanel.Controls.Add(this.textBox1);
            this.oAuthPanel.Location = new System.Drawing.Point(14, 274);
            this.oAuthPanel.Name = "oAuthPanel";
            this.oAuthPanel.Size = new System.Drawing.Size(340, 100);
            this.oAuthPanel.TabIndex = 0;
            // 
            // tokenLinkLabel
            // 
            this.tokenLinkLabel.AutoSize = true;
            this.tokenLinkLabel.Location = new System.Drawing.Point(288, 32);
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
            this.tokenLabel.Location = new System.Drawing.Point(15, 32);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(41, 13);
            this.tokenLabel.TabIndex = 1;
            this.tokenLabel.Text = "Token:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 0;
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
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(11, 11);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(160, 17);
            this.autoUpdateCheckBox.TabIndex = 1;
            this.autoUpdateCheckBox.Text = "Check for updates at startup";
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // proxyGroupBox
            // 
            this.proxyGroupBox.Location = new System.Drawing.Point(11, 34);
            this.proxyGroupBox.Name = "proxyGroupBox";
            this.proxyGroupBox.Size = new System.Drawing.Size(251, 114);
            this.proxyGroupBox.TabIndex = 2;
            this.proxyGroupBox.TabStop = false;
            this.proxyGroupBox.Text = "Proxy server";
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
            this.loggingPanel.ResumeLayout(false);
            this.loggingPanel.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.oAuthPanel.ResumeLayout(false);
            this.oAuthPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView settingsTreeView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel oAuthPanel;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel tokenLinkLabel;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Panel loggingPanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.GroupBox proxyGroupBox;
    }
}