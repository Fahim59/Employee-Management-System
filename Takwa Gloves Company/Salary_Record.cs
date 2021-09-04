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
    public partial class Salary_Record : Form
    {
        private bool isNew = true;
        public Salary_Record()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            snotxt.Text = "";
            idtxt.Text = "";
            nametxt.Text = "";
            stxt.Text = "";
            typetxt.Text = "";
            mtxt.Text = "";
            tsaltxt.Text = "";
            tbox.Text = "";
            searchtxt.Text = "";

            empTable.ClearSelection();
        }

        private void LoadEmpInfo()
        {
            string query = "Select * from Sal_Record";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Sal_Record.ename like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            empTable.AutoGenerateColumns = false;
            empTable.DataSource = dt;
            empTable.Refresh();
            empTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleEmp()
        {
            string query = "Select * from Sal_Record Where id = '" + snotxt.Text + "'";

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
            idtxt.Text = dt.Rows[0]["empid"].ToString();
            nametxt.Text = dt.Rows[0]["ename"].ToString();
            mtxt.Text = dt.Rows[0]["month"].ToString();
            stxt.Text = dt.Rows[0]["date"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            tsaltxt.Text = dt.Rows[0]["salary"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEmpInfo();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadEmpInfo();
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

        private void Salary_Record_Load(object sender, EventArgs e)
        {
            LoadEmpInfo();
        }

        private void Salary_Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void empTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = empTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                snotxt.Text = id;
                this.LoadSingleEmp();
            }
        }

        private void tbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Sal_Record WHERE month = '" + tbox.SelectedItem + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            empTable.AutoGenerateColumns = false;
            empTable.DataSource = dt;
            empTable.Refresh();
            empTable.ClearSelection();

            this.Refresh();
        }
    }
}
