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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat21
{
    public partial class Edit_Item : Syncfusion.Windows.Forms.MetroForm
    {
        Connection con = new Connection();
    public    List<Edit_Items> Edit_List_Input = null;
    public    List<Edit_Items> Edit_List_Output = null;
        public string Vendorid = null;
        private User user =null;
        public string DialogResult_ { get; set; }  // delete,update
        public Edit_Item(List<Edit_Items> el,string _vid,User _user)
        {
            InitializeComponent();
            Edit_List_Input = el;
            Vendorid = _vid;
            user = _user;

        }
        public List<Edit_Items> getList()
        {
            return Edit_List_Output;
        }
        public void SetList(List<Edit_Items> el)
        {
            Edit_List_Output = el;
        }
      

        private void Edit_Item_Load(object sender, EventArgs e)
        {
            //       dataGridView1.DataSource = Edit_List;

            dataGridView1.AutoGenerateColumns = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("ProductItemID", typeof(String));
            dt.Columns.Add("Barcode", typeof(String));
            dt.Columns.Add("ItemDescription", typeof(String));
            dt.Columns.Add("Cost", typeof(String));
            dt.Columns.Add("Sale1M", typeof(String));
            dt.Columns.Add("Sale2M", typeof(String));
            dt.Columns.Add("MOQ", typeof(String));
            dt.Columns.Add("MOQUnit", typeof(String));
            for (int i=0;i<Edit_List_Input.Count;i++)
            {
                dt.Rows.Add(new object[] { Edit_List_Input[i].ProductItemID, Edit_List_Input[i].Barcode,  Edit_List_Input[i].ItemDescription, Edit_List_Input[i].Cost, Edit_List_Input[i].Sale1M, Edit_List_Input[i].Sale2M, Edit_List_Input[i].MOQ,"Ctn"});
               
            }


            DataGridViewTextBoxColumn Pid = new DataGridViewTextBoxColumn();
            Pid.HeaderText = "ProductItemID";
            Pid.DataPropertyName = "ProductItemID";
            Pid.ReadOnly = true;
            Pid.Width = 40;

            DataGridViewTextBoxColumn S1 = new DataGridViewTextBoxColumn();
            S1.HeaderText = "Sale1M";
            S1.DataPropertyName = "Sale1M";
            S1.ReadOnly = true;

            DataGridViewTextBoxColumn S2 = new DataGridViewTextBoxColumn();
            S2.HeaderText = "Sale2M";
            S2.DataPropertyName = "Sale2M";
            S2.ReadOnly = true;

            DataGridViewTextBoxColumn b = new DataGridViewTextBoxColumn();
            b.HeaderText = "Barcode";
            b.DataPropertyName = "Barcode";
            b.ReadOnly = true;


            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "ItemDescription";
            id.DataPropertyName = "ItemDescription";
            id.ReadOnly = false;

            DataGridViewTextBoxColumn cost = new DataGridViewTextBoxColumn();
            cost.HeaderText = "Cost";
            cost.DataPropertyName = "Cost";
            cost.ReadOnly = false;

            DataGridViewTextBoxColumn MOQ = new DataGridViewTextBoxColumn();
            MOQ.HeaderText = "MOQ";
            MOQ.DataPropertyName = "MOQ";


            DataGridViewComboBoxColumn unit = new DataGridViewComboBoxColumn();
            var UnitList = new List<string>() { "Ctn", "Pc", "Katty", "Box","Tray" };
            unit.DataSource = UnitList;
            unit.HeaderText = "MOQUnit";
            unit.DataPropertyName = "MOQUnit";

            

            dataGridView1.DataSource = dt;
            dataGridView1.Columns.AddRange(Pid,b,id,cost,S1,S2,MOQ,unit);
         
         }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            List<Edit_Items> eid = new List<Edit_Items>();
            var dt = dataGridView1.DataSource as DataTable;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                Edit_Items ei = new Edit_Items()
                {

                    ItemDescription=dt.Rows[i]["ItemDescription"].ToString(),
                    MOQ=dt.Rows[i]["MOQ"].ToString(),
                    MOQUnit=dt.Rows[i]["MOQUnit"].ToString(),
                    ProductItemID=dt.Rows[i]["ProductItemID"].ToString(),
                };

                eid.Add(ei);
            }
            SetList(eid);
            foreach(var item in eid)
            {
                con.UpdateProductRecord("MERGE [mbo].[PSOrderingMOQ]  WITH (SERIALIZABLE) AS pm " +
                    " USING (VALUES ('" + item.ProductItemID + "', '" + item.MOQ + "', '" + item.MOQUnit + "')) AS U ([ProductItemId],[MOQ], [MOQUnit])" +
                    " ON U.[ProductItemId] = pm.[ProductItemId]" +
                    " WHEN MATCHED THEN " +
                    " UPDATE SET pm.MOQ = U.MOQ,pm.MOQUnit=U.MOQUnit" +
                    " WHEN NOT MATCHED THEN" +
                    " INSERT ([ProductItemId],[MOQ], [MOQUnit])" +
                    " VALUES (U.ProductItemId,U.MOQ,U.MOQUnit);");


                

            }
            foreach (var item in eid)
            {
                con.UpdateProductRecord("UPDATE [dbo].[ProductItem] SET [LongName] = '"+item.ItemDescription+"' WHERE ProductItemId='"+item.ProductItemID+"'");




            }

            this.Hide();

            DialogResult_ = "update";
        }

        private void ButtonAdv2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dt = MessageBox.Show("Do You Really want to Delete Item Permanently ?'", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dt == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string itemid = "";

                    for (int i = 0; i < Edit_List_Input.Count; i++)
                    {
                        if (Edit_List_Input[i].ProductItemID.Trim() == "")
                        { continue; }

                        itemid = itemid + "'" + Edit_List_Input[i].ProductItemID.Trim() + "',";
                    }
                    itemid = itemid.Substring(0, itemid.Length - 1);

                   con.UpdateProductRecord("Delete from [mbo].[PSVendorItemMapping] where [ProductVendorId]='" + Vendorid + "' and [ProductItemId] in (" + itemid + ")");
                    MessageBox.Show("Deleted From Vendor Mapping ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    DialogResult_ = "delete";

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonAdv3_Click(object sender, EventArgs e)
        {
            using (Search_Products sp = new Search_Products(user))
            {
                sp.ShowDialog();
                if (sp.ShowDialog == true)
                {
                    var pids = sp.ProductItemID_List;
                    for(int i=0;i<pids.Count;i++)
                    {
                        con.InsertInformation("INSERT INTO [mbo].[PSVendorItemMapping] ([ProductVendorId],[ProductItemId],[Name]) VALUES ('" + Vendorid + "','" + pids[i] + "',(select top 1 Name from [dbo].[ProductVendor] where ProductVendorId='" + Vendorid + "'))");
                    }
                    SharedServices srv = new SharedServices();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = srv.GetMappinOrderItems(Vendorid);

                }
            }
        }
    }
}
