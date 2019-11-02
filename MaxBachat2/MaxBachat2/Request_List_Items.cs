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
    public partial class Request_List_Items : Syncfusion.Windows.Forms.Office2007Form
    {

        MainForm parent = null;
        Connection con = new Connection();
        List<Request_Items_Model> RequestList = null;
        string Request_ID = null;

        public Request_List_Items(List<Request_Items_Model> _request_list,string _R_ID,MainForm _parent)
        {
            InitializeComponent();
            RequestList = _request_list;
            Request_ID = _R_ID;
            this.Text = "Request ID: " + Request_ID;
            parent = _parent;
        }

        private void Request_List_Items_Load(object sender, EventArgs e)
        {
            List<Request_Items_Model> RequestList = new List<Request_Items_Model>();

            try
            {
                var dt = con.getDataTableFromDB("SELECT [Barcode],[FloorQty] as [Qty],(CASE WHEN '[Urgency]'='1' THEN 'Normal' ELSE 'Urgent' END) as [Urgency] FROM [mbo].[PSFloorRequestItems] where [FloorRequestID]='" + Request_ID + "' ");
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Request_Items_Model r = new Request_Items_Model()
                    {
                        Barcode = dt.Rows[i]["Barcode"].ToString(),
                        FloorQty = dt.Rows[i]["Qty"].ToString(),
                     
                        Urgency = dt.Rows[i]["Urgency"].ToString(),
                        Add = false,

                    };
                    RequestList.Add(r);
                }


                InformationGrid.DataSource = RequestList;
                InformationGrid.Columns["Barcode"].Width = 170;
                InformationGrid.Columns["FloorQty"].Width = 60;
                InformationGrid.Columns["Urgency"].Width = 80;

                InformationGrid.Columns["Barcode"].ReadOnly = true;
                InformationGrid.Columns["FloorQty"].ReadOnly = true;
                InformationGrid.Columns["Urgency"].ReadOnly = true ;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            List<string> ProductItemID_List = new List<string>();


            for (int i = 0; i < InformationGrid.Rows.Count; i++)
            {
                if (InformationGrid.Rows[i].Cells["Add"].Value.ToString().ToLower() == "true")
                {
                    ProductItemID_List.Add(InformationGrid.Rows[i].Cells["Barcode"].Value.ToString());
                }
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string itemid = "";

                for (int i = 0; i < ProductItemID_List.Count; i++)
                {
                    if (ProductItemID_List[i].Trim() == "")
                    { continue; }

                    itemid = itemid + "'" + ProductItemID_List[i].Trim() + "',";
                }
                itemid = itemid.Substring(0, itemid.Length - 1);
                string SubQuery = "select bl.ProductItemId  from [mbo].BarcodeLookup bl where bl.Barcode in (" + itemid + ")";

                try
                {
                
                    string query = File.ReadAllText("script2.sql");
                    var currentlist = parent.GetPOList(true);
                    parent.subFunction_settingGrid_Branch_etc(query, SubQuery, null, parent.getBranchID(), currentlist);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }



                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            this.Hide();





        }

        private void ProductNameTextBox_Click(object sender, EventArgs e)
        {
         
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Request_Items_Model> RequestList = new List<Request_Items_Model>();

            try
            {
                var dt = con.getDataTableFromDB("SELECT [Barcode],[FloorQty] as [Qty],(CASE WHEN '[Urgency]'='1' THEN 'Normal' ELSE 'Urgent' END) as [Urgency] FROM [mbo].[PSFloorRequestItems] where [FloorRequestID]='" + Request_ID + "' and [Barcode] like  '"+BarcodeSearchTextBox.Text+"%' ");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Request_Items_Model r = new Request_Items_Model()
                    {
                        Barcode = dt.Rows[i]["Barcode"].ToString(),
                        FloorQty = dt.Rows[i]["Qty"].ToString(),

                        Urgency = dt.Rows[i]["Urgency"].ToString(),
                        Add = false,

                    };
                    RequestList.Add(r);
                }


                InformationGrid.DataSource = RequestList;
                InformationGrid.Columns["Barcode"].Width = 170;
                InformationGrid.Columns["FloorQty"].Width = 60;
                InformationGrid.Columns["Urgency"].Width = 80;
                InformationGrid.Columns["Barcode"].ReadOnly = true;
                InformationGrid.Columns["FloorQty"].ReadOnly = true;
                InformationGrid.Columns["Urgency"].ReadOnly = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroCheckBox1.CheckState == CheckState.Checked)
                {
                    for (int i = 0; i < InformationGrid.Rows.Count; i++)
                    {
                        InformationGrid.Rows[i].Cells["Add"].Value = true;

                    }
                }
                else
                {
                    for (int i = 0; i < InformationGrid.Rows.Count; i++)
                    {
                        InformationGrid.Rows[i].Cells["Add"].Value = false;

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
