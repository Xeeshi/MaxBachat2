using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;using System.Text;
using System.Threading.Tasks;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms;
using System.Data.SqlClient;
using NavigationDrawer_2010;
using MaxBachat2.Model;
using MaxBachat2.Services;

namespace MaxBachat2
{
    public partial class Test : Syncfusion.Windows.Forms.Office2007Form
    {
        /// <summary>
		/// Required designer variable.
		/// </summary>
		 private TabControlAdv tabCtrl;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPag;
        List<CartModel> ModelList = new List<CartModel>();
        Connection con = new Connection();
        DataTable ProductList;
        //public Test(DataTable dt)
        //{
        //    ProductList = dt;   
        //    InitializeComponent();
        //    setComponentSizeSame();
         
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        try
        //        {
        //            CartModel m = new CartModel()
        //            {
        //                Barcode = dt.Rows[i][0].ToString(),
        //                Item_Name = dt.Rows[i][1].ToString(),
        //                Quanity = int.Parse(dt.Rows[i][2].ToString()),
        //                Price = dt.Rows[i][3].ToString(),
        //                Brand = dt.Rows[i][4].ToString(),
        //                imgPath = "esajee Images 170x170\\esajee Images 170x170\\" + dt.Rows[i][0].ToString() + ".jpg",


        //            };

        //            ModelList.Add(m);
        //        }
        //        catch { }

        //    }

        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = ModelList;

       

        //    //
        //    // TODO: Add any constructor code after InitializeComponent call
        //    //
        //}
        public Test()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
          //  BindTreeview();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>

            

        private void BindTreeview()
        {
            var parentRows = con.GetRootNodes();

            foreach (var row in parentRows) // # Add all root nodes to treeview and call for child nodes
            {
                TreeNode node = new TreeNode();
                node.Text = row.name.ToString();
                //treeView1.BeginInvoke(new MethodInvoker(() =>
                //treeView1.Nodes.Add(node)));
                treeView1.Nodes.Add(node);

                AddChildNodes((int)row.categoryid, node);
            }
        }

        private void AddChildNodes(int catId, TreeNode node) // # Recursive method to add child nodes and call for child nodes of each child node
        {
            try
            {
                var childRows = con.GetChildNodes(catId.ToString());

                if (childRows.Count == 0) { return; } // # Recursion base case; if given node has no child nodes no more action is taken

                foreach (var row in childRows)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = row.name.ToString();
                    node.Nodes.Add(childNode);
                    AddChildNodes((int)row.categoryid, childNode);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Test_Load(object sender, EventArgs e)
        {
            try
            {

            //    backgroundWorker1.RunWorkerAsync();    
              //  loadBrand();
               // SetCompaniesAndVendorsIntoComboBox();
               // setComponentSizeSame();
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetCompaniesAndVendorsIntoComboBox()
        {
            List<string> vendorList = new List<string>();
            List<string> CompanyList = new List<string>();
            try
            {
                if (con.con.State == ConnectionState.Open)
                { con.con.Close(); }

                System.Data.SqlClient.SqlDataReader sdr;

                con.con.Open();
                SqlCommand cmd = new SqlCommand("Select Distinct [Company],[Vendor / Distribution Name] FROM [dbo].['PO Contact List$'_xlnm#_FilterDatabase]", con.con);

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if (!sdr.IsDBNull(0))
                    {

                        if (!CompanyList.Contains(sdr.GetString(0).ToString()))
                        {


                            CompanyList.Add(sdr.GetString(0).ToString());
                        }
                    }


                    if (!sdr.IsDBNull(1))
                    {

                        if (!vendorList.Contains(sdr.GetString(1).ToString()))
                        {
                            vendorList.Add(sdr.GetString(1).ToString());
                        

                        }
                    }


                }
                con.con.Close();

               // this.VendorsCombox.DataSource = vendorList;
                this.CompanyComboBox.DataSource = CompanyList;
              
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }
        //private void loadBrand()
        //{
          
        //    try
        //    {
        //        if (con.con.State == ConnectionState.Open)
        //        { con.con.Close(); }

        //        System.Data.SqlClient.SqlDataReader sdr;

        //        con.con.Open();
        //        SqlCommand cmd = new SqlCommand("Select Distinct [Company],[Vendor / Distribution Name] FROM [MB].[dbo].['PO Contact List$'_xlnm#_FilterDatabase]", con.con);

        //        sdr = cmd.ExecuteReader();

        //        while (sdr.Read())
        //        {
        //            if (!sdr.IsDBNull(0))
        //            {

        //                if (!CompanyList.Contains(sdr.GetString(0).ToString()))
        //                {


        //                    CompanyList.Add(sdr.GetString(0).ToString());
        //                }
        //            }


        //            if (!sdr.IsDBNull(1))
        //            {

        //                if (!vendorList.Contains(sdr.GetString(1).ToString()))
        //                {
        //                    vendorList.Add(sdr.GetString(1).ToString());


        //                }
        //            }


        //        }
        //        con.con.Close();

        //        // this.VendorsCombox.DataSource = vendorList;
        //        this.CompanyComboBox.DataSource = CompanyList;

        //    }
        //    catch (Exception ex)
        //    { MessageBox.Show(ex.Message); }


        //}




      

        private void Test_SizeChanged(object sender, EventArgs e)
        {
            //    VendorsCombox.Width = CompanyComboBox.Width;
            //    VendorsCombox.Height = CompanyComboBox.Height;
            //
        }

        private void buttonAdv1_Click_1(object sender, EventArgs e)
        {
            this.Text = CompanyComboBox.Text;
            this.tabPag.Text = CompanyComboBox.Text;
            
        }

       


        private void OrderToGroupBox_SizeChanged(object sender, EventArgs e)
        {
            setComponentSizeSame();
        }

        private void setComponentSizeSame()
        {
           // VendorsCombox.Width = panel1.Width -10;
            CompanyComboBox.Width = panel1.Width -10;
            BrandComboBox.Width = panel1.Width - 10;

        }

     

        private void ControlHide(Control ctrl)
        {
            ctrl.Hide();
        }
        private void ControlShow(Control ctrl)
        {
            ctrl.Show();
        }

      

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
