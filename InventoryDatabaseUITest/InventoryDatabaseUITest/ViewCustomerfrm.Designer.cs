﻿namespace InventoryDatabaseUITest
{
    partial class ViewCustomerfrm
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
            this.Lnametxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.custSearchbtn = new System.Windows.Forms.Button();
            this.CustomerQueryListBox = new System.Windows.Forms.ListBox();
            this.custBackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lnametxtbx
            // 
            this.Lnametxtbx.Location = new System.Drawing.Point(280, 46);
            this.Lnametxtbx.Name = "Lnametxtbx";
            this.Lnametxtbx.Size = new System.Drawing.Size(116, 20);
            this.Lnametxtbx.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // custSearchbtn
            // 
            this.custSearchbtn.Location = new System.Drawing.Point(402, 46);
            this.custSearchbtn.Name = "custSearchbtn";
            this.custSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.custSearchbtn.TabIndex = 5;
            this.custSearchbtn.Text = "Search";
            this.custSearchbtn.UseVisualStyleBackColor = true;
            this.custSearchbtn.Click += new System.EventHandler(this.custSearchbtn_Click);
            // 
            // CustomerQueryListBox
            // 
            this.CustomerQueryListBox.FormattingEnabled = true;
            this.CustomerQueryListBox.Location = new System.Drawing.Point(12, 75);
            this.CustomerQueryListBox.Name = "CustomerQueryListBox";
            this.CustomerQueryListBox.Size = new System.Drawing.Size(742, 290);
            this.CustomerQueryListBox.TabIndex = 4;
            // 
            // custBackbtn
            // 
            this.custBackbtn.Location = new System.Drawing.Point(346, 396);
            this.custBackbtn.Name = "custBackbtn";
            this.custBackbtn.Size = new System.Drawing.Size(75, 23);
            this.custBackbtn.TabIndex = 8;
            this.custBackbtn.Text = "Back";
            this.custBackbtn.UseVisualStyleBackColor = true;
            this.custBackbtn.Click += new System.EventHandler(this.custBackbtn_Click);
            // 
            // ViewCustomerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.custBackbtn);
            this.Controls.Add(this.Lnametxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custSearchbtn);
            this.Controls.Add(this.CustomerQueryListBox);
            this.Name = "ViewCustomerfrm";
            this.Text = "Search Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lnametxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button custSearchbtn;
        private System.Windows.Forms.ListBox CustomerQueryListBox;
        private System.Windows.Forms.Button custBackbtn;
    }
}