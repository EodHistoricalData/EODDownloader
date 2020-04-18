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
        System.Threading.CancellationTokenSource source = new System.Threading.CancellationTokenSource();

        private Timer _tm = null;
        private Timer _settingsTokenTimer = null;
        private int _startValue = 1;

        private volatile int totalProcessed = 0;
        private volatile int errors = 0;
        private volatile int processOk = 0;
        private int totalSymbolCount = 0;
        UpdateForm updateForm = new UpdateForm();

        public MainForm()
        {
            _configurationService = new ConfigurationService();

            _configuration = _configurationService.GetConfiguration();

            InitializeComponent();

            if (_configuration.AutoUpdateIsUsed)
            {
                updateForm.ShowDialog();

                _configuration = _configurationService.GetConfiguration();

            }

            this.Text = $"{this.Text} {Assembly.GetExecutingAssembly().GetName().Version}";

            _autoUpdateService = new AutoUpdateService();

<<<<<<< HEAD
            _eodHistoricalDataService = new EodHistoricalDataService();
=======
            _configurationService = new ConfigurationService();

            _configuration = _configurationService.GetConfiguration();
>>>>>>> parent of aebf7c5... added loger and change config

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|CSV files(*.csv)|*.csv|All files(*.*)|*.*";
            openFileDialog1.FileName = string.Empty;

            _symbolFileService = new SymbolFileService();

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
            System.Diagnostics.Process.Start("https://eodhistoricaldata.com/knowledgebase/");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            CheckTokenStatus(true);
=======

            if (_configuration.AutoUpdateIsUsed)
            {
                if (_autoUpdateService.Start())
                {
                    AutoUpdater_ApplicationExitEvent();
                }
            }
>>>>>>> parent of aebf7c5... added loger and change config

            toDateTimePicker.Value = DateTime.Now;

            periodComboBox.SelectedIndex = 0;

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

<<<<<<< HEAD
        private void CheckTokenStatus(bool isFirstLoad)
=======

        //TODO Add check token
        private void CheckTokenStatus()
>>>>>>> parent of aebf7c5... added loger and change config
        {
            if (_configuration.Token == string.Empty)
            {
                tokenValueLabel.ForeColor = Color.Red;
                tokenValueLabel.Text = "Empty";
                dToolStripMenuItem.Enabled = false;
            }
            else
            {
<<<<<<< HEAD
                bool tokenIsValid = true;

                if (!isFirstLoad)
                {
                    tokenIsValid = _eodHistoricalDataService.ValidateToken(_configuration.Token); //ValidationFunction
                }
=======
                bool tokenIsValid = true; //ValidationFunction
>>>>>>> parent of aebf7c5... added loger and change config

                if (tokenIsValid)
                {
                    tokenValueLabel.ForeColor = Color.Green;
                    dToolStripMenuItem.Enabled = true;

                    if (_configuration.Token == _configuration.TestToken)
                    {
                        tokenValueLabel.Text = "Test Token";
                    }
                    else
                    {
                        int tokenLength = _configuration.Token.Length;

                        string firstSubstring = _configuration.Token.Substring(0, 4);
                        string secondSubstring = _configuration.Token.Substring(tokenLength - 4, 4);
                        tokenValueLabel.Text = $"{firstSubstring}...{secondSubstring}";

                    }
                }
                else
                {
                    tokenValueLabel.ForeColor = Color.Red;
                    tokenValueLabel.Text = "Token is not valid";
                }
            }
            _settingsTokenTimer.Stop();
        }

        private async void dToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            if (ValidateStartInfo())
            {
                StartZeroing();
                _tm.Start();
                ChangeButtonEnabled();

                _eodHistoricalDataService = new EodHistoricalDataService();

                List<string> symbolList = symbolsListBox.Items.Cast<String>().ToList();

                totalSymbolCount = symbolList.Count;

                runProgressBar.Maximum = totalSymbolCount;

                totalSymbolsValueLabel.Text = totalSymbolCount.ToString();

                string testPeriod = periodComboBox.Text.ToString();

                bool avalibleDate = availableCheckBox.Checked;



<<<<<<< HEAD
                    var maxWorkerThreads = _configuration.NumberOfThread;

                    var factory = Task.Factory;
                    factory.StartNew(() =>
                    {
                        var queue = new Queue<string>(symbolList);

                        while (!source.Token.IsCancellationRequested || queue.Any())
                        {
                            var taskList = new List<Task>();
                            for (int i = 0; i < maxWorkerThreads; i++)
                            {
                                if (!queue.Any())
                                {
                                    break;
                                }
                                string symbol = queue.Dequeue();
                                Task.Run(() => StartGetInfo(symbol, testPeriod, avalibleDate), source.Token);
                            }
                        }
                    }, source.Token);

                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
                throw;
=======
                //System.Threading.Tasks.Parallel.ForEach(symbolList,
                //    new System.Threading.Tasks.ParallelOptions { MaxDegreeOfParallelism = _configuration.NumberOfThread },
                //    async symbol =>
                //    {
                //        await StartGetInfo(symbol, testPeriod, avalibleDate);
                //    });

                //Task.Run()


                //var queue = new Queue<string>(symbolList);
                //List<Task> taskList = new List<Task>();

                //while (queue.Any())
                //{

                //for (int i = 0; i < _configuration.NumberOfThread; i++)
                //{
                //    if (!queue.Any())
                //    {
                //        break;
                //    }

                //    string symbol = queue.Dequeue();



                //   //var task = Task.Run(async () =>
                //   // {
                //   //     await StartGetInfo(symbol, testPeriod, avalibleDate);
                //   // });


                //    //taskList.Add(task);

                //   // System.Threading.Thread test = new System.Threading.Thread(System.Threading.ParameterizedThreadStart);

                //    //taskList.Add(task);
                //    //taskList.Add(StartGetInfo(symbol, testPeriod, avalibleDate));
                //}



                //Task.WaitAny(taskList.ToArray());

                //foreach (var task in taskList)
                //{
                //    task.();
                //}



                //Task.WaitAny(taskList.ToArray(), source.Token);
                //var factory = Task.Factory.StartNew(() => taskList.ToArray());
                //Task.Factory.ContinueWhenAny(factory, () => { });
                //Task.(taskList.ToArray(), source.Token);

                //if (!queue.Any())
                //{
                //    ChangeButtonEnabled();
                //    _tm.Stop();
                //}
                //Task.WaitAny(taskList.ToArray());
                //allTasksList.AddRange(taskList);
                //taskList = new List<Task>();


                var factory = Task.Factory.StartNew(() =>
                {
                    var queue = new Queue<string>(symbolList);
                    List<Task> taskList = new List<Task>();
                    while (!source.Token.IsCancellationRequested || queue.Any())
                    {
                        for (int i = 0; i < _configuration.NumberOfThread; i++)
                        {
                            if (!queue.Any())
                            {
                                break;
                            }

                            string symbol = queue.Dequeue();

                           var task = Task.Run(() => StartGetInfo(symbol, testPeriod, avalibleDate), source.Token);

                        }
                    }

                }, source.Token);
                // }

>>>>>>> parent of aebf7c5... added loger and change config
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            source.Cancel();
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
<<<<<<< HEAD

            ValidateFormValues();
            if (totalSymbolCount == totalProcessed || source.IsCancellationRequested)
=======
            if (totalSymbolCount == totalProcessed)
>>>>>>> parent of aebf7c5... added loger and change config
            {
                source.Cancel();
                _tm.Stop();
                ChangeButtonEnabled();
            }
        }

        private void settingsTimeTick(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                _configuration = _configurationService.GetConfiguration();
                CheckTokenStatus(false);
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
            totalProcessed = 0;
            errors = 0;
            processOk = 0;
        }

        private bool ValidateStartInfo()
        {
            if (symbolFilePathTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please, check symbol file field", "Alert");
                return false;
            }

            if (symbolsListBox.Items.Count > 0 && symbolsListBox.Items[0].ToString() == string.Empty)
            {
                MessageBox.Show("Please, fill symbol file", "Alert");
                return false;
            }

            if (downloadDirectoryTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please, fill download directory field", "Alert");
                return false;
            }

            if (!Directory.Exists(downloadDirectoryTextBox.Text))
            {
                MessageBox.Show("Selected download directory do not exist", "Alert");
                return false;
            }

            return true;
        }



        private void ValidateFormValues()
        {
            totalProcessedValueLabel.Text = totalProcessed.ToString();
            processedOkValueLabel.Text = processOk.ToString();
            errorsValueLabel.Text = errors.ToString();
            runProgressBar.Value = totalProcessed;
        }

        private async Task StartGetInfo(string symbol, string testPeriod, bool avalibleDate)
        {
            try
            {
                HistoricalResult result;
                if (avalibleDate)
                {
                    result = await _eodHistoricalDataService.GetHistoricalPrices(symbol, null, null, testPeriod);
                }
                else
                {
                    result = await _eodHistoricalDataService.GetHistoricalPrices(symbol, fromDateTimePicker.Value, toDateTimePicker.Value, testPeriod);
                }

                // Invoke(totalProcessedValueLabel, () => totalProcessedValueLabel.Text = totalProcessed.ToString());

                //Invoke(runProgressBar, () => runProgressBar.Value = totalProcessed);

                switch (result.Status)
                {
                    case StatusEnum.Ok:
                        {
<<<<<<< HEAD
                            Invoke(RunLogGridView, () => RunLogGridView.Rows.Insert(0, Resources.StatusOK, result.Symbol, result.Description));
                            totalProcessed++;
=======
                            Invoke(RunLogGridView, () => RunLogGridView.Rows.Insert(0, Resources.StatusOK, result.Symbol, "Ok"));
>>>>>>> parent of aebf7c5... added loger and change config
                            processOk++;
                            //Invoke(processedOkValueLabel, () => processedOkValueLabel.Text = processOk.ToString());
                        }
                        break;
                    case StatusEnum.Error:
                        {
                            Invoke(RunLogGridView, () => RunLogGridView.Rows.Insert(0, Resources.StatusError, result.Symbol, result.Description));
                            totalProcessed++;
                            errors++;
<<<<<<< HEAD
                            //Invoke(errorsValueLabel, () => errorsValueLabel.Text = errors.ToString());
                            if (result.Description == "Unable to connect to remote server")
                            {
                                source.Cancel();
                            }
=======
                            Invoke(errorsValueLabel, () => errorsValueLabel.Text = errors.ToString());
>>>>>>> parent of aebf7c5... added loger and change config
                        }
                        break;
                    case StatusEnum.ErrorProxy:
                        {
                            Invoke(RunLogGridView, () => RunLogGridView.Rows.Insert(0, Resources.StatusError, result.Symbol, result.Description));
<<<<<<< HEAD
                            totalProcessed++;
                            errors++;
                            //Invoke(errorsValueLabel, () => errorsValueLabel.Text = errors.ToString());
=======
>>>>>>> parent of aebf7c5... added loger and change config
                            source.Cancel();
                        }
                        break;
                }

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

        private void tokenValueLabel_Click(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm();
                settingsForm.Show();
                _settingsTokenTimer.Start();
            }
        }
    }
}
