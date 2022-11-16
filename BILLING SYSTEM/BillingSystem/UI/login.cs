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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUsertype.Text.Trim();

            bool success = dal.loginCheck(l);

            if (success == true)
            {
                MessageBox.Show("Login Successful.");
                loggedIn = l.username;

                switch(l.user_type)
                {
                    case "ADMIN":
                        {
                            admindashboard admin = new admindashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "CASHIER":
                        {
                            cashierdashboard cashier = new cashierdashboard();
                            cashier.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed.");
            }
        }
    }
}
