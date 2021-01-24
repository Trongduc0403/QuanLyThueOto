﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChoThueOto.Controller;
using QuanLyChoThueOto.Models;


namespace QuanLyChoThueOto
{
    public partial class HopDongThueXe : DevExpress.XtraEditors.XtraForm
    {
        
        public HopDongThueXe()
        {
            InitializeComponent();
        }
        string GetMaHD { get; set; }
        //private void BindGrid(List<HopDong> listHopDong)
        //{
        //    //dgvHD.Rows.Clear();
        //    //foreach (var item in listHopDong)
        //    //{
        //    //    int index = dgvHD.Rows.Add();
        //    //    dgvHD.Rows[index].Cells[0].Value = item.idHopDong;
        //    //    dgvHD.Rows[index].Cells[1].Value = item.;
        //    //    dgvHD.Rows[index].Cells[2].Value = item.
        //    //    dgvHD.Rows[index].Cells[3].Value = item.MaKH;
        //    //    dgvHD.Rows[index].Cells[4].Value = item.NgayHD;
        //    //    dgvHD.Rows[index].Cells[5].Value = item.TienDat;
        //    //    dgvHD.Rows[index].Cells[6].Value = item.KhuyenMai;
        //    //    dgvHD.Rows[index].Cells[7].Value = item.NoiDungHD;
        //    //    dgvHD.Rows[index].Cells[8].Value = item.GiayToGiuLai;
        //    //}
        //}
        //private void FillMaKHCombobox(List<KhachHang> listKhachHang)
        //{
        //    this.cbbMaKH.DataSource = listKhachHang;
        //    this.cbbMaKH.DisplayMember = "MaKH";
        //}

        //private void FillMaNVCombobox(List<NhanVien> listNHANVIENs)
        //{
        //    this.cbbMaNV.DataSource = listNHANVIENs;
        //    this.cbbMaNV.DisplayMember = "MaNV";
        //}

        //private void FillSoXeCombobox(List<Xe> listXE)
        //{
        //    this.cbbSoXe.DataSource = listXE;
        //    this.cbbSoXe.DisplayMember = "SoXe";
        //}

        private void BindGrid(List<HopDong> lstHopDong)
        {
            dgvHD.Rows.Clear();
            int i = 0;
            foreach (var item in lstHopDong)
            {
                using (CNPMEntities db= new CNPMEntities())
                {
                    var getnv = (from hd in db.HopDongs
                                 join nv in db.NhanViens on hd.idNV equals nv.idNV
                                 select nv).ToList();
                    var getkh = (from hd in db.HopDongs
                                 join kh in db.KhachHangs on hd.idKH equals kh.idKH
                                 select kh).ToList();
                    var xe = (from hd in db.HopDongs
                              join x in db.Xes on hd.idXe equals x.idXe
                              select x).ToList();

                    int index = dgvHD.Rows.Add();
                   
                    dgvHD.Rows[index].Cells[0].Value = item.MaHD;
                    dgvHD.Rows[index].Cells[1].Value = xe[i].Biensoxe;
                    dgvHD.Rows[index].Cells[2].Value = getnv[i].MaNV;
                    dgvHD.Rows[index].Cells[3].Value = getkh[i].MaKH;
                    dgvHD.Rows[index].Cells[4].Value = item.NgayHD;
                    dgvHD.Rows[index].Cells[5].Value = item.TienDat;
                    dgvHD.Rows[index].Cells[6].Value = item.KhuyenMai;
                    dgvHD.Rows[index].Cells[7].Value = item.NoiDungHD;
                    dgvHD.Rows[index].Cells[8].Value = item.GiayToGiuLai;
                    i++;
                }
                
            }
        }

