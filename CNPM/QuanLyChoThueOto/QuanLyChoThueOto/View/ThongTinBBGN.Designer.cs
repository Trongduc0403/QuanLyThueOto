
namespace QuanLyChoThueOto
{
    partial class ThongTinBBGN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinBBGN));
            this.label1 = new System.Windows.Forms.Label();
            this.mskNgayNhan = new System.Windows.Forms.MaskedTextBox();
            this.mskNgayGiao = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtXangVe = new System.Windows.Forms.TextBox();
            this.txtXangDi = new System.Windows.Forms.TextBox();
            this.txtTTVe = new System.Windows.Forms.TextBox();
            this.txtTTDi = new System.Windows.Forms.TextBox();
            this.txtKmVe = new System.Windows.Forms.TextBox();
            this.txtKmDi = new System.Windows.Forms.TextBox();
            this.txtMaBBGN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBBGN = new System.Windows.Forms.DataGridView();
            this.clMaBBGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKmDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXangDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoTaTTDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKmVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoTaTTVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btIn = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbSoXe = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBGN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Biên bản Giao/Nhận";
            // 
            // mskNgayNhan
            // 
            this.mskNgayNhan.Font = new System.Drawing.Font("Tahoma", 14F);
            this.mskNgayNhan.Location = new System.Drawing.Point(693, 92);
            this.mskNgayNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgayNhan.Mask = "00/00/0000";
            this.mskNgayNhan.Name = "mskNgayNhan";
            this.mskNgayNhan.Size = new System.Drawing.Size(208, 36);
            this.mskNgayNhan.TabIndex = 9;
            this.mskNgayNhan.ValidatingType = typeof(System.DateTime);
            // 
            // mskNgayGiao
            // 
            this.mskNgayGiao.Font = new System.Drawing.Font("Tahoma", 14F);
            this.mskNgayGiao.Location = new System.Drawing.Point(100, 92);
            this.mskNgayGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgayGiao.Mask = "00/00/0000";
            this.mskNgayGiao.Name = "mskNgayGiao";
            this.mskNgayGiao.Size = new System.Drawing.Size(208, 36);
            this.mskNgayGiao.TabIndex = 5;
            this.mskNgayGiao.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.Fuchsia;
            this.label15.Location = new System.Drawing.Point(909, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 19);
            this.label15.TabIndex = 84;
            this.label15.Text = "(Ngày/Tháng/Năm)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.Color.Fuchsia;
            this.label14.Location = new System.Drawing.Point(322, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 19);
            this.label14.TabIndex = 83;
            this.label14.Text = "(Ngày/Tháng/Năm)";
            // 
            // txtXangVe
            // 
            this.txtXangVe.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtXangVe.Location = new System.Drawing.Point(693, 181);
            this.txtXangVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXangVe.Multiline = true;
            this.txtXangVe.Name = "txtXangVe";
            this.txtXangVe.Size = new System.Drawing.Size(208, 36);
            this.txtXangVe.TabIndex = 11;
            // 
            // txtXangDi
            // 
            this.txtXangDi.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtXangDi.Location = new System.Drawing.Point(100, 181);
            this.txtXangDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXangDi.Multiline = true;
            this.txtXangDi.Name = "txtXangDi";
            this.txtXangDi.Size = new System.Drawing.Size(208, 36);
            this.txtXangDi.TabIndex = 7;
            // 
            // txtTTVe
            // 
            this.txtTTVe.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtTTVe.Location = new System.Drawing.Point(693, 225);
            this.txtTTVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTTVe.Multiline = true;
            this.txtTTVe.Name = "txtTTVe";
            this.txtTTVe.Size = new System.Drawing.Size(318, 36);
            this.txtTTVe.TabIndex = 12;
            // 
            // txtTTDi
            // 
            this.txtTTDi.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtTTDi.Location = new System.Drawing.Point(100, 225);
            this.txtTTDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTTDi.Multiline = true;
            this.txtTTDi.Name = "txtTTDi";
            this.txtTTDi.Size = new System.Drawing.Size(318, 36);
            this.txtTTDi.TabIndex = 8;
            // 
            // txtKmVe
            // 
            this.txtKmVe.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtKmVe.Location = new System.Drawing.Point(693, 137);
            this.txtKmVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKmVe.Multiline = true;
            this.txtKmVe.Name = "txtKmVe";
            this.txtKmVe.Size = new System.Drawing.Size(208, 36);
            this.txtKmVe.TabIndex = 10;
            // 
            // txtKmDi
            // 
            this.txtKmDi.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtKmDi.Location = new System.Drawing.Point(100, 137);
            this.txtKmDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKmDi.Multiline = true;
            this.txtKmDi.Name = "txtKmDi";
            this.txtKmDi.Size = new System.Drawing.Size(208, 36);
            this.txtKmDi.TabIndex = 6;
            // 
            // txtMaBBGN
            // 
            this.txtMaBBGN.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtMaBBGN.Location = new System.Drawing.Point(100, 48);
            this.txtMaBBGN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaBBGN.Multiline = true;
            this.txtMaBBGN.Name = "txtMaBBGN";
            this.txtMaBBGN.Size = new System.Drawing.Size(208, 36);
            this.txtMaBBGN.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(600, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Km về";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(600, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ngày trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(600, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 66;
            this.label8.Text = "Mô tả TT về";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(10, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Mô tả TT đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Km đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Ngày giao";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(600, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 21);
            this.label13.TabIndex = 73;
            this.label13.Text = "Xăng về";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(15, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 71;
            this.label11.Text = "Xăng đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Mã BBGN";
            // 
            // dgvBBGN
            // 
            this.dgvBBGN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBBGN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBGN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaBBGN,
            this.clSoHD,
            this.clMaKH,
            this.clMaNV,
            this.clNgayGiao,
            this.clKmDi,
            this.clXangDi,
            this.clMoTaTTDi,
            this.clNgayTra,
            this.clKmVe,
            this.clXangVe,
            this.clMoTaTTVe});
            this.dgvBBGN.Location = new System.Drawing.Point(1, 329);
            this.dgvBBGN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBBGN.Name = "dgvBBGN";
            this.dgvBBGN.RowHeadersWidth = 51;
            this.dgvBBGN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBBGN.Size = new System.Drawing.Size(1209, 420);
            this.dgvBBGN.TabIndex = 99;
            this.dgvBBGN.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBBGN_CellMouseClick);
            // 
            // clMaBBGN
            // 
            this.clMaBBGN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaBBGN.HeaderText = "Mã BBGN";
            this.clMaBBGN.MinimumWidth = 6;
            this.clMaBBGN.Name = "clMaBBGN";
            // 
            // clSoHD
            // 
            this.clSoHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSoHD.HeaderText = "Số xe";
            this.clSoHD.MinimumWidth = 6;
            this.clSoHD.Name = "clSoHD";
            // 
            // clMaKH
            // 
            this.clMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaKH.HeaderText = "Mã KH";
            this.clMaKH.MinimumWidth = 6;
            this.clMaKH.Name = "clMaKH";
            // 
            // clMaNV
            // 
            this.clMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaNV.HeaderText = "Mã NV";
            this.clMaNV.MinimumWidth = 6;
            this.clMaNV.Name = "clMaNV";
            // 
            // clNgayGiao
            // 
            this.clNgayGiao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayGiao.HeaderText = "Ngày giao";
            this.clNgayGiao.MinimumWidth = 6;
            this.clNgayGiao.Name = "clNgayGiao";
            // 
            // clKmDi
            // 
            this.clKmDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clKmDi.HeaderText = "Km đi";
            this.clKmDi.MinimumWidth = 6;
            this.clKmDi.Name = "clKmDi";
            // 
            // clXangDi
            // 
            this.clXangDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clXangDi.HeaderText = "Xăng đi";
            this.clXangDi.MinimumWidth = 6;
            this.clXangDi.Name = "clXangDi";
            // 
            // clMoTaTTDi
            // 
            this.clMoTaTTDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMoTaTTDi.HeaderText = "Mô tả trạng thái đi";
            this.clMoTaTTDi.MinimumWidth = 6;
            this.clMoTaTTDi.Name = "clMoTaTTDi";
            // 
            // clNgayTra
            // 
            this.clNgayTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayTra.HeaderText = "Ngày trả";
            this.clNgayTra.MinimumWidth = 6;
            this.clNgayTra.Name = "clNgayTra";
            // 
            // clKmVe
            // 
            this.clKmVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clKmVe.HeaderText = "Km về";
            this.clKmVe.MinimumWidth = 6;
            this.clKmVe.Name = "clKmVe";
            // 
            // clXangVe
            // 
            this.clXangVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clXangVe.HeaderText = "Xăng về";
            this.clXangVe.MinimumWidth = 6;
            this.clXangVe.Name = "clXangVe";
            // 
            // clMoTaTTVe
            // 
            this.clMoTaTTVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMoTaTTVe.HeaderText = "Mô tả tình trạng về";
            this.clMoTaTTVe.MinimumWidth = 6;
            this.clMoTaTTVe.Name = "clMoTaTTVe";
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThem.ImageOptions.Image")));
            this.btThem.Location = new System.Drawing.Point(304, 276);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(103, 46);
            this.btThem.TabIndex = 88;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Enabled = false;
            this.btSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSua.ImageOptions.Image")));
            this.btSua.Location = new System.Drawing.Point(414, 276);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(103, 46);
            this.btSua.TabIndex = 89;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Enabled = false;
            this.btXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.ImageOptions.Image")));
            this.btXoa.Location = new System.Drawing.Point(524, 276);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(103, 46);
            this.btXoa.TabIndex = 90;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThoat.Appearance.Options.UseFont = true;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.ImageOptions.Image")));
            this.btThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btThoat.Location = new System.Drawing.Point(743, 276);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(103, 46);
            this.btThoat.TabIndex = 91;
            this.btThoat.Text = "Đóng";
            // 
            // btIn
            // 
            this.btIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btIn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btIn.Appearance.Options.UseFont = true;
            this.btIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btIn.Enabled = false;
            this.btIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btIn.ImageOptions.Image")));
            this.btIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btIn.Location = new System.Drawing.Point(633, 276);
            this.btIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(103, 46);
            this.btIn.TabIndex = 92;
            this.btIn.Text = "In";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Cornsilk;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(321, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 94;
            this.label9.Text = "Số Xe";
            // 
            // cbbSoXe
            // 
            this.cbbSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoXe.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.cbbSoXe.FormattingEnabled = true;
            this.cbbSoXe.Location = new System.Drawing.Point(378, 48);
            this.cbbSoXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSoXe.Name = "cbbSoXe";
            this.cbbSoXe.Size = new System.Drawing.Size(210, 35);
            this.cbbSoXe.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Cornsilk;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(600, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 94;
            this.label10.Text = "Mã KH";
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaKH.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(693, 48);
            this.cbbMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(210, 35);
            this.cbbMaKH.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Cornsilk;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(922, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 94;
            this.label12.Text = "Mã NV";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(979, 48);
            this.cbbMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(210, 35);
            this.cbbMaNV.TabIndex = 4;
            // 
            // ThongTinBBGN
            // 
            this.AcceptButton = this.btThem;
            this.Appearance.BackColor = System.Drawing.Color.Cornsilk;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(1212, 752);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbSoXe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.dgvBBGN);
            this.Controls.Add(this.mskNgayNhan);
            this.Controls.Add(this.mskNgayGiao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtXangVe);
            this.Controls.Add(this.txtXangDi);
            this.Controls.Add(this.txtTTVe);
            this.Controls.Add(this.txtTTDi);
            this.Controls.Add(this.txtKmVe);
            this.Controls.Add(this.txtKmDi);
            this.Controls.Add(this.txtMaBBGN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThongTinBBGN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biên bản giao/nhận";
            this.Load += new System.EventHandler(this.ThongTinBBGN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBGN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNgayNhan;
        private System.Windows.Forms.MaskedTextBox mskNgayGiao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtXangVe;
        private System.Windows.Forms.TextBox txtXangDi;
        private System.Windows.Forms.TextBox txtTTVe;
        private System.Windows.Forms.TextBox txtTTDi;
        private System.Windows.Forms.TextBox txtKmVe;
        private System.Windows.Forms.TextBox txtKmDi;
        private System.Windows.Forms.TextBox txtMaBBGN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBBGN;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private DevExpress.XtraEditors.SimpleButton btIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbSoXe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaBBGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKmDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXangDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoTaTTDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKmVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoTaTTVe;
    }
}