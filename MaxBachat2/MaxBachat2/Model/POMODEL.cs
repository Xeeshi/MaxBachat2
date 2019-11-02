using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBachat2.Model
{
   public class POMODEL
    {
        
        [DisplayName("Item Description")]
        public string ItemDescription { get; set; }

        public string MOQ { get; set; }

        [DisplayName("Inv")]
        public string Inventory { get; set; }

        public string DOS { get; set; }

        public string Sugg { get; set; }


        [DisplayName("Order PC")]
        public string FinalPC { get; set; }

        [DisplayName("Order CTN")]
        public double OrderCTN { get; set; }

        [DisplayName("MOQ Unit")]
        public string MOQUnit { get; set; }

        public double Cost { get; set; }

        public double Total { get; set; }
    
        //public string B1_1M { get; set; }

        //public string B1_2M { get; set; }

        //public string B1_3M { get; set; }

        //public string B2_1M { get; set; }

        //public string B2_2M { get; set; }

        //public string B2_3M { get; set; }


        public string Total_1M { get; set; }

        public string Total_2M { get; set; }

        //public string Total_3M { get; set; }

        //public string ShabanLY { get; set; }

        //public string RamazanLY { get; set; }


        //public string B1_1M_D { get; set; }

        //public string B1_2M_D { get; set; }

        //public string B1_3M_D { get; set; }

        //public string B2_1M_D { get; set; }

        //public string B2_2M_D { get; set; }

        //public string B2_3M_D { get; set; }


        public string Total_1M_D { get; set; }

        public string Total_2M_D { get; set; }

        //public string Total_3M_D { get; set; }

        //public string ShabanLY_D { get; set; }

        //public string RamazanLY_D { get; set; }




        //public string B3_1M_D { get; set; }

        //public string B3_2M_D { get; set; }

        //public string B3_3M_D { get; set; }


        [DisplayName("Product Item ID")]
        public string ProductItemID { get; set; }

        public string Barcode { get; set; }

        [DisplayName("Alt Barcode")]
        public string AltBarcode { get; set; }

        public string Min { get; set; }

        public string Max { get; set; }

        public string ROP { get; set; }
        //public string B3_1M { get; set; }

        //public string B3_2M { get; set; }

        //public string B3_3M { get; set; }

    }
}
