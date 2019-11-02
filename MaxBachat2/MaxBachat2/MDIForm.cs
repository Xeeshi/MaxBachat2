using iTextSharp.text;
using iTextSharp.text.pdf;
using MaxBachat2.Model;
using MaxBachat2.Services;
using MaxBachat21;
using MaxBachat21.Model;
using MaxBachat21.Services;
using NavigationDrawer_2010;
using ParcelNO_Analyzer;
using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using Font = iTextSharp.text.Font;

namespace MaxBachat2
{

    public partial class MainForm : Syncfusion.Windows.Forms.WorkbookForm
    {
        List<POMODEL> pomodellist = new List<POMODEL>();
        List<SearchModel> csvList = new List<SearchModel>();
        List<CartModel> cartList = new List<CartModel>();

        List<CategoryTree> CatgoryTreeList = new List<CategoryTree>();
        private static Double POID = 1;


        private int ItemJoPrintHoChuki = 0;
        User user = null;
        Connection con = new Connection();
        public MainForm(User _user)
        {

            InitializeComponent();
            VendorComboBox.SelectedIndexChanged += getEmailOfVendor;
            user = _user;

        }

 
        private void getEmailOfVendor(object sender, EventArgs e)
        {
            var id = VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);
            string email = con.StringValueFromDb("select [OrderEmails] from [mbo].[PSVendorOrderContacts] where VendorID='" + id[1] + "'");
            VendorTextBox.Text = email;
            
                    try
                    {
                        getActiveChildForm().TabPag.Text = id[0];
                    }
                    catch { }
                
            
        }
      
        private void MDIForm_Load(object sender, EventArgs e)
        {

          
            LoadDateTime();
            SetCompaniesAndVendorsIntoComboBox();
           timer1.Start();
        }
        private void SetCompaniesAndVendorsIntoComboBox()
        {

            try
            {
                if (con.con.State == ConnectionState.Closed)
                { con.con.Open(); }

                System.Data.SqlClient.SqlDataReader sdr;


                SqlCommand cmd = new SqlCommand("Select  pv.Name,pv.ProductVendorId From ProductVendor pv JOIN COA c on pv.COAId = c.COAID WHERE IsActiveCOA = 1", con.con);

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if (!sdr.IsDBNull(0) && !sdr.IsDBNull(1))
                    {

                        if (!VendorComboBox.Items.Contains(sdr.GetString(0).ToString()))
                        {
                            VendorComboBox.Items.Add(sdr.GetString(0).ToString() + "-----" + sdr.GetInt32(1));


                        }
                    }


                }
                con.con.Close();



            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }
      
        private void CreatePdf()
        {
            try
            {
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var FullBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                var MB_Head = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 30);


                //string locationToCreateFolder = AppDomain.CurrentDomain.BaseDirectory;
                //string folderName = "";
                //string date = DateTime.Now.ToString("ddd MM.dd.yyyy");
                //string time = DateTime.Now.ToString("HH.mm tt");
                //string format = "{0}";
                //folderName = string.Format(format, date);
                //Directory.CreateDirectory(locationToCreateFolder + folderName);


                string oldFile = "mb2.pdf";
                string newFile = "Order.pdf";

                // open the reader
                PdfReader reader = new PdfReader(oldFile);
                iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
                Document document = new Document(size);

                // open the writer
                FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // the pdf content
                PdfContentByte cb = writer.DirectContent;

                // select the font properties
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.SetColorFill(BaseColor.BLACK);
                cb.SetFontAndSize(bf, 8);
                // write the text in the pdf content
                cb.BeginText();

                int VPos = 440;
                var list = getActiveChildForm().DG.Table.Records;
                for (int i = 0; i < list.Count; i++)
                {
                    // put the alignment and coordinates here
                    cb.ShowTextAligned(0, list[i].GetValue("Barcode").ToString(), 40, VPos, 0);
                    cb.ShowTextAligned(0, list[i].GetValue("AltBarcode").ToString(), 120, VPos, 0);
                    cb.ShowTextAligned(0, list[i].GetValue("ItemDescription").ToString(), 290, VPos, 0);
                    cb.ShowTextAligned(0, list[i].GetValue("FinalPC").ToString(), 580, VPos, 0);
                    cb.ShowTextAligned(0, list[i].GetValue("OrderCTN").ToString(), 620, VPos, 0);
                    cb.ShowTextAligned(0, list[i].GetValue("Cost").ToString(), 670, VPos, 0);
                    cb.ShowTextAligned(0, list[i].GetValue("Total").ToString(), 720, VPos, 0);
                    cb.ShowTextAligned(0, "__________________________________________________________________________________________________________________________________________________________________", 38, (VPos - 5), 0);
                    VPos -= 30;
                }
                cb.EndText();

                cb.SetColorFill(BaseColor.BLACK);
                cb.SetFontAndSize(bf, 9);
                cb.BeginText();

                cb.ShowTextAligned(0, VendorComboBox.Text, 43, 542, 1);
                try
                {
                    var xx = VendorTextBox.Text.Split(new[] { ";" }, StringSplitOptions.None);
                    cb.ShowTextAligned(0, xx[0], 43, 530, 1);
                }
                catch { }
                cb.ShowTextAligned(0, BranchComboBox.Text, 204, 542, 1);  //branch
                cb.ShowTextAligned(0, RemarksTextbox2.Text, 452, 542, 1);  //remarks
                cb.ShowTextAligned(0, DateTime.Now.ToString("dd-MMM-yy (ddd)"), 692, 555, 1); //
                cb.SetColorFill(BaseColor.RED);
                cb.SetFontAndSize(bf, 9);
                cb.ShowTextAligned(0, DeliveryDateComboBox.Text, 692, 529, 1);
                cb.ShowTextAligned(0, ExpiryComboBox.Text, 692, 503, 1);
                cb.EndText();






                cb.ShowTextAligned(1, VendorComboBox.Text, 105, 542, 1);
                try
                {
                    var xx = VendorTextBox.Text.Split(new[] { ";" }, StringSplitOptions.None);
                    cb.ShowTextAligned(1, xx[0], 105, 530, 1);
                }
                catch { }


                // create the new page and add it to the pdf
                PdfImportedPage page = writer.GetImportedPage(reader, 1);
                cb.AddTemplate(page, 0, 0);

                // close the streams and voilá the file should be changed :)
                document.Close();
                fs.Close();
                writer.Close();
                reader.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private string Currency(string curr)
        {

            decimal parsed = decimal.Parse(curr, CultureInfo.InvariantCulture);
            CultureInfo hindi = new CultureInfo("en-us");
            string text = string.Format(hindi, "{0:#,#}", parsed);
            return text;
        }

        private System.Drawing.Image CreateBarcode(string data)
        {
            // iTextShirp
            //Bitmap barCode = new Bitmap(1, 1);
            Barcode128 code128 = new Barcode128(); // barcode type
            code128.Code = data;
            System.Drawing.Image barCode = code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White);
            //barCode.Save(Server.MapPath(“~/barcode.gif”), System.Drawing.Imaging.ImageFormat.Gif); //save file
            return barCode;
        }
       
        private string GetPIDFromDB()
        {

            try
            {
                Random r = new Random();
                string current = "";
                string yy = "", mm = "", dd = "";
                yy = DateTime.Now.ToString("yy");
                mm = DateTime.Now.ToString("MM");
                dd = DateTime.Now.ToString("dd");
                do
                {

                    current =r.Next(1,9999).ToString().PadLeft(4, '0');
                    current = yy + mm + dd + current;
                    if (con.ValidateInformationDatabase_More_Than_1("select count(*) from PurchaseOrder where [PurchaseOrderNumber]='" + current + "'") == false)
                    {



                        return current;

                    }
                    POID++;

                } while (con.ValidateInformationDatabase_More_Than_1("select count(*) from PurchaseOrder where [PurchaseOrderNumber]='" + current + "'") == true);
            }
            catch
            {


                return "null";
            }


            return null;



        }

