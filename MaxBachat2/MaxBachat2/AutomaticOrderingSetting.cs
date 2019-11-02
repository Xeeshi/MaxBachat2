using MaxBachat21.Model;
using NavigationDrawer_2010;
using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat21
{
    public partial class AutomaticOrderingSetting : Syncfusion.Windows.Forms.Office2010Form
    {
        User user = null;
        public AutomaticOrderingSetting(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        private ArrayList Get_DOM_ArrayList()
        {
            ArrayList al = new ArrayList() {"5","10","15" };
            return al;
        }
        private ArrayList Get_Method_ArrayList()
        {
            ArrayList al = new ArrayList() {"DOS","TARGET" };
            return al;
        }
        private void GridSetting()
        {
            DG2.ThemesEnabled = false;
            DG2.Appearance.ColumnHeaderCell.Themed = false;
            DG2.Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.Red, Color.White);
            DG2.Appearance.ColumnHeaderCell.TextColor = Color.Black;
            DG2.TableDescriptor.VisibleColumns.Remove("VendorID");

            DG2.TableDescriptor.Appearance.AnyCell.BackColor = Color.White ;

            DG2.TableDescriptor.Columns["Email"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Left;
            DG2.TableDescriptor.Columns["Email"].Appearance.AnyRecordFieldCell.WrapText = true;
            DG2.TableDescriptor.Columns["Email"].Width = 180;

            DG2.TableDescriptor.Columns["Phone"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Left;
            DG2.TableDescriptor.Columns["Phone"].Appearance.AnyRecordFieldCell.WrapText = true;
            DG2.TableDescriptor.Columns["Phone"].Width = 95;

            DG2.TableDescriptor.Columns["MON"].Width = 40;
            DG2.TableDescriptor.Columns["TUE"].Width = 35;
            DG2.TableDescriptor.Columns["WED"].Width = 35;
            DG2.TableDescriptor.Columns["THU"].Width = 35;
            DG2.TableDescriptor.Columns["FRI"].Width = 35;
            DG2.TableDescriptor.Columns["SAT"].Width = 35;
            DG2.TableDescriptor.Columns["SUN"].Width = 35;
            DG2.TableDescriptor.Columns["Auto_Ordering"].Width = 35;
            DG2.TableDescriptor.Columns["Set_Dos"].Width = 60;
            this.DG2.TableDescriptor.Columns["Auto_Ordering"].HeaderText="Auto";
            DG2.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            DG2.TopLevelGroupOptions.ShowCaption = false;
            DG2.AllowProportionalColumnSizing = false;

            DG2.TableDescriptor.Columns["Vendor"].Width = 220;
            DG2.TableDescriptor.Columns["Vendor"].Appearance.AnyRecordFieldCell.AllowEnter = false;
            DG2.TableDescriptor.Columns["Vendor"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Left;


            //  DG.TableDescriptor.Columns["OrderTime"].Appearance.AnyRecordFieldCell.Format = "dd/MM/yyyy";
            // DG.Refresh();
       //     DG2.TableDescriptor.Columns["OrderTime"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            DG2.TableDescriptor.Columns["OrderTime"].Appearance.AnyRecordFieldCell.CellValueType = typeof(DateTime);
            DG2.TableDescriptor.Columns["OrderTime"].Appearance.AnyRecordFieldCell.Format = "HH:ss";
            DG2.TableDescriptor.Columns["OrderTime"].Width = 70;

            DG2.TableDescriptor.Columns["DayOfMonth"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.ComboBox;
            DG2.TableDescriptor.Columns["DayOfMonth"].Appearance.AnyRecordFieldCell.DataSource = Get_DOM_ArrayList();
       //     DG2.TableDescriptor.Columns["DayOfMonth"].Appearance.AnyRecordFieldCell.ReadOnly = false;

            DG2.TableDescriptor.Columns["Method"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.ComboBox;
            DG2.TableDescriptor.Columns["Method"].Appearance.AnyRecordFieldCell.DataSource = Get_Method_ArrayList();
            //     DG2.TableDescriptor.Columns["Method"].Appearance.AnyRecordFieldCell.ReadOnly = false;

            DG2.TableDescriptor.Appearance.AnyRecordFieldCell.Font = new Syncfusion.Windows.Forms.Grid.GridFontInfo(new Font("Arial", 10f, FontStyle.Regular));
            DG2.TableDescriptor.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            DG2.TableDescriptor.Columns["Auto_Ordering"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.CheckBox;
            DG2.TableDescriptor.Columns["Auto_Ordering"].Appearance.AnyCell.BackColor = Color.Yellow;

            DG2.TableDescriptor.Columns["Set_Dos"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.PushButton;
            DG2.TableDescriptor.Columns["Set_Dos"].Appearance.AnyRecordFieldCell.Description = "Set Dos";
            DG2.TableDescriptor.Columns["Set_Dos"].Appearance.AnyRecordFieldCell.BackColor = Color.Yellow ;

         //   DG2.TableDescriptor.Columns["Review"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.PushButton;
              DG2.TableDescriptor.Columns["Remove"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.PushButton;
              DG2.TableDescriptor.Columns["Remove"].Appearance.AnyRecordFieldCell.Description = "Remove ";
              DG2.TableDescriptor.Columns["Remove"].Appearance.AnyHeaderCell.Text = "Remove Vendor";

            //DG2.TableDescriptor.Columns["MON"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["TUE"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["WED"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["THU"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["FRI"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["SAT"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["SUN"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["Phone"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["Email"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            //DG2.TableDescriptor.Columns["Auto_Ordering"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            GridMetroColors colors = new GridMetroColors();
            colors.PushButtonColor.NormalBackColor = Color.FromArgb(22, 165, 220);
            colors.PushButtonColor.HoverBackColor = Color.FromArgb(26, 198, 255);
            colors.PushButtonColor.PushedBackColor = Color.FromArgb(120, 191, 217);
            this.DG2.SetMetroStyle(colors);

            DG2.TableDescriptor.AllowNew = false;
            DG2.Refresh();
            DG2.Invalidate();
            DG2.TableControl.RefreshRange(GridRangeInfo.Table());

            //  DG.TableDescriptor.VisibleColumns.Remove("VendorID");
            //InformationGrid.Columns["VendorID"].Visible = false;
            //InformationGrid.Columns["Vendor"].Width = 150;
            //InformationGrid.Columns["Email"].Width = 200;
            //InformationGrid.Columns["Mon"].Width = 35;
            //InformationGrid.Columns["Tue"].Width = 35;
            //InformationGrid.Columns["Wed"].Width = 35;
            //InformationGrid.Columns["Thu"].Width = 35;
            //InformationGrid.Columns["Fri"].Width = 35;
            //InformationGrid.Columns["Sat"].Width = 35;
            //InformationGrid.Columns["Sun"].Width = 35;
            //InformationGrid.Columns["setDos"].DefaultCellStyle.ForeColor = Color.Blue;
            //InformationGrid.Columns["Update_Record"].DefaultCellStyle.ForeColor = Color.Black;
            //InformationGrid.Columns["Update_Record"].DefaultCellStyle.BackColor = Color.Yellow;
            //InformationGrid.Columns["Update_Record"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; ;
            //InformationGrid.Columns["Update_Record"].ReadOnly = true;

        }
        private bool ifNullReturnFalse(object v)
        {
            if (v.ToString() == "" || v.ToString().ToLower()=="false")
            {

                return false;
            }
            else
            { return true; }
        }
        private string ifNullReturnZero(object v)
        {
            if (v.ToString() == "")
            {

                return "0";
            }
            else
            { return v.ToString(); }
        }
        List<AutomaticOrderingModel> myList = new List<AutomaticOrderingModel>();
        Connection con = new Connection();
        private void DisplayRecords()
        {
            try
            {
                if (con.con.State == ConnectionState.Open)
                { con.con.Close(); }
                con.con.Open();
                string qot = "'";
                System.Data.SqlClient.SqlDataReader sdr;
                string script = File.ReadAllText("SQL/AutomaticOrderSetting.sql");


                script = script.Replace("\r\n", " ");
                script = script.Replace("\t", " ");
                SqlCommand cmd = new SqlCommand(script, con.con);


                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                    AutomaticOrderingModel slv = new AutomaticOrderingModel()
                    {
                        VendorID = sdr["VendorID"].ToString(),
                        Email = ifNullReturnZero(sdr["OrderEmails"]),
                        Phone = ifNullReturnZero(sdr["OrderPhoneNo"]),
                        Vendor = sdr["Name"].ToString(),
                        MON = ifNullReturnFalse(sdr["MON"]),
                        TUE = ifNullReturnFalse(sdr["TUE"]),
                        WED = ifNullReturnFalse(sdr["WED"]),
                        THU = ifNullReturnFalse(sdr["THU"]),
                        FRI = ifNullReturnFalse(sdr["FRI"]),
                        SAT = ifNullReturnFalse(sdr["SAT"]),
                        SUN = ifNullReturnFalse(sdr["SUN"]),
                        DayOfMonth = int.Parse(ifNullReturnZero(sdr["DayOfMonth"])),
                        OrderTime = DateTime.Parse(sdr["OrderTime"].ToString()),
                        Method = ifNullReturnZero(sdr["OrderMethod"].ToString()),
                        Set_Dos = "Click Here",
                        Auto_Ordering = ifNullReturnFalse(sdr["AutoOrdering"]),
                    };
                    myList.Add(slv);

                }

                con.con.Close();
                
                DG2.DataSource =ConvertToDatatable.ToDataTable(myList);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void AutomaticOrderingSetting_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            GridSetting();
        }

       
        private void InformationGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try {
            //    if (e.ColumnIndex == (InformationGrid.Columns.Count - 1))
            //    { MessageBox.Show("dos"); }
            //    else if (e.ColumnIndex == InformationGrid.Columns["Update_Record"].Index)
            //    {
            //        DialogResult dt = MessageBox.Show("Do You Want to Update Record of " + InformationGrid.Rows[e.RowIndex].Cells["Vendor"].Value.ToString(), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //       if (dt == DialogResult.Yes)
            //        {
            //            AutomaticOrderingModel m = new AutomaticOrderingModel()
            //            {
            //                VendorID = InformationGrid.Rows[e.RowIndex].Cells["VendorID"].Value.ToString(),
            //                Vendor = InformationGrid.Rows[e.RowIndex].Cells["Vendor"].Value.ToString(),
            //                MON = ifNullReturnFalse(InformationGrid.Rows[e.RowIndex].Cells["Mon"].Value),
            //                TUE = ifNullReturnFalse(InformationGrid.Rows[e.RowIndex].Cells["Tue"].Value),
            //                WED = ifNullReturnFalse(InformationGrid.Rows[e.RowIndex].Cells["Wed"].Value),
            //                THU = ifNullReturnFalse(InformationGrid.Rows[e.RowIndex].Cells["Thu"].Value),
            //                FRI = ifNullReturnFalse(InformationGrid.Rows[e.RowIndex].Cells["Fri"].Value),
            //                SAT = ifNullReturnFalse(InformationGrid.Rows[e.RowIndex].Cells["Sat"].Value),
            //                SUN = ifNullReturnFalse(InformationGrid.Rows[e.RowIndex].Cells["Sun"].Value),


            //                Email = InformationGrid.Rows[e.RowIndex].Cells["Email"].Value.ToString(),

            //                Method = InformationGrid.Rows[e.RowIndex].Cells["Method"].Value.ToString(),

            //                DayOfMonth = InformationGrid.Rows[e.RowIndex].Cells["DayOfMonth"].Value.ToString(),
            //                OrderTime = InformationGrid.Rows[e.RowIndex].Cells["OrderTime"].Value.ToString()





            //            };

                        //if (m.VendorID != "" && m.VendorID != "0")
                        //{
                        //    string ordermethod = (m.Method.ToLower() == "dos" ? "DOS" : "TARGET");
                        //    if (con.UpdateProductRecord("UPDATE [mbo].[PSVendorSchedule] SET " +
                        //        " [Mon]=" + (m.MON == true ? "1" : "0") + "," +
                        //        " [Tue]=" + (m.TUE == true ? "1" : "0") + "," +
                        //        " [Wed]=" + (m.WED == true ? "1" : "0") + "," +
                        //        " [Thu]=" + (m.THU == true ? "1" : "0") + "," +
                        //        " [Fri]=" + (m.FRI == true ? "1" : "0") + "," +
                        //        " [Sat]=" + (m.SAT == true ? "1" : "0") + "," +
                        //        " [Sun]=" + (m.SUN == true ? "1" : "0") + "," +
                        //        " [DayofMonth]='" + m.DayOfMonth + "',"+
                        //        " [OrderTime]='" + m.OrderTime + "'," +
                        //        " [OrderMethod]='" + ordermethod + "'" +
                        //        " Where [VendorID]='" + m.VendorID + "'")
                        //        )
                        //    {
                        //        if (con.UpdateProductRecord("MERGE [mbo].[PSVendorOrderContacts]  WITH (SERIALIZABLE) AS pvsl " +
                        //          " USING (VALUES ('" + m.VendorID + "','" + m.Email + "')) AS U ([VendorId],[OrderEmails])" +
                        //          " ON U.[VendorId] = pvsl.[VendorId]" +
                        //          " WHEN MATCHED THEN" +
                        //          " UPDATE SET pvsl.[OrderEmails] = U.[OrderEmails]" +
                        //          " WHEN NOT MATCHED THEN" +
                        //          " INSERT ([VendorId],[OrderEmails])" +
                        //          " VALUES (U.[VendorId],U.[OrderEmails]);"))
                        //        {
                        //            MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        }
                        //    }

                        //}
            //        }
            //    }
            //}catch(Exception x) { MessageBox.Show(x.Message); }
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            AddNewScheduleVendor auos = new AddNewScheduleVendor(user);
            auos.Show();
        }
        private void Refresh()
        {
            myList.Clear();
            DisplayRecords();
        }
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Refresh();    
        }

        private void DG2_TableControlCellButtonClicked(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellButtonClickedEventArgs e)
        {
            int field = e.TableControl.TableDescriptor.ColIndexToField(e.Inner.ColIndex);
            MessageBox.Show(e.TableControl.TableDescriptor.Columns[field].HeaderText);
        }

        private void DG2_TableControlPushButtonClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellPushButtonClickEventArgs e)
        {
            try
            {

                int row = e.Inner.RowIndex - 2;

                int col = e.Inner.ColIndex + 1;
                int field = e.TableControl.TableDescriptor.ColIndexToField(col);
                var vid = DG2.Table.Records[row].GetValue("VendorID").ToString();
                if ((e.TableControl.TableDescriptor.Columns[field].HeaderText.ToLower()) == "set_dos")
                {
                    Set_Product_Dos spd = new Set_Product_Dos(vid);
                    spd.ShowDialog();
                }
                if ((e.TableControl.TableDescriptor.Columns[field].HeaderText.ToLower()) == "remove")
                {
                    DialogResult dt = MessageBox.Show("Do You Really Want to Delete", "Confirmation ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dt==DialogResult.Yes)
                    {
                        con.UpdateProductRecord("DELETE FROM [mbo].[PSVendorSchedule] WHERE [VendorID]='" + vid + "'");
                        myList.Clear();
                        DisplayRecords();
                        GridSetting();
                    }
                }
                if ((e.TableControl.TableDescriptor.Columns[field].HeaderText.ToLower()) == "auto_ordering")
                {
                    //GridTableCellStyleInfo style = this.DG2.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
                    //GridTableCellStyleInfoIdentity id = style.CellIdentity as GridTableCellStyleInfoIdentity;
                    ////To get the current record   
                    //Record record = id.DisplayElement.GetRecord();
                    //if (record != null)
                    //{
                    //    string cellValue = record.GetValue("Auto_Ordering").ToString();



                    //}  
               

                
                }
            } catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var list = DG2.Table.Records;
                for(int i=0;i<list.Count;i++)
                {
                 
                    string script = "UPDATE [mbo].[PSVendorSchedule] SET " +
                        "[MON]=" +(bool.Parse(list[i].GetValue("MON").ToString())==true?1:0) +
                        ", [TUE]=" + (bool.Parse(list[i].GetValue("TUE").ToString()) == true ? 1 : 0) +
                        ", [WED]=" + (bool.Parse(list[i].GetValue("WED").ToString()) == true ? 1 : 0) +
                        ", [THU]=" + (bool.Parse(list[i].GetValue("THU").ToString()) == true ? 1 : 0) +
                        ", [FRI]=" + (bool.Parse(list[i].GetValue("FRI").ToString()) == true ? 1 : 0) +
                        ", [SAT]=" + (bool.Parse(list[i].GetValue("SAT").ToString()) == true ? 1 : 0) +
                        ", [SUN]=" + (bool.Parse(list[i].GetValue("SUN").ToString()) == true ? 1 : 0) +
                        ", [AutoOrdering]=" + (bool.Parse(list[i].GetValue("Auto_Ordering").ToString()) == true ? 1 : 0) +
                        ", [OrderMethod]='"+list[i].GetValue("Method").ToString()+"'"+
                        ", [OrderTime]='" + list[i].GetValue("OrderTime").ToString() + "'" +
                         ", [DayofMonth]='" + list[i].GetValue("DayOfMonth").ToString() + "' Where [VendorID]='"+ list[i].GetValue("VendorID").ToString() + "'";

                    if(!con.UpdateProductRecord(script))
                    { MessageBox.Show("Error While Inserting Data Into DB"); }



                }
                for (int i = 0; i < list.Count; i++)
                {

                    string script = "UPDATE [mbo].PSVendorOrderContacts SET OrderEmails='"+ list[i].GetValue("Email").ToString() + "',[OrderPhoneNo]='"+ list[i].GetValue("Phone").ToString() + "'  WHERE [VendorId]='" + list[i].GetValue("VendorID").ToString() + "'"; 

                    if (!con.UpdateProductRecord(script))
                    { MessageBox.Show("Error While Inserting Data Into DB"); }



                }
                MessageBox.Show("Record Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            ScheduleLog lg = new ScheduleLog();
            lg.ShowDialog();
        }

        private void DG2_TableControlCurrentCellControlDoubleClick(object sender, GridTableControlControlEventArgs e)
        {
       
        }

        private void DG2_TableControlCellDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
         
    try
            {
                int row = e.Inner.RowIndex-2;

                AutomaticOrderingModel aom = new AutomaticOrderingModel()
                {
                    Vendor = DG2.Table.Records[row].GetValue("Vendor").ToString(),
                    VendorID = DG2.Table.Records[row].GetValue("VendorID").ToString(),
                    Auto_Ordering= bool.Parse(DG2.Table.Records[row].GetValue("Auto_Ordering").ToString()),
                    Method = DG2.Table.Records[row].GetValue("Method").ToString(),
                    Phone = DG2.Table.Records[row].GetValue("Phone").ToString(),
                    MON= bool.Parse(DG2.Table.Records[row].GetValue("MON").ToString()),
                    TUE = bool.Parse(DG2.Table.Records[row].GetValue("TUE").ToString()),
                    WED = bool.Parse(DG2.Table.Records[row].GetValue("WED").ToString()),
                    THU = bool.Parse(DG2.Table.Records[row].GetValue("THU").ToString()),
                    FRI= bool.Parse(DG2.Table.Records[row].GetValue("FRI").ToString()),
                    SAT = bool.Parse(DG2.Table.Records[row].GetValue("SAT").ToString()),
                    SUN = bool.Parse(DG2.Table.Records[row].GetValue("SUN").ToString()),

                    Email= DG2.Table.Records[row].GetValue("Email").ToString(),
                    OrderTime=DateTime.Parse(DG2.Table.Records[row].GetValue("OrderTime").ToString()),
                    DayOfMonth =int.Parse(DG2.Table.Records[row].GetValue("DayOfMonth").ToString()),

                };

                using (Edit_Schedule_Info esi=new Edit_Schedule_Info(user, aom))
                {
                    esi.ShowDialog();
                    Refresh();
                }

            } catch{ }
            }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
