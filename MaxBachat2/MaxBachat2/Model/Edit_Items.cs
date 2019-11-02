using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBachat21.Model
{
   public class Edit_Items
    {
        public string ProductItemID { get; set; }
       
        [DisplayName("Item Description")]
        public string ItemDescription { get; set; }

        public string Cost { get; set; }

        public string Sale1M { get; set; }

        public string Sale2M { get; set; }

        public string MOQ { get; set; }

        public string MOQUnit { get; set; }


        public string Barcode { get; set; }
    }
}
