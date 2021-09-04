namespace Takwa_Gloves_Company
{
    partial class Sell_Record
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
            this.tbox = new System.Windows.Forms.DateTimePicker();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sellTable = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.costtxt = new System.Windows.Forms.TextBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.typetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.snotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtxt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.dgvserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvqn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellTable)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 363F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 575);
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
            this.panel1.Size = new System.Drawing.Size(633, 41);
            this.panel1.TabIndex = 0;
            // 
            // tbox
            // 
            this.tbox.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.tbox.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.tbox.CustomFormat = "yyyy-MM-dd";
            this.tbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbox.Location = new System.Drawing.Point(48, 7);
            this.tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.tbox.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(135, 28);
            this.tbox.TabIndex = 132;
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.searchtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.searchtxt.Location = new System.Drawing.Point(294, 6);
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
            this.searchBtn.Location = new System.Drawing.Point(490, 4);
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
            this.refreshBtn.Location = new System.Drawing.Point(189, 4);
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
            this.panel2.Location = new System.Drawing.Point(642, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 41);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(46, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "<< Factory Sells Record >> ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sellTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 518);
            this.panel3.TabIndex = 2;
            // 
            // sellTable
            // 
            this.sellTable.AllowUserToAddRows = false;
            this.sellTable.AllowUserToDeleteRows = false;
            this.sellTable.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.sellTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvserial,
            this.dgvweight,
            this.dgvname,
            this.dgvcname,
            this.dgvqn,
            this.dgvcost});
            this.sellTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellTable.Location = new System.Drawing.Point(0, 0);
            this.sellTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sellTable.Name = "sellTable";
            this.sellTable.ReadOnly = true;
            this.sellTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellTable.Size = new System.Drawing.Size(633, 518);
            this.sellTable.TabIndex = 0;
            this.sellTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellTable_CellClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.addtxt);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.pricetxt);
            this.panel4.Controls.Add(this.costtxt);
            this.panel4.Controls.Add(this.cnametxt);
            this.panel4.Controls.Add(this.typetxt);
            this.panel4.Controls.Add(this.nametxt);
            this.panel4.Controls.Add(this.idtxt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.qtxt);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.snotxt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtxt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(642, 53);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 518);
            this.panel4.TabIndex = 3;
            // 
            // addtxt
            // 
            this.addtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.addtxt.CausesValidation = false;
            this.addtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.addtxt.Location = new System.Drawing.Point(141, 183);
            this.addtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(209, 28);
            this.addtxt.TabIndex = 159;
            this.addtxt.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(24, 187);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 21);
            this.label13.TabIndex = 158;
            this.label13.Text = "Cus. Address:";
            // 
            // pricetxt
            // 
            this.pricetxt.BackColor = System.Drawing.Color.DarkCyan;
            this.pricetxt.CausesValidation = false;
            this.pricetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.pricetxt.Location = new System.Drawing.Point(141, 244);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(209, 28);
            this.pricetxt.TabIndex = 157;
            this.pricetxt.TabStop = false;
            // 
            // costtxt
            // 
            this.costtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.costtxt.CausesValidation = false;
            this.costtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.costtxt.Location = new System.Drawing.Point(141, 213);
            this.costtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(209, 28);
            this.costtxt.TabIndex = 154;
            this.costtxt.TabStop = false;
            // 
            // cnametxt
            // 
            this.cnametxt.BackColor = System.Drawing.Color.DarkCyan;
            this.cnametxt.CausesValidation = false;
            this.cnametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.cnametxt.Location = new System.Drawing.Point(141, 152);
            this.cnametxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(209, 28);
            this.cnametxt.TabIndex = 153;
            this.cnametxt.TabStop = false;
            // 
            // typetxt
            // 
            this.typetxt.BackColor = System.Drawing.Color.DarkCyan;
            this.typetxt.CausesValidation = false;
            this.typetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.typetxt.Location = new System.Drawing.Point(141, 121);
            this.typetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(209, 28);
            this.typetxt.TabIndex = 152;
            this.typetxt.TabStop = false;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.DarkCyan;
            this.nametxt.CausesValidation = false;
            this.nametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.nametxt.Location = new System.Drawing.Point(141, 61);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(209, 28);
            this.nametxt.TabIndex = 151;
            this.nametxt.TabStop = false;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.idtxt.CausesValidation = false;
            this.idtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.idtxt.Location = new System.Drawing.Point(141, 32);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(209, 28);
            this.idtxt.TabIndex = 150;
            this.idtxt.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(57, 278);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 149;
            this.label12.Text = "Quantity:";
            // 
            // qtxt
            // 
            this.qtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.qtxt.CausesValidation = false;
            this.qtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.qtxt.Location = new System.Drawing.Point(141, 274);
            this.qtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.qtxt.Name = "qtxt";
            this.qtxt.Size = new System.Drawing.Size(209, 28);
            this.qtxt.TabIndex = 148;
            this.qtxt.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(23, 248);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 21);
            this.label11.TabIndex = 146;
            this.label11.Text = "Product Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(52, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 138;
            this.label9.Text = "Serial No:";
            // 
            // snotxt
            // 
            this.snotxt.BackColor = System.Drawing.Color.DarkCyan;
            this.snotxt.CausesValidation = false;
            this.snotxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.snotxt.Location = new System.Drawing.Point(141, 2);
            this.snotxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.snotxt.Name = "snotxt";
            this.snotxt.ReadOnly = true;
            this.snotxt.Size = new System.Drawing.Size(209, 28);
            this.snotxt.TabIndex = 137;
            this.snotxt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 136;
            this.label3.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(39, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 135;
            this.label5.Text = "Invoice No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 133;
            this.label2.Text = "Total Cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 132;
            this.label1.Text = "Customer Name:";
            // 
            // dtxt
            // 
            this.dtxt.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dtxt.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.dtxt.CustomFormat = "yyyy-MM-dd";
            this.dtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtxt.Location = new System.Drawing.Point(142, 91);
            this.dtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtxt.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dtxt.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtxt.Name = "dtxt";
            this.dtxt.Size = new System.Drawing.Size(208, 28);
            this.dtxt.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(24, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 129;
            this.label7.Text = "Product Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(86, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 128;
            this.label4.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Takwa_Gloves_Company.Properties.Resources.Engaging_480p_70933386_bbd9_4055_9cc6_92d951471bda;
            this.pictureBox1.Location = new System.Drawing.Point(3, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.logoutBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.Location = new System.Drawing.Point(177, 480);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(95, 36);
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
            this.backBtn.Location = new System.Drawing.Point(83, 480);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(78, 36);
            this.backBtn.TabIndex = 90;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dgvserial
            // 
            this.dgvserial.DataPropertyName = "id";
            this.dgvserial.HeaderText = "Serial";
            this.dgvserial.Name = "dgvserial";
            this.dgvserial.ReadOnly = true;
            this.dgvserial.Width = 60;
            // 
            // dgvweight
            // 
            this.dgvweight.DataPropertyName = "invoice";
            this.dgvweight.HeaderText = "Invoice";
            this.dgvweight.Name = "dgvweight";
            this.dgvweight.ReadOnly = true;
            // 
            // dgvname
            // 
            this.dgvname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvname.DataPropertyName = "name";
            this.dgvname.HeaderText = "Pro. Name";
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            // 
            // dgvcname
            // 
            this.dgvcname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcname.DataPropertyName = "cname";
            this.dgvcname.HeaderText = "Cus. Name";
            this.dgvcname.Name = "dgvcname";
            this.dgvcname.ReadOnly = true;
            // 
            // dgvqn
            // 
            this.dgvqn.DataPropertyName = "quantity";
            this.dgvqn.HeaderText = "Quantity";
            this.dgvqn.Name = "dgvqn";
            this.dgvqn.ReadOnly = true;
            this.dgvqn.Width = 80;
            // 
            // dgvcost
            // 
            this.dgvcost.DataPropertyName = "cost";
            this.dgvcost.HeaderText = "Total";
            this.dgvcost.Name = "dgvcost";
            this.dgvcost.ReadOnly = true;
            this.dgvcost.Width = 80;
            // 
            // Sell_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1002, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sell_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sells Record";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sell_Record_FormClosed);
            this.Load += new System.EventHandler(this.Sell_Record_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView sellTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox qtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox snotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox costtxt;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.TextBox typetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        internal System.Windows.Forms.DateTimePicker tbox;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvqn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcost;
    }
}