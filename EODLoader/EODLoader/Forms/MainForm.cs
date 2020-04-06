using EODLoader.Common;
using EODLoader.Forms;
using EODLoader.Properties;
using EODLoader.Services.EodHistoricalData;
using EODLoader.Services.EodHistoricalData.Models;
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
using AutoUpdaterDotNET;
using System.Net;
using EODLoader.Services.Proxy;
using System.Reflection;

namespace EODLoader.Forms
{
    public partial class MainForm : Form
    {
        private ISymbolFileService _symbolFileService;
        private IEodHistoricalDataService _eodHistoricalDataService;
        private IWebProxyService _webProxyService;

        private BackgroundWorker _bw = new BackgroundWorker();

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
            _webProxyService = new WebProxyService();

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

        //private void AutoUpdater_ApplicationExitEvent()
        //{
        //    Text = @"Closing application...";
        //    System.Threading.Thread.Sleep(5000);
        //    Application.Exit();
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();

            if (Properties.Settings.Default.AutoUpdate)
            {
                //if (Properties.Settings.Default.proxyIsUsed)
                //{
                //    AutoUpdater.Proxy = _webProxyService.GetWebProxy();
                //}
                //AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
                //AutoUpdater.Mandatory = true;
                //AutoUpdater.Start("ftp://epiz_25473013@ftpupload.net/htdocs/update/update.xml", new NetworkCredential("epiz_25473013", "HIw8pYp1xv8", "ftpupload.net"));

            }

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

        private void dToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            if (ValidateStartInfo())
            {
                StartZeroing();
                _tm.Start();
                ChangeButtonEnabled();

                Task.Run(() => StartGetInfo());
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
                Invoke(menuStrip1, () =>
                 {
                     dToolStripMenuItem.Enabled = false;
                     stopToolStripMenuItem.Enabled = true;
                     settingsToolStripMenuItem.Enabled = false;
                     filesPanel.Enabled = false;
                     timeRangeGroupBox.Enabled = false;
                 });
            }
            else
            {
                Invoke(menuStrip1, () =>
                {
                    dToolStripMenuItem.Enabled = true;
                    stopToolStripMenuItem.Enabled = false;
                    settingsToolStripMenuItem.Enabled = true;
                    filesPanel.Enabled = true;
                    timeRangeGroupBox.Enabled = true;
                });
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
            runProgressBar.Value = 0;
            RunLogGridView.Rows.Clear();
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
            try
            {
                int symbolCount = symbolsListBox.Items.Count;
                List<string> symbolList = symbolsListBox.Items.Cast<String>().ToList();
                int totalProcessed = 0;

                Invoke(runProgressBar, () => runProgressBar.Maximum = symbolCount);

                Invoke(totalSymbolsValueLabel, () => totalSymbolsValueLabel.Text = symbolCount.ToString());

                string testPeriod = string.Empty;

                Invoke(periodComboBox, () => testPeriod = periodComboBox.Text.ToString());

                int errors = 0;
                int processOk = 0;

                for (int i = 0; i < symbolCount; i++)
                {
                    HistoricalResult result;
                    if (availableCheckBox.Checked)
                    {
                        result = _eodHistoricalDataService.GetHistoricalPrices(symbolList[i], null, null, testPeriod);
                    }
                    else
                    {
                        result = _eodHistoricalDataService.GetHistoricalPrices(symbolList[i], fromDateTimePicker.Value, toDateTimePicker.Value, testPeriod);
                    }

                    totalProcessed++;

                    Invoke(totalProcessedValueLabel, () => totalProcessedValueLabel.Text = totalProcessed.ToString());

                    Invoke(runProgressBar, () => runProgressBar.Value = totalProcessed);

                    switch (result.Status)
                    {
                        case StatusEnum.Ok:
                            {
                                Invoke(RunLogGridView, () => RunLogGridView.Rows.Insert(0, Resources.StatusOK, result.Symbol, "Ok"));
                                processOk++;
                                Invoke(processedOkValueLabel, () => processedOkValueLabel.Text = processOk.ToString());
                            }
                            break;
                        case StatusEnum.Error:
                            {
                                Invoke(RunLogGridView, () => RunLogGridView.Rows.Insert(0, Resources.StatusError, result.Symbol, result.Description));
                                errors++;
                                Invoke(errorsValueLabel, () => errorsValueLabel.Text = errors.ToString());
                            }
                            break;
                        case StatusEnum.ErrorProxy:
                            {
                                Invoke(RunLogGridView, () => RunLogGridView.Rows.Insert(0, Resources.StatusError, result.Symbol, result.Description));
                                return;
                            }
                    }
                }

                ChangeButtonEnabled();
                _tm.Stop();

            }
            catch (Exception ex)
            {
                ChangeButtonEnabled();
                _tm.Stop();
            }

        }

        public static void Invoke(ISynchronizeInvoke sync, Action action)
        {
            if (!sync.InvokeRequired)
            {
                action();
            }
            else
            {
                object[] args = new object[] { };
                sync.Invoke(action, args);
            }
        }

    }
}
