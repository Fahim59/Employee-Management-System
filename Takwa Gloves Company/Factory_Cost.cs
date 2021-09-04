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
    public partial class Factory_Cost : Form
    {
        private bool isNew = true;
        public Factory_Cost()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            snotxt.Text = "";
            typetxt.Text = "";
            dtxt.Text = "";
            pricetxt.Text = "";

            searchtxt.Text = "";

            costTable.ClearSelection();
        }

        private void LoadCost()
        {
            string query = "Select * from Cost";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Cost.type like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            costTable.AutoGenerateColumns = false;
            costTable.DataSource = dt;
            costTable.Refresh();
            costTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleCost()
        {
            string query = "Select * from Cost Where id = '" + snotxt.Text + "'";

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
            typetxt.Text = dt.Rows[0]["type"].ToString();
            dtxt.Text = dt.Rows[0]["date"].ToString();
            pricetxt.Text = dt.Rows[0]["price"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadCost();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadCost();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string type = this.typetxt.Text;
            string date = this.dtxt.Text;
            string price = this.pricetxt.Text;

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Cost(type, date, price) Values ('" + type + "' , '" + date + "', " + price + ")";
                MessageBox.Show("Cost Info Successfully Inserted");
            }
            else
            {
                query = "UPDATE Cost SET date = '" + date + "', type = '" + type + "', price = " + price + " WHERE id = '" + snotxt.Text + "'";
                MessageBox.Show("Cost Info Successfully Updated");
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                this.LoadCost();
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

        private void costTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string pid = costTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                snotxt.Text = pid;
                this.LoadSingleCost();
            }
        }

        private void Factory_Cost_Load(object sender, EventArgs e)
        {
            LoadCost();
        }

        private void Factory_Cost_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbox_ValueChanged(object sender, EventArgs e)
        {
            string query = "Select * from Cost WHERE date = '" + tbox.Text + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            costTable.AutoGenerateColumns = false;
            costTable.DataSource = dt;
            costTable.Refresh();
            costTable.ClearSelection();

            this.Refresh();
        }
    }
}
