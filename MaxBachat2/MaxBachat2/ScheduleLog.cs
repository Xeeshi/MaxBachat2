using MaxBachat21.Model;
using NavigationDrawer_2010;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
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
    public partial class ScheduleLog : Syncfusion.Windows.Forms.Office2007Form
    {
        public ScheduleLog()
        {
            InitializeComponent();
        }
        Connection con= new Connection();
        List<ScheduleLogView> myList = new List<ScheduleLogView>();

        private void ScheduleLog_Load(object sender, EventArgs e)
        {
            DisplayRecords();

        }

        private string ifNullReturnPending(string value)
        {
            try
            {
                if (value == "")
                {
                    return "Pending";
                }
                else
                {
                    return (value).ToString();
                }
            }
            catch { return ""; }

        }
        private string ifNullReturnZero(string value)
        {
            try
            {
                if (value == "")
                {
                    return "0";
                }
                else
                {
                    return double.Parse(value).ToString();
                }
            }
            catch { return ""; }

        }

        private void GridSetting()
        {
            GridConditionalFormatDescriptor format1 = new GridConditionalFormatDescriptor();

            format1.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            format1.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.LightGreen);

            format1.Expression = "[Status]='Sent' OR [Status]='SENT' ";


            DG2.TableDescriptor.ConditionalFormats.Add(format1);


            DG2.ThemesEnabled = false;
            DG2.Appearance.ColumnHeaderCell.Themed = false;
            DG2.Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.LightSkyBlue, Color.White);
            DG2.Appearance.ColumnHeaderCell.TextColor = Color.Black;
            DG2.TableDescriptor.VisibleColumns.Remove("VendorID");

            DG2.TableDescriptor.Appearance.AnyCell.TextColor = Color.Black;
            DG2.TableDescriptor.Appearance.AnyRecordFieldCell.Font = new Syncfusion.Windows.Forms.Grid.GridFontInfo(new Font("Arial", 10f, FontStyle.Regular));
            DG2.TableDescriptor.Columns["Vendor"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Left;
            DG2.TableDescriptor.Columns["Vendor"].Appearance.AnyRecordFieldCell.WrapText = true;
            DG2.TableDescriptor.Columns["Vendor"].Width = 250;
            DG2.TableDescriptor.Columns["Email"].Width = 150;

            DG2.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            DG2.TopLevelGroupOptions.ShowCaption = false;
            DG2.AllowProportionalColumnSizing = false;
           


            GridMetroColors colors = new GridMetroColors();
            colors.PushButtonColor.NormalBackColor = Color.FromArgb(22, 165, 220);
            colors.PushButtonColor.HoverBackColor = Color.FromArgb(26, 198, 255);
            colors.PushButtonColor.PushedBackColor = Color.FromArgb(120, 191, 217);
            this.DG2.SetMetroStyle(colors);

            DG2.TableDescriptor.AllowNew = false;
            DG2.Refresh();
            DG2.Invalidate();
            DG2.TableControl.RefreshRange(GridRangeInfo.Table());



        }

        private void DisplayRecords()
        {
            try
            {
                myList.Clear();
                if (con.con.State == ConnectionState.Open)
                { con.con.Close(); }
                con.con.Open();
                string qot = "'";
                System.Data.SqlClient.SqlDataReader sdr;
                string script = File.ReadAllText("SQL//ScheduleOrderLog.sql");
                script = script.Replace("@dow", qot + dateTimePicker1.Text + qot);

                script = script.Replace("\r\n", " ");
                script = script.Replace("\t", " ");
                script = script.Replace("@date", qot + dateTimePicker1.Text + qot);
                SqlCommand cmd = new SqlCommand(script, con.con);


                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    ScheduleLogView slv = new ScheduleLogView()
                    {
                        VendorID = sdr["VendorID"].ToString(),
                        Email = sdr["Email"].ToString(),
                        OrderValue = ifNullReturnZero(sdr["OrderValue"].ToString()),
                        PONumber = sdr["PONumber"].ToString(),
                        Status = ifNullReturnPending(sdr["Status"].ToString()),
                        Vendor = sdr["Vendor"].ToString(),
                        Schedule_Date_Time = sdr["Schedule Date/Time"].ToString(),
                       


                    };
                    myList.Add(slv);

                }

                con.con.Close();
                DG2.DataSource = ConvertToDatatable.ToDataTable(myList);
                GridSetting();  
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }
    }
}
