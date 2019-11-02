using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat2
{
    public partial class ServerSwitch : Syncfusion.Windows.Forms.MetroForm
    {
        public ServerSwitch()
        {
            InitializeComponent();
        }

        private void ServerSwitch_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSetting();
            }
        }
        private void SaveSetting()
        {
            //MaxBachat21.Properties.Settings.Default.ServerName = ServerNameTextBox.Text;
            //MaxBachat21.Properties.Settings.Default.Username = usernameTextbox.Text;
            //MaxBachat21.Properties.Settings.Default.Password = passwordTextBox.Text;
            //MaxBachat21.Properties.Settings.Default.Database = Databasenametextboc.Text;
            //MaxBachat21.Properties.Settings.Default.Save();
            //MessageBox.Show("System will be Restart", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Application.Restart();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        { 
            SaveSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (usernametxtbox.Text == "admin" && passwordtxtbox.Text == "admin")
            { PasswordPanel.Hide(); }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
              string dbstring = "Data Source=" + ServerNameTextBox.Text + ";Initial Catalog=" + Databasenametextboc.Text + ";User ID=" +usernameTextbox.Text + ";Password=" + passwordTextBox.Text;
            SqlConnection con = new SqlConnection(dbstring);
            try { con.Open();
                MessageBox.Show("Successfully Connected", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch { MessageBox.Show("Connection Failed", "Fail Connection", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
