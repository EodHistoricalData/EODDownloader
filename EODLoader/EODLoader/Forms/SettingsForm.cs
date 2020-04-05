using EODLoader.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            SelectTab(e.Node.Name);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settingsTabControl.Appearance = TabAppearance.FlatButtons;
            settingsTabControl.ItemSize = new Size(0, 1);
            settingsTabControl.SizeMode = TabSizeMode.Fixed;

            settingsTabControl.SelectedIndex = (int)SettingsTabEnum.OAuth;

            settingsTreeView.SelectedNode = settingsTreeView.Nodes[0];

            tokenTextBox.Text = Properties.Settings.Default.Token;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            if (tokenTextBox.Text.Length == 32)
            {
                Properties.Settings.Default.Token = tokenTextBox.Text;
            }

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
            }
        }

        private void logFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            logFileTextBox.Text = openFileDialog1.FileName;
        }
    }
}
