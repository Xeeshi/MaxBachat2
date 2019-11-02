using MaxBachat21.Model;
using NavigationDrawer_2010;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBachat21.Services
{
   public class SharedServices
    {
        Connection db = new Connection();
       public  List<Edit_Items> GetMappinOrderItems(string vid)
        { try
            {
                List<Edit_Items> editlist = new List<Edit_Items>();
                var dt = db.getDataTableFromDB("SELECT Distinct pi.ProductItemId,pi.Barcode ,pi.LongName ,pi.CostPrice,omoq.[MOQ],omoq.[MOQUnit],s1.SaleTotal as [Sale1M],s2.SaleTotal as [Sale2M] FROM ProductItem pi LEFT JOIN mbo.PSOrderingMOQ omoq on omoq.ProductItemid=pi.productitemid  LEFT JOIN dbo.MaxBSale1MB s1 on s1.ProductItemid=pi.productitemid  LEFT JOIN dbo.MaxBSale2MB s2 on s2.ProductItemid=pi.productitemid   LEFT JOIN [mbo].[PSVendorItemMapping] vim on pi.ProductItemId = vim.ProductItemId Where vim.ProductVendorId='" + vid + "'");


                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    Edit_Items er = new Edit_Items()
                    {
                        MOQ = dt.Rows[i]["MOQ"].ToString(),
                        MOQUnit = dt.Rows[i]["MOQUnit"].ToString(),
                        ProductItemID = dt.Rows[i]["ProductItemId"].ToString(),
                        ItemDescription = dt.Rows[i]["LongName"].ToString(),
                        Barcode= dt.Rows[i]["Barcode"].ToString(),
                        Cost = dt.Rows[i]["CostPrice"].ToString(),
                        Sale2M = dt.Rows[i]["Sale1M"].ToString(),
                        Sale1M= dt.Rows[i]["Sale2M"].ToString(),

                    };


                    // selectedRecord.Record.SetValue(column.Name, "Modified_Record");
                    editlist.Add(er);


                }
                return editlist;
            }
            catch (Exception ex)
            { System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
