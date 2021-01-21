
namespace QuanLyChoThueOto
{
    partial class ThongTinLoaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinLoaiXe));
            this.label10 = new System.Windows.Forms.Label();
            this.dgvLX = new System.Windows.Forms.DataGridView();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.clMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLX)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 27);
            this.label10.TabIndex = 106;
            this.label10.Text = "Loại xe";
            // 
            // dgvLX
            // 
            this.dgvLX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaLoai,
            this.clTenLoai,
            this.clSL,
            this.clMoTa});
            this.dgvLX.Location = new System.Drawing.Point(275, 39);
            this.dgvLX.Name = "dgvLX";
            this.dgvLX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLX.Size = new System.Drawing.Size(602, 318);
            this.dgvLX.TabIndex = 107;
            this.dgvLX.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLX_CellMouseClick);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtMoTa.Location = new System.Drawing.Point(88, 178);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(181, 30);
            this.txtMoTa.TabIndex = 3;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtSL.Location = new System.Drawing.Point(88, 141);
            this.txtSL.Multiline = true;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(181, 30);
            this.txtSL.TabIndex = 2;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtTenLoai.Location = new System.Drawing.Point(88, 106);
            this.txtTenLoai.Multiline = true;
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(181, 30);
            this.txtTenLoai.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(8, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 111;
            this.label2.Text = "Mô tả";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.BackColor = System.Drawing.Color.Cornsilk;
            this.labelTenKH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTenKH.Location = new System.Drawing.Point(8, 149);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(63, 17);
            this.labelTenKH.TabIndex = 112;
            this.labelTenKH.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "Tên loại xe";
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThem.ImageOptions.Image")));
            this.btThem.Location = new System.Drawing.Point(287, 363);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 37);
            this.btThem.TabIndex = 126;
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
            this.btSua.Location = new System.Drawing.Point(381, 363);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(88, 37);
            this.btSua.TabIndex = 127;
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
            this.btXoa.Location = new System.Drawing.Point(475, 363);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 37);
            this.btXoa.TabIndex = 128;
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
            this.btThoat.Location = new System.Drawing.Point(569, 363);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 37);
            this.btThoat.TabIndex = 129;
            this.btThoat.Text = "Đóng";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(276, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 113;
            this.label1.Text = "Thông tin các loại xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Mã loại xe";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtMaLoai.Location = new System.Drawing.Point(88, 70);
            this.txtMaLoai.Multiline = true;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(181, 30);
            this.txtMaLoai.TabIndex = 1;
            // 
            // clMaLoai
            // 
            this.clMaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaLoai.HeaderText = "Mã loại xe";
            this.clMaLoai.Name = "clMaLoai";
            // 
            // clTenLoai
            // 
            this.clTenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenLoai.HeaderText = "Tên loại xe";
            this.clTenLoai.Name = "clTenLoai";
            // 
            // clSL
            // 
            this.clSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSL.HeaderText = "Số lượng";
            this.clSL.Name = "clSL";
            // 
            // clMoTa
            // 
            this.clMoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMoTa.HeaderText = "Mô tả";
            this.clMoTa.Name = "clMoTa";
            // 
            // ThongTinLoaiXe
            // 
            this.AcceptButton = this.btThem;
            this.Appearance.BackColor = System.Drawing.Color.Cornsilk;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(880, 412);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvLX);
            this.Controls.Add(this.label10);
            this.Name = "ThongTinLoaiXe";
            this.Text = "Thông tin loại xe";
            this.Load += new System.EventHandler(this.ThongTinLoaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvLX;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoTa;
    }
}