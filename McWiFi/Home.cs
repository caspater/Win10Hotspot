using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McWiFi
{
    public partial class Home : Form
    {
        data db;
        command commander;
        public Home()
        {
            InitializeComponent();
            db = new data();
            db.read();
            commander = new command();
            txtInfo.Text = commander.NetworkStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNote.Text = commander.startNetwork();
            txtInfo.Text = commander.NetworkStatus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblNote.Text = commander.stopNetwork();
            txtInfo.Text = commander.NetworkStatus();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form startPage = new StartPage();
            startPage.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtInfo.Text = commander.NetworkStatus();
        }
    }
}
