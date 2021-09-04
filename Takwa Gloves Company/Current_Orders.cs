using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Takwa_Gloves_Company
{
    public partial class Current_Orders : Form
    {
        private bool isNew = true;
        public Current_Orders()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            dtxt.Text = "";
            typetxt.Text = "";
            cnametxt.Text = "";
            phonetxt.Text = "";
            wtxt.Text = "";
            stxt.Text = "";
            pricetxt.Text = "";
            qtxt.Text = "";
            addtxt.Text = "";
            totaltxt.Text = "";

            searchtxt.Text = "";

            nettxt.Text = "";
            
            sellTable.ClearSelection();
        }

        private void LoadOrder()
        {
            string query = "Select * from Product";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Product.name like '%" + searchtxt.Text + "%'";
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

        private void LoadSingleOrder()
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
        private void LoadOrderInfo()
        {
            string query = "Select * from Product";
            string query1 = "Select * from Customer";

            DataTable dt = DatabaseConnection.GetData(query);
            DataTable dt1 = DatabaseConnection.GetData(query1);

            if (dt == null)
                return;

            if (dt1 == null)
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

            pricetxt.DataSource = dt;
            pricetxt.DisplayMember = "price";
            pricetxt.ValueMember = "price";

            cnametxt.DataSource = dt1;
            cnametxt.DisplayMember = "cname";
            cnametxt.ValueMember = "cname";

            addtxt.DataSource = dt1;
            addtxt.DisplayMember = "address";
            addtxt.ValueMember = "address";

            phonetxt.DataSource = dt1;
            phonetxt.DisplayMember = "phone";
            phonetxt.ValueMember = "phone";
        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void Check()
        {
            for (int i = orderView.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = orderView.Items[i];

                if (item.SubItems[2].Text == "0")
                {
                    item.Remove();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (orderView.Items.Count > 0)
            {
                string id = this.idtxt.Text;
                string name = this.nametxt.Text;
                string type = this.typetxt.Text;
                string weight = this.wtxt.Text;
                string size = this.stxt.Text;
                string price = this.pricetxt.Text;

                string date = this.dtxt.Text;
                string cname = this.cnametxt.Text;
                string quantity = this.qtxt.Text;
                string address = this.addtxt.Text;
                string phone = this.phonetxt.Text;
                string sub = this.nettxt.Text;

                string total = this.nettxt.Text;

                if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(cname) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(total))
                {
                    MessageBox.Show("Invalid/Insufficient information");
                    return;
                }
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=MUSTAFIZ\FAHIMSQL;Initial Catalog=company;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "INSERT into Invoice(date) Values" + "(getdate()) select SCOPE_IDENTITY()";

                    string invoiceId = cmd.ExecuteScalar().ToString();

                    foreach (ListViewItem ListItem in orderView.Items)
                    {
                        cmd.CommandText = "INSERT into [Order](invoice,name,price,quantity,date,total,type,cname,address,phone) Values" + "(" + invoiceId + ",'" + ListItem.SubItems[0].Text + "', '" + ListItem.SubItems[1].Text + "', '" + ListItem.SubItems[2].Text + "', '" + date + "', '" + ListItem.SubItems[3].Text + "', '" + ListItem.SubItems[4].Text + "', '" + cname + "', '" + address + "', '" + phone + "')";
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "Update Invoice Set subtotal = " + sub + " WHERE Invoice = '" + invoiceId + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Invoice Successfully Inserted with InvoiceID: " + invoiceId);

                    //new Report.Print_Invoice(invoiceId).Show();

                    this.Refresh();
                    orderView.Items.Clear();
                    sellTable.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Atleast 1 item must be added in the cart");
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

        private void Current_Orders_Load(object sender, EventArgs e)
        {
            LoadOrder();
            LoadOrderInfo();

            Refresh();
        }

        private void Current_Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sellTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string pid = sellTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = pid;
                this.LoadSingleOrder();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
            orderView.Items.Clear();
            //sellTable.DataSource = null;
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (qtxt.Text == "")
            {
                MessageBox.Show("Enter Quantity");
                qtxt.Focus();
                return;
            }
            else if (isNew == true)
            {
                MessageBox.Show("Choose any Item");
                return;
            }

            string[] ar = new string[5];
            ar[0] = nametxt.Text;
            ar[1] = pricetxt.Text;
            ar[2] = qtxt.Text;
            ar[3] = totaltxt.Text;
            ar[4] = typetxt.Text;

            ListViewItem lvi = new ListViewItem(ar);

            for (int i = orderView.Items.Count - 1; i >= 0; i--)
            {
                if (orderView.Items[i].ToString().ToLower().Contains(nametxt.Text.ToLower()))
                {
                    orderView.Items[i].SubItems[2].Text = (Convert.ToInt32(orderView.Items[i].SubItems[2].Text) + Convert.ToInt32(qtxt.Text)).ToString();
                    orderView.Items[i].SubItems[3].Text = (Convert.ToInt32(orderView.Items[i].SubItems[2].Text) * Convert.ToInt32(pricetxt.Text)).ToString();
                    Refresh();
                    return;
                }
            }
            orderView.Items.Add(lvi);
            Refresh();
        }

        private void qtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (qtxt.Text.Length > 0)
                {
                    totaltxt.Text = (Convert.ToInt32(pricetxt.Text) * Convert.ToInt32(qtxt.Text)).ToString();
                    sellTable.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Integer Only!");
                qtxt.Text = "";
                qtxt.Focus();
            }
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
            qtxt.Text = "";
            qtxt.Focus();
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            if (orderView.SelectedItems.Count > 0)
            {
                for (int i = 0; i < orderView.Items.Count; i++)
                {
                    if (orderView.Items[i].Selected)
                    {
                        //subtxt.Text = (Convert.ToInt32(subtxt.Text) - Convert.ToInt32(orderView.Items[i].SubItems[3].Text)).ToString();
                        orderView.Items[i].Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderView.SelectedItems != null)
                {
                    ListViewItem item = orderView.SelectedItems[0];
                    item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) + Convert.ToInt32(1)).ToString();
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text)).ToString();

                    orderView.SelectedItems.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderView.SelectedItems != null)
                {
                    ListViewItem item = orderView.SelectedItems[0];

                    if (item.SubItems[2].Text == "0")
                    {
                        item.SubItems[2].Text = "0";
                        return;
                    }
                    item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) - Convert.ToInt32(1)).ToString();
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text)).ToString();

                    orderView.SelectedItems.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            Check();

            if (orderView.Items.Count > 0)
            {
                double sum = 0;
                foreach (ListViewItem lstItem in orderView.Items)
                {
                    sum += double.Parse(lstItem.SubItems[3].Text);
                    nettxt.Text = sum.ToString();
                }
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }
    }
}
