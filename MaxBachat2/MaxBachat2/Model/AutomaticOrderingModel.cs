
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBachat21.Model
{
    public class AutomaticOrderingModel
    {
        public string VendorID { get; set; }
        public string Vendor { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool MON { get; set; }
        public bool TUE { get; set; }
        public bool WED { get; set; }
        public bool THU { get; set; }
        public bool FRI { get; set; }

        public bool SAT { get; set; }
        public bool SUN { get; set; }

        public int DayOfMonth { get; set; }

        public DateTime OrderTime { get; set; }
        public string Method { get; set; }

        public bool Auto_Ordering { get; set; }
        public  string Set_Dos { get; set; }
        public string Remove { get; set; }
        
    }
}