        int childCount = 1;



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var name = tabControl1.SelectedTab.Text.ToString();
                if (name.ToLower() != "my plan")
                {

                    var childForm = getActiveChildForm();
                    //Activate the MDI child form
                    BranchComboBox.SelectedIndex = childForm.BranchCombobox;
                    VendorTextBox.Text = childForm.VendorTextBox;
                    VendorComboBox.SelectedIndex = childForm.VendorCombox;
                    ExpiryComboBox.SelectedIndex = childForm.ExpiryCombobox;
                    DeliveryDateComboBox.SelectedIndex = childForm.DeliveryDateCombobox;
                    PriorityComboBox.SelectedIndex = childForm.PriorityCombobox;
                    RemarksTextbox2.Text = childForm.Remarks;
                    NotifyStateLabel.Text = childForm.StateMsg;
                    if (childForm.Status != true)
                    {
                        PDFgeneratePanel.Enabled = true;
                    }
                    else
                    {
                        PDFgeneratePanel.Enabled = false;
                    }
                    childForm.Select();

                }else
                {
                    get_MyPlan_ActiveChildForm().Select();
                }

            }
            catch { }
        }

        private void tabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (tabControl1.TabCount == 1)
            { tabControl1.ShowTabCloseButton = false; }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = CsvImport.NewDataTable(of.FileName, ",");

                    // 

                       var childForm = getActiveChildForm();

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                CartModel m = new CartModel()
                                {
                                    Item_Name = dt.Rows[i][0].ToString(),
                                    Quanity = int.Parse(dt.Rows[i][1].ToString()),
                                    Price = dt.Rows[i][2].ToString(),
                                    imgPath = "esajee Images 170x170//" + dt.Rows[i][4].ToString(),
                                    Barcode = dt.Rows[i][4].ToString(),

                                    Brand = dt.Rows[i][5].ToString()


                                };
                                cartList.Add(m);
                            }

                            //test.DG.DataSource = null;
                            //test.DG.DataSource = cartList;
                            //test.DG.Columns[0].Width = 100;
                            //test.DG.Columns[1].Width = 330;
                            //test.DG.RowTemplate.Height = 50;

                            //Activate the MDI child form
                            //   test.dataGridView1.DataSource = dt;
                        
                    



                }
            };
        }
      

        private void LoadDateTime()
        {
            for (int i = 0; i <= 30; i++)
            {
                if (!DeliveryDateComboBox.Items.Contains(DateTime.Now.AddDays(i).ToString("dd-MMM-yyyy")))
                {
                    DeliveryDateComboBox.Items.Add(DateTime.Now.AddDays(i).ToString("dd-MMM-yyyy"));
                    ExpiryComboBox.Items.Add(DateTime.Now.AddDays(i).ToString("dd-MMM-yyyy"));
                }
            }
            ExpiryComboBox.SelectedIndex = 2;
            DeliveryDateComboBox.SelectedIndex = 1;
            BranchComboBox.SelectedIndex = 0;
            PriorityComboBox.SelectedIndex = 0;
        }


        private void tabControl1_SelectedIndexChanging(object sender, SelectedIndexChangingEventArgs args)
        {
            try
            {

                try
                {
                    var childForm = getActiveChildForm();
                    childForm.BranchCombobox = BranchComboBox.SelectedIndex;
                    childForm.VendorTextBox = VendorTextBox.Text;
                    childForm.VendorCombox = VendorComboBox.SelectedIndex;
                    childForm.ExpiryCombobox = ExpiryComboBox.SelectedIndex;
                    childForm.DeliveryDateCombobox = DeliveryDateComboBox.SelectedIndex;
                    childForm.PriorityCombobox = PriorityComboBox.SelectedIndex;
                    childForm.Remarks = RemarksTextbox2.Text;
                    childForm.StateMsg = NotifyStateLabel.Text;

                }
                catch
                {

                }
                    

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            GetPIDFromDB();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CreatePdf();
        }


        private string LoadInformationFromDb(string productid)
        {
            try
            {
                if (con.con.State == ConnectionState.Open)
                { con.con.Close(); }

                System.Data.SqlClient.SqlDataReader sdr;

                con.con.Open();
                SqlCommand cmd = new SqlCommand("select Barcode,LongName,CostPrice from ProductItem where ProductItemId='" + productid + "'", con.con);

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if (!sdr.IsDBNull(0))
                    {
                        return sdr.GetString(0).ToString() + "***" + sdr.GetString(1).ToString() + "***" + sdr.GetSqlMoney(2);

                    }
                }
                con.con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "0";
            }

            return "0";

        }
   
       

        public void DisplayStateMessage(ChildForm test, string msg)
        {
            NotifyStateLabel.Text = msg;
            test.StateMsg =msg;
        }
        public void DisplaySelectedColumn(ChildForm test, string msg)
        {
           SelectedColumnLabel.Text = msg;
            test.StateMsg = msg;
        }
        public void GridSettin(ChildForm childform)
        {
       

            childform.DG.TableDescriptor.VisibleColumns.Remove("Barcode");
            childform.DG.TableDescriptor.VisibleColumns.Remove("ProductItemID");
            childform.DG.TableDescriptor.VisibleColumns.Remove("AltBarcode");
            childform.DG.TableDescriptor.VisibleColumns.Remove("Max");
            childform.DG.TableDescriptor.VisibleColumns.Remove("Min");
            childform.DG.TableDescriptor.VisibleColumns.Remove("ROP");
           childform.DG.TableControl.CurrentCell.ShowErrorIcon = true;
            //childform.DG.TableDescriptor.VisibleColumns.Remove("B3_1M");
            //childform.DG.TableDescriptor.VisibleColumns.Remove("B3_2M");
            //childform.DG.TableDescriptor.VisibleColumns.Remove("B3_3M");


            //childform.DG.TableDescriptor.VisibleColumns.Remove("B3_1M_D");
            //childform.DG.TableDescriptor.VisibleColumns.Remove("B3_2M_D");
            //childform.DG.TableDescriptor.VisibleColumns.Remove("B3_3M_D");

            childform.DG.TableDescriptor.Columns["ItemDescription"].Appearance.AnyRecordFieldCell.AllowEnter = false;
            childform.DG.TableDescriptor.Columns["ItemDescription"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Left;
            //  childform.DG.TableModel.RowHeights.ResizeToFit(GridRangeInfo.Cells(10, 10, 1, 1));
            childform.DG.TableDescriptor.Columns["ItemDescription"].Width = 300;

            childform.DG.ThemesEnabled = false;
            childform.DG.Appearance.ColumnHeaderCell.Themed = false;
            childform.DG.Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(214, 220, 232), Color.FromArgb(106, 111, 151));
            childform.DG.Appearance.ColumnHeaderCell.TextColor = Color.Black;

            childform.DG.TableDescriptor.Columns["DOS"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            childform.DG.TableDescriptor.Columns["FinalPC"].Appearance.AnyRecordFieldCell.ReadOnly = false;
            childform.DG.TableDescriptor.Columns["DOS"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.NumericUpDown;
            childform.DG.TableDescriptor.Columns["FinalPC"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.NumericUpDown;

            childform.DG.TableDescriptor.Columns["DOS"].Appearance.AnyRecordFieldCell.BackColor = Color.LightBlue;
            childform.DG.TableDescriptor.Columns["FinalPC"].Appearance.AnyRecordFieldCell.BackColor = Color.LightCyan;


            //childform.DG.TableDescriptor.Columns["B1_1M_D"].Appearance.AnyRecordFieldCell.Format= "#.#";
            //childform.DG.TableDescriptor.Columns["B1_2M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            //childform.DG.TableDescriptor.Columns["B1_3M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";

            //childform.DG.TableDescriptor.Columns["B2_1M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            //childform.DG.TableDescriptor.Columns["B2_2M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            //childform.DG.TableDescriptor.Columns["B2_3M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";

            //childform.DG.TableDescriptor.Columns["B3_1M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            //childform.DG.TableDescriptor.Columns["B3_2M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            //childform.DG.TableDescriptor.Columns["B3_3M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";

            childform.DG.TableDescriptor.Columns["Total_1M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            childform.DG.TableDescriptor.Columns["Total_2M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            //childform.DG.TableDescriptor.Columns["Total_3M_D"].Appearance.AnyRecordFieldCell.Format = "#.#";

            //childform.DG.TableDescriptor.Columns["ShabanLY_D"].Appearance.AnyRecordFieldCell.Format = "#.#";
            //childform.DG.TableDescriptor.Columns["RamazanLY_D"].Appearance.AnyRecordFieldCell.Format = "#.#";



            //  ExpressionFieldDescriptor exp = new ExpressionFieldDescriptor("Expr1", "[ColumnName] *2", "System.Int32");
            GridConditionalFormatDescriptor format1 = new GridConditionalFormatDescriptor();
            GridConditionalFormatDescriptor format2 = new GridConditionalFormatDescriptor();
            GridConditionalFormatDescriptor format3 = new GridConditionalFormatDescriptor();
            GridConditionalFormatDescriptor format4 = new GridConditionalFormatDescriptor();
            GridConditionalFormatDescriptor format5 = new GridConditionalFormatDescriptor();

            format3.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            format3.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.OrangeRed);
            format3.Expression = "[FinalPC] < 0 ";

            format4.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            format4.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.LightGreen);
            format4.Expression = "[Sugg] >= 0 AND [FinalPC] = 0 ";

            format5.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            format5.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.White);
            format5.Expression = "[FinalPC] > 0 ";


            //     format1.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.LightGreen);
            format1.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            format1.Expression = "[OrderCTN] like '*.*' ";
            format1.Name = "ConditionalFormat 1";
            format1.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.LightPink);

            format2.Appearance.AnyRecordFieldCell.Interior = new BrushInfo(Color.LightGray);
            format2.Appearance.AnyRecordFieldCell.TextColor = Color.Black;
            format2.Expression = "[FinalPC] > -1 AND [FinalPC] <1  and [Sugg] <= 0  ";

            childform.DG.TableDescriptor.ConditionalFormats.Add(format1);
            childform.DG.TableDescriptor.ConditionalFormats.Add(format2);
            childform.DG.TableDescriptor.ConditionalFormats.Add(format3);
            childform.DG.TableDescriptor.ConditionalFormats.Add(format4);
            childform.DG.TableDescriptor.ConditionalFormats.Add(format5);

            ExpressionFieldDescriptor order = new ExpressionFieldDescriptor("OrderCTN", "([FinalPC])/([MOQ])", "System.Double");
            ExpressionFieldDescriptor total = new ExpressionFieldDescriptor("Total", "([FinalPC]*[Cost])", "System.Int32");

            //ExpressionFieldDescriptor b11m = new ExpressionFieldDescriptor("B1_1M_D", "(([Inventory]+[FinalPC]))/(([B1_1M]/31))", "System.Double");
            //ExpressionFieldDescriptor b12m = new ExpressionFieldDescriptor("B1_2M_D", "([Inventory]+[FinalPC])/([B1_2M]/31)", "System.Double");
            //ExpressionFieldDescriptor b13m = new ExpressionFieldDescriptor("B1_3M_D", "([Inventory]+[FinalPC])/([B1_3M]/31)", "System.Double");

            //ExpressionFieldDescriptor b21m = new ExpressionFieldDescriptor("B2_1M_D", "([Inventory]+[FinalPC])/([B2_1M]/31)", "System.Double");
            //ExpressionFieldDescriptor b22m = new ExpressionFieldDescriptor("B2_2M_D", "([Inventory]+[FinalPC])/([B2_2M]/31)", "System.Double");
            //ExpressionFieldDescriptor b23m = new ExpressionFieldDescriptor("B2_3M_D", "([Inventory]+[FinalPC])/([B2_3M]/31)", "System.Double");

            //ExpressionFieldDescriptor b31m = new ExpressionFieldDescriptor("B3_1M_D", "([Inventory]+[FinalPC])/([B3_1M]/31)", "System.Double");
            //ExpressionFieldDescriptor b32m = new ExpressionFieldDescriptor("B3_2M_D", "([Inventory]+[FinalPC])/([B3_2M]/31)", "System.Double");
            //ExpressionFieldDescriptor b33m = new ExpressionFieldDescriptor("B3_3M_D", "([Inventory]+[FinalPC])/([B3_3M]/31)", "System.Double");

            ExpressionFieldDescriptor t1m = new ExpressionFieldDescriptor("Total_1M_D", "([Inventory]+[FinalPC])/([Total_1M]/31)", "System.Double");
            ExpressionFieldDescriptor t2m = new ExpressionFieldDescriptor("Total_2M_D", "([Inventory]+[FinalPC])/([Total_2M]/31)", "System.Double");
            //ExpressionFieldDescriptor t3m = new ExpressionFieldDescriptor("Total_3M_D", "([Inventory]+[FinalPC])/([Total_3M]/31)", "System.Double");
            //ExpressionFieldDescriptor sbn = new ExpressionFieldDescriptor("ShabanLY_D", "([Inventory]+[FinalPC])/([ShabanLY]/31)", "System.Double");
            //ExpressionFieldDescriptor rmz = new ExpressionFieldDescriptor("RamazanLY_D", "([Inventory]+[FinalPC])/([RamazanLY]/31)", "System.Double");


            childform.DG.TableDescriptor.ExpressionFields.AddRange(new Syncfusion.Grouping.ExpressionFieldDescriptor[] { order, t1m, t2m,total });
            childform.DG.TableDescriptor.AllowNew = false;
            childform.DG.Refresh();
            childform.DG.Invalidate();
            childform.DG.TableControl.RefreshRange(GridRangeInfo.Table());

        }
        private void LoadCSV(string filename,string branchname,string script,string branchid)
        {
            pomodellist.Clear();
            try
            {

                DataTable dt = CsvImport.NewDataTable(filename, ",");
                string itemid = "";
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    itemid =itemid + "'"+dt.Rows[i][0].ToString()+"',";
                }
                itemid = itemid.Substring(0,itemid.Length - 1);

                subFunction_settingGrid_Branch_etc(script, itemid, dt, branchid,null);


        }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }

        
        }
        public void subFunction_settingGrid_Branch_etc(string script,string itemid,DataTable dt,string branchid,List<POMODEL> currentlist)
        {
            try
            {
                var ProductItemIDList = getVendorProductItem_csv_lookup(itemid, dt, script, branchid);
                currentlist.AddRange(ProductItemIDList);
                var childform = getActiveChildForm();
                childform.DG.DataSource = ConvertToDatatable.ToDataTable(currentlist);
               
                GridSettin(childform);

                childform.MonthlyView();
                if (BranchComboBox.Text == "BR1")
                {
                    childform.Select_Branch1_Column();
                }
                else if (BranchComboBox.Text == "BR2")
                { childform.Select_Branch2_Column(); }
                else if (BranchComboBox.Text == "BR3")
                { childform.Select_Branch3_Column(); }
                else
                { childform.Select_BranchJDC_GRC_Column(); }

                DisplayStateMessage(getActiveChildForm(), "Sucessfully Loaded Data");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void toolStripPanelItem16_Click(object sender, EventArgs e)
        {
            CreatePdf();
            //     SendEmailSendGrid.Send()
        }
      

        public void CreateNewOrder()
        {
            if (validateFields())
            {
                ChildForm childForm = new ChildForm(this,user);
                var xx = VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);
                childForm.Text = xx[0];
                childForm.MdiParent = this;

                //child Form will now hold a reference value to the tab control
                childForm.TabCtrl = tabControl1;

                //Add a Tabpage and enables it
                TabPageAdv tp = new TabPageAdv();
                tp.Parent = tabControl1;
                tp.Text = childForm.Text;



                tp.Show();

                //child Form will now hold a reference value to a tabpage
                childForm.TabPag = tp;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                //Activate the MDI child form
                childForm.Show();
                childCount++;
                if (tabControl1.TabCount > 1)
                { tabControl1.ShowTabCloseButton = true; }
                //Activate the newly created Tabpage
                tabControl1.SelectedTab = tp;

                DeliveryDateComboBox.SelectedIndex = 1;
                ExpiryComboBox.SelectedIndex = 2;

            }
        }

        private void toolStripPanelItem32_Click(object sender, EventArgs e)
        {
            CreateNewOrder();
            
        }

        private bool validateFields()
        {
            if (VendorComboBox.Text == "")
            {
                VendorComboBox.BackColor = Color.LightPink;
                VendorComboBox.Focus();
                MessageBox.Show("Please Select Vendor From Given List", "Vendor Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (BranchComboBox.Text == "")
            {
                BranchComboBox.BackColor = Color.LightPink;
                BranchComboBox.Focus();
                MessageBox.Show("Please Select Branch From Given List", "Vendor Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (PriorityComboBox.Text == "")
            {
                PriorityComboBox.BackColor = Color.LightPink;
                PriorityComboBox.Focus();
                MessageBox.Show("Please Select Priority From Given List", "Priority Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;


            }

            if (BranchComboBox.Text == "")
            {
                BranchComboBox.BackColor = Color.LightPink;
                BranchComboBox.Focus();
                MessageBox.Show("Please Select Branch From Given List", "Branch Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (DeliveryDateComboBox.Text == "")
            {
                DeliveryDateComboBox.BackColor = Color.LightPink;
                DeliveryDateComboBox.Focus();
                MessageBox.Show("Please Select Delivery Date From Given List", "Delivery Date Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (ExpiryComboBox.Text == "")
            {
                ExpiryComboBox.BackColor = Color.LightPink;
                ExpiryComboBox.Focus();
                MessageBox.Show("Please Select Expiry Date From Given List", "Expiry Date Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public void DisplayTotal(string total)
        {
            try
            {
                TotalAmountLabel.Text = "Total (Rs): " + Currency(total.ToString()); 
            }
            catch{  }
            }

        private void toolStripEx6_MouseEnter(object sender, EventArgs e)
        {
            RemarksTextbox2.ToolTipText = RemarksTextbox2.Text;

        }

        private void toolStripPanelItem24_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.ShowDialog();

        }
        public string getBranchID()
        {
            string branchid = "";

            ////if (BranchComboBox.Text == "BR1")
            ////{ branchid = "3"; }
            ////else if (BranchComboBox.Text == "BR2")
            ////{ branchid = "5"; }
            ////else if (BranchComboBox.Text == "BR3")
            ////{ branchid = "8"; }
            //if (BranchComboBox.Text == "JDC")
            //{ branchid = "1"; }
            //else if (BranchComboBox.Text == "GRC")
            //{ branchid = "2"; }
            return "1";

        }
        private string getPriority()
        {

            if (PriorityComboBox.Text.ToLower() != "urgent")
            {
                return "1";
            }
            return "";
        }
        //private void toolStripPanelItem27_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        var list = getpoList().Where(x=>x.FinalPC!="0").ToList();
                
        //        string branchid = getBranchID();
        //        string priority = getPriority();
        //        String getPOID = GetPIDFromDB();
                
        //        if (list.Count != 0)
        //        {
        //            DialogResult dt = MessageBox.Show("This Order Will be Marked as Final!", "Do You Agree?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //            if (dt == DialogResult.OK)
        //            {
        //                var vendorid = VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);

        //                //var PurchaseOrderID = con.InsertValuesIntoDataBase("INSERT INTO [dbo].[PurchaseOrder] ([ProductVendorId],[PurchaseOrderDate],[PaymentModeId],[CurrencyId],[VendorQuotationNumber],[NetAmount],[Remark],[PurchaseOrderNumber],[DeliveryDate],[DeliveryType],[BranchDeliveryLocationId],[ShipmentModeId],[ShipmentProvideById],[CompanyBranchId],[UserId],[DataEntryDate],[DataEntryStatus],[DataEntryPost],[InvoiceToClient],[Priority],[IsCalculateInvoiceDiscount]) values ('" + vendorid[1] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm") + "','1','1',NULL,'" + list.Sum(s => s.Total).ToString() + "','" + RemarksTextBox.Text + "','" + getPOID + "','" + DeliveryDateComboBox.Text + "',NULL,'" + branchid + "','1','1','1','1','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm") + "','1',NULL,NULL,'" + priority + "','1');SELECT SCOPE_IDENTITY();");
        //                //if (PurchaseOrderID != -1)
        //                //{
        //                //    foreach (var item in list)
        //                //    {
        //                //        con.InsertInformation("INSERT INTO [dbo].[PurchaseOrderItem]([PurchaseOrderId],[ProductItemId],[Quantity],[Price],[DiscountRate],[SystemStock],[ItemStatus]) values ('" + PurchaseOrderID + "','" + item.ProductItemID + "','" + item.FinalPC + "','" + item.Cost + "','0','0','0')");
        //                //    }

        //                { 
        //                    CompletepdfGenerate(getPOID);



        //                          var childForm = getActiveChildForm();

                          
        //                            childForm.Status = true;
        //                            childForm.OrderID = getPOID;
                                    
        //                            DisplayStateMessage(childForm, "Order has been Completed. Order ID: " + getPOID);
        //                            PDFgeneratePanel.Enabled = false;
        //                            childForm.DG.Columns["FinalPC"].ReadOnly = true;
        //                            childForm.DG.Columns["DOS"].ReadOnly = true;


        //                }
        //            }
        //            else
        //            { MessageBox.Show("There is not Item Selected", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //        }
        //    }
        //    catch (Exception ex)
        //    { MessageBox.Show(ex.Message, "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //
     
        private bool isEmailReady()
        {
                  var childForm = getActiveChildForm();        
                    if (childForm.Status == true)
                    { return true; }

                    else
                    { return false; }
                
          ;
        }
        private void toolStripPanelItem28_Click(object sender, EventArgs e)
        {
            if (VendorTextBox.Text != "")
            {
                if (isEmailReady())
                {
                    string Orderid = "";

                    var childForm = getActiveChildForm();
                                Orderid = childForm.OrderID;


                           //     var emaillist = VendorTextBox.Text.Split(new[] { ";" }, StringSplitOptions.None);

                               
                                    string path = AppDomain.CurrentDomain.BaseDirectory + "Purchase Orders PDF//" + Orderid + ".pdf";
                                   string obj = "MaxBachat Order # "+Orderid+" -- "+BranchComboBox.Text+" -- Delivery: "+DeliveryDateComboBox.Text+" -- Expiry: "+ExpiryComboBox.Text+" -- Rs "+GetPOList(false).Sum(x=>x.Total);
                                  OutlookEmail.SendEmail(VendorTextBox.Text, obj, path, Orderid);
                                    //{
                                       
                                    //    DisplayStateMessage(childForm, "Successfully Email Sent to " + emaillist[i]);
                                    //}
                                    //else
                                    //{
                                    
                                    //    DisplayStateMessage(childForm, "Email Sending Failed " + emaillist[i]);

                                    //}
                                }
                            

                        

                    


                
                else
                {
                    MessageBox.Show("Order is Saved, Please Save Order First! ", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }else
            { MessageBox.Show("Email Address is Not Found ", "Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        { try
            { var activechild = getActiveChildForm();
                double total = 0;
                foreach (var record in activechild.DG.Table.Records)
                {

                 total+= double.Parse(record.GetValue("Total").ToString());

                }

                DisplaySelectedColumn(activechild, "Selected Column:# " + activechild.SelectedColumnsList.Count);
                 TotalAmountLabel.Text = "Total (Rs): " + Currency(total.ToString());
            }
            catch { }

      }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void ToolStripButton12_Click(object sender, EventArgs e)
        {
            if(getActiveChildForm()==null)
            {
                CreateNewOrder();
                return;
            }


            using (Search_Products t = new Search_Products(user))
            {
                try
                {
                    t.ShowDialog();
                    if (t.ShowDialog)
                    {
                        var list = t.ProductItemID_List;
                        String itemid = "";
                        for (int i = 0; i < list.Count; i++)
                        {
                            itemid = itemid + "'" + list[i] + "',";
                        }
                        itemid = itemid.Substring(0, itemid.Length - 1);
                        string query = File.ReadAllText("script2.sql");
                        var currentlist = GetPOList(true);
                        subFunction_settingGrid_Branch_etc(query, itemid, null, getBranchID(), currentlist);

                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            };

               
        }

        private void ToolStripButton13_Click(object sender, EventArgs e)
        {
          
            string filename = "";
              using (OpenFileDialog of = new OpenFileDialog())
              {
                of.Filter = "CSV Files (*.csv)|*.csv";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    if (getActiveChildForm() == null)
                    {
                        if (validateFields())
                        {
                            CreateNewOrder();
                        }else
                        { return; }
                    }
                    string branchname = BranchComboBox.Text;
                    string query = File.ReadAllText("script2.sql");
                    string branchid = getBranchID();
                    var vendor=VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);
                    filename = of.FileName;
                    
                    LoadCSV(filename,branchname,query,branchid);
                }
              }
        }

        private void toolStripPanelItem4_MouseHover(object sender, EventArgs e)
        {
            toolStripPanelItem14.ToolTipText = RemarksTextbox2.Text;
        }
      
        private void toolStripSplitButtonEx1_MouseEnter(object sender, EventArgs e)
        {
            RemarksButton.ToolTipText = RemarksTextbox2.Text;
        }
        private string GetQuantityOfPO(string ProductItemID, bool isQtyGiven, DataTable dt)
        {

            try
            {
                if(isQtyGiven==false)
                { return "0"; }
               
                for(int i=0;i<dt.Rows.Count;i++)
                {
                  
                    if(dt.Rows[i][0].ToString()==ProductItemID)
                    {
                        return dt.Rows[i][1].ToString();
                    }
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return "0";
        }
        private List<POMODEL> getVendorProductItemId_FROM_DB(string vendorid)
        {
            DisplayStateMessage(getActiveChildForm(), "Getting Data From Database");
            List<POMODEL> ProductItemIDList = new List<POMODEL>();
            try
            {
                if (con.con.State == ConnectionState.Open)
                { con.con.Close(); }
                con.con.Open();
                string qot = "'";
                System.Data.SqlClient.SqlDataReader sdr;
                string script = File.ReadAllText("script.sql");
                script = script.Replace("@BranchId", qot + getBranchID() + qot);
                script = script.Replace("@VendorId", qot + vendorid + qot);
                script = script.Replace("\r\n", " ");
                script = script.Replace("\t", " ");
                SqlCommand cmd = new SqlCommand(script, con.con);


                sdr = cmd.ExecuteReader();
                DisplayStateMessage(getActiveChildForm(), "Loading Data Into Grid");
                while (sdr.Read())
                {

                    string aBC = "";

                    if (sdr["AltBarcode"].ToString().Trim() != "")
                    {

                        aBC = sdr.GetString(3).ToString();
                        aBC = aBC.Substring(1);
                    }
                    string MOQ = sdr["MOQ"].ToString();
                    if (MOQ == "")
                    {
                        MOQ = "1";
                    }
                    string dos = "";
                    int today = DateTime.Now.Day;
                    if (today >= 1 && today <= 5)
                    {
                        dos = sdr["DOS1_5"].ToString();
                    }
                    else if (today >= 6 && today <= 10)
                    {
                        dos = sdr["DOS6_10"].ToString();
                    }
                    else if (today >= 11 && today <= 15)
                    {
                        dos = sdr["DOS11_15"].ToString();
                    }
                    else if (today >= 16 && today <= 20)
                    {
                        dos = sdr["DOS16_20"].ToString();
                    }
                    else if (today >= 21 && today <= 25)
                    {
                        dos = sdr["DOS21_25"].ToString();
                    }
                    else if (today >= 26 && today <= 31)
                    { dos = sdr["DOS26_31"].ToString(); }

                    if (dos == "")
                    {
                        dos = "7";
                    }


                    POMODEL vp = new POMODEL()
                    {
                        ProductItemID = sdr["ProductItemId"].ToString(),
                        ItemDescription = sdr["LongName"].ToString(),
                        Barcode = sdr["Barcode"].ToString(),
                        AltBarcode = aBC,
                        FinalPC = "0",
                        Cost = double.Parse(sdr["CostPrice"].ToString()),
                        Inventory =ifNullReturnZero(sdr["Inv"].ToString()),
                        DOS = dos,
                        MOQ = MOQ,
                        MOQUnit = sdr["MOQUnit"].ToString(),

                        Total = 0,

                        Max = sdr["Max"].ToString(),
                        Min = sdr["Min"].ToString(),
                        ROP = sdr["ROP"].ToString(),

                        //ShabanLY = ifNullReturnZero(sdr["ShabanLY"].ToString()),
                        //RamazanLY = ifNullReturnZero(sdr["RamazanLY"].ToString()),

                        Total_1M = ifNullReturnZero(sdr["Total_1M"].ToString()),
                        Total_2M = ifNullReturnZero(sdr["Total_2M"].ToString()),
                        //Total_3M = ifNullReturnZero(sdr["Total_3M"].ToString()),

                        //B1_1M = ifNullReturnZero(sdr["B1_1M"].ToString()),
                        //B1_2M = ifNullReturnZero(sdr["B1_2M"].ToString()),
                        //B1_3M = ifNullReturnZero(sdr["B1_3M"].ToString()),

                        //B2_1M = ifNullReturnZero(sdr["B2_1M"].ToString()),
                        //B2_2M = ifNullReturnZero(sdr["B2_2M"].ToString()),
                        //B2_3M = ifNullReturnZero(sdr["B2_3M"].ToString()),
                        Sugg = "",

                        //B3_1M = ifNullReturnZero(sdr["B3_1M"].ToString()),
                        //B3_2M = ifNullReturnZero(sdr["B3_2M"].ToString()),
                        //B3_3M = ifNullReturnZero(sdr["B3_3M"].ToString()),








                    };


                    ProductItemIDList.Add(vp);



                }




                con.con.Close();
                return ProductItemIDList;


            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            return null;

        }

        private List<POMODEL> getVendorProductItem_csv_lookup(string ProductItemID,DataTable  dt,string script,string branchid)
        {
            DisplayStateMessage(getActiveChildForm(), "Getting Data From Database");
            List<POMODEL> ProductItemIDList = new List<POMODEL>();
            try
            {
                if (con.con.State == ConnectionState.Open)
                { con.con.Close(); }
                con.con.Open();
                string qot = "'";
                System.Data.SqlClient.SqlDataReader sdr;
               // string script = File.ReadAllText("script2.txt");
                script = script.Replace("@branchid", qot + branchid + qot);
                script = script.Replace("@productitemid", ProductItemID );
                script = script.Replace("\r\n", " ");
                script = script.Replace("\t", " ");
                SqlCommand cmd = new SqlCommand(script, con.con);


                sdr = cmd.ExecuteReader();
                DisplayStateMessage(getActiveChildForm(), "Loading Data Into Grid");
                while (sdr.Read())
                {

                    string aBC = "";

                    if (sdr["AltBarcode"].ToString().Trim() != "")
                    {

                        aBC = sdr.GetString(3).ToString();
                        aBC = aBC.Substring(1);
                    }
                    string MOQ = sdr["MOQ"].ToString();
                    if (MOQ == "")
                    {
                        MOQ = "1";
                    }
                    string dos = "";
                    int today = DateTime.Now.Day;
                    if (today >= 1 && today <= 5)
                    {
                        dos = sdr["DOS1_5"].ToString();
                    }
                    else if (today >= 6 && today <= 10)
                    {
                        dos = sdr["DOS6_10"].ToString();
                    }
                    else if (today >= 11 && today <= 15)
                    {
                        dos = sdr["DOS11_15"].ToString();
                    }
                    else if (today >= 16 && today <= 20)
                    {
                        dos = sdr["DOS16_20"].ToString();
                    }
                    else if (today >= 21 && today <= 25)
                    {
                        dos = sdr["DOS21_25"].ToString();
                    }
                    else if (today >= 26 && today <= 31)
                    { dos = sdr["DOS26_31"].ToString(); }

                    if (dos == "")
                    {
                        dos = "8";
                    }
                    string qty = "";
                    if (dt == null)  // checking dt is null if null its means data is from item lookup
                    {
                        qty = "0";
                    }else
                    {
                        qty = GetQuantityOfPO(sdr["ProductItemId"].ToString(), true, dt);
                    }
                        POMODEL vp = new POMODEL()
                    {
                        ProductItemID = sdr["ProductItemId"].ToString(),
                        ItemDescription = sdr["LongName"].ToString(),
                        Barcode = sdr["Barcode"].ToString(),
                        AltBarcode = aBC,

                        FinalPC =qty,
                        OrderCTN=0,
                        Cost = double.Parse(sdr["CostPrice"].ToString()),
                        Inventory = ifNullReturnZero(sdr["Inv"].ToString()),

                        DOS = dos,
                        MOQ = MOQ,
                        MOQUnit = sdr["MOQUnit"].ToString(),

                        Total = Math.Round(double.Parse(sdr["CostPrice"].ToString())*double.Parse(qty),1),

                        Max = sdr["Max"].ToString(),
                        Min = sdr["Min"].ToString(),
                        ROP = sdr["ROP"].ToString(),

                        

                        //ShabanLY = ifNullReturnZero(sdr["ShabanLY"].ToString()),
                        //RamazanLY = ifNullReturnZero(sdr["RamazanLY"].ToString()),

                        //Total_1M = ifNullReturnZero(sdr["Total_1M"].ToString()),
                        //Total_2M = ifNullReturnZero(sdr["Total_2M"].ToString()),
                        //Total_3M = ifNullReturnZero(sdr["Total_3M"].ToString()),

                        //B1_1M = ifNullReturnZero(sdr["B1_1M"].ToString()),
                        //B1_2M = ifNullReturnZero(sdr["B1_2M"].ToString()),
                        //B1_3M = ifNullReturnZero(sdr["B1_3M"].ToString()),

                        //B2_1M = ifNullReturnZero(sdr["B2_1M"].ToString()),
                        //B2_2M = ifNullReturnZero(sdr["B2_2M"].ToString()),
                        //B2_3M = ifNullReturnZero(sdr["B2_3M"].ToString()),
                        Sugg = "",

                        //B3_1M = ifNullReturnZero(sdr["B3_1M"].ToString()),
                        //B3_2M = ifNullReturnZero(sdr["B3_2M"].ToString()),
                        //B3_3M = ifNullReturnZero(sdr["B3_3M"].ToString()),








                    };


                    ProductItemIDList.Add(vp);



                }




                con.con.Close();
                return ProductItemIDList;


            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            return null;



           
        }
        
        private ChildForm getActiveChildForm()
        {
           
            foreach (ChildForm childForm in this.MdiChildren.Where(s=>s.Name.ToLower()=="childform"))
            {

                if (childForm.TabPag.Equals(tabControl1.SelectedTab))
                {
                    return childForm;
                }
            }
            return null;
        }
        private MyPlan get_MyPlan_ActiveChildForm()
        {

            foreach (MyPlan childForm in this.MdiChildren.Where(s=>s.Name.ToLower()=="myplan"))
            {

                if (childForm.TabPag.Equals(tabControl1.SelectedTab))
                {
                    return childForm;
                }
            }
            return null;
        }
   
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
               
                string branchName = BranchComboBox.Text;

               
                if (getActiveChildForm() == null)
                {
                   
                    CreateNewOrder();
                   
                }
                var childform = getActiveChildForm();

                //Wait_Control();
                var vendorid = VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);
               
                var ProductItemIDList = getVendorProductItemId_FROM_DB(vendorid[1]).OrderBy(x=>x.ItemDescription).ToList();


                childform.DG.DataSource  = ConvertToDatatable.ToDataTable(ProductItemIDList);



                GridSettin(childform);
                childform.MonthlyView();
              if(BranchComboBox.Text=="BR1")
                {
                    childform.Select_Branch1_Column();
                }
                else if(BranchComboBox.Text == "BR2")
                { childform.Select_Branch2_Column(); }
                else if (BranchComboBox.Text == "BR3")
                { childform.Select_Branch3_Column(); }
                else 
                { childform.Select_BranchJDC_GRC_Column(); }


                //childform.GridView_Settings(BranchComboBox.Text);

                //if (BranchComboBox.Text == "BR1")
                //{  
                //    childform.SelectBranch1_Column();

                //} else if(BranchComboBox.Text == "BR2")
                //{
                //    childform.SelectBranch2_Column();
                //}
                //else if (BranchComboBox.Text == "BR3")
                //{
                //    childform.SelectBranch3_Column();
                //}

                //else if (BranchComboBox.Text == "JDC")
                //{
                //    childform.SelectBranchGRC_JDC_Column();
                //}
                //else if (BranchComboBox.Text == "GRC")
                //{
                //    childform.SelectBranchGRC_JDC_Column();
                //}


                //Release_Control();
                //childform.MakingColumnEdiable();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }


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
        private List<POMODEL> getPoList_Half(bool is_With_Zero)
        {
            List<POMODEL> pmlist = new List<POMODEL>();
            try
            {

                var list = getActiveChildForm().DG.Table.Records;
                if (!is_With_Zero)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (Double.Parse(list[i].GetValue("FinalPC").ToString()) != 0)
                        {

                            POMODEL pm = new POMODEL()
                            {
                                Barcode = list[i].GetValue("Barcode").ToString(),
                                AltBarcode = list[i].GetValue("AltBarcode").ToString(),
                                ItemDescription = list[i].GetValue("ItemDescription").ToString(),
                                FinalPC = list[i].GetValue("FinalPC").ToString(),
                                OrderCTN = double.Parse(list[i].GetValue("OrderCTN").ToString()),
                                Total = double.Parse(list[i].GetValue("Total").ToString()),
                                ProductItemID = list[i].GetValue("ProductItemID").ToString(),
                                Cost = double.Parse(list[i].GetValue("Cost").ToString()),
                                MOQUnit= list[i].GetValue("MOQUnit").ToString(),


                            };
                            pmlist.Add(pm);





                        }

                    }
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {


                        POMODEL pm = new POMODEL()
                        {
                            Barcode = list[i].GetValue("Barcode").ToString(),
                            AltBarcode = list[i].GetValue("AltBarcode").ToString(),
                            ItemDescription = list[i].GetValue("ItemDescription").ToString(),
                            FinalPC = list[i].GetValue("FinalPC").ToString(),
                            OrderCTN = double.Parse(list[i].GetValue("OrderCTN").ToString()),
                            Total = double.Parse(list[i].GetValue("Total").ToString()),
                            ProductItemID = list[i].GetValue("ProductItemID").ToString(),
                            Cost = double.Parse(list[i].GetValue("Cost").ToString()),
                       
                          
                        };
                        pmlist.Add(pm);







                    }
                }
                return pmlist;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return null;
        }
        public List<POMODEL> GetPOList(bool is_With_Zero)
        {
            List<POMODEL> pmlist = new List<POMODEL>();
            try
            {

                var list =getActiveChildForm().DG.Table.Records;
                if (!is_With_Zero)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (Double.Parse(list[i].GetValue("FinalPC").ToString()) != 0)
                        {

                            POMODEL pm = new POMODEL()
                            {
                                Barcode = list[i].GetValue("Barcode").ToString(),
                                AltBarcode = list[i].GetValue("AltBarcode").ToString(),
                                ItemDescription = list[i].GetValue("ItemDescription").ToString(),
                                FinalPC = list[i].GetValue("FinalPC").ToString(),
                                OrderCTN = double.Parse(list[i].GetValue("OrderCTN").ToString()),
                                Total = double.Parse(list[i].GetValue("Total").ToString()),
                                ProductItemID = list[i].GetValue("ProductItemID").ToString(),
                                Cost = double.Parse(list[i].GetValue("Cost").ToString()),
                                Inventory = list[i].GetValue("Inventory").ToString(),

                                //B1_1M = list[i].GetValue("B1_1M").ToString(),
                                //B1_1M_D = list[i].GetValue("B1_1M_D").ToString(),
                                //B1_2M = list[i].GetValue("B1_2M").ToString(),
                                //B1_2M_D = list[i].GetValue("B1_2M_D").ToString(),
                                //
                                Min = list[i].GetValue("Min").ToString(),
                               // ShabanLY = list[i].GetValue("ShabanLY").ToString(),
                                Sugg = list[i].GetValue("Sugg").ToString(),
                                Total_1M = list[i].GetValue("Total_1M").ToString(),
                               // ShabanLY_D = list[i].GetValue("ShabanLY_D").ToString(),
                                DOS = list[i].GetValue("DOS").ToString(),
                                //B1_3M = list[i].GetValue("B1_3M").ToString(),
                                //B1_3M_D = list[i].GetValue("B1_3M_D").ToString(),
                                //B2_1M = list[i].GetValue("B2_1M").ToString(),
                                //B2_1M_D = list[i].GetValue("B2_1M_D").ToString(),
                                //B2_2M = list[i].GetValue("B2_2M").ToString(),
                                //B2_2M_D = list[i].GetValue("B2_2M_D").ToString(),
                                //B2_3M = list[i].GetValue("B2_3M").ToString(),
                                //B2_3M_D = list[i].GetValue("B2_3M_D").ToString(),
                                //B3_1M = list[i].GetValue("B3_1M").ToString(),
                                //B3_1M_D = list[i].GetValue("B3_1M_D").ToString(),
                                //B3_2M = list[i].GetValue("B3_2M").ToString(),
                                //B3_2M_D = list[i].GetValue("B3_2M_D").ToString(),
                                //B3_3M = list[i].GetValue("B3_3M").ToString(),
                                Max = list[i].GetValue("Max").ToString(),
                             //   B3_3M_D = list[i].GetValue("B3_3M_D").ToString(),
                                MOQ = list[i].GetValue("MOQ").ToString(),
                                MOQUnit = list[i].GetValue("MOQUnit").ToString(),
                               // RamazanLY = list[i].GetValue("RamazanLY").ToString(),
                                //RamazanLY_D = list[i].GetValue("RamazanLY_D").ToString(),
                                ROP = list[i].GetValue("ROP").ToString(),
                                Total_1M_D = list[i].GetValue("Total_1M_D").ToString(),
                                Total_2M = list[i].GetValue("Total_2M").ToString(),
                                Total_2M_D = list[i].GetValue("Total_2M_D").ToString(),
                                //Total_3M = list[i].GetValue("Total_3M").ToString(),
                                //Total_3M_D = list[i].GetValue("Total_3M_D").ToString(),

                            };
                            pmlist.Add(pm);





                        }

                    }
                }else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        

                            POMODEL pm = new POMODEL()
                            {
                                Barcode = list[i].GetValue("Barcode").ToString(),
                                AltBarcode = list[i].GetValue("AltBarcode").ToString(),
                                ItemDescription = list[i].GetValue("ItemDescription").ToString(),
                                FinalPC = list[i].GetValue("FinalPC").ToString(),
                                OrderCTN = double.Parse(list[i].GetValue("OrderCTN").ToString()),
                                Total = double.Parse(list[i].GetValue("Total").ToString()),
                                ProductItemID = list[i].GetValue("ProductItemID").ToString(),
                                Cost = double.Parse(list[i].GetValue("Cost").ToString()),
                               Inventory= list[i].GetValue("Inventory").ToString(),

                              // B1_1M= list[i].GetValue("B1_1M").ToString(),
                              // B1_1M_D= list[i].GetValue("B1_1M_D").ToString(),
                              //B1_2M= list[i].GetValue("B1_2M").ToString(),
                              //B1_2M_D= list[i].GetValue("B1_2M_D").ToString(),
                              Min= list[i].GetValue("Min").ToString(),
                              //ShabanLY= list[i].GetValue("ShabanLY").ToString(),
                              Sugg= list[i].GetValue("Sugg").ToString(),
                              Total_1M= list[i].GetValue("Total_1M").ToString(),
                              //ShabanLY_D= list[i].GetValue("ShabanLY_D").ToString(),
                             DOS= list[i].GetValue("DOS").ToString(),
                        //   B1_3M= list[i].GetValue("B1_3M").ToString(),
                        //   B1_3M_D= list[i].GetValue("B1_3M_D").ToString(),
                        //B2_1M= list[i].GetValue("B2_1M").ToString(),
                        //B2_1M_D= list[i].GetValue("B2_1M_D").ToString(),
                        //B2_2M= list[i].GetValue("B2_2M").ToString(),
                        //B2_2M_D= list[i].GetValue("B2_2M_D").ToString(),
                        //B2_3M= list[i].GetValue("B2_3M").ToString(),
                        //B2_3M_D= list[i].GetValue("B2_3M_D").ToString(),
                        //B3_1M= list[i].GetValue("B3_1M").ToString(),
                        //B3_1M_D= list[i].GetValue("B3_1M_D").ToString(),
                        //B3_2M= list[i].GetValue("B3_2M").ToString(),
                        //B3_2M_D= list[i].GetValue("B3_2M_D").ToString(),
                        //B3_3M= list[i].GetValue("B3_3M").ToString(),
                        Max = list[i].GetValue("Max").ToString(),
                        //B3_3M_D = list[i].GetValue("B3_3M_D").ToString(),
                        MOQ = list[i].GetValue("MOQ").ToString(),
                        MOQUnit = list[i].GetValue("MOQUnit").ToString(),
                        //RamazanLY = list[i].GetValue("RamazanLY").ToString(),
                        //RamazanLY_D = list[i].GetValue("RamazanLY_D").ToString(),
                        ROP = list[i].GetValue("ROP").ToString(),
                        Total_1M_D = list[i].GetValue("Total_1M_D").ToString(),
                        Total_2M = list[i].GetValue("Total_2M").ToString(),
                        Total_2M_D = list[i].GetValue("Total_2M_D").ToString(),
                        //Total_3M = list[i].GetValue("Total_3M").ToString(),
                        //Total_3M_D = list[i].GetValue("Total_3M_D").ToString(),
                            };
                            pmlist.Add(pm);





                        

                    }
                }
                    return pmlist;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return null;

        }



        private void PDFgeneratePanel_Click(object sender, EventArgs e)
        {
            try
            {

                var list = getPoList_Half(false);
                if(list.Count==0)
                {
                    MessageBox.Show("No Item is Selected", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

        

                if (list.Count != 0)
                {
                    DialogResult dt = MessageBox.Show("This Order Will be Marked as Final!", "Do You Agree?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dt == DialogResult.OK)
                    {
                        string total = TotalAmountLabel.Text;


                        string branchid = getBranchID();
                        string priority = getPriority();
                        String getPOID = GetPIDFromDB();

                        var vendorid = VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);

                       var PurchaseOrderID = con.InsertValuesIntoDataBase("INSERT INTO [dbo].[PurchaseOrder] ([ProductVendorId],[PurchaseOrderDate],[PaymentModeId],[CurrencyId],[VendorQuotationNumber],[NetAmount],[Remark],[PurchaseOrderNumber],[DeliveryDate],[DeliveryType],[BranchDeliveryLocationId],[ShipmentModeId],[ShipmentProvideById],[CompanyBranchId],[UserId],[DataEntryDate],[DataEntryStatus],[DataEntryPost],[InvoiceToClient],[Priority],[IsCalculateInvoiceDiscount]) values ('" + vendorid[1] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm") + "','1','1',NULL,'" + list.Sum(s => s.Total).ToString() + "','" + RemarksTextBox.Text + "','" + getPOID + "','" + DeliveryDateComboBox.Text + "',NULL,'" + branchid + "','1','1','1','1','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm") + "','1',NULL,NULL,'" + priority + "','1');SELECT SCOPE_IDENTITY();");
                        if (PurchaseOrderID != -1)
                        {
                            //foreach (var item in list)
                            //{
                            //    con.InsertInformation("INSERT INTO [dbo].[PurchaseOrderItem]([PurchaseOrderId],[ProductItemId],[Quantity],[Price],[DiscountRate],[SystemStock],[ItemStatus]) values ('" + PurchaseOrderID + "','" + item.ProductItemID + "','" + item.FinalPC + "','" + item.Cost + "','0','0','1')");
                            //}
                            con.Insert_Order_Items(list, PurchaseOrderID.ToString());



                            

                            CompletepdfGenerate(getPOID,total,list);



                            var childForm = getActiveChildForm();


                            childForm.Status = true;
                            childForm.OrderID = getPOID;

                            DisplayStateMessage(childForm, "Order has been Completed. Order ID: " + getPOID);
                         //   PDFgeneratePanel.Enabled = false;
                          
                        }
                    }
                    else
                    { MessageBox.Show("There is not Item Selected", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void CompletepdfGenerate( string orderID,string total, List<POMODEL> list)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "temp"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "temp");
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Purchase Orders PDF"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Purchase Orders PDF");
            }
            List<string> pdffiles = new List<string>();

            int PageNumber = 0;
            
            double temp = (double)list.Count / 20;

            var totalpage = Math.Ceiling(temp);
            for (int loop = ItemJoPrintHoChuki; loop < list.Count; loop += 20)
            {

                ItemJoPrintHoChuki += 20;
                if (ItemJoPrintHoChuki == list.Count)
                {
                    PageNumber++;
                    CreatePdfOfList(list, loop, ItemJoPrintHoChuki, "temp//" + loop + ".pdf", PageNumber, totalpage, orderID, true,total);
                    pdffiles.Add("temp//" + loop + ".pdf");
                }
                else if (ItemJoPrintHoChuki <= list.Count)
                {
                    PageNumber++;
                    CreatePdfOfList(list, loop, ItemJoPrintHoChuki, "temp//" + loop + ".pdf", PageNumber, totalpage, orderID, false,total);
                    pdffiles.Add("temp//" + loop + ".pdf");

                }
                else
                {
                    PageNumber++;
                    CreatePdfOfList(list, loop, list.Count, "temp//end.pdf", PageNumber, totalpage, orderID, true,total);
                    pdffiles.Add("temp//end.pdf");
                }



            }
            MergePdf.MergePDFs(pdffiles, "Purchase Orders PDF//" + orderID + ".pdf");
            for (int i = 0; i < pdffiles.Count; i++)
            {
                try
                {
                    File.Delete(pdffiles[i]);
                }
                catch { }
            }

            ItemJoPrintHoChuki = 0;
        }

        private void CreatePdfOfList(List<POMODEL> list, int st, int end, string savePdf, int PageNumber, double TotalPage, string OrderNumber, bool final,String total)
        {

            try
            {

                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var FullBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                var MB_Head = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 30);



                string oldFile = "mb2.pdf";


                // open the reader
                PdfReader reader = new PdfReader(oldFile);
                iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
                Document document = new Document(size);

                // open the writer
                FileStream fs = new FileStream(savePdf, FileMode.Create, FileAccess.Write);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                System.Drawing.Image img = barcode.Draw(OrderNumber, 300);


                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Jpeg);


                pic.Border = iTextSharp.text.Rectangle.BOX;
                pic.BorderColor = iTextSharp.text.BaseColor.BLACK;
                pic.BorderWidth = 150f;

                pic.SetAbsolutePosition(672, 600);
                pic.BorderWidth = 0f;
                document.Add(pic);



                // the pdf content
                PdfContentByte cb = writer.DirectContent;

                // select the font properties
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.SetColorFill(BaseColor.BLACK);
                cb.SetFontAndSize(bf, 8);
                // write the text in the pdf content
                cb.BeginText();

                int VPos = 440;



                for (int i = st; i < end; i++)
                {  // put the alignment and coordinates here
                    cb.ShowTextAligned(0, list[i].Barcode, 37, VPos, 0);
                    if (list[i].AltBarcode.Length < 40)
                    {
                        cb.ShowTextAligned(0, list[i].AltBarcode, 115, VPos, 0);
                    }
                    else
                    {
                        cb.ShowTextAligned(0, list[i].AltBarcode.Substring(0, 40) + "**", 115, VPos, 0);
                    }
                    cb.ShowTextAligned(0, list[i].ItemDescription, 327, VPos, 0);
                    cb.ShowTextAligned(0, list[i].FinalPC, 592, VPos, 0);
                    cb.ShowTextAligned(0, list[i].OrderCTN.ToString() +" "+ list[i].MOQUnit.ToString() , 625, VPos, 0);
                    cb.ShowTextAligned(0, list[i].Cost.ToString(), 670, VPos, 0);
                    cb.ShowTextAligned(0, list[i].Total.ToString(), 725, VPos, 0);
                    cb.ShowTextAligned(0, "__________________________________________________________________________________________________________________________________________________________________", 38, (VPos - 5), 0);
                    VPos -= 18;
                }
                cb.EndText();

                cb.SetColorFill(BaseColor.BLACK);
                cb.SetFontAndSize(bf, 9);
                cb.BeginText();
                var Vid = VendorComboBox.Text.Split(new[] { "-----" }, StringSplitOptions.None);
                if (Vid[0].Length > 30)
                {
                    cb.ShowTextAligned(0, Vid[0].Substring(0, 29), 43, 542, 1);
                }
                else
                {
                    cb.ShowTextAligned(0, Vid[0], 43, 542, 1);
                }
                cb.ShowTextAligned(0, " Page# " + PageNumber + " of " + TotalPage, 700, 10, 1);
                try
                {
                    var xx = VendorTextBox.Text.Split(new[] { ";" }, StringSplitOptions.None);
                    cb.ShowTextAligned(0, xx[0], 43, 530, 1);
                }
                catch { }
                cb.ShowTextAligned(0, BranchComboBox.Text, 204, 542, 1);  //branch
                cb.ShowTextAligned(0, user.EmployeeName, 290, 542, 1);  //Employee Name
                cb.ShowTextAligned(0, user.EmployeeEmail, 290, 531, 1);  //Employee Email
                cb.ShowTextAligned(0, RemarksTextbox2.Text, 432, 542, 1);  //remarks
                cb.ShowTextAligned(0, DateTime.Now.ToString("dd-MMM-yy (ddd)"), 692, 555, 1); //
                cb.SetColorFill(BaseColor.RED);
                cb.SetFontAndSize(bf, 9);
                cb.ShowTextAligned(0, DeliveryDateComboBox.Text, 692, 529, 1);
                cb.ShowTextAligned(0, ExpiryComboBox.Text, 692, 503, 1);

                if (final == true)
                {
                    cb.SetFontAndSize(bf, 12);
                    cb.SetColorFill(BaseColor.DARK_GRAY);
                    //  cb.ShowTextAligned(0, "  Total CTN:  " +  list.Sum(ss => ss.OrderCTN), 480, VPos-30, 1);


                    cb.ShowTextAligned(1, total, 680, VPos - 15, 1);

                }
                else

                {
                    cb.SetColorFill(BaseColor.BLACK);
                    cb.ShowTextAligned(0, "--Continue--", 400, VPos - 40, 1);
                }
                cb.SetColorFill(BaseColor.DARK_GRAY);
                cb.SetFontAndSize(bf, 13);
                cb.ShowTextAligned(0, OrderNumber, 520, 578, 1);
                cb.EndText();




                try
                {
                    var xx = VendorTextBox.Text.Split(new[] { ";" }, StringSplitOptions.None);
                    cb.ShowTextAligned(1, xx[0], 105, 530, 1);

                }
                catch { }


                // create the new page and add it to the pdf
                PdfImportedPage page = writer.GetImportedPage(reader, 1);
                cb.AddTemplate(page, 0, 0);

                // close the streams and voilá the file should be changed :)
                document.Close();
                fs.Close();
                writer.Close();
                reader.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void PlaceItems()
        {
            //foreach (CalendarItem item in _items)
            //{
            //    if (get_MyPlan_ActiveChildForm().calendar1.ViewIntersects(item))
            //    {
            //        calendar1.Items.Add(item);
            //    }
            //}
        }

        private void toolStripTabItem3_Click(object sender, EventArgs e)
        {
            Form[] form = this.MdiChildren;

            for (int i = 0; i < form.Length; i++)
            {
                if (form[i].Text.ToLower() == "my plan")
                {
                    form[i].Select();
                    return;
                }
            }
                MyPlan mp = new MyPlan(this);
                mp.Text = "My Plan";
                mp.MdiParent = this;

                //child Form will now hold a reference value to the tab control
                mp.TabCtrl = tabControl1;

                //Add a Tabpage and enables it
                TabPageAdv tp = new TabPageAdv();
                tp.Parent = tabControl1;
                tp.Text = mp.Text;



                tp.Show();

                //child Form will now hold a reference value to a tabpage
                mp.TabPag = tp;
                mp.FormBorderStyle = FormBorderStyle.None;
                mp.Dock = DockStyle.Fill;
                //Activate the MDI child form
                mp.Show();
                childCount++;
                if (tabControl1.TabCount > 1)
                { tabControl1.ShowTabCloseButton = true; }
                //Activate the newly created Tabpage
                tabControl1.SelectedTab = tp;

            
        
    }
        public void SetVendorBoxIndex(int i)
        {
            VendorComboBox.SelectedIndex = i;
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            var Shownlist = new List<string>();
            var Hiddenlist = new List<string>();
            var child = getActiveChildForm();
            try {
                //for (int i = 0; i < child.DG.TableDescriptor.VisibleColumns.Count; i++)

                //{

                //list.Add(child.DG.TableDescriptor.VisibleColumns[i].Name);
                //}

                for (int i = 0; i < child.DG.TableDescriptor.Columns.Count; i++)
                {
                    if (child.DG.TableDescriptor.VisibleColumns.Contains(child.DG.TableDescriptor.Columns[i].Name))
                    {
                        Shownlist.Add(child.DG.TableDescriptor.Columns[i].Name);
                    }
                    else
                    {
                        Hiddenlist.Add(child.DG.TableDescriptor.Columns[i].Name);
                    }
                }

                ShowColumn s = new ShowColumn(Hiddenlist, Shownlist,child);
                s.ShowDialog();
            }
            catch { }
            }

        private void MyListToolStrip_Click(object sender, EventArgs e)
        {
            My_List m = new My_List(user,this);
            m.ShowDialog();

        }

        private void RequestedListtoolStripButton_Click(object sender, EventArgs e)
        {
            Request_List rl = new Request_List(user, this);
            rl.ShowDialog();
        }

        private void ToolStripButton13_Click_1(object sender, EventArgs e)
        {
            AutomaticOrderingSetting aos = new AutomaticOrderingSetting(user);
            aos.ShowDialog();
        }
    }
}
