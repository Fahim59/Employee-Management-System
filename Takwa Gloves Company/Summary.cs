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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT COUNT(id) FROM Employee";
            string query2 = "SELECT COUNT(Invoice) FROM Invoice";

            DataTable dt1 = DatabaseConnection.GetData(query1);
            DataTable dt2 = DatabaseConnection.GetData(query2);

            tetxt.Text = dt1.Rows[0][0].ToString();
            totxt.Text = dt2.Rows[0][0].ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Visible = false;
            m.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Visible = true;
            this.Visible = false;
        }

        private void Summary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}