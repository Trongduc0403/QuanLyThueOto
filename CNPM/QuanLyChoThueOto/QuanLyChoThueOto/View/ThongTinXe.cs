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
    public partial class ThongTinXe : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinXe()
        {
            InitializeComponent();
        }

        string GetBSX { get; set; }

        private void btThem_Click(object sender, EventArgs e)
        {
            Xe xe= new Xe();
            xe.Biensoxe = txtBSX.Text;
            xe.idLoaiXe = (int)cbbLoaiXe.SelectedValue;
            xe.TenXe = txtTenXe.Text;
            xe.PhiXang = txtPhiXang.Text;
            xe.PhiQuaKm = txtPhiQuaKm.Text;
            xe.DonGia = txtDonGia.Text;
            xe.MoTaTT = txtMoTaTT.Text;
            xe.TrangThai = int.Parse(txtTrangThai.Text);

            

            if (XeController.AddXe(xe))
            {
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CNPMEntities context = new CNPMEntities();
            List<Xe> listXe = context.Xes.ToList();
            BindGrid(listXe);
        }

        private void BindGrid(List<Xe> listXe)
        {
            using (var _context = new CNPMEntities())
            {
                var loaixe = (from lx in _context.LoaiXes
                              join x in _context.Xes on lx.idLoaiXe equals x.idLoaiXe
                              select lx).ToList();
            }
            dgvXe.Rows.Clear();
            foreach (var item in listXe)
            {
                int index = dgvXe.Rows.Add();
                dgvXe.Rows[index].Cells[0].Value = item.Biensoxe;
                dgvXe.Rows[index].Cells[1].Value = item.LoaiXe.TenLoai;
                dgvXe.Rows[index].Cells[2].Value = item.TenXe;
                dgvXe.Rows[index].Cells[3].Value = item.PhiXang;
                dgvXe.Rows[index].Cells[4].Value = item.PhiQuaKm;
                dgvXe.Rows[index].Cells[5].Value = item.DonGia;
                dgvXe.Rows[index].Cells[6].Value = item.MoTaTT;
                dgvXe.Rows[index].Cells[7].Value = item.TrangThai;
            }

        }


        private void ThongTinXe_Load(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                
                var xe = (from x in db.LoaiXes
                          select x).ToList();


                this.cbbLoaiXe.DataSource = xe;
                this.cbbLoaiXe.ValueMember = "idLoaiXe";
                this.cbbLoaiXe.DisplayMember = "TenLoai";


                

            }
            CNPMEntities context = new CNPMEntities();
            List<Xe> listXe = context.Xes.ToList();

            BindGrid(listXe);
        }

        private void dgvXe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXe.Rows[e.RowIndex];
                txtBSX.Text = row.Cells[0].Value.ToString();
                cbbLoaiXe.Text = row.Cells[1].Value.ToString();
                txtTenXe.Text = row.Cells[2].Value.ToString();
                txtPhiXang.Text = row.Cells[3].Value.ToString();
                txtPhiQuaKm.Text = row.Cells[4].Value.ToString();
                txtDonGia.Text = row.Cells[5].Value.ToString();
                txtMoTaTT.Text = row.Cells[6].Value.ToString();
                txtTrangThai.Text = row.Cells[7].Value.ToString();
            }
            GetBSX = txtBSX.Text.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var xe = (from x in db.Xes
                            where x.Biensoxe == GetBSX
                            select x).FirstOrDefault();
                xe.Biensoxe = txtBSX.Text;
                xe.idLoaiXe = (int)cbbLoaiXe.SelectedValue;
                xe.TenXe = txtTenXe.Text;
                xe.PhiXang = txtPhiXang.Text;
                xe.PhiQuaKm = txtPhiQuaKm.Text;
                xe.DonGia = txtDonGia.Text;
                xe.MoTaTT = txtMoTaTT.Text;
                xe.TrangThai = int.Parse(txtTrangThai.Text);
                db.SaveChanges();
                MessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GetBSX = null;
            CNPMEntities context = new CNPMEntities();
            List<Xe> xes = context.Xes.ToList();
            BindGrid(xes);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (XeController.RemoveXe(GetBSX))
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vui lòng chọn khách hàng để xóa");

            CNPMEntities context = new CNPMEntities();
            List<Xe> xes = context.Xes.ToList();
            BindGrid(xes);
        }
    }
}