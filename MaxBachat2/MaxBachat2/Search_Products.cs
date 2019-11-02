using MaxBachat2;
using MaxBachat2.Model;
using MaxBachat21.Model;
using NavigationDrawer_2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat21
{
    public partial class Search_Products : Syncfusion.Windows.Forms.Office2007Form
    {
        
        Connection con = new Connection();
        public bool ShowDialog = false;
        User user;
        public List<string> ProductItemID_List = new List<string>();
        public Search_Products(User _user)
        {
            InitializeComponent();
          
            user = _user;
        }
        List<SearchModel> searchList = new List<SearchModel>();
        private void Search_Products_Load(object sender, EventArgs e)
        {
         
        }
        private void LoadDataIntoGrid(DataTable dt)
        {
            try
            {
                searchList.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SearchModel sm = new SearchModel()
                    {
                        ProductItemID = dt.Rows[i]["ProductItemID"].ToString(),
                        Add = false,
                        Cost = double.Parse(dt.Rows[i]["CostPrice"].ToString()),
                        ItemDescription = dt.Rows[i]["LongName"].ToString(),

                    };
                    searchList.Add(sm);
                }
                InformationGrid.DataSource = null;
                InformationGrid.DataSource = searchList;
                SearchItemCountLabel.Text = "(" + dt.Rows.Count + ")";

                InformationGrid.Columns[0].ReadOnly = true;
                InformationGrid.Columns[1].ReadOnly = true;
                InformationGrid.Columns[2].ReadOnly = true;
                InformationGrid.Columns[0].Width = 90;
                InformationGrid.Columns[1].Width = 400;
                InformationGrid.Columns[2].Width = 100;
                InformationGrid.Columns[3].Width = 100;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try {
               
                Cursor.Current = Cursors.WaitCursor;
                DataTable dt = con.getDataTableFromDB("SELECT top "+MaxLimitTextBox.Text+" [ProductItemId],[LongName],[CostPrice] from [dbo].[ProductItem] where [LongName] like '%" + ProductNameTextBox.Text + "%' ");

                LoadDataIntoGrid(dt);
                Cursor.Current = Cursors.Default;
            }catch(Exception ex)
            { MessageBox.Show(ex.Message);
                Cursor.Current = Cursors.Default;
            }
            }
        private void InformationGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //if(InformationGrid.Rows[e.RowIndex].Cells[3].Value.ToString().ToLower()=="true")
            //{
            //    MessageBox.Show(e.ColumnIndex + " " + e.RowIndex);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroCheckBox1.CheckState == CheckState.Checked)
                {
                    for (int i = 0; i < InformationGrid.Rows.Count; i++)
                    {
                        InformationGrid.Rows[i].Cells[3].Value = true;

                    }
                }else
                {
                    for (int i = 0; i < InformationGrid.Rows.Count; i++)
                    {
                        InformationGrid.Rows[i].Cells[3].Value = false;

                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ProductItemID_List.Clear();
            ShowDialog = true;
            for (int i = 0; i < InformationGrid.Rows.Count; i++)
            {
                if (InformationGrid.Rows[i].Cells[3].Value.ToString().ToLower() == "true")
                {
                    ProductItemID_List.Add(InformationGrid.Rows[i].Cells[0].Value.ToString());
                }
            }
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            BarcodeRichTextBox.Text = Clipboard.GetText();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string itemid = "";

                for (int i = 0; i < BarcodeRichTextBox.Lines.Length; i++)
                {
                    if (BarcodeRichTextBox.Lines[i].Trim() == "")
                    { continue; }

                    itemid = itemid + "'" + BarcodeRichTextBox.Lines[i] + "',";
                }
                itemid = itemid.Substring(0, itemid.Length - 1);
                string script = "SELECT bl.[ProductItemId]"+
            " ,pi.LongName"+
	        " ,pi.CostPrice "+
            "FROM [mbo].[BarcodeLookup] bl "+
            "JOIN ProductItem pi on pi.productitemid=bl.productitemid " +
            "where bl.Barcode in ( " + itemid + " )";

                var dt = con.getDataTableFromDB(script);
                LoadDataIntoGrid(dt);
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void SearchItemCountLabel_Click(object sender, EventArgs e)
        {

        }
        private void metroButton6_Click(object sender, EventArgs e)
        {
            List<string> productitemidList = new List<string>();
            for (int i = 0; i < InformationGrid.Rows.Count; i++)
            {
                if (InformationGrid.Rows[i].Cells[3].Value.ToString().ToLower() == "true")
                {
                    productitemidList.Add(InformationGrid.Rows[i].Cells["ProductItemID"].Value.ToString());
                }
            }
            if(productitemidList.Count==0)
            {
                MessageBox.Show("No Row Selected", "Empty", MessageBoxButtons.OK
                 , MessageBoxIcon.Error);
                return;
            }

            Save_Search_Dialog s = new Save_Search_Dialog(user,productitemidList,ProductNameTextBox.Text);
         
            s.ShowDialog();
        }
       
        private void MaxLimitTextBox_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void MaxLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            List<string> productitemidList = new List<string>();
            for(int i=0;i<productitemidList.Count;i++)
            {

               productitemidList.Add(InformationGrid.Rows[i].Cells["ProductItemID"].Value.ToString());
            }
        }

        private void ProductNameTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
