using MaxBachat2;
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
    public partial class Request_List : Syncfusion.Windows.Forms.Office2007Form
    {
        MainForm parent = null;
        Connection con = new Connection();
        User user;
        public Request_List(User _user, MainForm _parent)
        {
            InitializeComponent();
            user = _user;
            parent = _parent;
        }

        private void Request_List_Load(object sender, EventArgs e)
        {
            InformationGrid.DataSource = con.getDataTableFromDB(" SELECT [FloorRequestID] ,[RequestDate] " +
      ",[CompanyBranchId]"+
      ",[BranchFloorId]"+
      ",[RequestUser]"+
      ", (select count(*)  from [mbo].PSFloorRequestItems s where  s.FloorRequestID =[FloorRequestID]) AS [No of Records]"+
  " FROM [mbo].[PSFloorRequest]  order by [FloorRequestID] DESC");
           // InformationGrid.Columns["UserID"].Visible = false;

        }
        int CurrentRow = -1;
        private void InformationGrid_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    var hit = InformationGrid.HitTest(e.X, e.Y);

                    
                    CurrentRow = hit.RowIndex;

                }
            }
            catch (Exception)
            { }
        }

        private void InformationGrid_DoubleClick(object sender, EventArgs e)
        {
            //    MessageBox.Show(InformationGrid.Rows[CurrentRow].Cells[0].Value.ToString());
            Request_List_Items rli = new Request_List_Items(null, InformationGrid.Rows[CurrentRow].Cells[0].Value.ToString(),parent);
            rli.ShowDialog();
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

 //           InformationGrid.DataSource = con.getDataTableFromDB(" SELECT [FloorRequestID] ,[RequestDate] " +
 //    ",[CompanyBranchId]" +
 //    ",[BranchFloorId]" +
 //    ",[RequestUser]" +
 //    ", (select count(*)  from [mbo].PSFloorRequestItems s where  s.FloorRequestID =[FloorRequestID]) AS [No of Records]" +
 //" FROM [mbo].[PSFloorRequest] and  order by [FloorRequestID] DESC");
        }
    }
}
