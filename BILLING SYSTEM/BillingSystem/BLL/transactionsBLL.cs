using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.BLL
{
    class transactionsBLL
    {
        public int id { get; set; }
        public int cust_id { get; set; }
        public decimal grandtotal { get; set; }
        public DateTime transaction_date { get; set; }
        public decimal tax { get; set; }
        public decimal discount { get; set; }
        public DataTable transactionDetails { get; set; }
    }
}
