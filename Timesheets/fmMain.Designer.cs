﻿namespace Timesheets
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Company = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.lblWeekEnding = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWeekEnding = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddHours = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.gbWorkDays = new System.Windows.Forms.GroupBox();
            this.rbOver40 = new System.Windows.Forms.RadioButton();
            this.rb410 = new System.Windows.Forms.RadioButton();
            this.rbOver8 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPayrollItem = new System.Windows.Forms.ComboBox();
            this.cbClassEquip = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.tbTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayrollItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssProg = new System.Windows.Forms.ToolStripProgressBar();
            this.ssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbWorkDays.SuspendLayout();
            this.tbTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupFacilityToolStripMenuItem,
            this.setupAreaToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // setupFacilityToolStripMenuItem
            // 
            this.setupFacilityToolStripMenuItem.Name = "setupFacilityToolStripMenuItem";
            this.setupFacilityToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.setupFacilityToolStripMenuItem.Text = "Setup Facility";
            // 
            // setupAreaToolStripMenuItem
            // 
            this.setupAreaToolStripMenuItem.Name = "setupAreaToolStripMenuItem";
            this.setupAreaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.setupAreaToolStripMenuItem.Text = "Setup Area";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.Company);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCompany);
            this.panel1.Controls.Add(this.cbBranch);
            this.panel1.Controls.Add(this.lblWeekEnding);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpWeekEnding);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 81);
            this.panel1.TabIndex = 1;
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(825, 50);
            this.Company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(67, 17);
            this.Company.TabIndex = 7;
            this.Company.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branch";
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Items.AddRange(new object[] {
            "Non-Union",
            "Union"});
            this.cbCompany.Location = new System.Drawing.Point(913, 46);
            this.cbCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(160, 24);
            this.cbCompany.TabIndex = 5;
            // 
            // cbBranch
            // 
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Items.AddRange(new object[] {
            "Show All",
            "00-Corporate",
            "01-Theodore",
            "02-Tuscaloosa"});
            this.cbBranch.Location = new System.Drawing.Point(644, 46);
            this.cbBranch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(160, 24);
            this.cbBranch.TabIndex = 4;
            // 
            // lblWeekEnding
            // 
            this.lblWeekEnding.AutoSize = true;
            this.lblWeekEnding.Location = new System.Drawing.Point(502, 50);
            this.lblWeekEnding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekEnding.Name = "lblWeekEnding";
            this.lblWeekEnding.Size = new System.Drawing.Size(0, 17);
            this.lblWeekEnding.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Week Ending";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Week Ending";
            // 
            // dtpWeekEnding
            // 
            this.dtpWeekEnding.Location = new System.Drawing.Point(119, 47);
            this.dtpWeekEnding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpWeekEnding.Name = "dtpWeekEnding";
            this.dtpWeekEnding.Size = new System.Drawing.Size(265, 23);
            this.dtpWeekEnding.TabIndex = 0;
            this.dtpWeekEnding.ValueChanged += new System.EventHandler(this.dtpWeekEnding_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddHours);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbHours);
            this.panel2.Controls.Add(this.gbWorkDays);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbPayrollItem);
            this.panel2.Controls.Add(this.cbClassEquip);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.cbCustomer);
            this.panel2.Controls.Add(this.cbEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1492, 198);
            this.panel2.TabIndex = 2;
            // 
            // btnAddHours
            // 
            this.btnAddHours.Location = new System.Drawing.Point(1361, 155);
            this.btnAddHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(100, 28);
            this.btnAddHours.TabIndex = 15;
            this.btnAddHours.Text = "Add";
            this.btnAddHours.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1067, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date Worked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1269, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hours";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(1273, 156);
            this.tbHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(67, 23);
            this.tbHours.TabIndex = 12;
            // 
            // gbWorkDays
            // 
            this.gbWorkDays.Controls.Add(this.rbOver40);
            this.gbWorkDays.Controls.Add(this.rb410);
            this.gbWorkDays.Controls.Add(this.rbOver8);
            this.gbWorkDays.Location = new System.Drawing.Point(16, 52);
            this.gbWorkDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbWorkDays.Name = "gbWorkDays";
            this.gbWorkDays.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbWorkDays.Size = new System.Drawing.Size(1219, 63);
            this.gbWorkDays.TabIndex = 11;
            this.gbWorkDays.TabStop = false;
            this.gbWorkDays.Text = "OT When worked";
            // 
            // rbOver40
            // 
            this.rbOver40.AutoSize = true;
            this.rbOver40.Location = new System.Drawing.Point(195, 25);
            this.rbOver40.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOver40.Name = "rbOver40";
            this.rbOver40.Size = new System.Drawing.Size(70, 21);
            this.rbOver40.TabIndex = 2;
            this.rbOver40.TabStop = true;
            this.rbOver40.Text = "over40";
            this.rbOver40.UseVisualStyleBackColor = true;
            // 
            // rb410
            // 
            this.rb410.AutoSize = true;
            this.rb410.Location = new System.Drawing.Point(105, 25);
            this.rb410.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb410.Name = "rb410";
            this.rb410.Size = new System.Drawing.Size(74, 21);
            this.rb410.TabIndex = 1;
            this.rb410.TabStop = true;
            this.rb410.Text = "over 10";
            this.rb410.UseVisualStyleBackColor = true;
            // 
            // rbOver8
            // 
            this.rbOver8.AutoSize = true;
            this.rbOver8.Location = new System.Drawing.Point(27, 25);
            this.rbOver8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOver8.Name = "rbOver8";
            this.rbOver8.Size = new System.Drawing.Size(66, 21);
            this.rbOver8.TabIndex = 0;
            this.rbOver8.TabStop = true;
            this.rbOver8.Text = "over 8";
            this.rbOver8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Payroll Item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Class/Equipment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee";
            // 
            // cbPayrollItem
            // 
            this.cbPayrollItem.FormattingEnabled = true;
            this.cbPayrollItem.Location = new System.Drawing.Point(721, 158);
            this.cbPayrollItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPayrollItem.Name = "cbPayrollItem";
            this.cbPayrollItem.Size = new System.Drawing.Size(328, 24);
            this.cbPayrollItem.TabIndex = 4;
            // 
            // cbClassEquip
            // 
            this.cbClassEquip.FormattingEnabled = true;
            this.cbClassEquip.Location = new System.Drawing.Point(381, 156);
            this.cbClassEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClassEquip.Name = "cbClassEquip";
            this.cbClassEquip.Size = new System.Drawing.Size(331, 24);
            this.cbClassEquip.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dddd - dd/mm/yy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1071, 158);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(176, 23);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(12, 158);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(348, 24);
            this.cbCustomer.TabIndex = 1;
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(92, 7);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(401, 24);
            this.cbEmployee.TabIndex = 0;
            // 
            // tbTabs
            // 
            this.tbTabs.Controls.Add(this.tabPage1);
            this.tbTabs.Controls.Add(this.tabPage2);
            this.tbTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTabs.Location = new System.Drawing.Point(0, 303);
            this.tbTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTabs.Name = "tbTabs";
            this.tbTabs.SelectedIndex = 0;
            this.tbTabs.Size = new System.Drawing.Size(1492, 449);
            this.tbTabs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1484, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.ClassEquipment,
            this.PayrollItem,
            this.Date,
            this.Day,
            this.RegHours,
            this.OTHours});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1476, 412);
            this.dataGridView1.TabIndex = 4;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.Width = 250;
            // 
            // ClassEquipment
            // 
            this.ClassEquipment.HeaderText = "Class/Equipment";
            this.ClassEquipment.Name = "ClassEquipment";
            this.ClassEquipment.Width = 250;
            // 
            // PayrollItem
            // 
            this.PayrollItem.HeaderText = "Payroll Item";
            this.PayrollItem.Name = "PayrollItem";
            this.PayrollItem.Width = 250;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.Width = 50;
            // 
            // RegHours
            // 
            this.RegHours.HeaderText = "Reg Hours";
            this.RegHours.Name = "RegHours";
            this.RegHours.Width = 50;
            // 
            // OTHours
            // 
            this.OTHours.HeaderText = "OT Hours";
            this.OTHours.Name = "OTHours";
            this.OTHours.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1484, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(20, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLabel,
            this.ssProg});
            this.statusStrip1.Location = new System.Drawing.Point(4, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1476, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssProg
            // 
            this.ssProg.Name = "ssProg";
            this.ssProg.Size = new System.Drawing.Size(700, 16);
            // 
            // ssLabel
            // 
            this.ssLabel.Name = "ssLabel";
            this.ssLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 752);
            this.Controls.Add(this.tbTabs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheet Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbWorkDays.ResumeLayout(false);
            this.gbWorkDays.PerformLayout();
            this.tbTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupAreaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Label lblWeekEnding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpWeekEnding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPayrollItem;
        private System.Windows.Forms.ComboBox cbClassEquip;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.TabControl tbTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayrollItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.GroupBox gbWorkDays;
        private System.Windows.Forms.RadioButton rbOver40;
        private System.Windows.Forms.RadioButton rb410;
        private System.Windows.Forms.RadioButton rbOver8;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel;
        private System.Windows.Forms.ToolStripProgressBar ssProg;
    }
}

