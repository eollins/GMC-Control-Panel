using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMCCIT_Control_Panel
{
    class Consignment
    {
        public string UserID { get; set; }
        public string SKUMin { get; set; }
        public string SKUMax { get; set; }
        public string ConsignmentName { get; set; }
        public string Total { get; set; }
        public string NetSales { get; set; }
        public string Received { get; set; }
        public string Owed { get; set; }
        public string GrossSales { get; set; }
    }
}
