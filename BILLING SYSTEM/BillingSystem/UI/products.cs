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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        cashierDAL cdal = new cashierDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtproductid.Text = "";
            txtproductname.Text = "";
            txtdesc.Text = "";
            txtprice.Text = "";
            txt_quantity.Text = "";
            txtsearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.name = txtproductname.Text;
            p.description = txtdesc.Text;
            p.price = decimal.Parse(txtprice.Text);
            p.quantity = decimal.Parse(txt_quantity.Text);
            p.added_date = DateTime.Now;

            bool success = pdal.Insert(p);

            if (success == true)
            {
                MessageBox.Show("Product successfully added.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new product.");
            }

            DataTable dt = pdal.Select();
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtproductid.Text = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            txtproductname.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            txtdesc.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            txtprice.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            txt_quantity.Text = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void products_Load(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtproductid.Text);

            bool success = pdal.Delete(p);

            if (success == true)
            {
                MessageBox.Show("Product deleted successfully.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
            }

            DataTable dt = pdal.Select();
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtproductid.Text);
            p.name = txtproductname.Text;
            p.description = txtdesc.Text;
            p.price = decimal.Parse(txtprice.Text);
            p.quantity = decimal.Parse(txt_quantity.Text);
            p.added_date = DateTime.Now;

            bool success = pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show("Product data updated successfully.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update data.");
            }
            DataTable dt = pdal.Select();
            dataGridView2.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dataGridView2.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dataGridView2.DataSource = dt;
            }
        }
    }
}
