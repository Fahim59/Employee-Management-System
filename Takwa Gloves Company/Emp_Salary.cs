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
    public partial class Emp_Salary : Form
    {
        private bool isNew = true;
        public Emp_Salary()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            snotxt.Text = "";
            //idtxt.Text = "";
            //nametxt.Text = "";
            wtxt.Text = "";
            atxt.Text = "";
            stxt.Text = "";
            typetxt.Text = "";
            mtxt.Text = "";
            mdaytxt.Text = "";
            tsaltxt.Text = "";
            salarytxt.Text = "";
            tbox.Text = "";
            otimetxt.Text = "";

            sempTable.ClearSelection();
        }

        private void LoadEmpInfo()
        {
            string query = "Select * from Salary";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Salary.ename like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            sempTable.AutoGenerateColumns = false;
            sempTable.DataSource = dt;
            sempTable.Refresh();
            sempTable.ClearSelection();

            this.Refresh();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEmpInfo();
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
            string query = "Select * from Salary Where id = '" + snotxt.Text + "'";

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
            wtxt.Text = dt.Rows[0]["wday"].ToString();
            atxt.Text = dt.Rows[0]["aday"].ToString();
            stxt.Text = dt.Rows[0]["date"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            mtxt.Text = dt.Rows[0]["month"].ToString();
            mdaytxt.Text = dt.Rows[0]["mday"].ToString();
            otimetxt.Text = dt.Rows[0]["otime"].ToString();
            salarytxt.Text = dt.Rows[0]["rsalary"].ToString();
            tsaltxt.Text = dt.Rows[0]["tsalary"].ToString();
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
            string wday = Convert.ToString(this.wtxt.Text);
            string aday = Convert.ToString(this.atxt.Text);
            string date = this.stxt.Text;
            string type = this.typetxt.Text;
            string month = this.mtxt.Text;
            string mday = Convert.ToString(this.mdaytxt.Text);
            string otime = Convert.ToString(this.otimetxt.Text);
            string tsal = Convert.ToString(this.tsaltxt.Text);
            string rsal = Convert.ToString(this.salarytxt.Text);

            if (string.IsNullOrEmpty(eid) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(wday) || string.IsNullOrEmpty(aday) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(tsal) || string.IsNullOrEmpty(rsal))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Salary(empid, ename, wday,aday,date,type,tsalary,rsalary,month,mday,otime) Values (" + eid + ",'" + name + "', " + wday + ", " + aday + ", '" + date + "', '" + type + "', " + tsal + " , " + rsal + ", '" + month + "', " + mday + ", " + otime + "); INSERT into Sal_Record(empid, ename, month, date, salary, type) Values (" + eid + ",'" + name + "', '" + month + "', '" + date + "', " + rsal + ", '" + type + "')";
                MessageBox.Show("Employee Salary Info Successfully Inserted");
            }
            else
            {
                query = "UPDATE Salary SET empid = '" + eid + "', ename = '" + name + "', wday = " + wday + ", aday = " + aday + ", date = '" + date + "', type = '" + type + "', tsalary = " + tsal + ", rsalary = " + rsal + ", month = '" + month + "' , mday = " + mday + " , otime = " + otime + " WHERE empid = '" + idtxt.Text + "'; UPDATE Sal_Record SET empid = '" + eid + "', ename = '" + name + "', month = '" + month + "', date = '" + date + "', salary = " + rsal + ", type = '" + type + "' WHERE empid = '" + idtxt.Text + "'";
                MessageBox.Show("Employee Salary Info Successfully Updated");
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

            string query = "Delete from Salary Where id = '" + snotxt.Text + "'";

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

        private void Emp_Salary_Load(object sender, EventArgs e)
        {
            LoadEmpInfo();
            LoadEmployee();
        }

        private void Emp_Salary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sempTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = sempTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                //idtxt.Text = id;
                snotxt.Text = id;
                this.LoadSingleEmp();
            }
        }

        private void tbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Salary WHERE type = '" + tbox.SelectedItem + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            sempTable.AutoGenerateColumns = false;
            sempTable.DataSource = dt;
            sempTable.Refresh();
            sempTable.ClearSelection();

            this.Refresh();
        }

        private void calculatetxt_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double otime = 0;

            otime = Math.Round(((Convert.ToDouble(tsaltxt.Text) / Convert.ToDouble(mdaytxt.Text))) / 8 * Convert.ToDouble(otimetxt.Text), 2);

            sum = Math.Round((Convert.ToDouble(tsaltxt.Text) / Convert.ToDouble(mdaytxt.Text)) * Convert.ToDouble(wtxt.Text), 2) + otime;
            salarytxt.Text = sum.ToString();

        }
    }
}
