namespace th1
{
    partial class Form3
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
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.GiangVien = new System.Windows.Forms.DataGridView();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(254, 374);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(128, 374);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 374);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // GiangVien
            // 
            this.GiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GiangVien.Location = new System.Drawing.Point(326, 53);
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.RowHeadersWidth = 51;
            this.GiangVien.RowTemplate.Height = 24;
            this.GiangVien.Size = new System.Drawing.Size(562, 266);
            this.GiangVien.TabIndex = 20;
            this.GiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHsinh_CellClick);
            this.GiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GiangVien_CellContentClick);
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(30, 297);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(259, 22);
            this.dtpdate.TabIndex = 19;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(54, 207);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 22);
            this.txtCMND.TabIndex = 18;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(54, 122);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(200, 22);
            this.txtaddress.TabIndex = 17;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(54, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 22);
            this.txtname.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(-57, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-57, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-56, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "dia chi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ho va ten";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.GiangVien);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView GiangVien;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}