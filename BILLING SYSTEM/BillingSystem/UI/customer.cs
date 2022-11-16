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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        custBLL cu = new custBLL();
        custDAL cdal = new custDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtcustid.Text = "";
            txtcustname.Text = "";
            txtcustaddress.Text = "";
            txtcustcontact.Text = "";
            txtcustemail.Text = "";
            txtcustsearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cu.name = txtcustname.Text;
            cu.address = txtcustaddress.Text;
            cu.contact = txtcustcontact.Text;
            cu.email = txtcustemail.Text;
            cu.added_date = DateTime.Now;

            bool success = cdal.Insert(cu);

            if (success == true)
            {
                MessageBox.Show("Customer successfully added.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new customer.");
            }

            DataTable dt = cdal.Select();
            dgvcust.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cu.id = Convert.ToInt32(txtcustid.Text);
            cu.name = txtcustname.Text;
            cu.address = txtcustaddress.Text;
            cu.contact = txtcustcontact.Text;
            cu.email = txtcustemail.Text;
            cu.added_date = DateTime.Now;

            bool success = cdal.Update(cu);
            if (success == true)
            {
                MessageBox.Show("Customer data updated successfully.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update data.");
            }
            DataTable dt = cdal.Select();
            dgvcust.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cu.id = Convert.ToInt32(txtcustid.Text);

            bool success = cdal.Delete(cu);

            if (success == true)
            {
                MessageBox.Show("Customer deleted successfully.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete customer.");
            }

            DataTable dt = cdal.Select();
            dgvcust.DataSource = dt;
        }

        private void txtcustsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtcustsearch.Text;

            if (keywords != null)
            {
                DataTable dt = cdal.Search(keywords);
                dgvcust.DataSource = dt;
            }
            else
            {
                DataTable dt = cdal.Select();
                dgvcust.DataSource = dt;
            }
        }

        private void customer_Load(object sender, EventArgs e)
        {
            DataTable dt = cdal.Select();
            dgvcust.DataSource = dt;
        }

        private void dgvcust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtcustid.Text = dgvcust.Rows[rowIndex].Cells[0].Value.ToString();
            txtcustname.Text = dgvcust.Rows[rowIndex].Cells[1].Value.ToString();
            txtcustaddress.Text = dgvcust.Rows[rowIndex].Cells[2].Value.ToString();
            txtcustcontact.Text = dgvcust.Rows[rowIndex].Cells[3].Value.ToString();
            txtcustemail.Text = dgvcust.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}
