using EODLoader.Forms;
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
        private ISymbolFileService symbolFileService;

        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|CSV files(*.csv)|*.csv|All files(*.*)|*.*";
            openFileDialog1.FileName = string.Empty;
            symbolFileService = new SymbolFileService();
        }

        SettingsForm settingsForm;
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm();
                settingsForm.Show();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com/");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toDateTimePicker.Value = DateTime.Now;
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

            string filePatch = openFileDialog1.FileName;

            GetStringArrayAndUpdateListBoxByFile(filePatch);
        }

        private void ListBoxAddItems(string[] symbolsString)
        {
            symbolsListBox.Items.Clear();

            for (int i = 0; i < symbolsString.Length; i++)
            {
                symbolsListBox.Items.Add(symbolsString[i]);
            }

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            string filePatch = symbolFilePatchTextBox.Text;

            if (filePatch != string.Empty && File.Exists(filePatch))
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = filePatch
                };

                process.Start();
                process.WaitForExit();

                GetStringArrayAndUpdateListBoxByFile(filePatch);

            }
        }

        private void GetStringArrayAndUpdateListBoxByFile(string filePatch)
        {
            string[] symbols = symbolFileService.OpenFile(filePatch);

            if (symbols != null)
            {
                ListBoxAddItems(symbols);
                symbolFilePatchTextBox.Text = filePatch;
            }
        }
    }
}
