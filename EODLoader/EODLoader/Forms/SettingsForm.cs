using EODLoader.Common;
using EODLoader.Properties;
using EODLoader.Services.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EODLoader.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settingsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            settingsTreeView.SelectedNode = e.Node;
            groupBox.Text = settingsTreeView.SelectedNode.Text;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.FileName = string.Empty;
            SelectTab(e.Node.Name);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settingsTabControl.Appearance = TabAppearance.FlatButtons;
            settingsTabControl.ItemSize = new Size(0, 1);
            settingsTabControl.SizeMode = TabSizeMode.Fixed;

            settingsTabControl.SelectedIndex = (int)SettingsTabEnum.OAuth;

            settingsTreeView.SelectedNode = settingsTreeView.Nodes[0];

            //Data load
            autoUpdateCheckBox.Checked = Properties.Settings.Default.AutoUpdate;
            tokenTextBox.Text = Properties.Settings.Default.Token;
            credentialsCheckBox.Checked = Properties.Settings.Default.proxyCredentialsIsUsed;
            proxyCheckBox.Checked = Properties.Settings.Default.proxyIsUsed;
            proxyAddresstextBox.Text = Properties.Settings.Default.proxyWebAddress;
            proxyUserNameTextBox.Text = Properties.Settings.Default.proxyUserName;
            proxyUserPasswordTextBox.Text = Properties.Settings.Default.proxyPassword;

            if (Properties.Settings.Default.logFilePath != string.Empty)
            {
                if (Directory.Exists(Properties.Settings.Default.logFilePath))
                {
                    logFileTextBox.Text = Properties.Settings.Default.logFilePath;
                }
                else
                {
                    MessageBox.Show("The log file directory does not exist, the field is cleared", "Error");
                    Properties.Settings.Default.logFilePath = string.Empty;
                }
            }

            if (proxyCheckBox.Checked)
            {
                proxyGroupBox.Enabled = true;

                if (credentialsCheckBox.Checked)
                {
                    credentialsGroupBox.Enabled = true;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoUpdate = autoUpdateCheckBox.Checked;

            Properties.Settings.Default.proxyWebAddress = proxyAddresstextBox.Text;

            Properties.Settings.Default.proxyUserName = proxyUserNameTextBox.Text;

            Properties.Settings.Default.proxyPassword = proxyUserPasswordTextBox.Text;

            Properties.Settings.Default.logFilePath = logFileTextBox.Text;

            Properties.Settings.Default.proxyIsUsed = proxyCheckBox.Checked;

            Properties.Settings.Default.proxyCredentialsIsUsed = credentialsCheckBox.Checked;

            Properties.Settings.Default.Token = tokenTextBox.Text;

            Properties.Settings.Default.Save();
            this.Close();
            //TODO save all
        }

        private void tokenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tokenLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start("https://eodhistoricaldata.com/#pricing");
        }

        private void SelectTab(string nodeName)
        {
            switch (nodeName)
            {
                case NodeNames.OAuth:
                    settingsTabControl.SelectedIndex = (int)SettingsTabEnum.OAuth;
                    break;

                case NodeNames.General:
                    settingsTabControl.SelectedIndex = (int)SettingsTabEnum.General;
                    break;

                case NodeNames.Logging:
                    settingsTabControl.SelectedIndex = (int)SettingsTabEnum.Logging;
                    break;
            }
        }

        private void proxyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (proxyCheckBox.Checked)
            {
                proxyGroupBox.Enabled = true;
            }
            else
            {
                proxyGroupBox.Enabled = false;
                checkPictureBox.Hide();
            }
        }

        private void logFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            logFileTextBox.Text = openFileDialog1.FileName;
        }

        private void credentialsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (credentialsCheckBox.Checked)
            {
                credentialsGroupBox.Enabled = true;
            }
            else
            {
                credentialsGroupBox.Enabled = false;
            }
        }

        private void proxyCheckButton_Click(object sender, EventArgs e)
        {
            WebProxyService proxyService = new WebProxyService(proxyAddresstextBox.Text, proxyUserNameTextBox.Text,
                                                               proxyUserPasswordTextBox.Text, credentialsCheckBox.Checked,
                                                               proxyCheckBox.Checked);

            checkPictureBox.Hide();

            bool checkResult = proxyService.CheckConnection();

            if (checkResult)
            {
                checkPictureBox.Image = Resources.StatusOK;
            }
            else
            {
                checkPictureBox.Image = Resources.StatusError;
            }

            checkPictureBox.Visible = true;
        }
    }
}
