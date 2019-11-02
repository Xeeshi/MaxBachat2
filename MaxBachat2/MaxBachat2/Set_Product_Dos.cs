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
    public partial class Set_Product_Dos : Form
    {
        Connection con = new Connection();
        List<Set_DOS_Model> myList = new List<Set_DOS_Model>();
        string vid = "";
        public bool IsDosSet { get; set; }
        public Set_Product_Dos(string _vid)
        {
            InitializeComponent();
            vid = _vid;
        }
        private void LoadData(string vid)
        {
            
                try
                {
                    if (con.con.State == ConnectionState.Open)
                    { con.con.Close(); }
                    con.con.Open();
                    string qot = "'";
                    System.Data.SqlClient.SqlDataReader sdr;
                    string script = File.ReadAllText("SQL/SetDosViewModel.sql");


                    script = script.Replace("\r\n", " ");
                    script = script.Replace("\t", " ");
                script = script.Replace("@VendorId",qot+vid+qot);
                SqlCommand cmd = new SqlCommand(script, con.con);


                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {

                    Set_DOS_Model slv = new Set_DOS_Model()
                        {
                            VendorID = sdr["ProductVendorId"].ToString(),
                            ProductID = sdr["ProductItemId"].ToString(),
                            Product_Name=sdr["LongName"].ToString(),
                            DOS1_5= sdr["DOS1_5"].ToString(),
                            DOS6_10= sdr["DOS6_10"].ToString(),
                            DOS11_15 = sdr["DOS11_15"].ToString(),
                            DOS16_20 = sdr["DOS16_20"].ToString(),
                            DOS21_25 = sdr["DOS21_25"].ToString(),
                            DOS26_31 = sdr["DOS26_31"].ToString(),



                    };
                        myList.Add(slv);

                    }

                    con.con.Close();

                    DG2.DataSource = ConvertToDatatable.ToDataTable(myList);


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void GridSetting()
        {
            GridConditionalFormatDescriptor format1 = new GridConditionalFormatDescriptor();

            format1.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            format1.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.LightPink);

            format1.Expression =           "[DOS1_5]=''   OR [DOS1_5]='0'" +
                                        "OR [DOS1_5]=''   OR [DOS1_5]='0'" +
                                        "OR [DOS6_10]=''  OR [DOS6_10]='0'" +
                                        "OR [DOS11_15]='' OR [DOS11_15]='0'" +
                                        "OR [DOS16_20]='' OR [DOS16_20]='0'" +
                                        "OR [DOS21_25]='' OR [DOS21_25]='0'" +
                                        "OR [DOS26_31]='' OR [DOS26_31]='0'";
           DG2.TableDescriptor.ConditionalFormats.Add(format1);


            DG2.ThemesEnabled = false;
            DG2.Appearance.ColumnHeaderCell.Themed = false;
            DG2.Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.LightSkyBlue, Color.White);
            DG2.Appearance.ColumnHeaderCell.TextColor = Color.Black;
            DG2.TableDescriptor.VisibleColumns.Remove("VendorID");

            DG2.TableDescriptor.Appearance.AnyCell.TextColor = Color.Black;
            DG2.TableDescriptor.Appearance.AnyRecordFieldCell.Font = new Syncfusion.Windows.Forms.Grid.GridFontInfo(new Font("Arial", 10f, FontStyle.Regular));
            DG2.TableDescriptor.Columns["Product_Name"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Left;
            DG2.TableDescriptor.Columns["Product_Name"].Appearance.AnyRecordFieldCell.WrapText = true;
            DG2.TableDescriptor.Columns["Product_Name"].Width = 365;

            DG2.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            DG2.TopLevelGroupOptions.ShowCaption = false;
            DG2.AllowProportionalColumnSizing = false;
            DG2.TableDescriptor.Columns["DOS1_5"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.ComboBox;
            DG2.TableDescriptor.Columns["DOS6_10"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.OriginalTextBox;
            DG2.TableDescriptor.Columns["DOS11_15"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.FormulaCell;
            DG2.TableDescriptor.Columns["DOS16_20"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.TextBox;

            DG2.TableDescriptor.Columns["DOS1_5"].Appearance.AnyCell.ReadOnly = false;
            DG2.TableDescriptor.Columns["DOS6_10"].Appearance.AnyCell.ReadOnly = false;
            DG2.TableDescriptor.Columns["DOS11_15"].Appearance.AnyCell.ReadOnly = false;
            DG2.TableDescriptor.Columns["DOS16_20"].Appearance.AnyCell.ReadOnly = false;
            DG2.TableDescriptor.Columns["DOS21_25"].Appearance.AnyCell.ReadOnly = false;
            DG2.TableDescriptor.Columns["DOS26_31"].Appearance.AnyCell.ReadOnly = false;


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
        double OUTaGE = 0;
        public  bool HasValue( string value)
        {
            if(value=="")
            {
                return false;
            }
            if (Double.TryParse(value, out OUTaGE))
            {
                return false;
            }
            return true; ;
        }

        private bool validateAll_DOS()
        {
            try
            {
                var list = DG2.Table.Records;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].GetValue("DOS1_5").ToString() == "" || list[i].GetValue("DOS1_5").ToString() == "0" || HasValue(list[i].GetValue("DOS1_5").ToString()))
                    {
                        MessageBox.Show("Something Wrong with DOS1_5, Row: "+(i+1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (list[i].GetValue("DOS6_10").ToString() == "" || list[i].GetValue("DOS6_10").ToString() == "0" || HasValue(list[i].GetValue("DOS6_10").ToString()))
                    {
                        MessageBox.Show("Something Wrong with DOS6_10, Row: " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                    if (list[i].GetValue("DOS11_15").ToString() == "" || list[i].GetValue("DOS11_15").ToString() == "0" || HasValue(list[i].GetValue("DOS11_15").ToString()))
                    {
                        MessageBox.Show("Something Wrong with DOS11_15, Row: " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                    if (list[i].GetValue("DOS16_20").ToString() == "" || list[i].GetValue("DOS16_20").ToString() == "0" || HasValue(list[i].GetValue("DOS16_20").ToString()))
                    {
                        MessageBox.Show("Something Wrong with DOS16_20, Row: " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                    if (list[i].GetValue("DOS21_25").ToString() == "" || list[i].GetValue("DOS21_25").ToString() == "0" || HasValue(list[i].GetValue("DOS21_25").ToString()))
                    {
                        MessageBox.Show("Something Wrong with DOS21_25, Row: " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                    if (list[i].GetValue("DOS26_31").ToString() == "" || list[i].GetValue("DOS26_31").ToString() == "0" || HasValue(list[i].GetValue("DOS26_31").ToString()))
                    {
                        MessageBox.Show("Something Wrong with DOS26_31, Row: " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                   
                }
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
                return true;
            }
            return true; 
        }
        private void Set_Product_Dos_Load(object sender, EventArgs e)
        {
            IsDosSet = false;
            LoadData(vid);
            GridSetting();
        }

        private void MetroButton2_Click(object sender, EventArgs e)

        {
            if(validateAll_DOS())
            {
           var RawScript=  File.ReadAllText("SQL/InsertOrUpdateDos_.sql");
                RawScript = RawScript.Replace("\r\n", " ");
                RawScript = RawScript.Replace("\t", " ");
                var qot = "'";
               // RawScript = RawScript.Replace("@pid", qot+vid+qot);
                var list = DG2.Table.Records;

                RawScript = RawScript.Replace("@VendorId", qot + vid + qot);

                for (int i=0;i<list.Count;i++)
                {
                    try
                    {
                        var childScrip = RawScript;
                        childScrip = childScrip.Replace("@pid",qot+ list[i].GetValue("ProductID").ToString()+qot);
                        childScrip = childScrip.Replace("@dos15", qot + list[i].GetValue("DOS1_5").ToString() + qot);
                        childScrip = childScrip.Replace("@dos610", qot + list[i].GetValue("DOS6_10").ToString() + qot);
                        childScrip = childScrip.Replace("@dos1115", qot + list[i].GetValue("DOS11_15").ToString() + qot);
                        childScrip = childScrip.Replace("@dos1620", qot + list[i].GetValue("DOS16_20").ToString() + qot);
                        childScrip = childScrip.Replace("@dos2125", qot + list[i].GetValue("DOS21_25").ToString() + qot);
                        childScrip = childScrip.Replace("@dos2631", qot + list[i].GetValue("DOS26_31").ToString() + qot);



                        con.UpdateProductRecord(childScrip);



                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                IsDosSet = true;
                MessageBox.Show("Save Result", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            myList.Clear();
            LoadData(vid);
            GridSetting();
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var list = DG2.Table.Records;
                for(int i=1;i<list.Count;i++)
                {
                    DG2.Table.Records[i].SetValue("DOS1_5", list[0].GetValue("DOS1_5"));
                    DG2.Table.Records[i].SetValue("DOS6_10", list[0].GetValue("DOS6_10"));
                    DG2.Table.Records[i].SetValue("DOS11_15", list[0].GetValue("DOS11_15"));
                    DG2.Table.Records[i].SetValue("DOS16_20", list[0].GetValue("DOS16_20"));
                    DG2.Table.Records[i].SetValue("DOS21_25", list[0].GetValue("DOS21_25"));
                    DG2.Table.Records[i].SetValue("DOS26_31", list[0].GetValue("DOS26_31"));
               

                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
