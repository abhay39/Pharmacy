
namespace Pharmacy
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empage = new ns1.BunifuMaterialTextbox();
            this.empsalary = new ns1.BunifuMaterialTextbox();
            this.empname = new ns1.BunifuMaterialTextbox();
            this.empid = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.empnumber = new ns1.BunifuMaterialTextbox();
            this.backbtn = new ns1.BunifuThinButton2();
            this.deletebtn = new ns1.BunifuThinButton2();
            this.updatebtn = new ns1.BunifuThinButton2();
            this.addbtn = new ns1.BunifuThinButton2();
            this.empgridview = new ns1.BunifuCustomDataGrid();
            this.emppasswor = new ns1.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.empgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // empage
            // 
            this.empage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empage.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empage.HintForeColor = System.Drawing.Color.Empty;
            this.empage.HintText = "";
            this.empage.isPassword = false;
            this.empage.LineFocusedColor = System.Drawing.Color.Blue;
            this.empage.LineIdleColor = System.Drawing.Color.Gray;
            this.empage.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empage.LineThickness = 5;
            this.empage.Location = new System.Drawing.Point(41, 393);
            this.empage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.empage.Name = "empage";
            this.empage.Size = new System.Drawing.Size(264, 67);
            this.empage.TabIndex = 12;
            this.empage.Text = "Employee Age";
            this.empage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empage.OnValueChanged += new System.EventHandler(this.empage_OnValueChanged);
            // 
            // empsalary
            // 
            this.empsalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empsalary.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empsalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empsalary.HintForeColor = System.Drawing.Color.Empty;
            this.empsalary.HintText = "";
            this.empsalary.isPassword = false;
            this.empsalary.LineFocusedColor = System.Drawing.Color.Blue;
            this.empsalary.LineIdleColor = System.Drawing.Color.Gray;
            this.empsalary.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empsalary.LineThickness = 5;
            this.empsalary.Location = new System.Drawing.Point(377, 138);
            this.empsalary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.empsalary.Name = "empsalary";
            this.empsalary.Size = new System.Drawing.Size(264, 67);
            this.empsalary.TabIndex = 11;
            this.empsalary.Text = "Salary";
            this.empsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empname
            // 
            this.empname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empname.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empname.HintForeColor = System.Drawing.Color.Empty;
            this.empname.HintText = "";
            this.empname.isPassword = false;
            this.empname.LineFocusedColor = System.Drawing.Color.Blue;
            this.empname.LineIdleColor = System.Drawing.Color.Gray;
            this.empname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empname.LineThickness = 5;
            this.empname.Location = new System.Drawing.Point(41, 272);
            this.empname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(264, 67);
            this.empname.TabIndex = 10;
            this.empname.Text = "Employee Name";
            this.empname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empid
            // 
            this.empid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empid.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empid.HintForeColor = System.Drawing.Color.Empty;
            this.empid.HintText = "";
            this.empid.isPassword = false;
            this.empid.LineFocusedColor = System.Drawing.Color.Blue;
            this.empid.LineIdleColor = System.Drawing.Color.Gray;
            this.empid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empid.LineThickness = 5;
            this.empid.Location = new System.Drawing.Point(41, 138);
            this.empid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(264, 67);
            this.empid.TabIndex = 9;
            this.empid.Text = "Employee ID";
            this.empid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 80);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee";
            // 
            // empnumber
            // 
            this.empnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empnumber.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empnumber.HintForeColor = System.Drawing.Color.Empty;
            this.empnumber.HintText = "";
            this.empnumber.isPassword = false;
            this.empnumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.empnumber.LineIdleColor = System.Drawing.Color.Gray;
            this.empnumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empnumber.LineThickness = 5;
            this.empnumber.Location = new System.Drawing.Point(377, 393);
            this.empnumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.empnumber.Name = "empnumber";
            this.empnumber.Size = new System.Drawing.Size(264, 67);
            this.empnumber.TabIndex = 14;
            this.empnumber.Text = "Phone Number";
            this.empnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empnumber.OnValueChanged += new System.EventHandler(this.empnumber_OnValueChanged);
            // 
            // backbtn
            // 
            this.backbtn.ActiveBorderThickness = 1;
            this.backbtn.ActiveCornerRadius = 20;
            this.backbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.backbtn.ActiveForecolor = System.Drawing.Color.White;
            this.backbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.backbtn.BackColor = System.Drawing.SystemColors.Control;
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.ButtonText = "Back";
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.IdleBorderThickness = 1;
            this.backbtn.IdleCornerRadius = 20;
            this.backbtn.IdleFillColor = System.Drawing.Color.DarkRed;
            this.backbtn.IdleForecolor = System.Drawing.Color.White;
            this.backbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.backbtn.Location = new System.Drawing.Point(238, 714);
            this.backbtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(186, 72);
            this.backbtn.TabIndex = 18;
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.ActiveBorderThickness = 1;
            this.deletebtn.ActiveCornerRadius = 20;
            this.deletebtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.deletebtn.ActiveForecolor = System.Drawing.Color.White;
            this.deletebtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.deletebtn.BackColor = System.Drawing.SystemColors.Control;
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.ButtonText = "Delete";
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.IdleBorderThickness = 1;
            this.deletebtn.IdleCornerRadius = 20;
            this.deletebtn.IdleFillColor = System.Drawing.Color.DarkRed;
            this.deletebtn.IdleForecolor = System.Drawing.Color.White;
            this.deletebtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.deletebtn.Location = new System.Drawing.Point(455, 622);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(186, 72);
            this.deletebtn.TabIndex = 17;
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.ActiveBorderThickness = 1;
            this.updatebtn.ActiveCornerRadius = 20;
            this.updatebtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.updatebtn.ActiveForecolor = System.Drawing.Color.White;
            this.updatebtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updatebtn.BackColor = System.Drawing.SystemColors.Control;
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.ButtonText = "Update";
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.IdleBorderThickness = 1;
            this.updatebtn.IdleCornerRadius = 20;
            this.updatebtn.IdleFillColor = System.Drawing.Color.DarkRed;
            this.updatebtn.IdleForecolor = System.Drawing.Color.White;
            this.updatebtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.updatebtn.Location = new System.Drawing.Point(238, 622);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(186, 72);
            this.updatebtn.TabIndex = 16;
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.ActiveBorderThickness = 1;
            this.addbtn.ActiveCornerRadius = 20;
            this.addbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addbtn.ActiveForecolor = System.Drawing.Color.White;
            this.addbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addbtn.BackColor = System.Drawing.SystemColors.Control;
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.ButtonText = "Add";
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.IdleBorderThickness = 1;
            this.addbtn.IdleCornerRadius = 20;
            this.addbtn.IdleFillColor = System.Drawing.Color.DarkRed;
            this.addbtn.IdleForecolor = System.Drawing.Color.White;
            this.addbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addbtn.Location = new System.Drawing.Point(18, 622);
            this.addbtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(186, 72);
            this.addbtn.TabIndex = 15;
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // empgridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.empgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empgridview.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.empgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empgridview.ColumnHeadersHeight = 29;
            this.empgridview.DoubleBuffered = true;
            this.empgridview.EnableHeadersVisualStyles = false;
            this.empgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.empgridview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.empgridview.HeaderForeColor = System.Drawing.Color.White;
            this.empgridview.Location = new System.Drawing.Point(653, 12);
            this.empgridview.Name = "empgridview";
            this.empgridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empgridview.RowHeadersWidth = 51;
            this.empgridview.RowTemplate.Height = 24;
            this.empgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empgridview.Size = new System.Drawing.Size(1019, 774);
            this.empgridview.TabIndex = 19;
            this.empgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empgridview_CellContentClick);
            // 
            // emppasswor
            // 
            this.emppasswor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emppasswor.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emppasswor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emppasswor.HintForeColor = System.Drawing.Color.Empty;
            this.emppasswor.HintText = "";
            this.emppasswor.isPassword = false;
            this.emppasswor.LineFocusedColor = System.Drawing.Color.Blue;
            this.emppasswor.LineIdleColor = System.Drawing.Color.Gray;
            this.emppasswor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emppasswor.LineThickness = 5;
            this.emppasswor.Location = new System.Drawing.Point(377, 272);
            this.emppasswor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emppasswor.Name = "emppasswor";
            this.emppasswor.Size = new System.Drawing.Size(264, 67);
            this.emppasswor.TabIndex = 20;
            this.emppasswor.Text = "Employee Password";
            this.emppasswor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 805);
            this.Controls.Add(this.emppasswor);
            this.Controls.Add(this.empgridview);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.empnumber);
            this.Controls.Add(this.empage);
            this.Controls.Add(this.empsalary);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuMaterialTextbox empage;
        private ns1.BunifuMaterialTextbox empsalary;
        private ns1.BunifuMaterialTextbox empname;
        private ns1.BunifuMaterialTextbox empid;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox empnumber;
        private ns1.BunifuThinButton2 backbtn;
        private ns1.BunifuThinButton2 deletebtn;
        private ns1.BunifuThinButton2 updatebtn;
        private ns1.BunifuThinButton2 addbtn;
        private ns1.BunifuCustomDataGrid empgridview;
        private ns1.BunifuMaterialTextbox emppasswor;
    }
}