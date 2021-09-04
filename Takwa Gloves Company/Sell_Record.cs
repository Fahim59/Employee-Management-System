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
    public partial class Sell_Record : Form
    {
        private bool isNew = true;
        public Sell_Record()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            snotxt.Text = "";
            idtxt.Text = "";
            nametxt.Text = "";
            dtxt.Text = "";
            typetxt.Text = "";
            cnametxt.Text = "";
            costtxt.Text = "";
            pricetxt.Text = "";
            qtxt.Text = "";
            addtxt.Text = "";

            searchtxt.Text = "";

            sellTable.ClearSelection();
        }

        private void LoadSell()
        {
            string query = "Select * from [Order] ";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where [Order].name like '%" + searchtxt.Text + "%'";
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
        private void LoadSingleSell()
        {
            string query = "Select * from [Order] Where id = '" + snotxt.Text + "'";

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
            idtxt.Text = dt.Rows[0]["invoice"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            dtxt.Text = dt.Rows[0]["date"].ToString();
            cnametxt.Text = dt.Rows[0]["cname"].ToString();
            costtxt.Text = dt.Rows[0]["total"].ToString();
            pricetxt.Text = dt.Rows[0]["price"].ToString();
            qtxt.Text = dt.Rows[0]["quantity"].ToString();
            addtxt.Text = dt.Rows[0]["address"].ToString();
        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadSell();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadSell();
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
                snotxt.Text = pid;
                this.LoadSingleSell();
            }
        }

        private void Sell_Record_Load(object sender, EventArgs e)
        {
            LoadSell();
        }

        private void tbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Sell WHERE date = '" + tbox.Text + "'";

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

        private void Sell_Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
