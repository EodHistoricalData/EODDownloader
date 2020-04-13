using EODLoader.Services.AutoUpdate;
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
    public partial class UpdateForm : Form
    {
        private readonly Timer _tm = new Timer();
        private IAutoUpdateService _autoUpdateService { get; set; }

        public UpdateForm()
        {
            InitializeComponent();
        }

        public async void timeTickAsync(object sender, EventArgs e)
        {
            _tm.Stop();

            string downloadUrl = _autoUpdateService.CheckForUpdate();
            if (downloadUrl != null)
            {
                var result = MessageBox.Show(
                "There is an update, would you like to download it?",
                "Message",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    await _autoUpdateService.Start(downloadUrl);
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            _autoUpdateService = new AutoUpdateService();
            _tm.Start();
            _tm.Tick += new EventHandler(timeTickAsync);
            _tm.Interval = 100;
        }
    }
}
