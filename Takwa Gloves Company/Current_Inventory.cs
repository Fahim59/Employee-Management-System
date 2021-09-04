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
    public partial class Current_Inventory : Form
    {
        private bool isNew = true;
        public Current_Inventory()
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
            //dtxt.Text = "";
            stxt.Text = "";
            //pricetxt.Text = "";
            searchtxt.Text = "";
            qtxt.Text = "";

            sellTable.ClearSelection();
        }

        private void LoadProduct()
        {
            string query = "Select * from Inventory";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Inventory.name like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            sellTable.AutoGenerateColumns = false;
            sellTable.DataSource = dt;
            sellTable.Refresh();
            sellTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleProduct()
        {
            string query = "Select * from Inventory Where id = '" + snotxt.Text + "'";

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
            wtxt.Text = dt.Rows[0]["weight"].ToString();
            stxt.Text = dt.Rows[0]["size"].ToString();
            qtxt.Text = dt.Rows[0]["quantity"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadProduct();
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

        private void sellTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string pid = sellTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                //idtxt.Text = pid;
                snotxt.Text = pid;
                this.LoadSingleProduct();
            }
        }

        private void Current_Inventory_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void Current_Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Inventory WHERE type = '" + tbox.SelectedItem + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            sellTable.AutoGenerateColumns = false;
            sellTable.DataSource = dt;
            sellTable.Refresh();
            sellTable.ClearSelection();

            this.Refresh();
        }
    }
}
