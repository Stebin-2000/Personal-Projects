using BillingSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem.UI
{
    public partial class bills : Form
    {
        public bills()
        {
            InitializeComponent();
        }

        transactionsDAL tdal = new transactionsDAL();
        transaction_detailsDAL tdDAL = new transaction_detailsDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bills_Load(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransactions();
            dgv_transactions.DataSource = dt;
        }

        private void dgv_transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
