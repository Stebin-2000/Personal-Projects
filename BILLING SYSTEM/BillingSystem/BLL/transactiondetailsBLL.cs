using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.BLL
{
    class transactiondetailsBLL
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public decimal total { get; set; }
        public int cust_id { get; set; }
        public DateTime added_date { get; set; }
    }
}
