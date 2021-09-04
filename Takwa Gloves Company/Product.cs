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
    public partial class Product : Form
    {
        private bool isNew = true;
        public Product()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            typetxt.Text = "";
            wtxt.Text = "";
            stxt.Text = "";
            pricetxt.Text = "";
            searchtxt.Text = "";

            productTable.ClearSelection();
        }

        private void LoadProduct()
        {
            string query = "Select * from Product";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Product.name like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            productTable.AutoGenerateColumns = false;
            productTable.DataSource = dt;
            productTable.Refresh();
            productTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleProduct()
        {
            string query = "Select * from Product Where pid = '" + idtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            idtxt.Text = dt.Rows[0]["pid"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            wtxt.Text = dt.Rows[0]["weight"].ToString();
            stxt.Text = dt.Rows[0]["size"].ToString();
            pricetxt.Text = dt.Rows[0]["price"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string type = this.typetxt.Text;
            string weight = this.wtxt.Text;
            string size = this.stxt.Text;
            string price = this.pricetxt.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(weight) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Product(name, type, weight, size, price) Values ('" + name + "', '" + type + "', '" + weight + "', '" + size + "', '" + price + "')";
                MessageBox.Show("Product Info Successfully Inserted");
            }
            else
            {
                query = "UPDATE Product SET name = '" + name + "', type = '" + type + "', weight = '" + weight + "', size = '" + size + "', price = '" + price + "' WHERE pid = '" + idtxt.Text + "'";
                MessageBox.Show("Product Info Successfully Updated");
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                this.LoadProduct();
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

            string query = "Delete from Product Where id = '" + idtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Product Info Deleted");
                this.LoadProduct();
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

        private void productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string pid = productTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = pid;
                this.LoadSingleProduct();
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}