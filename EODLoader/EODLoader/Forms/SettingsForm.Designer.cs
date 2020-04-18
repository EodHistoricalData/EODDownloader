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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("API Key");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General Preferences");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Logging");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsTreeView = new System.Windows.Forms.TreeView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.OAuthTab = new System.Windows.Forms.TabPage();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tokenLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.threadNumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.label7 = new System.Windows.Forms.Label();
            this.logFileTextBox = new System.Windows.Forms.TextBox();
            this.logFileButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.OAuthTab.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadNumericUpDown)).BeginInit();
            this.proxyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).BeginInit();
            this.credentialsGroupBox.SuspendLayout();
            this.LoggingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTreeView
            // 
            this.settingsTreeView.Location = new System.Drawing.Point(32, 29);
            this.settingsTreeView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.settingsTreeView.Name = "settingsTreeView";
            treeNode1.Name = "OAuthNode";
            treeNode1.Text = "API Key";
            treeNode2.Name = "GeneralNode";
            treeNode2.Text = "General Preferences";
            treeNode3.Name = "LoggingNode";
            treeNode3.Text = "Logging";
            this.settingsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.settingsTreeView.Size = new System.Drawing.Size(409, 884);
            this.settingsTreeView.TabIndex = 1;
            this.settingsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.settingsTreeView_NodeMouseClick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.settingsTabControl);
            this.groupBox.Location = new System.Drawing.Point(469, 12);
            this.groupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox.Size = new System.Drawing.Size(960, 906);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "API Key";
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.OAuthTab);
            this.settingsTabControl.Controls.Add(this.GeneralTab);
            this.settingsTabControl.Controls.Add(this.LoggingTab);
            this.settingsTabControl.Location = new System.Drawing.Point(16, 45);
            this.settingsTabControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(928, 847);
            this.settingsTabControl.TabIndex = 4;
            // 
            // OAuthTab
            // 
            this.OAuthTab.Controls.Add(this.linkLabel4);
            this.OAuthTab.Controls.Add(this.label10);
            this.OAuthTab.Controls.Add(this.linkLabel3);
            this.OAuthTab.Controls.Add(this.linkLabel2);
            this.OAuthTab.Controls.Add(this.linkLabel1);
            this.OAuthTab.Controls.Add(this.textBox1);
            this.OAuthTab.Controls.Add(this.label9);
            this.OAuthTab.Controls.Add(this.label8);
            this.OAuthTab.Controls.Add(this.richTextBox1);
            this.OAuthTab.Controls.Add(this.tokenLinkLabel);
            this.OAuthTab.Controls.Add(this.tokenLabel);
            this.OAuthTab.Controls.Add(this.tokenTextBox);
            this.OAuthTab.Location = new System.Drawing.Point(10, 48);
            this.OAuthTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OAuthTab.Name = "OAuthTab";
            this.OAuthTab.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OAuthTab.Size = new System.Drawing.Size(908, 789);
            this.OAuthTab.TabIndex = 0;
            this.OAuthTab.Text = "OAuth";
            this.OAuthTab.UseVisualStyleBackColor = true;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(244, 369);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(431, 32);
            this.linkLabel4.TabIndex = 11;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "support@eoshidstoricaldata.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "App Page:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(244, 494);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(387, 32);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "eodhistoricaldata.com/pricing";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(244, 432);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(501, 32);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "eodhistoricaldata.com/knowledgebase";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(466, 686);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(431, 32);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "support@eoshidstoricaldata.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(431, 641);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(462, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Contact us if you have any questions";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "Pricing Page:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Documentation: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(22, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(860, 230);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tokenLinkLabel
            // 
            this.tokenLinkLabel.AutoSize = true;
            this.tokenLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tokenLinkLabel.Location = new System.Drawing.Point(744, 50);
            this.tokenLinkLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tokenLinkLabel.Name = "tokenLinkLabel";
            this.tokenLinkLabel.Size = new System.Drawing.Size(138, 32);
            this.tokenLinkLabel.TabIndex = 2;
            this.tokenLinkLabel.TabStop = true;
            this.tokenLinkLabel.Text = "Get token";
            this.tokenLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tokenLinkLabel_LinkClicked);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(16, 50);
            this.tokenLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(102, 32);
            this.tokenLabel.TabIndex = 1;
            this.tokenLabel.Text = "Token:";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Location = new System.Drawing.Point(141, 43);
            this.tokenTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(580, 38);
            this.tokenTextBox.TabIndex = 0;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.label6);
            this.GeneralTab.Controls.Add(this.threadNumericUpDown);
            this.GeneralTab.Controls.Add(this.proxyGroupBox);
            this.GeneralTab.Controls.Add(this.proxyCheckBox);
            this.GeneralTab.Controls.Add(this.autoUpdateCheckBox);
            this.GeneralTab.Location = new System.Drawing.Point(10, 48);
            this.GeneralTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GeneralTab.Size = new System.Drawing.Size(908, 789);
            this.GeneralTab.TabIndex = 1;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Simultaneous connections:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // threadNumericUpDown
            // 
            this.threadNumericUpDown.Location = new System.Drawing.Point(383, 26);
            this.threadNumericUpDown.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.threadNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.threadNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threadNumericUpDown.Name = "threadNumericUpDown";
            this.threadNumericUpDown.ReadOnly = true;
            this.threadNumericUpDown.Size = new System.Drawing.Size(131, 38);
            this.threadNumericUpDown.TabIndex = 5;
            this.threadNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            this.proxyGroupBox.Location = new System.Drawing.Point(16, 238);
            this.proxyGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.proxyGroupBox.Name = "proxyGroupBox";
            this.proxyGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.proxyGroupBox.Size = new System.Drawing.Size(853, 496);
            this.proxyGroupBox.TabIndex = 2;
            this.proxyGroupBox.TabStop = false;
            this.proxyGroupBox.Text = "Proxy server";
            // 
            // checkPictureBox
            // 
            this.checkPictureBox.ErrorImage = global::EODLoader.Properties.Resources.StatusError;
            this.checkPictureBox.Image = global::EODLoader.Properties.Resources.StatusOK;
            this.checkPictureBox.Location = new System.Drawing.Point(624, 420);
            this.checkPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
            this.credentialsGroupBox.Location = new System.Drawing.Point(16, 224);
            this.credentialsGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.credentialsGroupBox.Name = "credentialsGroupBox";
            this.credentialsGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.credentialsGroupBox.Size = new System.Drawing.Size(821, 174);
            this.credentialsGroupBox.TabIndex = 6;
            this.credentialsGroupBox.TabStop = false;
            this.credentialsGroupBox.Text = "Credentials";
            // 
            // proxyUserNameTextBox
            // 
            this.proxyUserNameTextBox.Location = new System.Drawing.Point(336, 50);
            this.proxyUserNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.proxyUserNameTextBox.Name = "proxyUserNameTextBox";
            this.proxyUserNameTextBox.Size = new System.Drawing.Size(441, 38);
            this.proxyUserNameTextBox.TabIndex = 0;
            // 
            // proxyUserPasswordTextBox
            // 
            this.proxyUserPasswordTextBox.Location = new System.Drawing.Point(336, 112);
            this.proxyUserPasswordTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.proxyUserPasswordTextBox.Name = "proxyUserPasswordTextBox";
            this.proxyUserPasswordTextBox.Size = new System.Drawing.Size(441, 38);
            this.proxyUserPasswordTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // credentialsCheckBox
            // 
            this.credentialsCheckBox.AutoSize = true;
            this.credentialsCheckBox.Location = new System.Drawing.Point(67, 169);
            this.credentialsCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.credentialsCheckBox.Name = "credentialsCheckBox";
            this.credentialsCheckBox.Size = new System.Drawing.Size(256, 36);
            this.credentialsCheckBox.TabIndex = 5;
            this.credentialsCheckBox.Text = "With credentials";
            this.credentialsCheckBox.UseVisualStyleBackColor = true;
            this.credentialsCheckBox.CheckedChanged += new System.EventHandler(this.credentialsCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Example: localhost:2290";
            // 
            // proxyCheckButton
            // 
            this.proxyCheckButton.Location = new System.Drawing.Point(232, 413);
            this.proxyCheckButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.proxyCheckButton.Name = "proxyCheckButton";
            this.proxyCheckButton.Size = new System.Drawing.Size(376, 55);
            this.proxyCheckButton.TabIndex = 3;
            this.proxyCheckButton.Text = "Check proxy connection";
            this.proxyCheckButton.UseVisualStyleBackColor = true;
            this.proxyCheckButton.Click += new System.EventHandler(this.proxyCheckButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "and port number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP address/name";
            // 
            // proxyAddresstextBox
            // 
            this.proxyAddresstextBox.Location = new System.Drawing.Point(336, 69);
            this.proxyAddresstextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.proxyAddresstextBox.Name = "proxyAddresstextBox";
            this.proxyAddresstextBox.Size = new System.Drawing.Size(439, 38);
            this.proxyAddresstextBox.TabIndex = 0;
            // 
            // proxyCheckBox
            // 
            this.proxyCheckBox.AutoSize = true;
            this.proxyCheckBox.Location = new System.Drawing.Point(16, 160);
            this.proxyCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.proxyCheckBox.Name = "proxyCheckBox";
            this.proxyCheckBox.Size = new System.Drawing.Size(264, 36);
            this.proxyCheckBox.TabIndex = 1;
            this.proxyCheckBox.Text = "Use proxy server";
            this.proxyCheckBox.UseVisualStyleBackColor = true;
            this.proxyCheckBox.CheckedChanged += new System.EventHandler(this.proxyCheckBox_CheckedChanged);
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(16, 110);
            this.autoUpdateCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(407, 36);
            this.autoUpdateCheckBox.TabIndex = 1;
            this.autoUpdateCheckBox.Text = "Check for updates at startup";
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoggingTab
            // 
            this.LoggingTab.Controls.Add(this.label7);
            this.LoggingTab.Controls.Add(this.logFileTextBox);
            this.LoggingTab.Controls.Add(this.logFileButton);
            this.LoggingTab.Location = new System.Drawing.Point(10, 48);
            this.LoggingTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LoggingTab.Name = "LoggingTab";
            this.LoggingTab.Size = new System.Drawing.Size(908, 789);
            this.LoggingTab.TabIndex = 2;
            this.LoggingTab.Text = "Logging";
            this.LoggingTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Path to log:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // logFileTextBox
            // 
            this.logFileTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logFileTextBox.Location = new System.Drawing.Point(16, 81);
            this.logFileTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.logFileTextBox.Name = "logFileTextBox";
            this.logFileTextBox.ReadOnly = true;
            this.logFileTextBox.Size = new System.Drawing.Size(884, 38);
            this.logFileTextBox.TabIndex = 1;
            // 
            // logFileButton
            // 
            this.logFileButton.Location = new System.Drawing.Point(16, 157);
            this.logFileButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.logFileButton.Name = "logFileButton";
            this.logFileButton.Size = new System.Drawing.Size(245, 55);
            this.logFileButton.TabIndex = 0;
            this.logFileButton.Text = "Log file";
            this.logFileButton.UseVisualStyleBackColor = true;
            this.logFileButton.Visible = false;
            this.logFileButton.Click += new System.EventHandler(this.logFileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1173, 932);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(256, 55);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 1006);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.settingsTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
            ((System.ComponentModel.ISupportInitialize)(this.threadNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown threadNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label10;
    }
}