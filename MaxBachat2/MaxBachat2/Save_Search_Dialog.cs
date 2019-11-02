using MaxBachat21.Model;
using NavigationDrawer_2010;
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

namespace MaxBachat21
{
    public partial class Save_Search_Dialog : Syncfusion.Windows.Forms.Office2007Form
    { User user;
        List<string> PID_List = null;
        Connection con = new Connection();
      
        public Save_Search_Dialog(User _user,List<string> _PID_List,string searchName)
        {
            InitializeComponent();
            user = _user;
            PID_List = _PID_List;
            ListNameTextBox.Text = searchName;
        }

        private void Save_Search_Dialog_Load(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
  
      
        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {

                Int32 insertedID = con.InsertValuesIntoDataBase("insert into [mbo].[PSMyList] ([List_Name],[UserId],[Created_Date]) values ('" + ListNameTextBox.Text + "','" + user.Userid + "','" + DateTime.Now.ToShortDateString() + "');SELECT SCOPE_IDENTITY();");


                if (con.Save_MY_LIST_ITEMS(PID_List, insertedID.ToString()))
                {

                    MessageBox.Show("Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                } catch(Exception ex)
            { MessageBox.Show(ex.Message); }

                  }
    }
}
