using MaxBachat2;
using MaxBachat21.Model;
using NavigationDrawer_2010;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace MaxBachat21
{
    public partial class MyPlan : Syncfusion.Windows.Forms.MetroForm
    {

        
        Color _color = System.Drawing.ColorTranslator.FromHtml("#F5F7FF");
        private TabControlAdv tabCtrl;
        MainForm parent = null;

        Connection con = new Connection();
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPag;
        int SelectedRowForDT = -1;
        int SelectedColumForDT = -1;
        string SelectedHeaderText = "";
        List<MyPlanModel> MyPlanList = new List<MyPlanModel>();
        public MyPlan(MainForm mn)
        {
            InitializeComponent();
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;
            parent = mn;
        }

        public Syncfusion.Windows.Forms.Tools.TabPageAdv TabPag
        {
            get
            {
                return tabPag;
            }
            set
            {
                tabPag = value;
            }
        }

        public TabControlAdv TabCtrl
        {
            set
            {
                tabCtrl = value;
            }
        }

        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            return dTable;
        }

        private void MyPlan_Load(object sender, EventArgs e)
        {
            string script = File.ReadAllText("MyPlanSql.sql");
         
            script = script.Replace("\r\n", " ");
            script = script.Replace("\t", " ");

            DataTable dt= con.getDataTableFromDB(script);
           // int count = -1;
            //for(int i=0;i<dt.Rows.Count;i++)
            //{ 
               
            //  //  MessageBox.Show(dt.Rows[i]["Mon"].ToString());
            //   if(dt.Rows[i]["Mon"].ToString()=="True")
            //    {
            //        count++;
            //        string vendorid = "";

            //        vendorid = dt.Rows[i]["VendorID"].ToString();
            //        if (MyPlanList.Count <= i)
            //        {
            //            MyPlanModel m = new MyPlanModel();

            //            MyPlanList.Add(m);
            //        }
            //        MyPlanList[count].Mon =int.Parse( vendorid);
            //    }


            //}
            //count = -1;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

            //    //  MessageBox.Show(dt.Rows[i]["Mon"].ToString());
            //    if (dt.Rows[i]["Tue"].ToString() == "True")
            //    {
            //        count++;
            //        string vendorid = "";

            //        vendorid = dt.Rows[i]["VendorID"].ToString();
            //        if (MyPlanList.Count <= i)
            //        {
            //            MyPlanModel m = new MyPlanModel();

            //            MyPlanList.Add(m);
            //        }
            //        MyPlanList[count].Tue = int.Parse(vendorid);
            //    }


            //}

            
            gridGroupingControl1.DataSource = dt;
           
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("RN1");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("RN2");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("RN3");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("RN4");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("RN5");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("RN6");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("RN7");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("MonDOM");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("TueDOM");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("WedDOM");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("ThuDOM");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("FriDOM");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("SatDOM");
            gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("SunDOM");
            
            gridGroupingControl1.TableDescriptor.AllowNew = false;
            gridGroupingControl1.TableModel.RowHeights.ResizeToFit(GridRangeInfo.Table(), GridResizeToFitOptions.ResizeCoveredCells);
          

            gridGroupingControl1.Appearance.AnyCell.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridGroupingControl1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridGroupingControl1.TableDescriptor.Appearance.AnyCell.ReadOnly = true;

            this.gridGroupingControl1.Table.DefaultRecordRowHeight = 70;
           

         
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
          //  GridSkins.ApplySkin(this.gridGroupingControl1.TableModel, Skins.Vista);
            this.gridGroupingControl1.TableControl.MetroColorTable.ThumbNormal = Color.ForestGreen;
            gridGroupingControl1.TableDescriptor.Columns["Mon"].Width = 150;
            gridGroupingControl1.TableDescriptor.Columns["Tue"].Width = 150;
            gridGroupingControl1.TableDescriptor.Columns["Wed"].Width = 150;
            gridGroupingControl1.TableDescriptor.Columns["Thu"].Width = 150;
            gridGroupingControl1.TableDescriptor.Columns["Fri"].Width = 150;
            gridGroupingControl1.TableDescriptor.Columns["Sat"].Width = 150;
            gridGroupingControl1.TableDescriptor.Columns["Sun"].Width = 150;
            SetDateCalender(DateTime.Now);
            gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font = new Syncfusion.Windows.Forms.Grid.GridFontInfo(new Font("Arial", 10f, FontStyle.Bold));
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;

        }

        private void SetDateCalender(DateTime today)
        { int index = -1;
            string[] arr = new string[7];
            arr[0] = "Mon";
            arr[1] = "Tue";
            arr[2] = "Wed";
            arr[3] = "Thu";
            arr[4] = "Fri";
            arr[5] = "Sat";
            arr[6] = "Sun";
                              


           for(int i=0;i<arr.Length;i++)
            {
                if(arr[i].ToLower()==today.ToString("ddd").ToLower())
                {
                    index = i;
                }
            }
            for (int i = 0; i < gridGroupingControl1.TableDescriptor.Columns.Count; i++)
            {

                gridGroupingControl1.TableDescriptor.Columns[i].Appearance.AnyRecordFieldCell.BackColor = _color ;
            }
            

            gridGroupingControl1.TableDescriptor.Columns[arr[ index%7]].Appearance.AnyRecordFieldCell.BackColor = Color.Gold;
                gridGroupingControl1.TableDescriptor.Columns[arr[ index%7]].HeaderText = arr[index%7] + " " + today.ToString("dd");


            int temp = 0;
            for (int i=index-1;i>=0;i--)
            {
                temp--;
                gridGroupingControl1.TableDescriptor.Columns[arr[i]].HeaderText = arr[i] + " " + today.AddDays(temp).ToString("dd");

            }
            temp = 0;
            for(int i=index+1;i<7;i++)
            {
                temp++;
                gridGroupingControl1.TableDescriptor.Columns[arr[i]].HeaderText = arr[i] + " " + today.AddDays(temp).ToString("dd");

            }


        }

        private void TableModel_QueryRowWidt(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index != 1)
            {
                e.Size = 100;
                e.Handled = true;
            }
        }

  
        private void gridGroupingControl1_TableControlCellClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {

        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            SetDateCalender(monthView1.SelectionStart);
        }

        private void gridGroupingControl1_TableControlCurrentCellActivating(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCurrentCellActivatingEventArgs e)
        {
            GridTableCellStyleInfo style = this.gridGroupingControl1.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            if (style.TableCellIdentity.TableCellType == GridTableCellType.RecordFieldCell || style.TableCellIdentity.TableCellType == GridTableCellType.AlternateRecordFieldCell)
            {
                e.Inner.Cancel = true;
            }
        }
        private string getNameOfVendor(string id)
        {
            try
            {
                if (id == "")
                { return "Empty"; }
                var list = parent.VendorComboBox;
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if (list.Items[i].ToString().Contains(id))
                    {
                        var name = list.Items[i].ToString().Split(new[] { "-----" }, StringSplitOptions.None);
                        return name[1];
                    }

                }
                return "Name Not Found";
            }
            catch { return "Name Not Found"; }
        }
        private void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {

            if (e.Style.TableCellIdentity.Column != null )
            {

                //Setting the comment tip text

                if (e.TableCellIdentity.DisplayElement != null)
                {
                    try
                    {
                        var col = e.TableCellIdentity.Column.HeaderText.Split(new [] { " " },StringSplitOptions.None);
                        var row = e.TableCellIdentity.RowIndex-2;
                        var value = gridGroupingControl1.Table.Records[row][col[0]].ToString();
                        e.Style.CommentTip.CommentText = getNameOfVendor(value);
                    }
                    catch { }
                }
            }







        }

        private void gridGroupingControl1_TableControlCellHitTest(object sender, GridTableControlCellHitTestEventArgs e)
        {
            gridGroupingControl1.TableModel.Options.SelectCellsMouseButtonsMask = MouseButtons.Left | MouseButtons.Right;
            if (e.Inner.MouseEventArgs.Button == System.Windows.Forms.MouseButtons.Right)
            {

                GridCurrentCell cc = e.TableControl.CurrentCell;
                GridTableCellStyleInfo style = e.TableControl.Model[e.Inner.RowIndex, e.Inner.ColIndex] as GridTableCellStyleInfo;


                SelectedRowForDT = (e.TableControl.TableDescriptor.ColIndexToField(e.Inner.RowIndex) - 2);
                SelectedColumForDT = e.TableControl.TableDescriptor.ColIndexToField(e.Inner.ColIndex);



                SelectedHeaderText = style.TableCellIdentity.Column.MappingName;


                contextMenuStrip1.Show(gridGroupingControl1, e.Inner.MouseEventArgs.X, e.Inner.MouseEventArgs.Y);



            }


        }
        private int getIndexOfVendor(string id)
        {
            if (id == "")
            { return -1; }
            var list = parent.VendorComboBox;
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].ToString().Contains(id))
                {
                    return i;
                }

            }
            return -1;

        }

        private void makeNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var value = gridGroupingControl1.Table.Records[SelectedRowForDT+1][SelectedHeaderText].ToString();

            int ind= getIndexOfVendor(value);
            parent.SetVendorBoxIndex(ind);
            parent.CreateNewOrder();
            parent.SetVendorBoxIndex(ind);
            parent.NewPOStripButton.Checked = true;
        }
    }
}
