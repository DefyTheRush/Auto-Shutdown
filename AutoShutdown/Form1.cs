using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace AutoShutdown
{
    public partial class frmAutoShutdown : Form
    {
        public frmAutoShutdown()
        {
            InitializeComponent();
        }

        int secondsTillShutdown = 300;

        private void frmAutoShutdown_Load(object sender, EventArgs e)
        {
            tmrStartShutdown.Start();
        }

        private void tmrStartShutdown_Tick(object sender, EventArgs e)
        {
            prgShutdownCounter.Increment(1);
            secondsTillShutdown--;
            lblShutdownMessage.Text = "Shutdown in: " + secondsTillShutdown + " seconds";
            checkTimeReached();
            
        }

        private void btnCancelShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void checkTimeReached()
        {
            if (secondsTillShutdown == 0)
            {
                tmrStartShutdown.Stop();
                System.Diagnostics.Process.Start("shutdown", "/s /t 00");
            }
        }
    }
}
