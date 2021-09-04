namespace Takwa_Gloves_Company
{
    partial class Emp_Daily_Info
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
            this.dempTable = new System.Windows.Forms.DataGridView();
            this.dgvsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nametxt = new System.Windows.Forms.ComboBox();
            this.idtxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.snotxt = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtimetxt = new System.Windows.Forms.TextBox();
            this.extxt = new System.Windows.Forms.DateTimePicker();
            this.entxt = new System.Windows.Forms.DateTimePicker();
            this.dobtxt = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dempTable)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1031, 412);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.panel1.Size = new System.Drawing.Size(633, 43);
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
            this.tbox.Location = new System.Drawing.Point(44, 5);
            this.tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(135, 31);
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
            this.searchtxt.Location = new System.Drawing.Point(283, 6);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(213, 30);
            this.searchtxt.TabIndex = 11;
            this.searchtxt.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Yellow;
            this.searchBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Location = new System.Drawing.Point(498, 3);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 36);
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
            this.refreshBtn.Location = new System.Drawing.Point(182, 3);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(99, 36);
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
            this.panel2.Location = new System.Drawing.Point(642, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 43);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(48, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "<< Employee Daily Details >> ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dempTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 353);
            this.panel3.TabIndex = 2;
            // 
            // dempTable
            // 
            this.dempTable.AllowUserToAddRows = false;
            this.dempTable.AllowUserToDeleteRows = false;
            this.dempTable.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dempTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dempTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsno,
            this.dgvdate,
            this.dgvename,
            this.dgvetime,
            this.dgvltime,
            this.dgvdtime});
            this.dempTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dempTable.Location = new System.Drawing.Point(0, 0);
            this.dempTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dempTable.Name = "dempTable";
            this.dempTable.ReadOnly = true;
            this.dempTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dempTable.Size = new System.Drawing.Size(633, 353);
            this.dempTable.TabIndex = 0;
            this.dempTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dempTable_CellClick);
            // 
            // dgvsno
            // 
            this.dgvsno.DataPropertyName = "id";
            this.dgvsno.FillWeight = 257.732F;
            this.dgvsno.HeaderText = "Serial";
            this.dgvsno.Name = "dgvsno";
            this.dgvsno.ReadOnly = true;
            this.dgvsno.Width = 60;
            // 
            // dgvdate
            // 
            this.dgvdate.DataPropertyName = "date";
            this.dgvdate.HeaderText = "Date";
            this.dgvdate.Name = "dgvdate";
            this.dgvdate.ReadOnly = true;
            // 
            // dgvename
            // 
            this.dgvename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvename.DataPropertyName = "ename";
            this.dgvename.FillWeight = 60.56701F;
            this.dgvename.HeaderText = "Emp Name";
            this.dgvename.Name = "dgvename";
            this.dgvename.ReadOnly = true;
            // 
            // dgvetime
            // 
            this.dgvetime.DataPropertyName = "etime";
            this.dgvetime.FillWeight = 60.56701F;
            this.dgvetime.HeaderText = "Entry Time";
            this.dgvetime.Name = "dgvetime";
            this.dgvetime.ReadOnly = true;
            this.dgvetime.Width = 115;
            // 
            // dgvltime
            // 
            this.dgvltime.DataPropertyName = "ltime";
            this.dgvltime.FillWeight = 60.56701F;
            this.dgvltime.HeaderText = "Leave Time";
            this.dgvltime.Name = "dgvltime";
            this.dgvltime.ReadOnly = true;
            this.dgvltime.Width = 115;
            // 
            // dgvdtime
            // 
            this.dgvdtime.DataPropertyName = "dtime";
            this.dgvdtime.FillWeight = 60.56701F;
            this.dgvdtime.HeaderText = "Delay";
            this.dgvdtime.Name = "dgvdtime";
            this.dgvdtime.ReadOnly = true;
            this.dgvdtime.Width = 70;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.nametxt);
            this.panel4.Controls.Add(this.idtxt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.snotxt);
            this.panel4.Controls.Add(this.delBtn);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtimetxt);
            this.panel4.Controls.Add(this.extxt);
            this.panel4.Controls.Add(this.entxt);
            this.panel4.Controls.Add(this.dobtxt);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Controls.Add(this.typetxt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(642, 55);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 353);
            this.panel4.TabIndex = 3;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.DarkCyan;
            this.nametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.nametxt.FormattingEnabled = true;
            this.nametxt.Location = new System.Drawing.Point(135, 83);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(228, 29);
            this.nametxt.TabIndex = 102;
            this.nametxt.TabStop = false;
            this.nametxt.Text = "Choose Employee";
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.idtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.idtxt.FormattingEnabled = true;
            this.idtxt.Location = new System.Drawing.Point(135, 46);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(228, 29);
            this.idtxt.TabIndex = 101;
            this.idtxt.TabStop = false;
            this.idtxt.Text = "Choose Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(50, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 100;
            this.label9.Text = "Serial No:";
            // 
            // snotxt
            // 
            this.snotxt.BackColor = System.Drawing.Color.DarkCyan;
            this.snotxt.CausesValidation = false;
            this.snotxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.snotxt.Location = new System.Drawing.Point(135, 10);
            this.snotxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.snotxt.Name = "snotxt";
            this.snotxt.ReadOnly = true;
            this.snotxt.Size = new System.Drawing.Size(227, 28);
            this.snotxt.TabIndex = 99;
            this.snotxt.TabStop = false;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.delBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.delBtn.Location = new System.Drawing.Point(90, 311);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(102, 36);
            this.delBtn.TabIndex = 98;
            this.delBtn.TabStop = false;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(38, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 97;
            this.label8.Text = "Delay Time:";
            // 
            // dtimetxt
            // 
            this.dtimetxt.BackColor = System.Drawing.Color.DarkCyan;
            this.dtimetxt.CausesValidation = false;
            this.dtimetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtimetxt.Location = new System.Drawing.Point(136, 269);
            this.dtimetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtimetxt.Name = "dtimetxt";
            this.dtimetxt.Size = new System.Drawing.Size(227, 28);
            this.dtimetxt.TabIndex = 96;
            this.dtimetxt.TabStop = false;
            // 
            // extxt
            // 
            this.extxt.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.extxt.Location = new System.Drawing.Point(136, 158);
            this.extxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extxt.Name = "extxt";
            this.extxt.Size = new System.Drawing.Size(226, 28);
            this.extxt.TabIndex = 95;
            this.extxt.Value = new System.DateTime(2021, 8, 24, 14, 51, 0, 0);
            // 
            // entxt
            // 
            this.entxt.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.entxt.Location = new System.Drawing.Point(136, 120);
            this.entxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entxt.Name = "entxt";
            this.entxt.Size = new System.Drawing.Size(226, 28);
            this.entxt.TabIndex = 94;
            this.entxt.Value = new System.DateTime(2021, 8, 24, 14, 51, 0, 0);
            // 
            // dobtxt
            // 
            this.dobtxt.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dobtxt.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.dobtxt.CustomFormat = "yyyy-MM-dd";
            this.dobtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobtxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobtxt.Location = new System.Drawing.Point(136, 194);
            this.dobtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dobtxt.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dobtxt.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.Size = new System.Drawing.Size(227, 28);
            this.dobtxt.TabIndex = 93;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(2, 311);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 36);
            this.saveBtn.TabIndex = 92;
            this.saveBtn.TabStop = false;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.logoutBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.Location = new System.Drawing.Point(281, 311);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(102, 36);
            this.logoutBtn.TabIndex = 91;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.backBtn.Location = new System.Drawing.Point(193, 311);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(87, 36);
            this.backBtn.TabIndex = 90;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // typetxt
            // 
            this.typetxt.BackColor = System.Drawing.Color.DarkCyan;
            this.typetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Jr. Mechanic",
            "Mechanic",
            "Overlock",
            "Packing"});
            this.typetxt.Location = new System.Drawing.Point(135, 231);
            this.typetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(228, 29);
            this.typetxt.TabIndex = 87;
            this.typetxt.TabStop = false;
            this.typetxt.Text = "Choose Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 86;
            this.label7.Text = "Employee Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(84, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 83;
            this.label1.Text = "Leave Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Entry Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 86);
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
            this.label5.Location = new System.Drawing.Point(27, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 80;
            this.label5.Text = "Employee ID:";
            // 
            // Emp_Daily_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1031, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Emp_Daily_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Daily Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Emp_Daily_Info_FormClosed);
            this.Load += new System.EventHandler(this.Emp_Daily_Info_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dempTable)).EndInit();
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
        private System.Windows.Forms.DataGridView dempTable;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.DateTimePicker dobtxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker extxt;
        private System.Windows.Forms.DateTimePicker entxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dtimetxt;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox snotxt;
        private System.Windows.Forms.ComboBox idtxt;
        private System.Windows.Forms.ComboBox nametxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdtime;

    }
}