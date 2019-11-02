using MaxBachat21.Model;
using MaxBachat21.Services;
using NavigationDrawer_2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat21
{
    public partial class AddNewScheduleVendor : Form
    {
        Connection con = new Connection();
        static bool IsDos_Target_Set = false;
        AutomaticOrderingModel aom;
        User user = null;
        public AddNewScheduleVendor(User _user)
        {
            InitializeComponent();
            user = _user;
           
        }

    
        private void MetroButton5_Click(object sender, EventArgs e)
        {
         
        }
        private void Getting_Details()
        { try
           {
                DOSlabel.Text = con.StringValueFromDb("Select count(*) AS DOS From [mbo].PSVendorSchedule WHERE OrderMethod='DOS'");
                Targetlabel.Text = con.StringValueFromDb("Select count(*) AS TARGET From [mbo].PSVendorSchedule WHERE OrderMethod = 'TARGET'");
                Totallabel.Text =( Double.Parse(DOSlabel.Text) + Double.Parse(Targetlabel.Text)).ToString();
            }
            catch { } }

        private void AddNewScheduleVendor_Load(object sender, EventArgs e)
        {
            SetCompaniesAndVendorsIntoComboBox();
            VendorId_Name_combo.SelectedIndexChanged += getEmailOfVendor;
            Getting_Details();
            IsDos_Target_Set = false;
        }
     

        private void getEmailOfVendor(object sender, EventArgs e)
        {
            try
            {
                var id = VendorId_Name_combo.Text.Split(new[] { "-----" }, StringSplitOptions.None);
                string email = con.StringValueFromDb("select [OrderEmails] from [mbo].[PSVendorOrderContacts] where VendorID='" + id[1] + "'");
                EmailTextBox.Text = email;
                string phone = con.StringValueFromDb("select OrderPhoneNo from [mbo].[PSVendorOrderContacts] where VendorID='" + id[1] + "'");
                PhoneTextboxTextBox.Text = phone;


            }
            catch { }
        }

        private bool DOS_Validation()
        {
            try
            {
                if (DOSradioButton.Enabled)
                {
                    MessageBox.Show("DOS is Missing, Please Set DOS Before Saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
       
        private bool All_Validations()
        {
            try
            {
                

                if (EmailTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Email is Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                string emailPat = @"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)";
                var EmaillArr = EmailTextBox.Text.Split(';');
                for (int i = 0; i < EmaillArr.Length; i++)
                {
                    if (!Regex.IsMatch(EmaillArr[i], emailPat))
                    { MessageBox.Show(EmaillArr[i] + " is Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
                var vid = VendorId_Name_combo.Text.Split(new[] { "-----" }, StringSplitOptions.None);
                if (vid[1].Trim() == "" && vid[1].Trim() == "0")
                {
                    MessageBox.Show("Invalid OR Mssing Vendor ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (vid[0].Trim() == "" && vid[0].Trim() == "0")
                {
                    MessageBox.Show("Invalid OR Mssing Vendor Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
       
        private void MetroButton5_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (All_Validations())
                { if (DOS_Validation())
                    {
                        var vid = VendorId_Name_combo.Text.Split(new[] { "-----" }, StringSplitOptions.None);

                        string ordermethod = DOSradioButton.Checked == true ? "DOS" : "TARGET";
                        if (con.UpdateProductRecord("Insert into [mbo].[PSVendorSchedule]  " +
                         "  ([VendorID],[Mon],[Tue],[Wed],[Thu],[Fri],[Sat],[Sun],[DayofMonth],[OrderTime],[OrderMethod]) values (" +
                                      " '" + vid[1] + "'," +
                                  (MoncheckBox.Checked == true ? "1" : "0") + "," +
                                  (TuecheckBox.Checked == true ? "1" : "0") + "," +
                                  (WedcheckBox.Checked == true ? "1" : "0") + "," +
                                  (ThucheckBox.Checked == true ? "1" : "0") + "," +
                                  (FRIcheckbox.Checked == true ? "1" : "0") + "," +
                                  (SATcheckBox.Checked == true ? "1" : "0") + "," +
                                  (SUNcheckBox.Checked == true ? "1" : "0") + "," +
                                   "'" + DOMcomboBox.Text + "'," +
                                   "'" + dateTimePicker1.Text + "'," +
                                   "'" + ordermethod + "')"))
                        {
                            string qot = "'";

                            string script = File.ReadAllText("SQL/InsertOrUpdateEmail.sql");
                            script = script.Replace("\r\n", " ");
                            script = script.Replace("\t", " ");
                            script = script.Replace("@vid", qot+vid[1]+qot);
                            script = script.Replace("@email",qot+ EmailTextBox.Text+qot);
                            script = script.Replace("@phone", qot + PhoneTextboxTextBox.Text + qot);

                            con.UpdateProductRecord(script);

                            Reset_Screen(VendorId_Name_combo.Text);
                            MessageBox.Show("Successfully Added", "Adde", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Reset_Screen(string item)
        {
            try
            {
                MoncheckBox.Checked = false;
                TuecheckBox.Checked = false;
                WedcheckBox.Checked = false;
                ThucheckBox.Checked = false;
                FRIcheckbox.Checked = false;
                SATcheckBox.Checked = false;
                SUNcheckBox.Checked = false;
                EmailTextBox.Text = "";
                VendorId_Name_combo.Items.Remove(item);
                DOMcomboBox.Text = "";
                Getting_Details();

            } catch { }
        }
        private void SetCompaniesAndVendorsIntoComboBox()
        {

            try
            {
               
    
                if (con.con.State == ConnectionState.Open)
                { con.con.Close(); }
                con.con.Open();
                string qot = "'";
             
                string script = File.ReadAllText("SQL/LoadVendorForAddNew.SQL");


                script = script.Replace("\r\n", " ");
                script = script.Replace("\t", " ");
                System.Data.SqlClient.SqlDataReader sdr;


                SqlCommand cmd = new SqlCommand(script, con.con);

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if (!sdr.IsDBNull(0) && !sdr.IsDBNull(1))
                    {

                        if (!VendorId_Name_combo.Items.Contains(sdr.GetString(0).ToString()))
                        {
                            VendorId_Name_combo.Items.Add(sdr.GetString(0).ToString() + "-----" + sdr.GetInt32(1));


                        }
                    }


                }
                con.con.Close();



            }

            catch (Exception ex)
            { MessageBox.Show("9" + ex.Message); }


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(DOSradioButton.Checked)
            {


                SetTargetbutton.Text = "SET DOS";
            }
            else
            {
                SetTargetbutton.Text = "SET TARGET";

            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (DOSradioButton.Checked)
            {


                SetTargetbutton.Text = "SET DOS";
            }
            else
            {
                SetTargetbutton.Text = "SET TARGET";

            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SetTargetbutton_Click(object sender, EventArgs e)
        {
            if(DOSradioButton.Checked)
            {
                var vid = VendorId_Name_combo.Text.Split(new[] { "-----" }, StringSplitOptions.None);
                if (All_Validations())

                {
                    using (Set_Product_Dos spd = new Set_Product_Dos(vid[1]))
                    {
                        spd.ShowDialog();
                        if(spd.IsDosSet)
                        {
                            DOSradioButton.Enabled = false;
                           // TargetradioButton.Checked = true;
                        }
                        
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var id = VendorId_Name_combo.Text.Split(new[] { "-----" }, StringSplitOptions.None);
                Edit_Delete_Item(id[1]);
            }
            catch { MessageBox.Show("Please Select A Vendor First"); }
            }
        private void Edit_Delete_Item(string vid)
        {
            try
            {
                SharedServices ss = new SharedServices();
              var editlist=  ss.GetMappinOrderItems(vid);
                using (Edit_Item eis = new Edit_Item(editlist, vid,user))
                {
                    eis.ShowDialog();
                   

                };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void VendorId_Name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