        private void HopDongThueXe_Load(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var getnv = (from nv in db.NhanViens
                             select nv).ToList();
                var getkh = (from kh in db.KhachHangs
                             select kh).ToList();
                var xe = (from x in db.Xes
                          select x).ToList();
                this.cbbMaNV.DataSource = getnv;
                this.cbbMaNV.ValueMember = "idNV";
                this.cbbMaNV.DisplayMember = "MaNV";

                this.cbbMaKH.DataSource = getkh;
                this.cbbMaKH.ValueMember = "idKH";
                this.cbbMaKH.DisplayMember = "MaKH";

                this.cbbSoXe.DataSource = xe;
                this.cbbSoXe.ValueMember = "idXe";
                this.cbbSoXe.DisplayMember = "Biensoxe";

            }
                CNPMEntities context = new CNPMEntities();
                List<HopDong> lstHopDong = context.HopDongs.ToList();
                BindGrid(lstHopDong);

            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HopDong hopdong = new HopDong();
            try
            {
                hopdong.MaHD = txtSoDH.Text;
                hopdong.idXe = (int)cbbSoXe.SelectedValue;
                hopdong.idNV = (int)cbbMaNV.SelectedValue;
                hopdong.idKH = (int)cbbMaKH.SelectedValue;
                hopdong.NgayHD = DateTime.Parse(msktbNgayHD.Text.ToString());
                hopdong.TienDat = txtTienDat.Text;
                hopdong.KhuyenMai = txtKhuyenMai.Text;
                hopdong.NoiDungHD = txtNoiDungHD.Text;
                hopdong.GiayToGiuLai = txtGiayTo.Text;
                if (HopDongController.AddHopDong(hopdong))
                {
                    XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CNPMEntities context = new CNPMEntities();
                List<HopDong> lstHopDong = context.HopDongs.ToList();
                BindGrid(lstHopDong);
            }
            catch
            {
                MessageBox.Show("Nhập tất cả các thuộc tính và đảm bảo giá trị nhập đúng với giá trị cần lưu");
            }
            
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (CNPMEntities db = new CNPMEntities())
                {
                    var dbhd = (from hd in db.HopDongs
                                where hd.MaHD == GetMaHD
                                select hd).FirstOrDefault();
                    dbhd.MaHD = txtSoDH.Text.ToString();
                    dbhd.idXe = (int)cbbSoXe.SelectedValue;
                    dbhd.idNV = (int)cbbMaNV.SelectedValue;
                    dbhd.idKH = (int)cbbMaKH.SelectedValue;
                    dbhd.NgayHD = DateTime.Parse(msktbNgayHD.Text.ToString());
                    dbhd.TienDat = txtTienDat.Text;
                    dbhd.KhuyenMai = txtKhuyenMai.Text.ToString();
                    dbhd.NoiDungHD = txtNoiDungHD.Text.ToString();
                    dbhd.GiayToGiuLai = txtGiayTo.Text.ToString();
                    db.SaveChanges();
                    XtraMessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                GetMaHD = null;
                CNPMEntities context = new CNPMEntities();
                List<HopDong> lstHopDong = context.HopDongs.ToList();
                BindGrid(lstHopDong);
            }
            catch
            {
                MessageBox.Show("Nhập tất cả các thuộc tính và đảm bảo giá trị nhập đúng với giá trị cần lưu");
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (HopDongController.RemoveHopDong(GetMaHD))
                MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("vui long chon hang de xoa");

            CNPMEntities context = new CNPMEntities();
            List<HopDong> lstHopDong = context.HopDongs.ToList();
            BindGrid(lstHopDong);
        }

        private void dgvHD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btIn.Enabled = true;

            
            CNPMEntities context = new CNPMEntities();
            List<HopDong> lstHopDong = context.HopDongs.ToList();
            BindGrid(lstHopDong);
            // phải doubleclick để chọn row, vì lúc đầu click vào nó phải load lại datagridview nên con trỏ chuột về lại đầu, có cách khác xử lý hay hơn, đều t nhác làm :v
            if (e.RowIndex < lstHopDong.Count)
            {
                    DataGridViewRow row = dgvHD.Rows[e.RowIndex];
                    txtSoDH.Text = row.Cells[0].Value.ToString();
                    txtTienDat.Text = row.Cells[5].Value.ToString();
                    txtKhuyenMai.Text = row.Cells[6].Value.ToString();
                    txtNoiDungHD.Text = row.Cells[7].Value.ToString();
                    txtGiayTo.Text = row.Cells[8].Value.ToString();
                    msktbNgayHD.Text = row.Cells[4].Value.ToString();
                    cbbMaKH.Text = row.Cells[3].Value.ToString();
                    cbbMaNV.Text = row.Cells[2].Value.ToString();
                    cbbSoXe.Text = row.Cells[1].Value.ToString();
                    GetMaHD = txtSoDH.Text.ToString();
            }
            else
            {
                btSua.Enabled = false;
                btXoa.Enabled = false;
                btIn.Enabled = false;
                MessageBox.Show("Chọn sai record");
                return;
            }
            
        }
    }
}