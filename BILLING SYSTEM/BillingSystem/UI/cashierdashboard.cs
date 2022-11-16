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
    public partial class cashierdashboard : Form
    {
        public cashierdashboard()
        {
            InitializeComponent();
        }

        private void cashierdashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void cashierdashboard_Load(object sender, EventArgs e)
        {
            label4.Text = login.loggedIn;
        }

        private void iNVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.Show();
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

        private void bILLINGToolStripMenuItem_Click(object sender, EventArgs e)
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
