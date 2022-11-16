using BillingSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class admindashboard : Form
    {
        public admindashboard()
        {
            InitializeComponent();
        }

        public static string transactionType;

        private void lOGINASADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cashier cashier = new cashier();
            cashier.Show();
        }

        private void admindashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void admindashboard_Load(object sender, EventArgs e)
        {
            label4.Text = login.loggedIn;
        }

        private void lOGINASCASHIERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products products = new products();
            products.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void cUSTOMERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
        }

        private void sALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billing billing = new billing();
            billing.Show();
        }

        private void bILLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bills bills = new bills();
            bills.Show();
        }
    }
}
