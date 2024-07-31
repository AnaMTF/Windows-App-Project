using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultate
{
    public partial class LoadingScreen : Form
    {
        int startingPoint = 0;
        
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingScreenTimer.Start();
        }

        private void loadingScreenTimer_Tick(object sender, EventArgs e)
        {
            startingPoint+=4;
            loadingScreenProgressBar.Value = startingPoint;
            if (loadingScreenProgressBar.Value >= loadingScreenProgressBar.Maximum)
            {
                loadingScreenProgressBar.Value = 0;
                loadingScreenTimer.Stop();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
