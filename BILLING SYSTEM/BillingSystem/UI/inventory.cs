using BillingSystem.BLL;
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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvinventory.DataSource = dt;
        }

        private void txtinventorysearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtinventorysearch.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgvinventory.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvinventory.DataSource = dt;
            }
        }
    }
}
