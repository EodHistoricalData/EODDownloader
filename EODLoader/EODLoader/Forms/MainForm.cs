using EODLoader.Forms;
using EODLoader.Services.EodHistoricalData;
using EODLoader.Services.SymbolFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EODLoader.Forms
{
    public partial class MainForm : Form
    {
        private ISymbolFileService _symbolFileService;
        private IEodHistoricalDataService _eodHistoricalDataService;

        private Timer _tm = null;
        private Timer _settingsTokenTimer = null;
        private int _startValue = 1;

        public MainForm()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|CSV files(*.csv)|*.csv|All files(*.*)|*.*";
            openFileDialog1.FileName = string.Empty;

            _symbolFileService = new SymbolFileService();
            _eodHistoricalDataService = new EodHistoricalDataService();

            _settingsTokenTimer = new Timer();
            _settingsTokenTimer.Tick += new EventHandler(settingsTimeTick);
            _settingsTokenTimer.Interval = 500;

            _tm = new Timer();
            _tm.Tick += new EventHandler(timeTick);
            _tm.Interval = 1000;
        }

        SettingsForm settingsForm;
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm();
                settingsForm.Show();
                _settingsTokenTimer.Start();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com/");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toDateTimePicker.Value = DateTime.Now;

            periodComboBox.SelectedIndex = 0;

            CheckTokenStatus();

            string symbolPath = Properties.Settings.Default.lastSymbolFilePath;

            string downloadDirectory = Properties.Settings.Default.lastDownloadDirectoryPath;

            if (File.Exists(symbolPath))
            {
                GetStringArrayAndUpdateListBoxByFile(symbolPath);
                symbolFilePathTextBox.Text = symbolPath;
            }
            else
            {
                Properties.Settings.Default.lastSymbolFilePath = string.Empty;
            }

            if (Directory.Exists(downloadDirectory))
            {
                downloadDirectoryTextBox.Text = downloadDirectory;
            }
            else
            {
                Properties.Settings.Default.lastDownloadDirectoryPath = string.Empty;
            }
        }

        private void availableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (availableCheckBox.Checked)
            {
                fromDateTimePicker.Enabled = false;
                toDateTimePicker.Enabled = false;
            }
            else
            {
                fromDateTimePicker.Enabled = true;
                toDateTimePicker.Enabled = true;
            }
        }

        private void fileDialogButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filePath = openFileDialog1.FileName;

            GetStringArrayAndUpdateListBoxByFile(filePath);
        }

        private void ListBoxAddItems(string[] symbolsString)
        {
            symbolsListBox.Items.Clear();

            for (int i = 0; i < symbolsString.Length; i++)
            {
                if (!string.IsNullOrEmpty(symbolsString[i]))
                {
                    symbolsListBox.Items.Add(symbolsString[i]);
                }
            }

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            string filePath = symbolFilePathTextBox.Text;

            if (filePath != string.Empty && File.Exists(filePath))
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = filePath
                };

                process.Start();
                process.WaitForExit();

                GetStringArrayAndUpdateListBoxByFile(filePath);

            }
        }

        private void GetStringArrayAndUpdateListBoxByFile(string filePath)
        {
            string[] symbols = _symbolFileService.OpenFile(filePath);

            if (symbols != null)
            {
                ListBoxAddItems(symbols);
                symbolFilePathTextBox.Text = filePath;
                Properties.Settings.Default.lastSymbolFilePath = filePath;
                Properties.Settings.Default.Save();
            }
        }

        private void downloadDirectoryButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            downloadDirectoryTextBox.Text = folderBrowserDialog1.SelectedPath;

            Properties.Settings.Default.lastDownloadDirectoryPath = folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void openDirectoryButton_Click(object sender, EventArgs e)
        {
            string directoryPath = downloadDirectoryTextBox.Text;
            if (directoryPath != string.Empty && Directory.Exists(directoryPath))
            {
                Process.Start(directoryPath);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                CheckTokenStatus();
            }
        }

        private void CheckTokenStatus()
        {
            if (Properties.Settings.Default.Token != string.Empty)
            {
                tokenValueLabel.ForeColor = Color.Blue;
                tokenValueLabel.Text = "OK";
                dToolStripMenuItem.Enabled = true;
            }
            else
            {
                tokenValueLabel.ForeColor = Color.Red;
                tokenValueLabel.Text = "Empty";
                dToolStripMenuItem.Enabled = false;
            }
            _settingsTokenTimer.Stop();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateStartInfo())
            {
                StartZeroing();
                _tm.Start();
                ChangeButtonEnabled();

                StartGetInfo();
            }
            else
            {
                MessageBox.Show("Please check the fields", "Alert");
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tm.Stop();
            ChangeButtonEnabled();
        }

        private string Int2StringTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }

        private void timeTick(object sender, EventArgs e)
        {
            durationValueLabel.Text = Int2StringTime(_startValue);
            _startValue++;
        }

        private void settingsTimeTick(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                CheckTokenStatus();
            }
        }

        private void ChangeButtonEnabled()
        {
            if (dToolStripMenuItem.Enabled)
            {
                dToolStripMenuItem.Enabled = false;
                stopToolStripMenuItem.Enabled = true;
                settingsToolStripMenuItem.Enabled = false;
                filesPanel.Enabled = false;
                timeRangeGroupBox.Enabled = false;
            }
            else
            {
                dToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = false;
                settingsToolStripMenuItem.Enabled = true;
                filesPanel.Enabled = true;
                timeRangeGroupBox.Enabled = true;
            }
        }

        private void StartZeroing()
        {
            _startValue = 1;
            totalSymbolsValueLabel.Text = "0";
            totalProcessedValueLabel.Text = "0";
            processedOkValueLabel.Text = "0";
            errorsValueLabel.Text = "0";
            durationValueLabel.Text = "00:00:00";
            statusValueLabel.Text = string.Empty;
            runProgressBar.Value = 0;
        }

        private bool ValidateStartInfo()
        {
            if (symbolsListBox.Items.Count > 0 &&
                symbolsListBox.Items[0].ToString() != string.Empty &&
                Directory.Exists(downloadDirectoryTextBox.Text))
            {
                return true;
            }

            return false;
        }

        private void StartGetInfo()
        {
            int symbolCount = symbolsListBox.Items.Count;
            int totalProcessed = 0;

            totalSymbolsValueLabel.Text = symbolCount.ToString();

            for (int i = 0; i < symbolCount; i++)
            {
                //_eodHistoricalDataService
                totalProcessed++;
                totalProcessedValueLabel.Text = totalProcessed.ToString();
            }

            _tm.Stop();
            ChangeButtonEnabled();
        }
    }
}
