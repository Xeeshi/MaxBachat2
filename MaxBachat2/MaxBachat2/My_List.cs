using MaxBachat2;
using MaxBachat21.Model;
using NavigationDrawer_2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat21
{
    public partial class My_List : Syncfusion.Windows.Forms.Office2007Form
    {
        int CurrentRow = -1;
        MainForm parent = null;
        Connection con = new Connection();
        User user;
        public My_List(User _user,MainForm _parent)
        {
            InitializeComponent();
            user = _user;
            parent = _parent;
        }
        private void DisplayRecord()
        {
            try
            {
                InformationGrid.DataSource = con.getDataTableFromDB("select  * from [mbo].[PSMyList] where [UserId]='" + user.Userid + "' ");
                InformationGrid.Columns["UserID"].Visible = false;
                InformationGrid.AllowUserToAddRows = false;
                InformationGrid.Columns[0].Width = 100;
                InformationGrid.Columns[1].Width = 200;
                InformationGrid.Columns[2].Width = 100;
             
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        
    }
        private void My_List_Load(object sender, EventArgs e)
        {
            DisplayRecord();
        }

   

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InformationGrid.DataSource = null;
                InformationGrid.DataSource = con.getDataTableFromDB("select  * from [mbo].[PSMyList] where [UserId]='" + user.Userid + "' and [List_Name] like '" + ProductNameTextBox.Text + "%'");
                InformationGrid.Columns["UserID"].Visible = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try { 
            InformationGrid.DataSource = null;
            InformationGrid.DataSource = con.getDataTableFromDB("select  * from [mbo].[PSMyList] where [UserId]='" + user.Userid + "' and [List_Name] like '" + ProductNameTextBox.Text + "%'");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void InformationGrid_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    var hit = InformationGrid.HitTest(e.X, e.Y);

                    InformationGrid.Rows[hit.RowIndex].Selected = true;
                   
                    CurrentRow = hit.RowIndex;

                }
            }
            catch (Exception)
            { }
        }

        private void addToOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentRow = InformationGrid.CurrentCell.RowIndex;
                string query = File.ReadAllText("script2.sql");
                var currentlist = parent.GetPOList(true);
                string itemid = "select ProductItemId from [mbo].PSMyListItems where List_ID=" + InformationGrid.Rows[CurrentRow].Cells[0].Value.ToString();
                parent.subFunction_settingGrid_Branch_etc(query, itemid, null, parent.getBranchID(), currentlist);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do You Want to Delete List?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dt==DialogResult.Yes)
            {
                CurrentRow = InformationGrid.CurrentCell.RowIndex;
                con.InsertInformation("delete from [mbo].[PSMyListItems] WHERE [List_ID]='" + InformationGrid.Rows[CurrentRow].Cells[0].Value.ToString() + "' ; delete from [mbo].[PSMyList] WHERE [List_ID]='" + InformationGrid.Rows[CurrentRow].Cells[0].Value.ToString() + "'");
                DisplayRecord();      
            }
        }

        private void ProductNameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void InformationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
