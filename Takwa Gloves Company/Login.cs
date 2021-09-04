using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takwa_Gloves_Company
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "a001" && passtxt.Text == "admin")
            {
                Menu m = new Menu();
                m.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invaild Id or Password");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usertxt.Text = "Enter Username";
            passtxt.Text = "Enter Password";
        }

        private void usertxt_Enter(object sender, EventArgs e)
        {
            if (usertxt.Text == "Enter Username")
            {
                usertxt.Text = "";
            }
        }

        private void usertxt_Leave(object sender, EventArgs e)
        {
            if (usertxt.Text == "")
            {
                usertxt.Text = "Enter Username";
            }
        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            if (passtxt.Text == "Enter Password")
            {
                passtxt.Text = "";
                passtxt.UseSystemPasswordChar = true;
            }
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.Text = "Enter Password";
                passtxt.UseSystemPasswordChar = false;
            }
        }
    }
}
