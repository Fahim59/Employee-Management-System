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
using Microsoft.Reporting.WinForms;

namespace Takwa_Gloves_Company.Report
{
    public partial class PrintChalan : Form
    {
        public PrintChalan()
        {
            InitializeComponent();
        }

        private void PrintChalan_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MUSTAFIZ\FAHIMSQL;Initial Catalog=company;Integrated Security=True");

            //SqlDataAdapter sda = new SqlDataAdapter("select m.cname,m.phone,m.address,d.id,d.name,d.date,d.price,d.quantity,d.cost from Customer m inner join Sell d on m.cname = d.cname where d.id = '" + searchtxt.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter("select * from [Order] where invoice = '" + searchtxt.Text + "'", con);

            DataSet1 ds = new DataSet1();
            sda.Fill(ds, "DataTable_Bill");

            ReportDataSource rds = new ReportDataSource("DataSet_Report", ds.Tables[0]);

            //this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //this.reportViewer1.LocalReport.ReportPath = @"F:\C# Code\Takwa Gloves Company\Takwa Gloves Company\Report\Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
