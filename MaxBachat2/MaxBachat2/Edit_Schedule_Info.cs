using MaxBachat21.Model;
using MaxBachat21.Services;
using NavigationDrawer_2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat21
{
    public partial class Edit_Schedule_Info : Form
    {
     
        User user = null;
        Connection con = new Connection();
        public Edit_Schedule_Info(User _user, AutomaticOrderingModel modl)
        {
            InitializeComponent();
            user = _user;
            
            setModelToFilels(modl);

        }
       

        private void setModelToFilels(AutomaticOrderingModel modl)
        {
            VendorId_Name_combo.Text = modl.Vendor + "-----" + modl.VendorID;
            EmailTextBox.Text = modl.Email;
            PhoneTextboxTextBox.Text = modl.Phone;
            MoncheckBox.Checked = modl.MON;
            TuecheckBox.Checked = modl.TUE;
            WedcheckBox.Checked = modl.WED;
            ThucheckBox.Checked = modl.THU;
            FRIcheckbox.Checked = modl.FRI;
            SATcheckBox.Checked = modl.SAT;
            SUNcheckBox.Checked = modl.SUN;
            DOMcomboBox.Text = modl.DayOfMonth.ToString();
            dateTimePicker1.Text = modl.OrderTime.ToString("HH:mm");
            AutoOrderingcheckBox.Checked = modl.Auto_Ordering;
           if(modl.Method.ToLower()=="dos")
            {
                DOSradioButton.Checked = true;
                TargetradioButton.Checked = false;
            }else

            {
                DOSradioButton.Checked = false;
                TargetradioButton.Checked = true ;
            }
            




        }

        private void Edit_Schedule_Info_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                if (All_Validations())
                {
                    var vid = VendorId_Name_combo.Text.Split(new[] { "-----" }, StringSplitOptions.None);


                    string script = "UPDATE [mbo].[PSVendorSchedule] SET " +
                            "[MON]=" + (MoncheckBox.Checked == true ? 1 : 0) +
                            ", [TUE]=" + (TuecheckBox.Checked == true ? 1 : 0) +
                            ", [WED]=" + (WedcheckBox.Checked == true ? 1 : 0) +
                            ", [THU]=" + (ThucheckBox.Checked == true ? 1 : 0) +
                            ", [FRI]=" + (FRIcheckbox.Checked == true ? 1 : 0) +
                            ", [SAT]=" + (SATcheckBox.Checked == true ? 1 : 0) +
                            ", [SUN]=" + (SUNcheckBox.Checked == true ? 1 : 0) +
                            ", [AutoOrdering]=" + (AutoOrderingcheckBox.Checked == true ? 1 : 0) +
                            ", [OrderMethod]='" + (DOSradioButton.Checked == true ? "Dos" : "Target") + "'" +
                            ", [OrderTime]='" + dateTimePicker1.Text + "'" +
                             ", [DayofMonth]='" + DOMcomboBox.Text + "' Where [VendorID]='" + vid[1] + "'";

                    if (!con.UpdateProductRecord(script))
                    { MessageBox.Show("Error While Inserting Data Into DB"); }






                    string script2 = "UPDATE [mbo].PSVendorOrderContacts SET OrderEmails='" + EmailTextBox.Text + "',[OrderPhoneNo]='" + PhoneTextboxTextBox.Text + "'  WHERE [VendorId]='" + vid[1] + "'";

                    if (!con.UpdateProductRecord(script2))
                    { MessageBox.Show("Error While Inserting Data Into DB"); }


                    

                    MessageBox.Show("Record Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
                    {
                        MessageBox.Show(EmaillArr[i] + " is Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Edit_Delete_Item(string vid)
        {
            try
            {
                SharedServices ss = new SharedServices();
                var editlist = ss.GetMappinOrderItems(vid);
                using (Edit_Item eis = new Edit_Item(editlist, vid, user))
                {
                    eis.ShowDialog();


                };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
    }
}
