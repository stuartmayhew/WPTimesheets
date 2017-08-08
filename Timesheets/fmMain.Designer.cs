namespace Timesheets
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupLoginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickbooksDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPayrollItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAppRequest = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.lblWeekEnding = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWeekEnding = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFac = new System.Windows.Forms.ComboBox();
            this.btnShowActiveCust = new System.Windows.Forms.Button();
            this.btnShowActive = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddHours = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbClassEquip = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPayrollItem = new System.Windows.Forms.ComboBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateWorked = new System.Windows.Forms.DateTimePicker();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.tbTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssProg = new System.Windows.Forms.ToolStripProgressBar();
            this.gvTimesheet = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvRecap = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCheckHO = new System.Windows.Forms.Button();
            this.btnCheckOM = new System.Windows.Forms.Button();
            this.btnCheckSup = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimesheet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecap)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.quickbooksDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupFacilityToolStripMenuItem,
            this.setupAreaToolStripMenuItem,
            this.setupLoginsToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // setupFacilityToolStripMenuItem
            // 
            this.setupFacilityToolStripMenuItem.Name = "setupFacilityToolStripMenuItem";
            this.setupFacilityToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.setupFacilityToolStripMenuItem.Text = "Facilities";
            this.setupFacilityToolStripMenuItem.Click += new System.EventHandler(this.setupFacilityToolStripMenuItem_Click);
            // 
            // setupAreaToolStripMenuItem
            // 
            this.setupAreaToolStripMenuItem.Name = "setupAreaToolStripMenuItem";
            this.setupAreaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.setupAreaToolStripMenuItem.Text = "Areas";
            this.setupAreaToolStripMenuItem.Click += new System.EventHandler(this.setupAreaToolStripMenuItem_Click);
            // 
            // setupLoginsToolStripMenuItem
            // 
            this.setupLoginsToolStripMenuItem.Name = "setupLoginsToolStripMenuItem";
            this.setupLoginsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.setupLoginsToolStripMenuItem.Text = "Logins";
            this.setupLoginsToolStripMenuItem.Click += new System.EventHandler(this.setupLoginsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // quickbooksDataToolStripMenuItem
            // 
            this.quickbooksDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshEmployeeToolStripMenuItem,
            this.refreshCustomersToolStripMenuItem,
            this.refreshPayrollItemsToolStripMenuItem,
            this.refreshClassesToolStripMenuItem});
            this.quickbooksDataToolStripMenuItem.Name = "quickbooksDataToolStripMenuItem";
            this.quickbooksDataToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.quickbooksDataToolStripMenuItem.Text = "Quickbooks Data";
            // 
            // refreshEmployeeToolStripMenuItem
            // 
            this.refreshEmployeeToolStripMenuItem.Name = "refreshEmployeeToolStripMenuItem";
            this.refreshEmployeeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.refreshEmployeeToolStripMenuItem.Text = "Refresh Employee";
            this.refreshEmployeeToolStripMenuItem.Click += new System.EventHandler(this.refreshEmployeeToolStripMenuItem_Click);
            // 
            // refreshCustomersToolStripMenuItem
            // 
            this.refreshCustomersToolStripMenuItem.Name = "refreshCustomersToolStripMenuItem";
            this.refreshCustomersToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.refreshCustomersToolStripMenuItem.Text = "Refresh Customers";
            this.refreshCustomersToolStripMenuItem.Click += new System.EventHandler(this.refreshCustomersToolStripMenuItem_Click);
            // 
            // refreshPayrollItemsToolStripMenuItem
            // 
            this.refreshPayrollItemsToolStripMenuItem.Name = "refreshPayrollItemsToolStripMenuItem";
            this.refreshPayrollItemsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.refreshPayrollItemsToolStripMenuItem.Text = "Refresh Payroll Items";
            this.refreshPayrollItemsToolStripMenuItem.Click += new System.EventHandler(this.refreshPayrollItemsToolStripMenuItem_Click);
            // 
            // refreshClassesToolStripMenuItem
            // 
            this.refreshClassesToolStripMenuItem.Name = "refreshClassesToolStripMenuItem";
            this.refreshClassesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.refreshClassesToolStripMenuItem.Text = "Refresh Classes";
            this.refreshClassesToolStripMenuItem.Click += new System.EventHandler(this.refreshClassesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAppRequest);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1752, 81);
            this.panel1.TabIndex = 1;
            // 
            // btnAppRequest
            // 
            this.btnAppRequest.Location = new System.Drawing.Point(1121, 35);
            this.btnAppRequest.Name = "btnAppRequest";
            this.btnAppRequest.Size = new System.Drawing.Size(129, 37);
            this.btnAppRequest.TabIndex = 9;
            this.btnAppRequest.Text = "Request Approval";
            this.btnAppRequest.UseVisualStyleBackColor = true;
            this.btnAppRequest.Click += new System.EventHandler(this.btnAppRequest_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(16, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 8;
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(816, 50);
            this.Company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(67, 17);
            this.Company.TabIndex = 7;
            this.Company.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 50);
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
            this.cbCompany.Location = new System.Drawing.Point(904, 46);
            this.cbCompany.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(160, 24);
            this.cbCompany.TabIndex = 5;
            this.cbCompany.SelectedIndexChanged += new System.EventHandler(this.cbCompany_SelectedIndexChanged);
            // 
            // cbBranch
            // 
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Items.AddRange(new object[] {
            "Show All",
            "00-Corporate",
            "01-Theodore",
            "02-Tuscaloosa"});
            this.cbBranch.Location = new System.Drawing.Point(635, 46);
            this.cbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(160, 24);
            this.cbBranch.TabIndex = 4;
            this.cbBranch.SelectedIndexChanged += new System.EventHandler(this.cbBranch_SelectedIndexChanged);
            // 
            // lblWeekEnding
            // 
            this.lblWeekEnding.AutoSize = true;
            this.lblWeekEnding.Location = new System.Drawing.Point(493, 50);
            this.lblWeekEnding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekEnding.Name = "lblWeekEnding";
            this.lblWeekEnding.Size = new System.Drawing.Size(0, 17);
            this.lblWeekEnding.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Week Ending";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Week Ending";
            // 
            // dtpWeekEnding
            // 
            this.dtpWeekEnding.Location = new System.Drawing.Point(110, 47);
            this.dtpWeekEnding.Margin = new System.Windows.Forms.Padding(4);
            this.dtpWeekEnding.Name = "dtpWeekEnding";
            this.dtpWeekEnding.Size = new System.Drawing.Size(265, 23);
            this.dtpWeekEnding.TabIndex = 0;
            this.dtpWeekEnding.ValueChanged += new System.EventHandler(this.dtpWeekEnding_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbArea);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbFac);
            this.panel2.Controls.Add(this.btnShowActiveCust);
            this.panel2.Controls.Add(this.btnShowActive);
            this.panel2.Controls.Add(this.btnAddNote);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnAddHours);
            this.panel2.Controls.Add(this.cbCustomer);
            this.panel2.Controls.Add(this.cbClassEquip);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbPayrollItem);
            this.panel2.Controls.Add(this.tbHours);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpDateWorked);
            this.panel2.Controls.Add(this.cbEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1752, 170);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(769, 99);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Area";
            // 
            // cbArea
            // 
            this.cbArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(772, 124);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(178, 24);
            this.cbArea.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Facility";
            // 
            // cbFac
            // 
            this.cbFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFac.FormattingEnabled = true;
            this.cbFac.Location = new System.Drawing.Point(598, 124);
            this.cbFac.Margin = new System.Windows.Forms.Padding(4);
            this.cbFac.Name = "cbFac";
            this.cbFac.Size = new System.Drawing.Size(166, 24);
            this.cbFac.TabIndex = 3;
            this.cbFac.SelectedIndexChanged += new System.EventHandler(this.cbFac_SelectedIndexChanged);
            // 
            // btnShowActiveCust
            // 
            this.btnShowActiveCust.Location = new System.Drawing.Point(319, 95);
            this.btnShowActiveCust.Name = "btnShowActiveCust";
            this.btnShowActiveCust.Size = new System.Drawing.Size(124, 24);
            this.btnShowActiveCust.TabIndex = 18;
            this.btnShowActiveCust.Text = "Show Active Only";
            this.btnShowActiveCust.UseVisualStyleBackColor = true;
            this.btnShowActiveCust.Click += new System.EventHandler(this.btnShowActiveCust_Click);
            // 
            // btnShowActive
            // 
            this.btnShowActive.Location = new System.Drawing.Point(416, 25);
            this.btnShowActive.Name = "btnShowActive";
            this.btnShowActive.Size = new System.Drawing.Size(124, 24);
            this.btnShowActive.TabIndex = 17;
            this.btnShowActive.Text = "Show Active Only";
            this.btnShowActive.UseVisualStyleBackColor = true;
            this.btnShowActive.Click += new System.EventHandler(this.btnShowActive_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(1640, 122);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(100, 28);
            this.btnAddNote.TabIndex = 16;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer";
            // 
            // btnAddHours
            // 
            this.btnAddHours.Location = new System.Drawing.Point(1567, 122);
            this.btnAddHours.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(65, 28);
            this.btnAddHours.TabIndex = 8;
            this.btnAddHours.Text = "Add";
            this.btnAddHours.UseVisualStyleBackColor = true;
            this.btnAddHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomer.DropDownWidth = 800;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(251, 124);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(339, 24);
            this.cbCustomer.TabIndex = 2;
            // 
            // cbClassEquip
            // 
            this.cbClassEquip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClassEquip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClassEquip.FormattingEnabled = true;
            this.cbClassEquip.Location = new System.Drawing.Point(958, 124);
            this.cbClassEquip.Margin = new System.Windows.Forms.Padding(4);
            this.cbClassEquip.Name = "cbClassEquip";
            this.cbClassEquip.Size = new System.Drawing.Size(272, 24);
            this.cbClassEquip.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date Worked";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1237, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Payroll Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1490, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hours";
            // 
            // cbPayrollItem
            // 
            this.cbPayrollItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPayrollItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPayrollItem.FormattingEnabled = true;
            this.cbPayrollItem.Location = new System.Drawing.Point(1240, 124);
            this.cbPayrollItem.Margin = new System.Windows.Forms.Padding(4);
            this.cbPayrollItem.Name = "cbPayrollItem";
            this.cbPayrollItem.Size = new System.Drawing.Size(231, 24);
            this.cbPayrollItem.TabIndex = 6;
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(1492, 125);
            this.tbHours.Margin = new System.Windows.Forms.Padding(4);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(67, 23);
            this.tbHours.TabIndex = 7;
            this.tbHours.Enter += new System.EventHandler(this.tbHours_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(954, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Class/Equipment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee";
            // 
            // dtpDateWorked
            // 
            this.dtpDateWorked.CustomFormat = "";
            this.dtpDateWorked.Location = new System.Drawing.Point(4, 125);
            this.dtpDateWorked.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateWorked.Name = "dtpDateWorked";
            this.dtpDateWorked.Size = new System.Drawing.Size(227, 23);
            this.dtpDateWorked.TabIndex = 1;
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(4, 25);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(401, 24);
            this.cbEmployee.TabIndex = 0;
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // tbTabs
            // 
            this.tbTabs.Controls.Add(this.tabPage1);
            this.tbTabs.Controls.Add(this.tabPage2);
            this.tbTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTabs.Location = new System.Drawing.Point(0, 275);
            this.tbTabs.Margin = new System.Windows.Forms.Padding(4);
            this.tbTabs.Name = "tbTabs";
            this.tbTabs.SelectedIndex = 0;
            this.tbTabs.Size = new System.Drawing.Size(1752, 477);
            this.tbTabs.TabIndex = 3;
            this.tbTabs.SelectedIndexChanged += new System.EventHandler(this.tbTabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.gvTimesheet);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1744, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLabel,
            this.ssProg});
            this.statusStrip1.Location = new System.Drawing.Point(4, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1736, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssLabel
            // 
            this.ssLabel.Name = "ssLabel";
            this.ssLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ssProg
            // 
            this.ssProg.Name = "ssProg";
            this.ssProg.Size = new System.Drawing.Size(700, 16);
            // 
            // gvTimesheet
            // 
            this.gvTimesheet.AllowUserToAddRows = false;
            this.gvTimesheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvTimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTimesheet.ContextMenuStrip = this.contextMenuStrip1;
            this.gvTimesheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTimesheet.Location = new System.Drawing.Point(4, 4);
            this.gvTimesheet.Margin = new System.Windows.Forms.Padding(4);
            this.gvTimesheet.Name = "gvTimesheet";
            this.gvTimesheet.Size = new System.Drawing.Size(1736, 440);
            this.gvTimesheet.TabIndex = 4;
            this.gvTimesheet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTimesheet_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem1.Text = "Delete Entry";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1744, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvRecap
            // 
            this.gvRecap.AllowUserToAddRows = false;
            this.gvRecap.AllowUserToDeleteRows = false;
            this.gvRecap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvRecap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRecap.Location = new System.Drawing.Point(0, 0);
            this.gvRecap.Name = "gvRecap";
            this.gvRecap.ReadOnly = true;
            this.gvRecap.Size = new System.Drawing.Size(1732, 367);
            this.gvRecap.TabIndex = 0;
            this.gvRecap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRecap_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnCheckSup);
            this.panel3.Controls.Add(this.btnCheckOM);
            this.panel3.Controls.Add(this.btnCheckHO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1736, 69);
            this.panel3.TabIndex = 1;
            // 
            // btnCheckHO
            // 
            this.btnCheckHO.Location = new System.Drawing.Point(758, 40);
            this.btnCheckHO.Name = "btnCheckHO";
            this.btnCheckHO.Size = new System.Drawing.Size(75, 23);
            this.btnCheckHO.TabIndex = 0;
            this.btnCheckHO.Text = "Check All";
            this.btnCheckHO.UseVisualStyleBackColor = true;
            this.btnCheckHO.Click += new System.EventHandler(this.btnCheckHO_Click);
            // 
            // btnCheckOM
            // 
            this.btnCheckOM.Location = new System.Drawing.Point(659, 40);
            this.btnCheckOM.Name = "btnCheckOM";
            this.btnCheckOM.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOM.TabIndex = 1;
            this.btnCheckOM.Text = "Check All";
            this.btnCheckOM.UseVisualStyleBackColor = true;
            this.btnCheckOM.Click += new System.EventHandler(this.btnCheckOM_Click);
            // 
            // btnCheckSup
            // 
            this.btnCheckSup.Location = new System.Drawing.Point(564, 40);
            this.btnCheckSup.Name = "btnCheckSup";
            this.btnCheckSup.Size = new System.Drawing.Size(75, 23);
            this.btnCheckSup.TabIndex = 2;
            this.btnCheckSup.Text = "Check All";
            this.btnCheckSup.UseVisualStyleBackColor = true;
            this.btnCheckSup.Click += new System.EventHandler(this.btnCheckSup_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.gvRecap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1736, 371);
            this.panel4.TabIndex = 2;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 752);
            this.Controls.Add(this.tbTabs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.tbTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimesheet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dtpDateWorked;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.TabControl tbTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gvTimesheet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel;
        private System.Windows.Forms.ToolStripProgressBar ssProg;
        private System.Windows.Forms.ToolStripMenuItem quickbooksDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshPayrollItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshClassesToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approvedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnShowActive;
        private System.Windows.Forms.Button btnShowActiveCust;
        private System.Windows.Forms.DataGridView gvRecap;
        private System.Windows.Forms.Button btnAppRequest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFac;
        private System.Windows.Forms.ToolStripMenuItem setupLoginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCheckSup;
        private System.Windows.Forms.Button btnCheckOM;
        private System.Windows.Forms.Button btnCheckHO;
        private System.Windows.Forms.Panel panel4;
    }
}

