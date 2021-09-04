namespace Takwa_Gloves_Company
{
    partial class Emp_Salary
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
            this.sempTable = new System.Windows.Forms.DataGridView();
            this.dgvsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvrsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgvmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.otimetxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tsaltxt = new System.Windows.Forms.TextBox();
            this.mtxt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.ComboBox();
            this.idtxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.snotxt = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.calculatetxt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mdaytxt = new System.Windows.Forms.TextBox();
            this.wtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.atxt = new System.Windows.Forms.TextBox();
            this.stxt = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sempTable)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 472);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.panel1.Size = new System.Drawing.Size(593, 42);
            this.panel1.TabIndex = 0;
            // 
            // tbox
            // 
            this.tbox.BackColor = System.Drawing.Color.DarkCyan;
            this.tbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox.FormattingEnabled = true;
            this.tbox.Items.AddRange(new object[] {
            "Jr. Mechanic",
            "Mechanic",
            "Overlock",
            "Packing"});
            this.tbox.Location = new System.Drawing.Point(9, 4);
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
            this.searchtxt.Location = new System.Drawing.Point(258, 5);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(213, 30);
            this.searchtxt.TabIndex = 11;
            this.searchtxt.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Yellow;
            this.searchBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(478, 2);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(103, 36);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.refreshBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(149, 2);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(103, 36);
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
            this.panel2.Location = new System.Drawing.Point(602, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 42);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "<< Employee Salary Details >> ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sempTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 414);
            this.panel3.TabIndex = 2;
            // 
            // sempTable
            // 
            this.sempTable.AllowUserToAddRows = false;
            this.sempTable.AllowUserToDeleteRows = false;
            this.sempTable.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.sempTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sempTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsno,
            this.dgvname,
            this.dgvsalary,
            this.dgvrsal,
            this.fgvmonth});
            this.sempTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sempTable.Location = new System.Drawing.Point(0, 0);
            this.sempTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sempTable.Name = "sempTable";
            this.sempTable.ReadOnly = true;
            this.sempTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sempTable.Size = new System.Drawing.Size(593, 414);
            this.sempTable.TabIndex = 0;
            this.sempTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sempTable_CellContentClick);
            // 
            // dgvsno
            // 
            this.dgvsno.DataPropertyName = "id";
            this.dgvsno.HeaderText = "Serial";
            this.dgvsno.Name = "dgvsno";
            this.dgvsno.ReadOnly = true;
            this.dgvsno.Width = 60;
            // 
            // dgvname
            // 
            this.dgvname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvname.DataPropertyName = "ename";
            this.dgvname.HeaderText = "Emp Name";
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            // 
            // dgvsalary
            // 
            this.dgvsalary.DataPropertyName = "tsalary";
            this.dgvsalary.HeaderText = "Salary";
            this.dgvsalary.Name = "dgvsalary";
            this.dgvsalary.ReadOnly = true;
            this.dgvsalary.Width = 85;
            // 
            // dgvrsal
            // 
            this.dgvrsal.DataPropertyName = "rsalary";
            this.dgvrsal.HeaderText = "Rec Salary";
            this.dgvrsal.Name = "dgvrsal";
            this.dgvrsal.ReadOnly = true;
            this.dgvrsal.Width = 120;
            // 
            // fgvmonth
            // 
            this.fgvmonth.DataPropertyName = "month";
            this.fgvmonth.HeaderText = "Month";
            this.fgvmonth.Name = "fgvmonth";
            this.fgvmonth.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.otimetxt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.tsaltxt);
            this.panel4.Controls.Add(this.mtxt);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.nametxt);
            this.panel4.Controls.Add(this.idtxt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.snotxt);
            this.panel4.Controls.Add(this.delBtn);
            this.panel4.Controls.Add(this.calculatetxt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.salarytxt);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.mdaytxt);
            this.panel4.Controls.Add(this.wtxt);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.atxt);
            this.panel4.Controls.Add(this.stxt);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Controls.Add(this.typetxt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(602, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 414);
            this.panel4.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 277);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 21);
            this.label13.TabIndex = 114;
            this.label13.Text = "Over Time:";
            // 
            // otimetxt
            // 
            this.otimetxt.BackColor = System.Drawing.Color.DarkCyan;
            this.otimetxt.CausesValidation = false;
            this.otimetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.otimetxt.Location = new System.Drawing.Point(138, 275);
            this.otimetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.otimetxt.Name = "otimetxt";
            this.otimetxt.Size = new System.Drawing.Size(227, 28);
            this.otimetxt.TabIndex = 113;
            this.otimetxt.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 246);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 21);
            this.label12.TabIndex = 112;
            this.label12.Text = "Total Salary:";
            // 
            // tsaltxt
            // 
            this.tsaltxt.BackColor = System.Drawing.Color.DarkCyan;
            this.tsaltxt.CausesValidation = false;
            this.tsaltxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsaltxt.Location = new System.Drawing.Point(138, 244);
            this.tsaltxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tsaltxt.Name = "tsaltxt";
            this.tsaltxt.Size = new System.Drawing.Size(227, 28);
            this.tsaltxt.TabIndex = 111;
            this.tsaltxt.TabStop = false;
            // 
            // mtxt
            // 
            this.mtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.mtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt.FormattingEnabled = true;
            this.mtxt.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.mtxt.Location = new System.Drawing.Point(138, 212);
            this.mtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.mtxt.Name = "mtxt";
            this.mtxt.Size = new System.Drawing.Size(226, 29);
            this.mtxt.TabIndex = 110;
            this.mtxt.TabStop = false;
            this.mtxt.Text = "Choose Month";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(71, 215);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 109;
            this.label11.Text = "Month:";
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.DarkCyan;
            this.nametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.nametxt.FormattingEnabled = true;
            this.nametxt.Location = new System.Drawing.Point(139, 59);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(228, 29);
            this.nametxt.TabIndex = 108;
            this.nametxt.TabStop = false;
            this.nametxt.Text = "Choose Employee";
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.idtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.idtxt.FormattingEnabled = true;
            this.idtxt.Location = new System.Drawing.Point(139, 29);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(228, 29);
            this.idtxt.TabIndex = 107;
            this.idtxt.TabStop = false;
            this.idtxt.Text = "Choose Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(48, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 106;
            this.label9.Text = "Serial No:";
            // 
            // snotxt
            // 
            this.snotxt.BackColor = System.Drawing.Color.DarkCyan;
            this.snotxt.CausesValidation = false;
            this.snotxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.snotxt.Location = new System.Drawing.Point(139, 0);
            this.snotxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.snotxt.Name = "snotxt";
            this.snotxt.ReadOnly = true;
            this.snotxt.Size = new System.Drawing.Size(227, 28);
            this.snotxt.TabIndex = 105;
            this.snotxt.TabStop = false;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.delBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.delBtn.Location = new System.Drawing.Point(111, 372);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(91, 36);
            this.delBtn.TabIndex = 104;
            this.delBtn.TabStop = false;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // calculatetxt
            // 
            this.calculatetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.calculatetxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatetxt.Location = new System.Drawing.Point(369, 332);
            this.calculatetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculatetxt.Name = "calculatetxt";
            this.calculatetxt.Size = new System.Drawing.Size(40, 32);
            this.calculatetxt.TabIndex = 103;
            this.calculatetxt.TabStop = false;
            this.calculatetxt.Text = "=";
            this.calculatetxt.UseVisualStyleBackColor = false;
            this.calculatetxt.Click += new System.EventHandler(this.calculatetxt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 102;
            this.label10.Text = "Received Salary:";
            // 
            // salarytxt
            // 
            this.salarytxt.BackColor = System.Drawing.Color.DarkCyan;
            this.salarytxt.CausesValidation = false;
            this.salarytxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.salarytxt.Location = new System.Drawing.Point(138, 335);
            this.salarytxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(227, 28);
            this.salarytxt.TabIndex = 101;
            this.salarytxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 100;
            this.label1.Text = "Month Day:";
            // 
            // mdaytxt
            // 
            this.mdaytxt.BackColor = System.Drawing.Color.DarkCyan;
            this.mdaytxt.CausesValidation = false;
            this.mdaytxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.mdaytxt.Location = new System.Drawing.Point(138, 306);
            this.mdaytxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.mdaytxt.Name = "mdaytxt";
            this.mdaytxt.Size = new System.Drawing.Size(227, 28);
            this.mdaytxt.TabIndex = 99;
            this.mdaytxt.TabStop = false;
            // 
            // wtxt
            // 
            this.wtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.wtxt.CausesValidation = false;
            this.wtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.wtxt.Location = new System.Drawing.Point(139, 89);
            this.wtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.wtxt.Name = "wtxt";
            this.wtxt.Size = new System.Drawing.Size(227, 28);
            this.wtxt.TabIndex = 98;
            this.wtxt.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 97;
            this.label8.Text = "Absent Days:";
            // 
            // atxt
            // 
            this.atxt.BackColor = System.Drawing.Color.DarkCyan;
            this.atxt.CausesValidation = false;
            this.atxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.atxt.Location = new System.Drawing.Point(139, 119);
            this.atxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.atxt.Name = "atxt";
            this.atxt.Size = new System.Drawing.Size(227, 28);
            this.atxt.TabIndex = 96;
            this.atxt.TabStop = false;
            // 
            // stxt
            // 
            this.stxt.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.stxt.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.stxt.CustomFormat = "yyyy-MM-dd";
            this.stxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stxt.Location = new System.Drawing.Point(139, 150);
            this.stxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stxt.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.stxt.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(227, 28);
            this.stxt.TabIndex = 93;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(19, 372);
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
            this.logoutBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(300, 372);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(96, 36);
            this.logoutBtn.TabIndex = 91;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(207, 372);
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
            this.typetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Jr. Mechanic",
            "Mechanic",
            "Overlock",
            "Packing"});
            this.typetxt.Location = new System.Drawing.Point(138, 181);
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
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 86;
            this.label7.Text = "Employee Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Salary Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Work Days:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Employee Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 80;
            this.label5.Text = "Employee ID:";
            // 
            // Emp_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1018, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Emp_Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Emp_Salary_FormClosed);
            this.Load += new System.EventHandler(this.Emp_Salary_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sempTable)).EndInit();
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
        private System.Windows.Forms.DataGridView sempTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox atxt;
        internal System.Windows.Forms.DateTimePicker stxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mdaytxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.Button calculatetxt;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox snotxt;
        private System.Windows.Forms.ComboBox nametxt;
        private System.Windows.Forms.ComboBox idtxt;
        private System.Windows.Forms.ComboBox mtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvrsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgvmonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tsaltxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox otimetxt;

    }
}