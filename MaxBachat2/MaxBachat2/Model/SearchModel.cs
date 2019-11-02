using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBachat2.Model
{
    class SearchModel
    {
        public string ProductItemID { get; set; }

       [DisplayName("Item Description")]
        public string ItemDescription { get; set; }

        public double Cost { get; set; }
        [DisplayName("Add Item")]
        public bool Add { get; set; }
        

    }
}
