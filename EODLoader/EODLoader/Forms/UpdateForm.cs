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
            _autoUpdateService = new AutoUpdateService();
            _tm.Start();
            _tm.Tick += new EventHandler(timeTickAsync);
            _tm.Interval = 100;
        }

        public async void timeTickAsync(object sender, EventArgs e)
        {
            _tm.Stop();

            if (await _autoUpdateService.Start())
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
