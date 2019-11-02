using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBachat21.Model
{
   public class Request_Items_Model
    {
    
        public string Barcode { get; set; }
        public string  FloorQty { get; set; }
        public string Urgency { get; set; }
        public bool Add { get; set; }
    }
}
