﻿namespace Timesheets
{
    partial class fmRequestApproval
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
            this.lbRequest = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbRequest
            // 
            this.lbRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRequest.FormattingEnabled = true;
            this.lbRequest.Location = new System.Drawing.Point(0, 0);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(478, 603);
            this.lbRequest.TabIndex = 0;
            // 
            // fmRequestApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 603);
            this.Controls.Add(this.lbRequest);
            this.Name = "fmRequestApproval";
            this.Text = "fmRequestApproval";
            this.Load += new System.EventHandler(this.fmRequestApproval_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbRequest;
    }
}