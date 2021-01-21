using DevExpress.XtraEditors;
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
    public partial class ThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

        string GetMaNV { get; set; }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.MaNV = txtMaNV.Text;
            nhanvien.TenNV = txtTenNV.Text;
            nhanvien.VaiTro = txtVaiTro.Text;
            nhanvien.sdtNV = txtSDT.Text;
            nhanvien.cmtNV = txtCMT.Text;

            


            if (NhanVienController.AddNhanVien(nhanvien))
            {
                XtraMessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CNPMEntities context = new CNPMEntities();
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGrid(listNhanVien);
        }
        private void BindGrid(List<NhanVien> listNhanVien)
        {
            dgvNV.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                int index = dgvNV.Rows.Add();
                dgvNV.Rows[index].Cells[0].Value = item.MaNV;
                dgvNV.Rows[index].Cells[1].Value = item.TenNV;
                dgvNV.Rows[index].Cells[2].Value = item.VaiTro;
                dgvNV.Rows[index].Cells[3].Value = item.sdtNV;
                dgvNV.Rows[index].Cells[4].Value = item.cmtNV;
            }
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            CNPMEntities context = new CNPMEntities();
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGrid(listNhanVien);
        }

        private void dgvNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtVaiTro.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtCMT.Text = row.Cells[4].Value.ToString();
            }
            GetMaNV = txtMaNV.Text.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var dbnv = (from nv in db.NhanViens
                            where nv.MaNV == GetMaNV
                            select nv).FirstOrDefault();
                dbnv.MaNV = txtMaNV.Text;
                dbnv.TenNV = txtTenNV.Text;
                dbnv.VaiTro = txtVaiTro.Text;
                dbnv.sdtNV = txtSDT.Text;
                dbnv.cmtNV = txtCMT.Text;
                db.SaveChanges();
                MessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetMaNV = null;
            CNPMEntities context = new CNPMEntities();
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGrid(listNhanVien);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (NhanVienController.RemoveNhanVien(GetMaNV))
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vui lòng chọn nhân viên để xóa");
            CNPMEntities context = new CNPMEntities();
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGrid(listNhanVien);
        }

    }
}