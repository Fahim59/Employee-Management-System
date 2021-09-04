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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newEmpBtn_Click(object sender, EventArgs e)
        {
            Employee_Reg er = new Employee_Reg();
            this.Hide();
            er.Show();
        }

        private void daily_reportBtn_Click(object sender, EventArgs e)
        {
            Emp_Daily_Info dr = new Emp_Daily_Info();
            this.Hide();
            dr.Show();
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            Emp_Salary es = new Emp_Salary();
            this.Hide();
            es.Show();
        }

        private void sal_recordBtn_Click(object sender, EventArgs e)
        {
            Salary_Record sr = new Salary_Record();
            this.Hide();
            sr.Show();
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.Show();
        }

        private void dailyProductBtn_Click(object sender, EventArgs e)
        {
            Daily_Product d = new Daily_Product();
            this.Hide();
            d.Show();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            Current_Inventory ce = new Current_Inventory();
            this.Hide();
            ce.Show();
        }

        private void newCusBtn_Click(object sender, EventArgs e)
        {
            Customer_Details cd = new Customer_Details();
            this.Hide();
            cd.Show();
        }

        private void cOrderBtn_Click(object sender, EventArgs e)
        {
            Current_Orders co = new Current_Orders();
            this.Hide();
            co.Show();
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            new Report.PrintBill().Show();
        }

        private void chalanBtn_Click(object sender, EventArgs e)
        {
            new Report.PrintChalan().Show();
        }

        private void costBtn_Click(object sender, EventArgs e)
        {
            Factory_Cost fc = new Factory_Cost();
            this.Hide();
            fc.Show();
        }

        private void salaryRecordBtn_Click(object sender, EventArgs e)
        {
            Salary_Record sr = new Salary_Record();
            this.Hide();
            sr.Show();
        }

        private void sellRecordBtn_Click(object sender, EventArgs e)
        {
            Sell_Record sr = new Sell_Record();
            this.Hide();
            sr.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Visible = true;
            this.Visible = false;
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            Summary s = new Summary();
            this.Hide();
            s.Show();
        }
    }
}
