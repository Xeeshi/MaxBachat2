using MaxBachat2.Model;
using MaxBachat21;
using MaxBachat21.Model;
using NavigationDrawer_2010;
using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat2
{
    public partial class ChildForm : Syncfusion.Windows.Forms.MetroForm
    {
        MainForm parent = null;
        User user = null;
        public ChildForm(MainForm m,User _user)
        {
            InitializeComponent();
            parent = m;
            user = _user;
        }

        private TabControlAdv tabCtrl;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPag;
        Connection con = new Connection();
        static int SelectedColumForDT = -1;
       static int SelectedRowForDT = -1;
        static string SelectedHeaderText = "";

        public int VendorCombox { get; set; }
        public string VendorTextBox { get; set; }
        public int BranchCombobox { get; set; }
        public int DeliveryDateCombobox { get; set; }
        public int ExpiryCombobox { get; set; }
        public int PriorityCombobox { get; set; }
        public string Remarks { get; set; }
        public bool Status { get; set; }
        public string OrderID { get; set; }
        public string StateMsg { get; set; }
        public List<string> SelectedColumnsList = new List<string>();
        public List<string> SelectedRowList = new List<string>();


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

      


        private void ChildForm_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R))
            {


                SelectRow();
                return true;
            }
            else if(keyData==(Keys.Control | Keys.E))
            {
                Edit_Delete_Item();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }



     
        private double getMaxNumberFromSelectedColumn(int row, RecordsInTableCollection dt)
        {
            try
            {
                if (SelectedColumnsList.Count == 0)
                {
                    return 0;
                }
                double maxnumber = double.Parse(dt[row][SelectedColumnsList[0]].ToString());

                for (int i = 0; i < SelectedColumnsList.Count; i++)
                {
                    if (double.Parse(dt[row][SelectedColumnsList[i]].ToString()) > maxnumber)
                    {
                        maxnumber = double.Parse(dt[row][SelectedColumnsList[i]].ToString());
                    }

                }
                return maxnumber;
            }
            catch (Exception ex)
            {
                //      MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public void DosMode()
        {
            monthtlyViewToolStripMenuItem.Enabled = true;
            dOSViewToolStripMenuItem.Enabled = false;
            DG.TableDescriptor.VisibleColumns.Remove("B1_1M");
            DG.TableDescriptor.VisibleColumns.Remove("B1_2M");
            DG.TableDescriptor.VisibleColumns.Remove("B1_3M");

            DG.TableDescriptor.VisibleColumns.Remove("B2_1M");
            DG.TableDescriptor.VisibleColumns.Remove("B2_2M");
            DG.TableDescriptor.VisibleColumns.Remove("B2_3M");

            //DG.TableDescriptor.VisibleColumns.Remove("B3_1M");
            //DG.TableDescriptor.VisibleColumns.Remove("B3_2M");
            //DG.TableDescriptor.VisibleColumns.Remove("B3_3M");

            DG.TableDescriptor.VisibleColumns.Remove("Total_1M");
            DG.TableDescriptor.VisibleColumns.Remove("Total_2M");
            DG.TableDescriptor.VisibleColumns.Remove("Total_3M");

            DG.TableDescriptor.VisibleColumns.Remove("ShabanLY");
            DG.TableDescriptor.VisibleColumns.Remove("RamazanLY");

            DG.TableDescriptor.VisibleColumns.Add("B1_1M_D");
            DG.TableDescriptor.VisibleColumns.Add("B1_2M_D");
            DG.TableDescriptor.VisibleColumns.Add("B1_3M_D");

            DG.TableDescriptor.VisibleColumns.Add("B2_1M_D");
            DG.TableDescriptor.VisibleColumns.Add("B2_2M_D");
            DG.TableDescriptor.VisibleColumns.Add("B2_3M_D");

            //DG.TableDescriptor.VisibleColumns.Add("B3_1M_D");
            //DG.TableDescriptor.VisibleColumns.Add("B3_2M_D");
            //DG.TableDescriptor.VisibleColumns.Add("B3_3M_D");

            DG.TableDescriptor.VisibleColumns.Add("Total_1M_D");
            DG.TableDescriptor.VisibleColumns.Add("Total_2M_D");
            DG.TableDescriptor.VisibleColumns.Add("Total_3M_D");

            DG.TableDescriptor.VisibleColumns.Add("ShabanLY_D");
            DG.TableDescriptor.VisibleColumns.Add("RamazanLY_D");



            DG.Refresh();
            DG.Invalidate();
            DG.TableControl.RefreshRange(GridRangeInfo.Table());

        }
        public void MonthlyView()
        {
            monthtlyViewToolStripMenuItem.Enabled = false;
            dOSViewToolStripMenuItem.Enabled = true;

            //DG.TableDescriptor.VisibleColumns.Add("B1_1M");
            //DG.TableDescriptor.VisibleColumns.Add("B1_2M");
            //DG.TableDescriptor.VisibleColumns.Add("B1_3M");

            //DG.TableDescriptor.VisibleColumns.Add("B2_1M");
            //DG.TableDescriptor.VisibleColumns.Add("B2_2M");
            //DG.TableDescriptor.VisibleColumns.Add("B2_3M");

            ////DG.TableDescriptor.VisibleColumns.Add("B3_1M");
            ////DG.TableDescriptor.VisibleColumns.Add("B3_2M");
            //DG.TableDescriptor.VisibleColumns.Add("B3_3M");

            DG.TableDescriptor.VisibleColumns.Add("Total_1M");
            DG.TableDescriptor.VisibleColumns.Add("Total_2M");
            DG.TableDescriptor.VisibleColumns.Add("Total_3M");

            DG.TableDescriptor.VisibleColumns.Add("ShabanLY");
            DG.TableDescriptor.VisibleColumns.Add("RamazanLY");



            DG.TableDescriptor.VisibleColumns.Remove("B1_1M_D");
            DG.TableDescriptor.VisibleColumns.Remove("B1_2M_D");
            DG.TableDescriptor.VisibleColumns.Remove("B1_3M_D");

            DG.TableDescriptor.VisibleColumns.Remove("B2_1M_D");
            DG.TableDescriptor.VisibleColumns.Remove("B2_2M_D");
            DG.TableDescriptor.VisibleColumns.Remove("B2_3M_D");

            //DG.TableDescriptor.VisibleColumns.Remove("B3_1M_D");
            //DG.TableDescriptor.VisibleColumns.Remove("B3_2M_D");
            //DG.TableDescriptor.VisibleColumns.Remove("B3_3M_D");

            DG.TableDescriptor.VisibleColumns.Remove("Total_1M_D");
            DG.TableDescriptor.VisibleColumns.Remove("Total_2M_D");
            DG.TableDescriptor.VisibleColumns.Remove("Total_3M_D");

            DG.TableDescriptor.VisibleColumns.Remove("ShabanLY_D");
            DG.TableDescriptor.VisibleColumns.Remove("RamazanLY_D");

            DG.Refresh();
            DG.Invalidate();
            DG.TableControl.RefreshRange(GridRangeInfo.Table());
        }
        private decimal IfNegativeMakeZero(string number)
        {
            try
            {
                if(decimal.Parse(number)<0)
                {
                    return 0;
                }
                else
                { return decimal.Parse(number); }

               

            } catch(Exception ex) { MessageBox.Show(ex.Message); }
           return 0;
        }
        private void calculateSuggestOrder()
        {
            
            for (int i = 0; i < DG.Table.Records.Count; i++)
            {
                if (SelectedColumnsList.Count == 0)
                {
                    MessageBox.Show("Please Select One or More Column to Calculate Suggest Order", "Column Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
    

                decimal max = decimal.Parse(getMaxNumberFromSelectedColumn(i, DG.Table.Records).ToString());
                // var result = Math.Round((max / 31) * decimal.Parse(DG.Table.Records[i]["DOS"].ToString()) - decimal.Parse(DG.Table.Records[i]["Inventory"].ToString()), 0) / decimal.Parse(DG.Table.Records[i]["MOQ"].ToString());
               


                var result = max / 31;
                result = result * decimal.Parse(DG.Table.Records[i].GetValue("DOS").ToString());
                result = result - IfNegativeMakeZero(DG.Table.Records[i].GetValue("Inventory").ToString());
                result = Math.Round(result, 0);
                result = result / decimal.Parse(DG.Table.Records[i].GetValue("MOQ").ToString());
                result = Math.Round(result, 0);
                result = result * decimal.Parse(DG.Table.Records[i].GetValue("MOQ").ToString());

                DG.Table.Records[i].SetValue("Sugg", result);
                if(result>0)
                {
                    DG.Table.Records[i].SetValue("FinalPC", result);
                }
                if(result<=0)
                { DG.Table.Records[i].SetValue("FinalPC", 0); }
            }
            
            DG.Refresh();
            DG.Invalidate();
          //  dt.AcceptChanges();
            DG.TableControl.RefreshRange(GridRangeInfo.Table());
        }



        private void calculateSuggestedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculateSuggestOrder();

        }
        private void ResetTabs()
        {
            for (int i = 0; i < SelectedColumnsList.Count; i++)
            {
                this.DG.TableDescriptor.Columns[SelectedColumnsList[i]].Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(214, 220, 232), Color.FromArgb(106, 111, 151));
            }
            SelectedColumnsList.Clear();
        }
        public void Select_Branch1_Column()
        {
            ResetTabs();
            this.DG.TableDescriptor.Columns["B1_1M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B1_1M");

            this.DG.TableDescriptor.Columns["B1_2M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B1_2M");
            this.DG.TableDescriptor.Columns["B1_3M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B1_3M");

            calculateSuggestOrder();
        }
        public void Select_Branch2_Column()
        {
            ResetTabs();
            this.DG.TableDescriptor.Columns["B2_1M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B2_1M");

            this.DG.TableDescriptor.Columns["B2_2M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B2_2M");
            this.DG.TableDescriptor.Columns["B2_3M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B2_3M");

            calculateSuggestOrder();
        }
        public void Select_Branch3_Column()
        {
            ResetTabs();
            this.DG.TableDescriptor.Columns["B3_1M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B3_1M");

            this.DG.TableDescriptor.Columns["B3_2M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B3_2M");
            this.DG.TableDescriptor.Columns["B3_3M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("B3_3M");

            calculateSuggestOrder();
        }
        public void Select_BranchJDC_GRC_Column()
        {
            ResetTabs();
            this.DG.TableDescriptor.Columns["Total_1M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("Total_1M");

            this.DG.TableDescriptor.Columns["Total_2M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            SelectedColumnsList.Add("Total_2M");
            //this.DG.TableDescriptor.Columns["Total_3M"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            //SelectedColumnsList.Add("Total_3M");

            //this.DG.TableDescriptor.Columns["ShabanLY"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            //SelectedColumnsList.Add("ShabanLY");

            //this.DG.TableDescriptor.Columns["RamazanLY"].Appearance.ColumnHeaderCell.BackColor = Color.Red;
            //SelectedColumnsList.Add("RamazanLY");

            calculateSuggestOrder();
        }

        private void dOSViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DosMode();
        }

        private void monthtlyViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyView();
        }

  
        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.DG.Table.Records[SelectedRowForDT].Delete();
                // this.DG.Table.Records.Delete()

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        private void DG_TableControlCurrentCellValidating(object sender, GridTableControlCancelEventArgs e)
        {
            double output;
           
                if(!double.TryParse(this.DG.TableControl.CurrentCell.Renderer.ControlText,out output ))
            {
              //  MessageBoxAdv.Show("Only Integers are Allowed", "Invalid INPUT", MessageBoxButtons.OK);
                this.DG.TableControl.CurrentCell.Renderer.ControlText = "0";
                return;
            }
            
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DG.Table.Records.DeleteAll();
        }

       
        //private List<POMODEL> GetPOList()
        //{
        //    List<POMODEL> pmlist = new List<POMODEL>();
        //    try
        //    {
             
        //        var list = DG.Table.Records;
                
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (Double.Parse(list[i].GetValue("FinalPC").ToString()) != 0)
        //            {

        //                POMODEL pm = new POMODEL()
        //                { Barcode = list[i].GetValue("Barcode").ToString(),
        //                    AltBarcode = list[i].GetValue("AltBarcode").ToString(),
        //                    ItemDescription= list[i].GetValue("ItemDescription").ToString(),
        //                    FinalPC= list[i].GetValue("FinalPC").ToString(),
        //                    OrderCTN= double.Parse(list[i].GetValue("OrderCTN").ToString()),
        //                    Total=double.Parse( list[i].GetValue("Total").ToString()),
        //                    Cost = double.Parse(list[i].GetValue("Cost").ToString()),


        //                };
        //                pmlist.Add(pm);





        //            }
                
        //        }
        //        return pmlist;
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message); }

        //    return null;

        //}

  

        private void DG_TableControlCellHitTest(object sender, GridTableControlCellHitTestEventArgs e)
        {
            try
            {
                DG.TableModel.Options.SelectCellsMouseButtonsMask = MouseButtons.Left | MouseButtons.Right;
                if (e.Inner.MouseEventArgs.Button == System.Windows.Forms.MouseButtons.Right)
                {

                    GridCurrentCell cc = e.TableControl.CurrentCell;
                    GridTableCellStyleInfo style = e.TableControl.Model[e.Inner.RowIndex, e.Inner.ColIndex] as GridTableCellStyleInfo;


                    SelectedRowForDT = (e.TableControl.TableDescriptor.ColIndexToField(e.Inner.RowIndex) - 2);
                    SelectedColumForDT = e.TableControl.TableDescriptor.ColIndexToField(e.Inner.ColIndex);



                    SelectedHeaderText = style.TableCellIdentity.Column.MappingName;


                    contextMenuStrip1.Show(DG, e.Inner.MouseEventArgs.X, e.Inner.MouseEventArgs.Y);



                }


            }
            catch { }
            
        }

        private void DG_TableControlCurrentCellEditingComplete(object sender, GridTableControlEventArgs e)
        {
            GridCurrentCell cc = e.TableControl.CurrentCell;

            GridTableCellStyleInfo style = e.TableControl.Model[cc.RowIndex, cc.ColIndex] as GridTableCellStyleInfo;
            if (style.TableCellIdentity.Column.MappingName.ToLower() == "dos")
            {
                string newvalue = cc.Renderer.ControlText;
                GridRecordRow rr = style.TableCellIdentity.DisplayElement as GridRecordRow;
                CalculateDosForSingleRow(rr, cc.RowIndex, decimal.Parse(newvalue));
                //Task.Run(()=>
                //calculateSuggestOrder());
            }

        }


        private void CalculateDosForSingleRow(GridRecordRow rr,int i,decimal dos)
        {
            // manging index
            i = i - 3;

            decimal max = decimal.Parse(getMaxNumberFromSelectedColumn(i, DG.Table.Records).ToString());


            var result = max / 31;
          
            result = result * dos;
            result = result - IfNegativeMakeZero(DG.Table.Records[i]["Inventory"].ToString());
            result = Math.Round(result, 0);
            result = result / decimal.Parse(DG.Table.Records[i]["MOQ"].ToString());
            result = Math.Round(result, 0);
            result = result * decimal.Parse(DG.Table.Records[i]["MOQ"].ToString());

            rr.ParentRecord.SetValue("Sugg", result);
            if(result>0)
            { rr.ParentRecord.SetValue("FinalPC", result); }
            else if(result<=0)
            {
                rr.ParentRecord.SetValue("FinalPC", 0);
            }
            
        }
        private void Edit_Delete_Item()
        {
            try
            {
                List<Edit_Items> editlist = new List<Edit_Items>();

                var vendor = parent.VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);

                foreach (SelectedRecord selectedRecord in this.DG.Table.SelectedRecords)
                {

                    Edit_Items er = new Edit_Items()
                    {
                        MOQ = selectedRecord.Record["MOQ"].ToString(),
                        Barcode= selectedRecord.Record["Barcode"].ToString(),
                        ProductItemID = selectedRecord.Record["ProductItemID"].ToString(),
                        ItemDescription = selectedRecord.Record["ItemDescription"].ToString(),

                    };


                    // selectedRecord.Record.SetValue(column.Name, "Modified_Record");
                    editlist.Add(er);


                }
                using (Edit_Item eis = new Edit_Item(editlist, vendor[1].Trim(),user))
                {
                    eis.ShowDialog();
                    if (eis.DialogResult_ == "update")
                    {
                        var list = eis.Edit_List_Output;

                        for (int i = 0; i < this.DG.Table.SelectedRecords.Count; i++)
                        {


                            this.DG.Table.SelectedRecords[i].Record.SetValue("MOQ", list[i].MOQ);
                            this.DG.Table.SelectedRecords[i].Record.SetValue("MOQUnit", list[i].MOQUnit);
                            this.DG.Table.SelectedRecords[i].Record.SetValue("ItemDescription", list[i].ItemDescription);




                        }

                        this.DG.Table.SelectedRecords.Clear();
                    }
                    else if (eis.DialogResult_ == "delete")
                    {
                        Syncfusion.Grouping.SelectedRecordsCollection selRecords;
                        selRecords = this.DG.Table.SelectedRecords;
                        foreach (Syncfusion.Grouping.SelectedRecord record in selRecords)
                        {
                            record.Record.Delete();
                        }


                    }

                };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Delete_Item();

        }

        private void selectColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select_Column();

        }
        private void Select_Column()
            {
                if (!SelectedColumnsList.Contains(SelectedHeaderText))
                {
                    SelectedColumnsList.Add(SelectedHeaderText);
                    //this.DG.TableDescriptor.Columns[SelectedHeaderText].Appearance.AnyRecordFieldCell.BackColor = Color.LightSkyBlue;
                    this.DG.TableDescriptor.Columns[SelectedHeaderText].Appearance.ColumnHeaderCell.BackColor = Color.Red;

                }
            
        }
        private void deselectColumnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Deselect_Column();
          
        }
        private void Deselect_Column()
        {
            if (SelectedColumnsList.Contains(SelectedHeaderText))
            {
                SelectedColumnsList.Remove(SelectedHeaderText);
                this.DG.TableDescriptor.Columns[SelectedHeaderText].Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(214, 220, 232), Color.FromArgb(106, 111, 151));
            }


            SelectedHeaderText = "";
        }
        private void selectRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.DG.TableModel.Selections.Add(GridRangeInfo.Row(SelectedRowForDT+3));
            //     
            SelectRow();

        }

        private void SelectRow()
        {
            try {
                if (this.DG.Table.CurrentRecord != null)
                {

                    Record rec = this.DG.Table.CurrentRecord;
                    if (this.DG.Table.SelectedRecords.Contains(rec))
                    {
                        this.DG.Table.SelectedRecords.Remove(rec);
                    }
                    else
                    {
                        this.DG.Table.SelectedRecords.Add(rec);
                    }
                }
            }
            catch { }
            }
        private void deselectRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deselect_Row();
        }
        private void Deselect_Row()
        {
            try
            {
                Record rec = this.DG.Table.Records[SelectedRowForDT];
                this.DG.Table.SelectedRecords.Remove(rec);
            }
            catch { }
        }
     

        private void setDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal dos;
            using (SetDOS sd = new SetDOS())
            {
                sd.ShowDialog();
                if (sd.DialogResult_ == true)
                {

                    dos = sd.DOS;

                    for (int i = 0; i < this.DG.Table.Records.Count; i++)
                    {


                      
                        this.DG.Table.Records[i].SetValue("DOS", dos);





                    }
               
                    calculateSuggestOrder();
                }
            };
            }

        private void rowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectRow();
        }

        private void deselectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select_Column();
        }

        private void deselectRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Deselect_Row();
        }

        private void deleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DG.Table.SelectedRecords.Clear();
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.DG.Table.Records.SelectAll();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select_Column();
        }

        private void deselectColumnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Deselect_Column();
        }

        private void deselectAllColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0;i<SelectedColumnsList.Count;i++)
            {
                if (SelectedColumnsList.Contains(SelectedColumnsList[i]))
                {
                    SelectedColumnsList.Remove(SelectedColumnsList[i]);
                    this.DG.TableDescriptor.Columns[SelectedColumnsList[i]].Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(214, 220, 232), Color.FromArgb(106, 111, 151));
                }


                SelectedHeaderText = "";
            }
        }












        //private void CalculateSuggestedRow(int i)
        //{
        //    parent.StateMessageLabel.Text = "Calcuated Suggested Order " + (DG.RowCount - 1) + "/" + i;

        //    if (SelectedColumnsList.Count == 0)
        //    {
        //        MessageBox.Show("Please Select One or More Columns", "Selected Column Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    try
        //    {
        //        double result = getMaxNumberFromSelectedColumn(i);
        //        result = result / 31;
        //        result = result * double.Parse(DG.Rows[i].Cells["DOS"].Value.ToString());
        //        result = result - ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString());
        //        result = ROUNDUP(result, 0);
        //        result = result / double.Parse(DG.Rows[i].Cells["MOQ"].Value.ToString());
        //        result = ROUNDUP(result, 0);
        //        result = result * double.Parse(DG.Rows[i].Cells["MOQ"].Value.ToString());

        //        //if(result<0)
        //        //{
        //        //    DG.BeginInvoke(new MethodInvoker(()=>
        //        //    DG.Rows[i].Cells["Sugg"].Style.BackColor = Color.LightPink));
        //        //}
        //        //else {
        //        //    DG.BeginInvoke(new MethodInvoker(() =>
        //        //    DG.Rows[i].Cells["Sugg"].Style.BackColor = Color.White));
        //        //}
        //        DG.BeginInvoke(new MethodInvoker(() =>
        //        DG.Rows[i].Cells["Sugg"].Value = result));



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        ////        private string Currency(string curr)
        //        {

        //            decimal parsed = decimal.Parse(curr, CultureInfo.InvariantCulture);
        //            CultureInfo hindi = new CultureInfo("hi-IN");
        //            string text = string.Format(hindi, "{0:#,#}", parsed);
        //            return text;
        //        }

        //        public void GridView_Settings(string branch)
        //        {

        //            try
        //            {
        //                DG.BeginInvoke(new MethodInvoker(() =>
        //              DG.Columns["Barcode"].Visible = false
        //                   ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //            DG.Columns["AltBarcode"].Visible = false
        //             ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //            DG.Columns["ProductItemID"].Visible = false
        //                 ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //          DG.Columns["B3_1M"].Visible = false
        //               ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //          DG.Columns["B3_2M"].Visible = false
        //               ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //          DG.Columns["B3_3M"].Visible = false
        //               ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //          DG.Columns["Min"].Visible = false
        //               ));
        //                DG.BeginInvoke(new MethodInvoker(() =>
        //       DG.Columns["DOS"].DefaultCellStyle.BackColor = Color.LightSteelBlue
        //            ));

        //            DG.BeginInvoke(new MethodInvoker(() =>
        //            DG.Columns["FinalPC"].DefaultCellStyle.BackColor = Color.LightSteelBlue
        //                    ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //       DG.Columns["MOQUnit"].Visible = true
        //            ));
        //                DG.BeginInvoke(new MethodInvoker(() =>
        //          DG.Columns["Max"].Visible = false
        //               ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //          DG.Columns["ROP"].Visible = false
        //               ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //      DG.Columns["Sugg"].DefaultCellStyle.Font= new System.Drawing.Font("Arial", 10F, FontStyle.Bold)
        //           ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        // DG.Columns["FinalPC"].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F, FontStyle.Bold)
        //      ));




        //                DG.BeginInvoke(new MethodInvoker(() =>
        //             DG.Columns["ItemDescription"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        //             ));




        //                DG.BeginInvoke(new MethodInvoker(() =>
        //              DG.Columns["FinalPC"].ReadOnly = false
        //              ));

        //                DG.BeginInvoke(new MethodInvoker(() =>
        //          DG.Columns["DOS"].ReadOnly = false
        //          ));


        //                if (branch == "BR1")
        //                {

        //                    DG.BeginInvoke(new MethodInvoker(() =>
        // DG.Columns["B1_1M"].DisplayIndex = 13
        // ));
        //                    DG.BeginInvoke(new MethodInvoker(() =>
        //  DG.Columns["B1_2M"].DisplayIndex = 14
        //       ));
        //                    DG.BeginInvoke(new MethodInvoker(() =>
        //  DG.Columns["B1_3M"].DisplayIndex = 15
        //       ));
        //                }

        //                else if (branch == "BR2")
        //                {

        //                    DG.BeginInvoke(new MethodInvoker(() =>
        //DG.Columns["B2_1M"].DisplayIndex = 13
        //));
        //                    DG.BeginInvoke(new MethodInvoker(() =>
        //  DG.Columns["B2_2M"].DisplayIndex = 14
        //       ));
        //                    DG.BeginInvoke(new MethodInvoker(() =>
        //  DG.Columns["B2_3M"].DisplayIndex = 15
        //       ));

        //                }



        //            }
        //            catch (Exception ex) { MessageBox.Show(ex.Message); }
        //        }

        //        private List<POMODEL> getpolist()
        //        {

        //              try
        //                {
        //                    List<POMODEL> pmlist = new List<POMODEL>();
        //                    for (int i = 0; i < DG.Rows.Count; i++)
        //                        {
        //                            POMODEL pm = new POMODEL()
        //                            {
        //                                ProductItemID = DG.Rows[i].Cells["ProductItemID"].Value.ToString(),
        //                                Barcode = DG.Rows[i].Cells["Barcode"].Value.ToString(),
        //                                AltBarcode = DG.Rows[i].Cells["AltBarcode"].Value.ToString(),
        //                                ItemDescription = DG.Rows[i].Cells["ItemDescription"].Value.ToString(),


        //                                // OrderPC = dataGridView1.Rows[i].Cells["OrderPC"].Value.ToString(),
        //                                  OrderCTN = double.Parse(DG.Rows[i].Cells["OrderCTN"].Value.ToString()),


        //                                Cost = double.Parse(DG.Rows[i].Cells["Cost"].Value.ToString()),
        //                                Total = double.Parse(DG.Rows[i].Cells["Total"].Value.ToString()),
        //                                FinalPC = DG.Rows[i].Cells["FinalPC"].Value.ToString(),

        //                                Inventory = DG.Rows[i].Cells["Inventory"].Value.ToString(),

        //                                Total_1M = DG.Rows[i].Cells["Total_1M"].Value.ToString(),
        //                                Total_2M = DG.Rows[i].Cells["Total_2M"].Value.ToString(),
        //                                Total_3M = DG.Rows[i].Cells["Total_3M"].Value.ToString(),

        //                                ShabanLY = DG.Rows[i].Cells["ShabanLY"].Value.ToString(),
        //                                RamazanLY = DG.Rows[i].Cells["RamazanLY"].Value.ToString(),

        //                                Max = DG.Rows[i].Cells["Max"].Value.ToString(),
        //                                Min = DG.Rows[i].Cells["Min"].Value.ToString(),
        //                                ROP = DG.Rows[i].Cells["ROP"].Value.ToString(),

        //                                Sugg = DG.Rows[i].Cells["Sugg"].Value.ToString(),
        //                                B1_1M = DG.Rows[i].Cells["B1_1M"].Value.ToString(),
        //                                B1_2M = DG.Rows[i].Cells["B1_2M"].Value.ToString(),
        //                                B1_3M = DG.Rows[i].Cells["B1_3M"].Value.ToString(),




        //                                MOQ = DG.Rows[i].Cells["MOQ"].Value.ToString(),
        //                                DOS = DG.Rows[i].Cells["DOS"].Value.ToString(),
        //                                MOQUnit = DG.Rows[i].Cells["MOQUnit"].Value.ToString(),

        //                                B2_1M = DG.Rows[i].Cells["B2_1M"].Value.ToString(),
        //                                B2_2M = DG.Rows[i].Cells["B2_2M"].Value.ToString(),
        //                                B2_3M = DG.Rows[i].Cells["B2_3M"].Value.ToString(),

        //                                B3_1M = DG.Rows[i].Cells["B3_1M"].Value.ToString(),
        //                                B3_2M = DG.Rows[i].Cells["B3_2M"].Value.ToString(),
        //                                B3_3M = DG.Rows[i].Cells["B3_3M"].Value.ToString(),







        //                            };
        //                            pmlist.Add(pm);

        //                        }


        //                        return pmlist;

        //                }
        //                catch (Exception ex) { MessageBox.Show(ex.Message); }


        //            return null;
        //        }
        //        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        //        {
        //            try {


        //           //     List<POMODEL> list = getpolist();

        //              //  list.RemoveAt(SelectedRow);
        //                DG.Rows.RemoveAt(SelectedRow);
        //               // DG.DataSource = null;
        //              //  DG.DataSource = list;
        //                SelectedRow = -1;
        //                GridView_Settings(parent.BranchComboBox.Text);

        //            } catch(Exception ex)
        //            { MessageBox.Show(ex.Message); }
        //            }

        //        private void ShowColoumnsToolStripMenuItem_Click(object sender, EventArgs e)
        //        {
        //            if (!(SelectedColumnsList.Contains(DG.SelectedCells[SelectedColum].OwningColumn.HeaderText)))
        //            {
        //                DG.Columns[SelectedColum].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //                SelectedColumnsList.Add(DG.SelectedCells[SelectedColum].OwningColumn.HeaderText);


        //                SelectedColum = -1;
        //            }
        //        }

        //        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        //        {
        //            DG.DataSource = null;
        //            var list=getpolist();
        //            DG.DataSource = list;
        //        }

        //        private void deselectColumnToolStripMenuItem_Click(object sender, EventArgs e)
        //        {    
        //            DG.Columns[SelectedColum].DefaultCellStyle.BackColor = Color.White;
        //            SelectedColumnsList.Remove(DG.SelectedCells[SelectedColum].OwningColumn.HeaderText);


        //            SelectedColum = -1;

        //        }
        //        double ROUNDUP(double number, int digits)
        //        {
        //            return Math.Ceiling(number * Math.Pow(10, digits)) / Math.Pow(10, digits);
        //        }

        //        private void calculateSuggestedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        //        {
        //            parent.StateMessageLabel.Text = "Please Wait. System is Calculating Suggested Order...";
        //            Task.Run(() =>
        //            CalculateSuggested());

        //        }
        //        private void CalculateSuggested()
        //        {
        //            try
        //            {
        //                if(SelectedColumnsList.Count==0)
        //                {
        //                    MessageBox.Show("Please Select One or More Columns", "Selected Column Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }

        //                for (int i = 0; i < DG.RowCount; i++)
        //                {
        //                    CalculateSuggestedRow(i);

        //                }
        //                parent.StateMessageLabel.Text = "Suggested Order Calculation Completed";

        //            }
        //            catch (Exception ex)
        //            { MessageBox.Show(ex.Message); }
        //        }
        //        private void CalculateSuggestedRow(int i)
        //        {
        //            parent.StateMessageLabel.Text = "Calcuated Suggested Order " + (DG.RowCount - 1) + "/" + i;

        //            if (SelectedColumnsList.Count == 0)
        //            {
        //                MessageBox.Show("Please Select One or More Columns", "Selected Column Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //            try
        //            {
        //                double result = getMaxNumberFromSelectedColumn(i);
        //                result = result / 31;
        //                result = result * double.Parse(DG.Rows[i].Cells["DOS"].Value.ToString());
        //                result = result - ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString());
        //                result = ROUNDUP(result, 0);
        //                result = result / double.Parse(DG.Rows[i].Cells["MOQ"].Value.ToString());
        //                result = ROUNDUP(result, 0);
        //                result = result * double.Parse(DG.Rows[i].Cells["MOQ"].Value.ToString());

        //                //if(result<0)
        //                //{
        //                //    DG.BeginInvoke(new MethodInvoker(()=>
        //                //    DG.Rows[i].Cells["Sugg"].Style.BackColor = Color.LightPink));
        //                //}
        //                //else {
        //                //    DG.BeginInvoke(new MethodInvoker(() =>
        //                //    DG.Rows[i].Cells["Sugg"].Style.BackColor = Color.White));
        //                //}
        //                DG.BeginInvoke(new MethodInvoker(() =>
        //                DG.Rows[i].Cells["Sugg"].Value = result));



        //            }
        //            catch (Exception ex)
        //            { MessageBox.Show(ex.Message);
        //            }
        //        }
        //        private double ifNullReturnZero(string value)
        //        {
        //            try {
        //                if (value == "")
        //                {
        //                    return 0;
        //                }
        //                else
        //                {
        //                    return double.Parse(value);
        //                }
        //            } catch{ return 0; }

        //        }

        //        private double getMaxNumberFromSelectedColumn(int row)
        //        {
        //            try
        //            {
        //                if (SelectedColumnsList.Count == 0)
        //                {
        //                    return 0;
        //                }
        //                double maxnumber = ifNullReturnZero(DG.Rows[row].Cells[SelectedColumnsList[0]].Value.ToString());

        //                for (int i = 0; i < SelectedColumnsList.Count; i++)
        //                {
        //                    if (ifNullReturnZero(DG.Rows[row].Cells[SelectedColumnsList[i]].Value.ToString()) > maxnumber)
        //                    {
        //                        maxnumber = double.Parse(DG.Rows[row].Cells[SelectedColumnsList[i]].Value.ToString());
        //                    }

        //                }
        //                return maxnumber;
        //            }
        //            catch (Exception ex)
        //            {
        //          //      MessageBox.Show(ex.Message);
        //                return 0;
        //            }
        //        }
        //        public void SelectBranch1_Column()
        //        {
        //            SelectedColumnsList.Clear();
        //                DG.Columns["B1_1M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //                SelectedColumnsList.Add("B1_1M");
        //            DG.Columns["B1_2M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B1_2M");
        //            DG.Columns["B1_3M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B1_3M");

        //            CalculateSuggested();


        //        }
        //        public void SelectBranch2_Column()
        //        {
        //            SelectedColumnsList.Clear();

        //            DG.Columns["B2_1M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B2_1M");
        //            DG.Columns["B2_2M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B2_2M");
        //            DG.Columns["B2_3M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B2_3M");

        //            CalculateSuggested();


        //        }
        //        public void SelectBranch3_Column()
        //        {

        //            SelectedColumnsList.Clear();

        //            DG.Columns["B3_1M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B3_1M");
        //            DG.Columns["B3_2M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B3_2M");
        //            DG.Columns["B3_3M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("B3_3M");

        //            CalculateSuggested();

        //        }
        //        public void SelectBranchGRC_JDC_Column()
        //        {
        //            SelectedColumnsList.Clear();

        //            DG.Columns["Total_1M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("Total_1M");
        //            DG.Columns["Total_2M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("Total_2M");
        //            DG.Columns["Total_3M"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        //            SelectedColumnsList.Add("Total_3M");

        //            CalculateSuggested();


        //        }
        //        private void dOSViewToolStripMenuItem_Click(object sender, EventArgs e)
        //        {

        //         //   var DosList = getpolist();
        //         //   MonthlyList = DosList;
        //            dOSViewToolStripMenuItem.Enabled = false;
        //            monthtlyViewToolStripMenuItem.Enabled = true;
        //            DisableEditing();

        //            CalculatingDos();





        //        }
        //        private void CalculatingDos()
        //        {
        //            for (int i = 0; i < DG.RowCount; i++)
        //            {
        //                try
        //                {
        //                    //parent.DisplayStateMessage(this, "Preparing DOS VIEW. " + (DG.RowCount - 1) + "/" + i);
        //                    //DG.Rows[i].Cells["B1_1M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B1_1M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["B1_2M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B1_2M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["B1_3M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B1_3M"].Value.ToString()) / 31))).ToString();

        //                    //DG.Rows[i].Cells["B2_1M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B2_1M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["B2_2M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B2_2M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["B2_3M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B2_3M"].Value.ToString()) / 31))).ToString();

        //                    //DG.Rows[i].Cells["B3_1M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B3_1M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["B3_2M_D"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B3_2M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["B3_3M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString())) / (ifNullReturnZero(DG.Rows[i].Cells["B3_3M"].Value.ToString()) / 31))).ToString();


        //                    //DG.Rows[i].Cells["Total_1M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["Total_1M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["Total_2M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["Total_2M"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["Total_3M_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["Total_3M"].Value.ToString()) / 31))).ToString();


        //                    //DG.Rows[i].Cells["RamazanLY_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["RamazanLY"].Value.ToString()) / 31))).ToString();
        //                    //DG.Rows[i].Cells["ShabanLY_D"].Value = (Math.Round((ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["ShabanLY"].Value.ToString()) / 31))).ToString();


        //                }
        //                catch(Exception ex) { MessageBox.Show(ex.Message); }

        //            }
        //            parent.DisplayStateMessage(this, "You are in DOS-Mode, You Can't Edit Record");
        //            GridView_Disable_Editing();
        //        }

        //        private void GridView_Disable_Editing()
        //        {
        //            removeItemToolStripMenuItem.Enabled = false;
        //            DisableEditing();

        //        }

        //        private void DisableEditing()
        //        {
        //            removeItemToolStripMenuItem.Enabled = false;

        //        }
        //        private void EnableEditing()
        //        {
        //            removeItemToolStripMenuItem.Enabled = true;





        //        }

        //        private void monthtlyViewToolStripMenuItem_Click(object sender, EventArgs e)
        //        {

        //             GridView_Settings(parent.BranchComboBox.Text);
        //            dOSViewToolStripMenuItem.Enabled = true;
        //            monthtlyViewToolStripMenuItem.Enabled = false;

        //            Task.Run(() =>
        //            CalculatingMonthlyView());



        //        }
        //        public void MakingColumnEdiable()
        //            {
        //            for(int i=0;i<DG.ColumnCount;i++)
        //            {
        //                if(DG.Columns[i].HeaderText!="DOS" || DG.Columns[i].HeaderText != "FinalPC")
        //                {
        //                    DG.Columns[i].ReadOnly = true;
        //                }else
        //                {
        //                    DG.Columns[i].ReadOnly = false;
        //                }

        //             }

        //        }
        //        public void MakingColumnUnEditable()
        //        {
        //            for (int i = 0; i < DG.ColumnCount; i++)
        //            {

        //                    DG.Columns[i].ReadOnly = true;


        //            }

        //        }
        //        private void CalculatingMonthlyView()
        //        { 
        //            for (int i = 0; i < DG.RowCount; i++)
        //            {
        //                parent.DisplayStateMessage(this, "Preparing Monthly View.. " + (DG.RowCount - 0) + "/" + i);

        //                try
        //                {

        //                    DG.Rows[i].Cells["B1_1M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B1_1M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["B1_2M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B1_2M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["B1_3M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B1_3M"].Value.ToString()) / 31))).ToString();

        //                    DG.Rows[i].Cells["B2_1M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B2_1M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["B2_2M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B2_2M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["B2_3M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B2_3M"].Value.ToString()) / 31))).ToString();

        //                    DG.Rows[i].Cells["B3_1M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B3_1M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["B3_2M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B3_2M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["B3_3M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["B3_3M"].Value.ToString()) / 31))).ToString();


        //                    DG.Rows[i].Cells["Total_1M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["Total_1M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["Total_2M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["Total_2M"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["Total_3M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["Total_3M"].Value.ToString()) / 31))).ToString();


        //                    DG.Rows[i].Cells["RamazanLY"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["RamazanLY"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["ShabanLY"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventor"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["ShabanLY"].Value.ToString()) / 31))).ToString();
        //                    DG.Rows[i].Cells["Total_3M"].Value = (Math.Round(ifNullReturnZero(DG.Rows[i].Cells["Inventory"].Value.ToString()) + ifNullReturnZero(DG.Rows[i].Cells["FinalPC"].Value.ToString()) / (ifNullReturnZero(DG.Rows[i].Cells["Total_3M"].Value.ToString()) / 31))).ToString();

        //                }
        //                catch { }

        //            }

        //            parent.DisplayStateMessage(this, "You Are in Monthly View Mode");

        //        }

        //        private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //        {

        //        }
    }
}
