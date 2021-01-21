
namespace QuanLyChoThueOto
{
    partial class ThongTinKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinKhachHang));
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.clMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGPLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGPLX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKH
            // 
            this.dgvKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaKH,
            this.clTenKH,
            this.clDiaChi,
            this.clSDT,
            this.clCMT,
            this.clGPLX});
            this.dgvKH.Location = new System.Drawing.Point(260, 66);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(674, 296);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKH_CellMouseClick);
            // 
            // clMaKH
            // 
            this.clMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaKH.HeaderText = "Mã KH";
            this.clMaKH.Name = "clMaKH";
            // 
            // clTenKH
            // 
            this.clTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenKH.HeaderText = "Tên KH";
            this.clTenKH.Name = "clTenKH";
            // 
            // clDiaChi
            // 
            this.clDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.Name = "clDiaChi";
            // 
            // clSDT
            // 
            this.clSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSDT.HeaderText = "SĐT KH";
            this.clSDT.Name = "clSDT";
            // 
            // clCMT
            // 
            this.clCMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clCMT.HeaderText = "CMT KH";
            this.clCMT.Name = "clCMT";
            // 
            // clGPLX
            // 
            this.clGPLX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGPLX.HeaderText = "GPLX";
            this.clGPLX.Name = "clGPLX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(49, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 27);
            this.label10.TabIndex = 106;
            this.label10.Text = "Khách hàng";
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThem.ImageOptions.Image")));
            this.btThem.Location = new System.Drawing.Point(258, 368);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 37);
            this.btThem.TabIndex = 108;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Enabled = false;
            this.btSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSua.ImageOptions.Image")));
            this.btSua.Location = new System.Drawing.Point(352, 368);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(88, 37);
            this.btSua.TabIndex = 109;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Enabled = false;
            this.btXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.ImageOptions.Image")));
            this.btXoa.Location = new System.Drawing.Point(446, 368);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 37);
            this.btXoa.TabIndex = 110;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThoat.Appearance.Options.UseFont = true;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.ImageOptions.Image")));
            this.btThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btThoat.Location = new System.Drawing.Point(540, 368);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 37);
            this.btThoat.TabIndex = 111;
            this.btThoat.Text = "Đóng";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtDiaChi.Location = new System.Drawing.Point(73, 175);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(181, 30);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtTenKH.Location = new System.Drawing.Point(73, 138);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(181, 30);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtSDT.Location = new System.Drawing.Point(73, 211);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(181, 30);
            this.txtSDT.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(12, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "GPLX";
            // 
            // txtCMT
            // 
            this.txtCMT.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtCMT.Location = new System.Drawing.Point(73, 247);
            this.txtCMT.Multiline = true;
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(181, 30);
            this.txtCMT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Số CMT";
            // 
            // txtGPLX
            // 
            this.txtGPLX.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtGPLX.Location = new System.Drawing.Point(73, 283);
            this.txtGPLX.Multiline = true;
            this.txtGPLX.Name = "txtGPLX";
            this.txtGPLX.Size = new System.Drawing.Size(181, 30);
            this.txtGPLX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 90;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Địa chỉ";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.BackColor = System.Drawing.Color.Cornsilk;
            this.labelTenKH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTenKH.Location = new System.Drawing.Point(12, 147);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(52, 17);
            this.labelTenKH.TabIndex = 90;
            this.labelTenKH.Text = "Tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtMaKH.Location = new System.Drawing.Point(73, 103);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(181, 30);
            this.txtMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(257, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // ThongTinKhachHang
            // 
            this.AcceptButton = this.btThem;
            this.Appearance.BackColor = System.Drawing.Color.Cornsilk;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(938, 408);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtGPLX);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKH);
            this.Name = "ThongTinKhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGPLX;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGPLX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
    }
}