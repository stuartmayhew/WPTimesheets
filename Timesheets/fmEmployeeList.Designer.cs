namespace Timesheets
{
    partial class fmEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEmployeeList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.ComboBox();
            this.Company = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvEmpList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbShow);
            this.panel1.Controls.Add(this.Company);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCompany);
            this.panel1.Controls.Add(this.cbBranch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 155);
            this.panel1.TabIndex = 1;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(88, 85);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(323, 20);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(444, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Show";
            // 
            // cbShow
            // 
            this.cbShow.FormattingEnabled = true;
            this.cbShow.Items.AddRange(new object[] {
            "Active",
            "InActive",
            "ALL"});
            this.cbShow.Location = new System.Drawing.Point(408, 38);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(121, 21);
            this.cbShow.TabIndex = 12;
            this.cbShow.SelectedIndexChanged += new System.EventHandler(this.cbShow_SelectedIndexChanged);
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(207, 21);
            this.Company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(51, 13);
            this.Company.TabIndex = 11;
            this.Company.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branch";
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Items.AddRange(new object[] {
            "Non-Union",
            "Union"});
            this.cbCompany.Location = new System.Drawing.Point(210, 38);
            this.cbCompany.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(160, 21);
            this.cbCompany.TabIndex = 9;
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
            this.cbBranch.Location = new System.Drawing.Point(28, 38);
            this.cbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(160, 21);
            this.cbBranch.TabIndex = 8;
            this.cbBranch.SelectedIndexChanged += new System.EventHandler(this.cbBranch_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvEmpList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 613);
            this.panel2.TabIndex = 2;
            // 
            // gvEmpList
            // 
            this.gvEmpList.AllowUserToAddRows = false;
            this.gvEmpList.AllowUserToDeleteRows = false;
            this.gvEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEmpList.Location = new System.Drawing.Point(0, 0);
            this.gvEmpList.MultiSelect = false;
            this.gvEmpList.Name = "gvEmpList";
            this.gvEmpList.ReadOnly = true;
            this.gvEmpList.RowHeadersWidth = 80;
            this.gvEmpList.Size = new System.Drawing.Size(719, 613);
            this.gvEmpList.TabIndex = 1;
            this.gvEmpList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvEmpList_DataBindingComplete);
            this.gvEmpList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvEmpList_RowHeaderMouseDoubleClick);
            // 
            // fmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmEmployeeList";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.fmEmployeeList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvEmpList;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbShow;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbBranch;
    }
}