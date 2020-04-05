namespace EODLoader.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.symbolFilePathTextBox = new System.Windows.Forms.TextBox();
            this.downloadDirectoryButton = new System.Windows.Forms.Button();
            this.downloadDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.timeRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusValueLabel = new System.Windows.Forms.Label();
            this.durationValueLabel = new System.Windows.Forms.Label();
            this.errorsValueLabel = new System.Windows.Forms.Label();
            this.processedOkValueLabel = new System.Windows.Forms.Label();
            this.totalProcessedValueLabel = new System.Windows.Forms.Label();
            this.totalSymbolsValueLabel = new System.Windows.Forms.Label();
            this.tokenValueLabel = new System.Windows.Forms.Label();
            this.runProgressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.processedOkLabel = new System.Windows.Forms.Label();
            this.totalProcessedLabel = new System.Windows.Forms.Label();
            this.totalSymbolsLabel = new System.Windows.Forms.Label();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.RunLogGridView = new System.Windows.Forms.DataGridView();
            this.ImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.SymbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDirectoryButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.symbolsListBox = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.filesPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.timeRangeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunLogGridView)).BeginInit();
            this.filesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dToolStripMenuItem.Image")));
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dToolStripMenuItem.Text = "Run";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::EODLoader.Properties.Resources.Help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(3, 6);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(107, 23);
            this.openFileDialogButton.TabIndex = 1;
            this.openFileDialogButton.Text = "Symbol file";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.fileDialogButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // symbolFilePathTextBox
            // 
            this.symbolFilePathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.symbolFilePathTextBox.Location = new System.Drawing.Point(146, 8);
            this.symbolFilePathTextBox.Name = "symbolFilePathTextBox";
            this.symbolFilePathTextBox.ReadOnly = true;
            this.symbolFilePathTextBox.Size = new System.Drawing.Size(213, 20);
            this.symbolFilePathTextBox.TabIndex = 4;
            // 
            // downloadDirectoryButton
            // 
            this.downloadDirectoryButton.Location = new System.Drawing.Point(3, 35);
            this.downloadDirectoryButton.Name = "downloadDirectoryButton";
            this.downloadDirectoryButton.Size = new System.Drawing.Size(107, 23);
            this.downloadDirectoryButton.TabIndex = 2;
            this.downloadDirectoryButton.Text = "Download directory";
            this.downloadDirectoryButton.UseVisualStyleBackColor = true;
            this.downloadDirectoryButton.Click += new System.EventHandler(this.downloadDirectoryButton_Click);
            // 
            // downloadDirectoryTextBox
            // 
            this.downloadDirectoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.downloadDirectoryTextBox.Location = new System.Drawing.Point(146, 37);
            this.downloadDirectoryTextBox.Name = "downloadDirectoryTextBox";
            this.downloadDirectoryTextBox.ReadOnly = true;
            this.downloadDirectoryTextBox.Size = new System.Drawing.Size(213, 20);
            this.downloadDirectoryTextBox.TabIndex = 4;
            // 
            // timeRangeGroupBox
            // 
            this.timeRangeGroupBox.Controls.Add(this.toDateTimePicker);
            this.timeRangeGroupBox.Controls.Add(this.toLabel);
            this.timeRangeGroupBox.Controls.Add(this.fromDateTimePicker);
            this.timeRangeGroupBox.Controls.Add(this.fromLabel);
            this.timeRangeGroupBox.Controls.Add(this.periodLabel);
            this.timeRangeGroupBox.Controls.Add(this.periodComboBox);
            this.timeRangeGroupBox.Controls.Add(this.availableCheckBox);
            this.timeRangeGroupBox.Location = new System.Drawing.Point(118, 94);
            this.timeRangeGroupBox.Name = "timeRangeGroupBox";
            this.timeRangeGroupBox.Size = new System.Drawing.Size(152, 136);
            this.timeRangeGroupBox.TabIndex = 5;
            this.timeRangeGroupBox.TabStop = false;
            this.timeRangeGroupBox.Text = "Time Range";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(54, 104);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.toDateTimePicker.TabIndex = 3;
            this.toDateTimePicker.Value = new System.DateTime(2020, 4, 4, 0, 0, 0, 0);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(7, 107);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "To:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(54, 78);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.fromDateTimePicker.TabIndex = 3;
            this.fromDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(7, 81);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(6, 22);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(40, 13);
            this.periodLabel.TabIndex = 2;
            this.periodLabel.Text = "Period:";
            // 
            // periodComboBox
            // 
            this.periodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.periodComboBox.Location = new System.Drawing.Point(54, 19);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(92, 21);
            this.periodComboBox.TabIndex = 1;
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.Location = new System.Drawing.Point(39, 52);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(82, 17);
            this.availableCheckBox.TabIndex = 0;
            this.availableCheckBox.Text = "All available";
            this.availableCheckBox.UseVisualStyleBackColor = true;
            this.availableCheckBox.CheckedChanged += new System.EventHandler(this.availableCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusValueLabel);
            this.groupBox2.Controls.Add(this.durationValueLabel);
            this.groupBox2.Controls.Add(this.errorsValueLabel);
            this.groupBox2.Controls.Add(this.processedOkValueLabel);
            this.groupBox2.Controls.Add(this.totalProcessedValueLabel);
            this.groupBox2.Controls.Add(this.totalSymbolsValueLabel);
            this.groupBox2.Controls.Add(this.tokenValueLabel);
            this.groupBox2.Controls.Add(this.runProgressBar);
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Controls.Add(this.durationLabel);
            this.groupBox2.Controls.Add(this.errorsLabel);
            this.groupBox2.Controls.Add(this.processedOkLabel);
            this.groupBox2.Controls.Add(this.totalProcessedLabel);
            this.groupBox2.Controls.Add(this.totalSymbolsLabel);
            this.groupBox2.Controls.Add(this.tokenLabel);
            this.groupBox2.Location = new System.Drawing.Point(285, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Latest download stats";
            // 
            // statusValueLabel
            // 
            this.statusValueLabel.AutoSize = true;
            this.statusValueLabel.Location = new System.Drawing.Point(109, 147);
            this.statusValueLabel.Name = "statusValueLabel";
            this.statusValueLabel.Size = new System.Drawing.Size(0, 13);
            this.statusValueLabel.TabIndex = 2;
            // 
            // durationValueLabel
            // 
            this.durationValueLabel.AutoSize = true;
            this.durationValueLabel.Location = new System.Drawing.Point(109, 123);
            this.durationValueLabel.Name = "durationValueLabel";
            this.durationValueLabel.Size = new System.Drawing.Size(49, 13);
            this.durationValueLabel.TabIndex = 2;
            this.durationValueLabel.Text = "00:00:00";
            // 
            // errorsValueLabel
            // 
            this.errorsValueLabel.AutoSize = true;
            this.errorsValueLabel.Location = new System.Drawing.Point(109, 100);
            this.errorsValueLabel.Name = "errorsValueLabel";
            this.errorsValueLabel.Size = new System.Drawing.Size(13, 13);
            this.errorsValueLabel.TabIndex = 2;
            this.errorsValueLabel.Text = "0";
            // 
            // processedOkValueLabel
            // 
            this.processedOkValueLabel.AutoSize = true;
            this.processedOkValueLabel.Location = new System.Drawing.Point(109, 78);
            this.processedOkValueLabel.Name = "processedOkValueLabel";
            this.processedOkValueLabel.Size = new System.Drawing.Size(13, 13);
            this.processedOkValueLabel.TabIndex = 2;
            this.processedOkValueLabel.Text = "0";
            // 
            // totalProcessedValueLabel
            // 
            this.totalProcessedValueLabel.AutoSize = true;
            this.totalProcessedValueLabel.Location = new System.Drawing.Point(109, 57);
            this.totalProcessedValueLabel.Name = "totalProcessedValueLabel";
            this.totalProcessedValueLabel.Size = new System.Drawing.Size(13, 13);
            this.totalProcessedValueLabel.TabIndex = 2;
            this.totalProcessedValueLabel.Text = "0";
            // 
            // totalSymbolsValueLabel
            // 
            this.totalSymbolsValueLabel.AutoSize = true;
            this.totalSymbolsValueLabel.Location = new System.Drawing.Point(109, 37);
            this.totalSymbolsValueLabel.Name = "totalSymbolsValueLabel";
            this.totalSymbolsValueLabel.Size = new System.Drawing.Size(13, 13);
            this.totalSymbolsValueLabel.TabIndex = 2;
            this.totalSymbolsValueLabel.Text = "0";
            // 
            // tokenValueLabel
            // 
            this.tokenValueLabel.AutoSize = true;
            this.tokenValueLabel.Location = new System.Drawing.Point(109, 18);
            this.tokenValueLabel.Name = "tokenValueLabel";
            this.tokenValueLabel.Size = new System.Drawing.Size(0, 13);
            this.tokenValueLabel.TabIndex = 2;
            // 
            // runProgressBar
            // 
            this.runProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.runProgressBar.Location = new System.Drawing.Point(9, 173);
            this.runProgressBar.Name = "runProgressBar";
            this.runProgressBar.Size = new System.Drawing.Size(174, 22);
            this.runProgressBar.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 147);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(6, 123);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(50, 13);
            this.durationLabel.TabIndex = 0;
            this.durationLabel.Text = "Duration:";
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Location = new System.Drawing.Point(6, 100);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(37, 13);
            this.errorsLabel.TabIndex = 0;
            this.errorsLabel.Text = "Errors:";
            // 
            // processedOkLabel
            // 
            this.processedOkLabel.AutoSize = true;
            this.processedOkLabel.Location = new System.Drawing.Point(6, 78);
            this.processedOkLabel.Name = "processedOkLabel";
            this.processedOkLabel.Size = new System.Drawing.Size(78, 13);
            this.processedOkLabel.TabIndex = 0;
            this.processedOkLabel.Text = "Processed OK:";
            // 
            // totalProcessedLabel
            // 
            this.totalProcessedLabel.AutoSize = true;
            this.totalProcessedLabel.Location = new System.Drawing.Point(6, 57);
            this.totalProcessedLabel.Name = "totalProcessedLabel";
            this.totalProcessedLabel.Size = new System.Drawing.Size(86, 13);
            this.totalProcessedLabel.TabIndex = 0;
            this.totalProcessedLabel.Text = "Total processed:";
            // 
            // totalSymbolsLabel
            // 
            this.totalSymbolsLabel.AutoSize = true;
            this.totalSymbolsLabel.Location = new System.Drawing.Point(6, 37);
            this.totalSymbolsLabel.Name = "totalSymbolsLabel";
            this.totalSymbolsLabel.Size = new System.Drawing.Size(74, 13);
            this.totalSymbolsLabel.TabIndex = 0;
            this.totalSymbolsLabel.Text = "Total symbols:";
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(6, 18);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(41, 13);
            this.tokenLabel.TabIndex = 0;
            this.tokenLabel.Text = "Token:";
            // 
            // RunLogGridView
            // 
            this.RunLogGridView.AllowUserToAddRows = false;
            this.RunLogGridView.AllowUserToDeleteRows = false;
            this.RunLogGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RunLogGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RunLogGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageColumn,
            this.SymbolColumn,
            this.StatusColumn});
            this.RunLogGridView.Location = new System.Drawing.Point(12, 306);
            this.RunLogGridView.MultiSelect = false;
            this.RunLogGridView.Name = "RunLogGridView";
            this.RunLogGridView.ReadOnly = true;
            this.RunLogGridView.RowHeadersVisible = false;
            this.RunLogGridView.RowHeadersWidth = 40;
            this.RunLogGridView.Size = new System.Drawing.Size(462, 227);
            this.RunLogGridView.TabIndex = 7;
            // 
            // ImageColumn
            // 
            this.ImageColumn.Frozen = true;
            this.ImageColumn.HeaderText = "";
            this.ImageColumn.MinimumWidth = 25;
            this.ImageColumn.Name = "ImageColumn";
            this.ImageColumn.ReadOnly = true;
            this.ImageColumn.Width = 25;
            // 
            // SymbolColumn
            // 
            this.SymbolColumn.Frozen = true;
            this.SymbolColumn.HeaderText = "Symbol";
            this.SymbolColumn.MinimumWidth = 100;
            this.SymbolColumn.Name = "SymbolColumn";
            this.SymbolColumn.ReadOnly = true;
            this.SymbolColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SymbolColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Frozen = true;
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.MinimumWidth = 337;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 337;
            // 
            // openDirectoryButton
            // 
            this.openDirectoryButton.Image = global::EODLoader.Properties.Resources.OpenFolder;
            this.openDirectoryButton.Location = new System.Drawing.Point(116, 35);
            this.openDirectoryButton.Name = "openDirectoryButton";
            this.openDirectoryButton.Size = new System.Drawing.Size(24, 23);
            this.openDirectoryButton.TabIndex = 3;
            this.openDirectoryButton.UseVisualStyleBackColor = true;
            this.openDirectoryButton.Click += new System.EventHandler(this.openDirectoryButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Image = global::EODLoader.Properties.Resources.OpenFile_16x;
            this.openFileButton.Location = new System.Drawing.Point(116, 6);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(24, 23);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // symbolsListBox
            // 
            this.symbolsListBox.FormattingEnabled = true;
            this.symbolsListBox.Location = new System.Drawing.Point(12, 36);
            this.symbolsListBox.Name = "symbolsListBox";
            this.symbolsListBox.Size = new System.Drawing.Size(100, 264);
            this.symbolsListBox.TabIndex = 10000;
            // 
            // filesPanel
            // 
            this.filesPanel.Controls.Add(this.openFileButton);
            this.filesPanel.Controls.Add(this.openFileDialogButton);
            this.filesPanel.Controls.Add(this.downloadDirectoryButton);
            this.filesPanel.Controls.Add(this.openDirectoryButton);
            this.filesPanel.Controls.Add(this.symbolFilePathTextBox);
            this.filesPanel.Controls.Add(this.downloadDirectoryTextBox);
            this.filesPanel.Location = new System.Drawing.Point(115, 28);
            this.filesPanel.Name = "filesPanel";
            this.filesPanel.Size = new System.Drawing.Size(368, 60);
            this.filesPanel.TabIndex = 10001;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 545);
            this.Controls.Add(this.filesPanel);
            this.Controls.Add(this.symbolsListBox);
            this.Controls.Add(this.RunLogGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.timeRangeGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EODLoader";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.timeRangeGroupBox.ResumeLayout(false);
            this.timeRangeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunLogGridView)).EndInit();
            this.filesPanel.ResumeLayout(false);
            this.filesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox symbolFilePathTextBox;
        private System.Windows.Forms.Button openDirectoryButton;
        private System.Windows.Forms.TextBox downloadDirectoryTextBox;
        public System.Windows.Forms.Button downloadDirectoryButton;
        private System.Windows.Forms.GroupBox timeRangeGroupBox;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DataGridView RunLogGridView;
        private System.Windows.Forms.Label totalSymbolsLabel;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.Label totalProcessedLabel;
        private System.Windows.Forms.Label processedOkLabel;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar runProgressBar;
        private System.Windows.Forms.Label statusValueLabel;
        private System.Windows.Forms.Label durationValueLabel;
        private System.Windows.Forms.Label errorsValueLabel;
        private System.Windows.Forms.Label processedOkValueLabel;
        private System.Windows.Forms.Label totalProcessedValueLabel;
        private System.Windows.Forms.Label totalSymbolsValueLabel;
        private System.Windows.Forms.Label tokenValueLabel;
        private System.Windows.Forms.ListBox symbolsListBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewImageColumn ImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.Panel filesPanel;
    }
}

