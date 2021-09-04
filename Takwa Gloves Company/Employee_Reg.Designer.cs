namespace Takwa_Gloves_Company
{
    partial class Employee_Reg
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbox = new System.Windows.Forms.ComboBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.empTable = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delBtn = new System.Windows.Forms.Button();
            this.gendertxt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pmtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.prtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.statustxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dobtxt = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 466);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbox);
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 41);
            this.panel1.TabIndex = 0;
            // 
            // tbox
            // 
            this.tbox.BackColor = System.Drawing.Color.DarkCyan;
            this.tbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.tbox.FormattingEnabled = true;
            this.tbox.Items.AddRange(new object[] {
            "Jr. Mechanic",
            "Mechanic",
            "Overlock",
            "Packing"});
            this.tbox.Location = new System.Drawing.Point(50, 6);
            this.tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(122, 31);
            this.tbox.Sorted = true;
            this.tbox.TabIndex = 57;
            this.tbox.TabStop = false;
            this.tbox.Text = "Type";
            this.tbox.SelectedIndexChanged += new System.EventHandler(this.tbox_SelectedIndexChanged);
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.searchtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.searchtxt.Location = new System.Drawing.Point(281, 6);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(190, 30);
            this.searchtxt.TabIndex = 11;
            this.searchtxt.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Yellow;
            this.searchBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Location = new System.Drawing.Point(477, 4);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 35);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.refreshBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.refreshBtn.Location = new System.Drawing.Point(176, 4);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(99, 35);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(631, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 41);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(60, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "<< Employee Details >> ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.empTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 409);
            this.panel3.TabIndex = 2;
            // 
            // empTable
            // 
            this.empTable.AllowUserToAddRows = false;
            this.empTable.AllowUserToDeleteRows = false;
            this.empTable.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.empTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvename,
            this.dgvphone,
            this.dgvtype,
            this.dgvstatus});
            this.empTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empTable.Location = new System.Drawing.Point(0, 0);
            this.empTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empTable.Name = "empTable";
            this.empTable.ReadOnly = true;
            this.empTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empTable.Size = new System.Drawing.Size(622, 409);
            this.empTable.TabIndex = 0;
            this.empTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empTable_CellClick);
            // 
            // dgvid
            // 
            this.dgvid.DataPropertyName = "id";
            this.dgvid.HeaderText = "Emp ID";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 90;
            // 
            // dgvename
            // 
            this.dgvename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvename.DataPropertyName = "ename";
            this.dgvename.HeaderText = "Emp Name";
            this.dgvename.Name = "dgvename";
            this.dgvename.ReadOnly = true;
            // 
            // dgvphone
            // 
            this.dgvphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvphone.DataPropertyName = "phone";
            this.dgvphone.HeaderText = "Phone";
            this.dgvphone.Name = "dgvphone";
            this.dgvphone.ReadOnly = true;
            // 
            // dgvtype
            // 
            this.dgvtype.DataPropertyName = "type";
            this.dgvtype.HeaderText = "Type";
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.ReadOnly = true;
            // 
            // dgvstatus
            // 
            this.dgvstatus.DataPropertyName = "status";
            this.dgvstatus.HeaderText = "Status";
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.delBtn);
            this.panel4.Controls.Add(this.gendertxt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.pmtxt);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.prtxt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.salarytxt);
            this.panel4.Controls.Add(this.statustxt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dobtxt);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.typetxt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.nidtxt);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.phonetxt);
            this.panel4.Controls.Add(this.nametxt);
            this.panel4.Controls.Add(this.idtxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(631, 53);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 409);
            this.panel4.TabIndex = 3;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.delBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(92, 368);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(90, 35);
            this.delBtn.TabIndex = 107;
            this.delBtn.TabStop = false;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // gendertxt
            // 
            this.gendertxt.BackColor = System.Drawing.Color.DarkCyan;
            this.gendertxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.gendertxt.FormattingEnabled = true;
            this.gendertxt.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.gendertxt.Location = new System.Drawing.Point(159, 196);
            this.gendertxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(205, 29);
            this.gendertxt.TabIndex = 106;
            this.gendertxt.TabStop = false;
            this.gendertxt.Text = "Choose Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(0, 264);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 21);
            this.label12.TabIndex = 105;
            this.label12.Text = "Permanent Address:";
            // 
            // pmtxt
            // 
            this.pmtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.pmtxt.CausesValidation = false;
            this.pmtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.pmtxt.Location = new System.Drawing.Point(159, 262);
            this.pmtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pmtxt.Name = "pmtxt";
            this.pmtxt.Size = new System.Drawing.Size(205, 28);
            this.pmtxt.TabIndex = 104;
            this.pmtxt.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(21, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 21);
            this.label11.TabIndex = 103;
            this.label11.Text = "Present Address:";
            // 
            // prtxt
            // 
            this.prtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.prtxt.CausesValidation = false;
            this.prtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.prtxt.Location = new System.Drawing.Point(159, 229);
            this.prtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.prtxt.Name = "prtxt";
            this.prtxt.Size = new System.Drawing.Size(205, 28);
            this.prtxt.TabIndex = 102;
            this.prtxt.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(94, 297);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 97;
            this.label10.Text = "Salary:";
            // 
            // salarytxt
            // 
            this.salarytxt.BackColor = System.Drawing.Color.DarkCyan;
            this.salarytxt.CausesValidation = false;
            this.salarytxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.salarytxt.Location = new System.Drawing.Point(159, 294);
            this.salarytxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(205, 28);
            this.salarytxt.TabIndex = 96;
            this.salarytxt.TabStop = false;
            // 
            // statustxt
            // 
            this.statustxt.BackColor = System.Drawing.Color.DarkCyan;
            this.statustxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustxt.FormattingEnabled = true;
            this.statustxt.Items.AddRange(new object[] {
            "Active",
            "On Leave"});
            this.statustxt.Location = new System.Drawing.Point(159, 326);
            this.statustxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(205, 29);
            this.statustxt.TabIndex = 95;
            this.statustxt.TabStop = false;
            this.statustxt.Text = "Choose Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(92, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 94;
            this.label9.Text = "Status:";
            // 
            // dobtxt
            // 
            this.dobtxt.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dobtxt.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.dobtxt.CustomFormat = "yyyy-MM-dd";
            this.dobtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobtxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobtxt.Location = new System.Drawing.Point(159, 133);
            this.dobtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dobtxt.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dobtxt.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.Size = new System.Drawing.Size(205, 28);
            this.dobtxt.TabIndex = 93;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(2, 368);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 35);
            this.saveBtn.TabIndex = 92;
            this.saveBtn.TabStop = false;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(276, 368);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(90, 35);
            this.logoutBtn.TabIndex = 91;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.backBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(185, 368);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 35);
            this.backBtn.TabIndex = 90;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(89, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 88;
            this.label8.Text = "Gender:";
            // 
            // typetxt
            // 
            this.typetxt.BackColor = System.Drawing.Color.DarkCyan;
            this.typetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Jr. Mechanic",
            "Mechanic",
            "Overlock",
            "Packing"});
            this.typetxt.Location = new System.Drawing.Point(158, 165);
            this.typetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(206, 29);
            this.typetxt.TabIndex = 87;
            this.typetxt.TabStop = false;
            this.typetxt.Text = "Choose Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(105, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 86;
            this.label7.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(39, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Date of Birth:";
            // 
            // nidtxt
            // 
            this.nidtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.nidtxt.CausesValidation = false;
            this.nidtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.nidtxt.Location = new System.Drawing.Point(159, 101);
            this.nidtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nidtxt.Name = "nidtxt";
            this.nidtxt.Size = new System.Drawing.Size(205, 28);
            this.nidtxt.TabIndex = 84;
            this.nidtxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(81, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 83;
            this.label1.Text = "NID No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Phone No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Employee Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(48, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 80;
            this.label5.Text = "Employee ID:";
            // 
            // phonetxt
            // 
            this.phonetxt.BackColor = System.Drawing.Color.DarkCyan;
            this.phonetxt.CausesValidation = false;
            this.phonetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.phonetxt.Location = new System.Drawing.Point(159, 69);
            this.phonetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(205, 28);
            this.phonetxt.TabIndex = 79;
            this.phonetxt.TabStop = false;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.DarkCyan;
            this.nametxt.CausesValidation = false;
            this.nametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.nametxt.Location = new System.Drawing.Point(159, 37);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(205, 28);
            this.nametxt.TabIndex = 78;
            this.nametxt.TabStop = false;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.idtxt.CausesValidation = false;
            this.idtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.idtxt.Location = new System.Drawing.Point(159, 5);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(205, 28);
            this.idtxt.TabIndex = 77;
            this.idtxt.TabStop = false;
            // 
            // Employee_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1001, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Employee_Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Employee Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employee_Reg_FormClosed);
            this.Load += new System.EventHandler(this.Employee_Reg_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tbox;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView empTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Button saveBtn;
        internal System.Windows.Forms.DateTimePicker dobtxt;
        private System.Windows.Forms.ComboBox statustxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pmtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox prtxt;
        private System.Windows.Forms.ComboBox gendertxt;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;

    }
}