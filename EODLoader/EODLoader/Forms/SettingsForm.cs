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

        private Panel selectedPanel;

        private void settingsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            settingsTreeView.SelectedNode = e.Node;
            groupBox.Text = settingsTreeView.SelectedNode.Text;

            SelectPanel(e.Node.Name);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settingsTreeView.SelectedNode = settingsTreeView.Nodes[0];
            selectedPanel = oAuthPanel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TODO save all
        }

        private void tokenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tokenLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start("https://eodhistoricaldata.com/#pricing");
        }

        private void SelectPanel(string nodeName)
        {
            switch (nodeName)
            {
                case NodeNames.OAuth:
                    {
                        selectedPanel.Hide();
                        selectedPanel = oAuthPanel;
                    }
                    break;

                case NodeNames.General:
                    {
                        selectedPanel.Hide();
                        selectedPanel = generalPanel;
                    }
                    break;

                case NodeNames.Logging:
                    {
                        selectedPanel.Hide();
                        selectedPanel = loggingPanel;
                    }
                    break;
            }
            selectedPanel.Show();
        }
    }
}
