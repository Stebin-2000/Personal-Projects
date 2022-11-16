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
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();
        }

        cashierBLL c = new cashierBLL();
        cashierDAL dal = new cashierDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.name = txtname.Text;
            c.address = txtaddress.Text;
            c.contact = txtcontact.Text;
            c.gender = cmbgender.Text;
            c.email = txtemail.Text;
            c.username = txtusername.Text;
            c.password = txtpassword.Text;
            c.user_type = cmbusertype.Text;
            c.added_date = DateTime.Now;

            bool success = dal.Insert(c);

            if (success==true)
            {
                MessageBox.Show("User successfully added.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new cashier.");
            }

            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void cashier_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void clear()
        {
            txtcashierid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            cmbgender.Text = "";
            txtemail.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            cmbusertype.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtcashierid.Text);
            c.name = txtname.Text;
            c.address = txtaddress.Text;
            c.contact = txtcontact.Text;
            c.gender = cmbgender.Text;
            c.email = txtemail.Text;
            c.username = txtusername.Text;
            c.password = txtpassword.Text;
            c.user_type = cmbusertype.Text;
            c.added_date = DateTime.Now;

            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("Cashier data updated successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update data.");
            }
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtcashierid.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtcontact.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbgender.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            txtemail.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            txtusername.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            cmbusertype.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtcashierid.Text);

            bool success = dal.Delete(c);

            if (success == true)
            {
                MessageBox.Show("Cashier deleted successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete cashier.");
            }

            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords!=null)
            {
                DataTable dt = dal.Search(keywords);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
