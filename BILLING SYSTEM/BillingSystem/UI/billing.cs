using BillingSystem.BLL;
using BillingSystem.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BillingSystem.UI
{
    public partial class billing : Form
    {
        public billing()
        {
            InitializeComponent();
        }

        custDAL cDAL = new custDAL();
        productsDAL pDAL = new productsDAL();

        DataTable transactionDT = new DataTable();

        transactionsDAL tDAL = new transactionsDAL();
        transaction_detailsDAL tdDAL = new transaction_detailsDAL();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void billing_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Price");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;

            if(keyword == "")
            {
                txt_name.Text = "";
                txt_email.Text = "";
                txt_contact.Text = "";
                txt_address.Text = "";

                return;
            }

            custBLL c = cDAL.SearchCustomerForTransaction(keyword);

            txt_name.Text = c.name;
            txt_address.Text = c.address;
            txt_contact.Text = c.contact;
            txt_email.Text = c.email;
        }

        private void txt_prodsearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_prodsearch.Text;

            if (keyword == "")
            {
                txt_prodname.Text = "";
                txt_price.Text = "";
                txt_inventory.Text = "";
                txt_quantity.Text = "";

                return;
            }

            productsBLL p = pDAL.GetProductsForTransaction(keyword);

            txt_prodname.Text = p.name;
            txt_price.Text = p.price.ToString();
            txt_inventory.Text = p.quantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productname = txt_prodname.Text;
            decimal price = decimal.Parse(txt_price.Text);
            decimal quantity = decimal.Parse(txt_quantity.Text);

            decimal total = price * quantity;

            decimal subtotal = decimal.Parse(txt_subtotal.Text);
            subtotal = subtotal + total;

            if (productname == "")
            {
                MessageBox.Show("Enter a product first");
            }
            else
            {
                transactionDT.Rows.Add(productname, price, quantity, total);

                dgvproductsadded.DataSource = transactionDT;

                txt_subtotal.Text = subtotal.ToString();

                txt_prodsearch.Text = "";
                txt_prodname.Text = "";
                txt_price.Text = "";
                txt_quantity.Text = "";
                txt_inventory.Text = "";
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            string value = txt_discount.Text;

            if (value == "")
            {
                MessageBox.Show("Please add Discount.");
            }
            else
            {
                decimal subtotal = decimal.Parse(txt_subtotal.Text);
                decimal discount = decimal.Parse(txt_discount.Text);

                decimal grandtotal = ((100 - discount) / 100) * subtotal;

                txt_grandtotal.Text = grandtotal.ToString();
            }
        }

        private void txt_tax_TextChanged(object sender, EventArgs e)
        {
            string check = txt_grandtotal.Text;
            if (check == "")
            {
                MessageBox.Show("Please add Discount first.");
            }
            else
            {
                decimal previousGT = decimal.Parse(txt_grandtotal.Text);
                decimal tax = decimal.Parse(txt_tax.Text);
                decimal grandtotalwithtax = ((100 + tax) / 100) * previousGT;

                txt_grandtotal.Text = grandtotalwithtax.ToString();
            }
        }

        private void txt_amountpaid_TextChanged(object sender, EventArgs e)
        {
            string amount = txt_amountpaid.Text;
            if (amount == "")
            {
                MessageBox.Show("Please enter the Amount Paid.");
            }
            else
            {

                decimal grandtotal = decimal.Parse(txt_grandtotal.Text);
                decimal amountpaid = decimal.Parse(txt_amountpaid.Text);

                decimal returnamount = amountpaid - grandtotal;

                txt_returnamount.Text = returnamount.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transactionsBLL transaction = new transactionsBLL();

            string custname = txt_name.Text;
            custBLL c = cDAL.GetCustIdFromName(custname);

            transaction.cust_id = c.id;
            transaction.grandtotal = Math.Round(decimal.Parse(txt_grandtotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txt_tax.Text);
            transaction.discount = decimal.Parse(txt_discount.Text);
            transaction.transactionDetails = transactionDT;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                for (int i=0;i<transactionDT.Rows.Count;i++)
                {
                    transactiondetailsBLL transactionDetail = new transactiondetailsBLL();
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDAL.GetProdIdFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.price = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.quantity = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.cust_id = c.id;
                    transactionDetail.added_date = DateTime.Now;

                    bool x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.quantity);

                    bool y = tdDAL.InsertTransactionDetails(transactionDetail);
                    success = w && x && y;
                }
                
                if (success == true)
                {
                    scope.Complete();

                    MessageBox.Show("Transaction completed successfully.");

                    dgvproductsadded.DataSource = null;
                    dgvproductsadded.Rows.Clear();

                    txt_search.Text = "";
                    txt_name.Text = "";
                    txt_contact.Text = "";
                    txt_address.Text = "";
                    txt_email.Text = "";

                    txt_prodsearch.Text = "";
                    txt_prodname.Text = "";
                    txt_price.Text = "0";
                    txt_quantity.Text = "0";
                    txt_inventory.Text = "0";

                    txt_subtotal.Text = "0";
                    txt_discount.Text = "0";
                    txt_tax.Text = "0";
                    txt_grandtotal.Text = "0";
                    txt_amountpaid.Text = "0";
                    txt_returnamount.Text = "0";
                }
                else
                {
                    MessageBox.Show("Transaction failed.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n BILLING SYSTEM \r\n\r\n";
            printer.SubTitle = "MUMBAI, INDIA \r\n CONTACT US AT : 7506015057 \r\n\r\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Discount: " + txt_discount.Text + "% \r\n" + "Tax:" + txt_tax.Text + "% \r\n" + "Grand Total:" + txt_grandtotal.Text + "\r\n" + "Thank You for Shopping With Us.";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvproductsadded);
        }
    }
}
