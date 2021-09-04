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
    public partial class Customer_Details : Form
    {
        private bool isNew = true;
        public Customer_Details()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            phonetxt.Text = "";
            addresstxt.Text = "";
            snametxt.Text = "";

            cusTable.ClearSelection();
        }

        private void LoadCustomer()
        {
            string query = "Select * from Customer";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Customer.sname like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            cusTable.AutoGenerateColumns = false;
            cusTable.DataSource = dt;
            cusTable.Refresh();
            cusTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleCus()
        {  
            string query = "Select * from Customer Where id = '" + idtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            idtxt.Text = dt.Rows[0]["id"].ToString();
            nametxt.Text = dt.Rows[0]["cname"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
            snametxt.Text = dt.Rows[0]["sname"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string phone = this.phonetxt.Text;
            string address = this.addresstxt.Text;
            string sname = this.snametxt.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(sname))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Customer(cname, phone, address,sname) Values ('" + name + "','" + phone + "', '" + address + "', '" + sname + "');";
                MessageBox.Show("Customer Info Successfully Inserted");
            }
            else
            {
                query = "UPDATE Customer SET cname = '" + name + "', phone = '" + phone + "', address = '" + address + "', sname = '" + sname + "' WHERE id = '" + idtxt.Text + "'";
                MessageBox.Show("Customer Info Successfully Updated");
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                this.LoadCustomer();
                this.Refresh();
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            string query = "Delete from Customer Where id = '" + idtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Customer Info Deleted");
                this.LoadCustomer();
                this.Refresh();
            }
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

        private void Customer_Details_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void Customer_Details_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cusTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = cusTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleCus();
            }
        }
    }
}