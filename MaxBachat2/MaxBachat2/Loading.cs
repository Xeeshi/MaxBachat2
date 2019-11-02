using MaxBachat2;
using MaxBachat21.Model;
using NavigationDrawer_2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Loading : Syncfusion.Windows.Forms.MetroForm
    {
        User user = null;
        MainForm mm;
      
        List<string> ServerList = new List<string>();
        public Loading()
        {
          
            InitializeComponent();
            


        }


       
        private bool CheckDBConnection()
        {
            Connection cc = new Connection();
            using (cc.con)
            {
                try
                {
                    cc.con.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }
      
      
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
         
        }
        private void Login()
        {
            if (validateConnection())
            {

                ValidatePasswordFromDatabase();
            }

        }
        private bool Check_LocalDBConnection()
        {
            Connection cc = new Connection();
            using (cc.con)
            {
                try
                {
                    cc.con.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        private bool validateConnection()
        {
            //if (MaxBachat21.Properties.Settings.Default.ServerName == "")
            //{
            //    MessageBox.Show("Connection String is Not Intialized", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if (!CheckDBConnection())
            //{
            //    MessageBox.Show("Information is Incorrect or Database is Not Connected", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    DialogResult dt = MessageBox.Show("Do You Want to Reset Settings", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //    if (dt == DialogResult.OK)
            //    {
            //    //    MaxBachat21.Properties.Settings.Default.Password = "";
            //    //    MaxBachat21.Properties.Settings.Default.ServerName = "";
            //    //    MaxBachat21.Properties.Settings.Default.Username = "";
            //    //    MaxBachat21.Properties.Settings.Default.Database = "";
            //    //    MaxBachat21.Properties.Settings.Default.Save();

            //        return false;

            //    }
             
            //}
            return true;
        }

        public  void ValidatePasswordFromDatabase()
        {
           
            Connection cc = new Connection();
       
           try {  
           
                SqlDataAdapter sda = new SqlDataAdapter("select [UserId],[Username],[Password],[EmployeeName],[EmployeePhone],[EmployeeEmail],[EmployeeDesignation],[AllowInternetLogin] from [mbo].[PSUsers] where Username='" + UserNameTextBox.Text + "' and password='" + PasswordTextBox.Text + "'",cc.con );
                DataTable dt = new DataTable();
                sda.Fill(dt);




                if (dt.Rows.Count==1)
                {
                    User _user = new User()
                    {
                        Userid = dt.Rows[0]["UserId"].ToString(),
                        Username = dt.Rows[0]["Username"].ToString(),
                        EmployeeName = dt.Rows[0]["EmployeeName"].ToString(),
                        EmployeeEmail = dt.Rows[0]["EmployeeEmail"].ToString(),
                        EmployeeDesignation = dt.Rows[0]["EmployeeDesignation"].ToString(),
                        AllowInternet = dt.Rows[0]["AllowInternetLogin"].ToString(),
                    };
                    user = _user;

                    if (InternetradioButton.Checked == true)
                    {
                      
                        mm = new MainForm(user);

                        if (dt.Rows[0]["AllowInternetLogin"].ToString() == "1")
                        {

                            NotificationLabel.Text = "Welcome " + user.EmployeeName;


                            NotificationLabel.Show();

                            mm.WindowState = FormWindowState.Minimized;

                            mm.Show();

                            timer1.Start();

                        }
                        else
                        {
                            MessageBox.Show("You Are Not Allowed to Login via Internet", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        NotificationLabel.Text = "Welcome "+user.EmployeeName;


                        NotificationLabel.Show();
                        mm = new MainForm(user);
                        mm.WindowState = FormWindowState.Minimized;

                        mm.Show();

                        timer1.Start();
                    }
                }
                else
                {
                    NotificationLabel.Text = "Login Faild";
                    NotificationLabel.Show();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }


      
        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            NotificationLabel.Hide();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            NotificationLabel.Hide();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            Test_Local_Connection());
            Task.Run(() =>
            Test_Online_Connection()
            );

            if(MaxBachat21.Properties.Settings.Default.isInternet=="" || MaxBachat21.Properties.Settings.Default.isInternet == "0")
            {
                LocalRadioButton.Checked = true;
            }
            else
            {
                InternetradioButton.Checked = true;
            }

      
        }

        private void UserNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            { Login(); }
            }

    

        private void label3_Click(object sender, EventArgs e)
        {
            ServerSwitch S = new ServerSwitch();
            S.ShowDialog();
        }

    


  
        int z = 0;
      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServerSwitch s = new ServerSwitch();
            s.ShowDialog();
        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value = z;
            z++;
            
            if (z == 40)
            {
               
                mm.WindowState = FormWindowState.Maximized;

                mm.Show();
                timer1.Stop();
                this.Hide();

                z = 0;
            }
        }
   
        private void Test_Local_Connection()
        {
            SqlConnection L_Con = new SqlConnection(Credential.Local_ConnectionString);

            try
            {if(L_Con.State==ConnectionState.Open)
                { L_Con.Close(); }
                L_Con.Open();
                LocalLabel.BeginInvoke(new MethodInvoker(() =>
                LocalLabel.Text = "Connected"
                ));
              
                L_Con.Close();
                LocalLabel.BeginInvoke(new MethodInvoker(() =>
             LocalLabel.ForeColor = Color.Green
             ));
            }
            catch
            {
                LocalLabel.BeginInvoke(new MethodInvoker(() =>
      LocalLabel.Text = "Disconnected"
      ));
                LocalLabel.BeginInvoke(new MethodInvoker(() =>
             LocalLabel.ForeColor = Color.Red
             ));

            }

        }
        private void Test_Online_Connection()
        {
            SqlConnection O_con = new SqlConnection(Credential.Internet_ConnectionString);
            try
                {
                if(O_con.State==ConnectionState.Open)
                { O_con.Close(); }
                O_con.Open();
                OnlineLabel.BeginInvoke(new MethodInvoker(() =>
          OnlineLabel.Text = "Connected"
          ));
                OnlineLabel.BeginInvoke(new MethodInvoker(() =>
             OnlineLabel.ForeColor = Color.Green
             ));
                O_con.Close();

            }
                catch
            {
                OnlineLabel.BeginInvoke(new MethodInvoker(() =>
OnlineLabel.Text = "Disconnected"
));
                OnlineLabel.BeginInvoke(new MethodInvoker(() =>
             OnlineLabel.ForeColor = Color.Red
             ));

            }

            
        }
        private void LoginRadioButton_CheckedChanged(object sender, EventArgs e)
        {  ///for local

            MaxBachat21.Properties.Settings.Default.isInternet = "0";
            MaxBachat21.Properties.Settings.Default.Save();
        }

        private void InternetradioButton_CheckedChanged(object sender, EventArgs e)
        {

            MaxBachat21.Properties.Settings.Default.isInternet = "1";
            MaxBachat21.Properties.Settings.Default.Save();
        }

        private void DBConTestingTimer_Tick(object sender, EventArgs e)
        {
            Test_Local_Connection();
            Test_Online_Connection();
        }
    }
}
