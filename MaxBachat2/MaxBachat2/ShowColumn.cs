using MaxBachat2;
using MaxBachat2.Model;
using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
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
    public partial class ShowColumn : Syncfusion.Windows.Forms.MetroForm
    { List<string> Hiddenlist;
        List<string> Shownlist;
        ChildForm child;
        public ShowColumn(List<string> hidden,List<string> shown,ChildForm c)
        {
            InitializeComponent();
            Hiddenlist = hidden;
            Shownlist = shown;
            child = c;
        }

        
        private void ShowColumn_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Shownlist.Count; i++)
            {
                ShownlistBox.Items.Add(Shownlist[i]);
            }

            for (int i=0;i<Hiddenlist.Count;i++)
            {
                HiddenlistBox.Items.Add(Hiddenlist[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void button5_Click(object sender, EventArgs e)
        {

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
            childform.DG.TableDescriptor.VisibleColumns.Remove("B3_1M");
            childform.DG.TableDescriptor.VisibleColumns.Remove("B3_2M");
            childform.DG.TableDescriptor.VisibleColumns.Remove("B3_3M");


            childform.DG.TableDescriptor.VisibleColumns.Remove("B3_1M_D");
            childform.DG.TableDescriptor.VisibleColumns.Remove("B3_2M_D");
            childform.DG.TableDescriptor.VisibleColumns.Remove("B3_3M_D");
            childform.DG.TableDescriptor.VisibleColumns.Add("ItemDescription");
            childform.DG.TableDescriptor.VisibleColumns.Add("MOQ");
            childform.DG.TableDescriptor.VisibleColumns.Add("Inventory");
            childform.DG.TableDescriptor.VisibleColumns.Add("DOS");
            childform.DG.TableDescriptor.VisibleColumns.Add("Sugg");
            childform.DG.TableDescriptor.VisibleColumns.Add("FinalPC");
            childform.DG.TableDescriptor.VisibleColumns.Add("OrderCTN");
            childform.DG.TableDescriptor.VisibleColumns.Add("MOQUnit");
            childform.DG.TableDescriptor.VisibleColumns.Add("Cost");
            childform.DG.TableDescriptor.VisibleColumns.Add("Total");
            childform.DG.TableDescriptor.VisibleColumns.Add("B1_1M");
            childform.DG.TableDescriptor.VisibleColumns.Add("B1_2M");
            childform.DG.TableDescriptor.VisibleColumns.Add("B1_3M");
            childform.DG.TableDescriptor.VisibleColumns.Add("B2_1M");
            childform.DG.TableDescriptor.VisibleColumns.Add("B2_2M");
            childform.DG.TableDescriptor.VisibleColumns.Add("B2_3M");
            childform.DG.TableDescriptor.VisibleColumns.Add("Total_1M");
            childform.DG.TableDescriptor.VisibleColumns.Add("Total_2M");
            childform.DG.TableDescriptor.VisibleColumns.Add("Total_3M");
            childform.DG.TableDescriptor.VisibleColumns.Add("ShabanLY");
            childform.DG.TableDescriptor.VisibleColumns.Add("RamazanLY");
       




            childform.DG.Refresh();
            childform.DG.Invalidate();
            childform.DG.TableControl.RefreshRange(GridRangeInfo.Table());

        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            try
            {
                var item = HiddenlistBox.SelectedIndex;
                ShownlistBox.Items.Add(HiddenlistBox.Items[item]);
                child.DG.TableDescriptor.VisibleColumns.Add(HiddenlistBox.Items[item].ToString());
                HiddenlistBox.Items.RemoveAt(item);

            }
            catch { }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ShownlistBox.SelectedIndex;
                HiddenlistBox.Items.Add(ShownlistBox.Items[item]);
                child.DG.TableDescriptor.VisibleColumns.Remove(ShownlistBox.Items[item].ToString());
                ShownlistBox.Items.RemoveAt(item);
            }
            catch { }
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {

            GridSettin(child);
            ShownlistBox.Items.Clear();
            HiddenlistBox.Items.Clear();
            for (int i = 0; i < child.DG.TableDescriptor.Columns.Count; i++)
            {
                if (child.DG.TableDescriptor.VisibleColumns.Contains(child.DG.TableDescriptor.Columns[i].Name))
                {
                    ShownlistBox.Items.Add(child.DG.TableDescriptor.Columns[i].Name);
                }
                else
                {
                    HiddenlistBox.Items.Add(child.DG.TableDescriptor.Columns[i].Name);
                }
            }
        }
    }
}
