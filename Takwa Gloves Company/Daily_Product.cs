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
    public partial class Daily_Product : Form
    {
        private bool isNew = true;
        public Daily_Product()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            snotxt.Text = "";
            idtxt.Text = "";
            nametxt.Text = "";
            typetxt.Text = "";
            wtxt.Text = "";
            dtxt.Text = "";
            stxt.Text = "";
            searchtxt.Text = "";
            qtxt.Text = "";

            productTable.ClearSelection();
        }

        private void LoadProduct()
        {
            string query = "Select * from Daily_Product";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Daily_Product.name like '%" + searchtxt.Text + "%'";
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
            string query = "Select * from Daily_Product Where id = '" + snotxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            snotxt.Text = dt.Rows[0]["id"].ToString();
            idtxt.Text = dt.Rows[0]["pid"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            dtxt.Text = dt.Rows[0]["date"].ToString();
            wtxt.Text = dt.Rows[0]["weight"].ToString();
            stxt.Text = dt.Rows[0]["size"].ToString();
            qtxt.Text = dt.Rows[0]["quantity"].ToString();
        }

        private void LoadProductInfo()
        {
            string query = "Select * from Product";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            idtxt.DataSource = dt;
            idtxt.DisplayMember = "pid";
            idtxt.ValueMember = "pid";

            nametxt.DataSource = dt;
            nametxt.DisplayMember = "name";
            nametxt.ValueMember = "name";

            wtxt.DataSource = dt;
            wtxt.DisplayMember = "weight";
            wtxt.ValueMember = "weight";

            stxt.DataSource = dt;
            stxt.DisplayMember = "size";
            stxt.ValueMember = "size";

            typetxt.DataSource = dt;
            typetxt.DisplayMember = "type";
            typetxt.ValueMember = "type";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private bool checkProduct() //It is checking if the product is available or not
        {
            string query = ("Select * from Inventory where pid = '" + idtxt.Text + "'");
            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string type = this.typetxt.Text;
            string date = this.dtxt.Text;
            string weight = this.wtxt.Text;
            string size = this.stxt.Text;
            string qn = this.qtxt.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(weight) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(qn))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";
            string query1 = "";

            if (isNew == true)
            {
                query = "INSERT into Daily_Product(pid, name, type, date, weight, size,quantity) Values (" + id + ",'" + name + "', '" + type + "' , '" + date + "', '" + weight + "', '" + size + "', " + qn + ")";
                MessageBox.Show("Product Info Successfully Inserted");

                if (checkProduct())
                {
                    query1 = "Update Inventory SET quantity = quantity + " + Convert.ToInt32(qn) + " WHERE pid = '" + idtxt.Text + "'";
                    MessageBox.Show("Inventory Successfully Updated");
                }
                else
                {
                    query1 = "INSERT into Inventory(pid, name, type, weight, size,quantity) Values (" + id + ",'" + name + "', '" + type + "' , '" + weight + "', '" + size + "', " + qn + ")";
                    MessageBox.Show("Inventory Successfully Inserted");
                }

                DatabaseConnection.ExecuteQuery(query1);
            }
            else
            {
                query = "UPDATE Daily_Product SET pid = " + id + ", name = '" + name + "', date = '" + date + "', type = '" + type + "', weight = '" + weight + "', size = '" + size + "' WHERE pid = '" + idtxt.Text + "'";
                MessageBox.Show("Product Info Successfully Updated");
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
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

        private void Daily_Product_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadProductInfo();
        }

        private void sellTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string pid = productTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                snotxt.Text = pid;
                this.LoadSingleProduct();
            }
        }

        private void Daily_Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbox_ValueChanged(object sender, EventArgs e)
        {
            string query = "Select * from Daily_Product WHERE date = '" + tbox.Text + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            productTable.AutoGenerateColumns = false;
            productTable.DataSource = dt;
            productTable.Refresh();
            productTable.ClearSelection();

            this.Refresh();
        }
    }
}
