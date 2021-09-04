namespace Takwa_Gloves_Company.Report
{
    partial class PrintChalan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.DataSet1 = new Takwa_Gloves_Company.Report.DataSet1();
            this.DataTable_BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_BillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkCyan;
            reportDataSource1.Name = "DataSet_Report";
            reportDataSource1.Value = this.DataTable_BillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Takwa_Gloves_Company.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(606, 498);
            this.reportViewer1.TabIndex = 1;
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.searchtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.searchtxt.Location = new System.Drawing.Point(153, 9);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(190, 30);
            this.searchtxt.TabIndex = 15;
            this.searchtxt.TabStop = false;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Yellow;
            this.printBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.printBtn.Location = new System.Drawing.Point(349, 7);
            this.printBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(88, 35);
            this.printBtn.TabIndex = 14;
            this.printBtn.TabStop = false;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_BillBindingSource
            // 
            this.DataTable_BillBindingSource.DataMember = "DataTable_Bill";
            this.DataTable_BillBindingSource.DataSource = this.DataSet1;
            // 
            // PrintChalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(607, 546);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PrintChalan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Chalan";
            this.Load += new System.EventHandler(this.PrintChalan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_BillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.BindingSource DataTable_BillBindingSource;
        private DataSet1 DataSet1;
    }
}