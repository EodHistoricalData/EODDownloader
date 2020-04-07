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
using System.Net;
using EODLoader.Services.Proxy;
using System.Reflection;
using EODLoader.Services.AutoUpdate;
using EODLoader.Services.ConfigurationData.Model;
using EODLoader.Services.ConfigurationData;

namespace EODLoader.Forms
{
    public partial class MainForm : Form
    {
        private ISymbolFileService _symbolFileService;
        private IEodHistoricalDataService _eodHistoricalDataService;
        private IWebProxyService _webProxyService;
        private IConfigurationService _configurationService;
        private IAutoUpdateService _autoUpdateService;

        private ConfigurationModel _configuration { get; set; }

        private Timer _tm = null;
        private Timer _settingsTokenTimer = null;
        private int _startValue = 1;

        public MainForm()
        {
            InitializeComponent();

            this.Text = $"{this.Text} {Assembly.GetExecutingAssembly().GetName().Version}";

            _autoUpdateService = new AutoUpdateService();

            _configurationService = new ConfigurationService();

            _configuration = _configurationService.GetConfiguration();

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

        private void AutoUpdater_ApplicationExitEvent()
        {
            System.Threading.Thread.Sleep(5000);
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (_configuration.AutoUpdateIsUsed)
            {
                if (_autoUpdateService.Start())
                {
                    AutoUpdater_ApplicationExitEvent();
                }
            }

            toDateTimePicker.Value = DateTime.Now;

            periodComboBox.SelectedIndex = 0;

            CheckTokenStatus();

            string symbolPath = _configuration.LastSymbolFilePath;

            string downloadDirectory = _configuration.LastDownloadDirectoryPath;

            if (File.Exists(symbolPath))
            {
                GetStringArrayAndUpdateListBoxByFile(symbolPath);
                symbolFilePathTextBox.Text = symbolPath;
            }
            else
            {
                _configuration.LastSymbolFilePath = string.Empty;
            }

            if (Directory.Exists(downloadDirectory))
            {
                downloadDirectoryTextBox.Text = downloadDirectory;
            }
            else
            {
                _configuration.LastDownloadDirectoryPath = string.Empty;
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
                _configuration.LastSymbolFilePath = filePath;
                _configurationService.Save(_configuration);
            }
        }

        private void downloadDirectoryButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            downloadDirectoryTextBox.Text = folderBrowserDialog1.SelectedPath;

            _configuration.LastDownloadDirectoryPath = folderBrowserDialog1.SelectedPath;
            _configurationService.Save(_configuration);
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
            if (_configuration.Token == string.Empty)
            {
                tokenValueLabel.ForeColor = Color.Red;
                tokenValueLabel.Text = "Empty";
                dToolStripMenuItem.Enabled = false;
            }
            else if (_configuration.Token == _configuration.TestToken)
            {
                tokenValueLabel.ForeColor = Color.Blue;
                tokenValueLabel.Text = "OK";
                dToolStripMenuItem.Enabled = true;
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
                _configuration = _configurationService.GetConfiguration();
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
