
namespace Pharmacy
{
    partial class Medicine_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine_Stock));
            this.label1 = new System.Windows.Forms.Label();
            this.medname = new ns1.BunifuMaterialTextbox();
            this.medgridview = new ns1.BunifuCustomDataGrid();
            this.bptb = new ns1.BunifuMaterialTextbox();
            this.sptb = new ns1.BunifuMaterialTextbox();
            this.qttb = new ns1.BunifuMaterialTextbox();
            this.comcb = new System.Windows.Forms.ComboBox();
            this.addbtn = new ns1.BunifuThinButton2();
            this.updatebtn = new ns1.BunifuThinButton2();
            this.deletebtn = new ns1.BunifuThinButton2();
            this.backbtn = new ns1.BunifuThinButton2();
            this.expdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.medgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Stock";
            // 
            // medname
            // 
            this.medname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medname.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medname.HintForeColor = System.Drawing.Color.Empty;
            this.medname.HintText = "";
            this.medname.isPassword = false;
            this.medname.LineFocusedColor = System.Drawing.Color.Blue;
            this.medname.LineIdleColor = System.Drawing.Color.Gray;
            this.medname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.medname.LineThickness = 5;
            this.medname.Location = new System.Drawing.Point(26, 134);
            this.medname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.medname.Name = "medname";
            this.medname.Size = new System.Drawing.Size(264, 67);
            this.medname.TabIndex = 1;
            this.medname.Text = "Medicine Name";
            this.medname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // medgridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.medgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medgridview.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.medgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medgridview.ColumnHeadersHeight = 29;
            this.medgridview.DoubleBuffered = true;
            this.medgridview.EnableHeadersVisualStyles = false;
            this.medgridview.GridColor = System.Drawing.Color.Blue;
            this.medgridview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.medgridview.HeaderForeColor = System.Drawing.Color.White;
            this.medgridview.Location = new System.Drawing.Point(717, 4);
            this.medgridview.Name = "medgridview";
            this.medgridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medgridview.RowHeadersWidth = 51;
            this.medgridview.RowTemplate.Height = 24;
            this.medgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medgridview.Size = new System.Drawing.Size(974, 799);
            this.medgridview.TabIndex = 2;
            this.medgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // bptb
            // 
            this.bptb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bptb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bptb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bptb.HintForeColor = System.Drawing.Color.Empty;
            this.bptb.HintText = "";
            this.bptb.isPassword = false;
            this.bptb.LineFocusedColor = System.Drawing.Color.Blue;
            this.bptb.LineIdleColor = System.Drawing.Color.Gray;
            this.bptb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bptb.LineThickness = 5;
            this.bptb.Location = new System.Drawing.Point(441, 134);
            this.bptb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bptb.Name = "bptb";
            this.bptb.Size = new System.Drawing.Size(264, 67);
            this.bptb.TabIndex = 3;
            this.bptb.Text = "Buying Price";
            this.bptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sptb
            // 
            this.sptb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sptb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sptb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sptb.HintForeColor = System.Drawing.Color.Empty;
            this.sptb.HintText = "";
            this.sptb.isPassword = false;
            this.sptb.LineFocusedColor = System.Drawing.Color.Blue;
            this.sptb.LineIdleColor = System.Drawing.Color.Gray;
            this.sptb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sptb.LineThickness = 5;
            this.sptb.Location = new System.Drawing.Point(441, 290);
            this.sptb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sptb.Name = "sptb";
            this.sptb.Size = new System.Drawing.Size(264, 67);
            this.sptb.TabIndex = 4;
            this.sptb.Text = "Selling Price";
            this.sptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // qttb
            // 
            this.qttb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qttb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qttb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qttb.HintForeColor = System.Drawing.Color.Empty;
            this.qttb.HintText = "";
            this.qttb.isPassword = false;
            this.qttb.LineFocusedColor = System.Drawing.Color.Blue;
            this.qttb.LineIdleColor = System.Drawing.Color.Gray;
            this.qttb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.qttb.LineThickness = 5;
            this.qttb.Location = new System.Drawing.Point(441, 447);
            this.qttb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.qttb.Name = "qttb";
            this.qttb.Size = new System.Drawing.Size(264, 67);
            this.qttb.TabIndex = 5;
            this.qttb.Text = "Quantity";
            this.qttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comcb
            // 
            this.comcb.BackColor = System.Drawing.Color.White;
            this.comcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comcb.FormattingEnabled = true;
            this.comcb.Items.AddRange(new object[] {
            "INDIAN MEDICINE",
            "AFRICANMED",
            "NPL",
            "MAGNUS",
            "SPOUTIN"});
            this.comcb.Location = new System.Drawing.Point(26, 457);
            this.comcb.Name = "comcb";
            this.comcb.Size = new System.Drawing.Size(264, 37);
            this.comcb.TabIndex = 7;
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
            this.addbtn.Location = new System.Drawing.Point(26, 587);
            this.addbtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(186, 72);
            this.addbtn.TabIndex = 8;
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbtn.Click += new System.EventHandler(this.bunifuThinButton21_Click);
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
            this.updatebtn.Location = new System.Drawing.Point(268, 587);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(186, 72);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
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
            this.deletebtn.Location = new System.Drawing.Point(519, 587);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(186, 72);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
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
            this.backbtn.Location = new System.Drawing.Point(277, 690);
            this.backbtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(186, 72);
            this.backbtn.TabIndex = 11;
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // expdate
            // 
            this.expdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdate.Location = new System.Drawing.Point(26, 306);
            this.expdate.Name = "expdate";
            this.expdate.Size = new System.Drawing.Size(264, 22);
            this.expdate.TabIndex = 12;
            // 
            // Medicine_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 803);
            this.Controls.Add(this.expdate);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.comcb);
            this.Controls.Add(this.qttb);
            this.Controls.Add(this.sptb);
            this.Controls.Add(this.bptb);
            this.Controls.Add(this.medgridview);
            this.Controls.Add(this.medname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medicine_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine_Stock";
            this.Load += new System.EventHandler(this.Medicine_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox medname;
        private ns1.BunifuCustomDataGrid medgridview;
        private ns1.BunifuMaterialTextbox bptb;
        private ns1.BunifuMaterialTextbox sptb;
        private ns1.BunifuMaterialTextbox qttb;
        private System.Windows.Forms.ComboBox comcb;
        private ns1.BunifuThinButton2 addbtn;
        private ns1.BunifuThinButton2 updatebtn;
        private ns1.BunifuThinButton2 deletebtn;
        private ns1.BunifuThinButton2 backbtn;
        private System.Windows.Forms.DateTimePicker expdate;
    }
}