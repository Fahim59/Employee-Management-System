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
    public partial class Emp_Daily_Info : Form
    {
        private bool isNew = true;
        public Emp_Daily_Info()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            snotxt.Text = "";
            //idtxt.Text = "";
            //nametxt.Text = "";
            entxt.Text = "";
            extxt.Text = "";
            dobtxt.Text = "";
            typetxt.Text = "";
            dtimetxt.Text = "";
            searchtxt.Text = "";
            tbox.Text = "";

            dempTable.ClearSelection();
        }

        private void LoadEmpInfo()
        {
            string query = "Select * from Emp_Info";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Emp_Info.ename like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            dempTable.AutoGenerateColumns = false;
            dempTable.DataSource = dt;
            dempTable.Refresh();
            dempTable.ClearSelection();

            this.Refresh();
        }

        private void Emp_Daily_Info_Load(object sender, EventArgs e)
        {
            LoadEmpInfo();
            LoadEmployee();
        }

        private void LoadEmployee()
        {
            string query = "Select * from Employee";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            idtxt.DataSource = dt;
            idtxt.DisplayMember = "id";
            idtxt.ValueMember = "id";

            nametxt.DataSource = dt;
            nametxt.DisplayMember = "ename";
            nametxt.ValueMember = "ename";
        }

        private void LoadSingleEmp()
        {
            //string query = "Select * from Emp_Info Where empid = '" + idtxt.Text + "'";
            string query = "Select * from Emp_Info Where id = '" + snotxt.Text + "'";

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
            dobtxt.Text = dt.Rows[0]["date"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            entxt.Text = dt.Rows[0]["etime"].ToString();
            extxt.Text = dt.Rows[0]["ltime"].ToString();
            dtimetxt.Text = dt.Rows[0]["dtime"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEmpInfo();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadEmpInfo();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.snotxt.Text;
            string eid = Convert.ToString(this.idtxt.Text);
            string name = this.nametxt.Text;
            string dob = this.dobtxt.Text;
            string type = this.typetxt.Text;
            string etime = Convert.ToString(this.entxt.Text);
            string ltime = Convert.ToString(this.extxt.Text);
            string dtime = Convert.ToString(this.dtimetxt.Text);

            if (string.IsNullOrEmpty(eid) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(etime) || string.IsNullOrEmpty(ltime) || string.IsNullOrEmpty(dtime))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Emp_Info(empid, ename, etime,ltime,date,type,dtime) Values (" + eid + ",'" + name + "', '" + etime + "', '" + ltime + "', '" + dob + "', '" + type + "', '" + dtime + "');";
                MessageBox.Show("Employee Info Successfully Inserted");
            }
            else
            {
                query = "UPDATE Emp_Info SET empid = '" + eid + "', ename = '" + name + "', etime = '" + etime + "', ltime = '" + ltime + "', date = '" + dob + "', type = '" + type + "', dtime = '" + dtime + "' WHERE empid = '" + idtxt.Text + "'";
                MessageBox.Show("Employee Info Successfully Updated");
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                this.LoadEmpInfo();
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

            string query = "Delete from Emp_Info Where id = '" + snotxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Employee Info Deleted");
                this.LoadEmpInfo();
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

        private void Emp_Daily_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Emp_Info WHERE type = '" + tbox.SelectedItem + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            dempTable.AutoGenerateColumns = false;
            dempTable.DataSource = dt;
            dempTable.Refresh();
            dempTable.ClearSelection();

            this.Refresh();
        }

        private void dempTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dempTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                //idtxt.Text = id;
                snotxt.Text = id;
                this.LoadSingleEmp();
            }
        }
    }
}
