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
    public partial class StartPage : Form
    {
        data db;
        String checkState;
        command commander;
        public StartPage()
        {
            InitializeComponent();
            db = new data();
            commander = new command();
            settings sett= new settings(db.read());
            txtSSID.Text = sett.SSID;
            txtKey.Text = sett.Key;
            ckbShowKey.Checked = sett.PassChar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ckbShowKey_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowKey.Checked)
            {
                checkState = "1";
                txtKey.PasswordChar='\0';
            }
            else
            {
                checkState = "0";
                txtKey.PasswordChar= '☺';
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String[] content = { checkState, txtSSID.Text, txtKey.Text };
            MessageBox.Show(commander.setCredentials(content));
            db.writeData(content);
           

        }
    }
}
