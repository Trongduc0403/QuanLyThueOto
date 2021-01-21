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
using QuanLyChoThueOto.Models;
using QuanLyChoThueOto.Controller;

namespace QuanLyChoThueOto
{
    public partial class ThongTinLoaiXe : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinLoaiXe()
        {
            InitializeComponent();
        }

        string GetTenLoai { get; set; }
        private void BindGrid(List<LoaiXe> listLoaiXe)
        {
            dgvLX.Rows.Clear();
            foreach (var item in listLoaiXe)
            {
                int index = dgvLX.Rows.Add();
                dgvLX.Rows[index].Cells[0].Value = item.MaLoai;
                dgvLX.Rows[index].Cells[1].Value = item.TenLoai;
                dgvLX.Rows[index].Cells[2].Value = item.SoLuong;
                dgvLX.Rows[index].Cells[3].Value = item.MoTa;
            }
        }
        private void ThongTinLoaiXe_Load(object sender, EventArgs e)
        {
            CNPMEntities context = new CNPMEntities();
            List<LoaiXe> listLoaiXe = context.LoaiXes.ToList();
            BindGrid(listLoaiXe);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LoaiXe loaixe = new LoaiXe();
            loaixe.MaLoai = txtMaLoai.Text;
            loaixe.TenLoai = txtTenLoai.Text;
            loaixe.SoLuong = int.Parse(txtSL.Text);
            loaixe.MoTa = txtMoTa.Text;
            

            if (LoaiXeController.AddLoaiXe(loaixe))
            {
                XtraMessageBox.Show("Thêm loại xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("Thêm loại xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CNPMEntities context = new CNPMEntities();
            List<LoaiXe> listLoaiXe = context.LoaiXes.ToList();
            BindGrid(listLoaiXe);
        }

        private void dgvLX_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLX.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai.Text = row.Cells[1].Value.ToString();
                txtSL.Text = row.Cells[2].Value.ToString();
                txtMoTa.Text = row.Cells[3].Value.ToString();

            }
            GetTenLoai = txtTenLoai.Text.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var dblx = (from lx in db.LoaiXes
                            where lx.TenLoai == GetTenLoai
                            select lx).FirstOrDefault();
                dblx.MaLoai = txtMaLoai.Text;
                dblx.TenLoai = txtTenLoai.Text;
                dblx.SoLuong = int.Parse(txtSL.Text);
                dblx.MoTa = txtMoTa.Text;
                db.SaveChanges();
                MessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetTenLoai = null;
            CNPMEntities context = new CNPMEntities();
            List<LoaiXe> listLoaiXe = context.LoaiXes.ToList();
            BindGrid(listLoaiXe);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(LoaiXeController.RemoveLoaiXe(GetTenLoai))
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vui lòng chọn loại xe để xóa");
            CNPMEntities context = new CNPMEntities();
            List<LoaiXe> listLoaiXe = context.LoaiXes.ToList();
            BindGrid(listLoaiXe);
        }
    }
}