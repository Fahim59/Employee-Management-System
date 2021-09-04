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
    public partial class Employee_Reg : Form
    {
        private bool isNew = true;
        public Employee_Reg()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            phonetxt.Text = "";
            nidtxt.Text = "";
            dobtxt.Text = "";
            typetxt.Text = "";
            gendertxt.Text = "";
            prtxt.Text = "";
            pmtxt.Text = "";
            salarytxt.Text = "";
            statustxt.Text = "";
            tbox.Text = "";
            
            empTable.ClearSelection();
        }

        private void LoadEmpInfo()
        {
            string query = "Select * from Employee";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Employee.ename like '%" + searchtxt.Text + "%'";
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
            string query = "Select * from Employee Where id = '" + idtxt.Text + "'";

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
            nametxt.Text = dt.Rows[0]["ename"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
            nidtxt.Text = dt.Rows[0]["nid"].ToString();
            dobtxt.Text = dt.Rows[0]["dob"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            gendertxt.Text = dt.Rows[0]["gender"].ToString();
            prtxt.Text = dt.Rows[0]["praddress"].ToString();
            pmtxt.Text = dt.Rows[0]["pmaddress"].ToString();
            salarytxt.Text = dt.Rows[0]["salary"].ToString();
            statustxt.Text = dt.Rows[0]["status"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            LoadEmpInfo();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadEmpInfo();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string phone = this.phonetxt.Text;
            string nid = Convert.ToString(this.nidtxt.Text);
            string dob = this.dobtxt.Text;
            string type = this.typetxt.Text;
            string gender = this.gendertxt.Text;
            string praddress = this.prtxt.Text;
            string pmaddress = this.pmtxt.Text;
            string salary = Convert.ToString(this.salarytxt.Text);
            string status = this.statustxt.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(nid) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(praddress) || string.IsNullOrEmpty(pmaddress) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Employee(ename,phone,nid,dob,type,gender,praddress,pmaddress,salary,status) Values ('" + name + "', '" + phone + "', " + nid + ", '" + dob + "', '" + type + "', '" + gender + "', '" + praddress + "', '" + pmaddress + "', " + salary + ", '" + status + "')";
                MessageBox.Show("Employee Successfully Inserted");
            }
            else
            {
                query = "UPDATE Employee SET ename = '" + name + "', phone = '" + phone + "', nid = " + nid + ", dob = '" + dob + "', type = '" + type + "', gender = '" + gender + "', praddress = '" + praddress + "', pmaddress = '" + pmaddress + "', salary = " + salary + ", status = '" + status + "' WHERE id = '" + idtxt.Text + "'";
                MessageBox.Show("Employee Successfully Updated");
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

            string query = "Delete from Employee Where id = '" + idtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Book Deleted");
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

        private void Employee_Reg_Load(object sender, EventArgs e)
        {
            LoadEmpInfo();
        }

        private void empTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = empTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleEmp();
            }
        }

        private void Employee_Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Employee WHERE type = '" + tbox.SelectedItem + "'";

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
