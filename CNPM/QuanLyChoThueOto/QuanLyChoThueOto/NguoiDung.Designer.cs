
namespace QuanLyChoThueOto
{
    partial class NguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiDung));
            this.dgvND = new System.Windows.Forms.DataGridView();
            this.clTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvND
            // 
            this.dgvND.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTaiKhoan,
            this.clMatKhau});
            this.dgvND.Location = new System.Drawing.Point(1, 6);
            this.dgvND.Name = "dgvND";
            this.dgvND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvND.Size = new System.Drawing.Size(507, 232);
            this.dgvND.TabIndex = 0;
            this.dgvND.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvND_CellMouseClick);
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTaiKhoan.HeaderText = "Tài khoản";
            this.clTaiKhoan.Name = "clTaiKhoan";
            // 
            // clMatKhau
            // 
            this.clMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMatKhau.HeaderText = "Mật khẩu";
            this.clMatKhau.Name = "clMatKhau";
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThem.ImageOptions.Image")));
            this.btThem.Location = new System.Drawing.Point(132, 244);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 37);
            this.btThem.TabIndex = 112;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Enabled = false;
            this.btXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.ImageOptions.Image")));
            this.btXoa.Location = new System.Drawing.Point(226, 244);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 37);
            this.btXoa.TabIndex = 113;
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
            this.btThoat.Location = new System.Drawing.Point(320, 244);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 37);
            this.btThoat.TabIndex = 114;
            this.btThoat.Text = "Đóng";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // NguoiDung
            // 
            this.Appearance.BackColor = System.Drawing.Color.Cornsilk;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 293);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dgvND);
            this.Name = "NguoiDung";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMatKhau;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        public System.Windows.Forms.DataGridView dgvND;
    }
}