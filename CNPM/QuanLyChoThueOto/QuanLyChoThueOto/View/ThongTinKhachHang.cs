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
    public partial class ThongTinKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        string GetMaKH { get; set; }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BindGrid(List<KhachHang> listKhachHang)
        {
            dgvKH.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = dgvKH.Rows.Add();
                dgvKH.Rows[index].Cells[0].Value = item.MaKH;
                dgvKH.Rows[index].Cells[1].Value = item.TenKH;
                dgvKH.Rows[index].Cells[2].Value = item.DiaChi;
                dgvKH.Rows[index].Cells[3].Value = item.sdtKH;
                dgvKH.Rows[index].Cells[4].Value = item.cmtKH;
                dgvKH.Rows[index].Cells[5].Value = item.GPLX;
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            CNPMEntities context = new CNPMEntities();
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();
            BindGrid(listKhachHang);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            KhachHang KhachHang = new KhachHang();
            KhachHang.MaKH = txtMaKH.Text;
            KhachHang.TenKH = txtTenKH.Text;
            KhachHang.DiaChi = txtDiaChi.Text;
            KhachHang.sdtKH = txtSDT.Text;
            KhachHang.cmtKH = txtCMT.Text;
            KhachHang.GPLX = txtGPLX.Text;
            dgvKH.Rows.Add(1);
            int index = dgvKH.Rows.Count - 1;
            dgvKH.Rows[index - 1].Cells[0].Value = KhachHang.MaKH;
            dgvKH.Rows[index - 1].Cells[1].Value = KhachHang.TenKH;
            dgvKH.Rows[index - 1].Cells[2].Value = KhachHang.DiaChi;
            dgvKH.Rows[index - 1].Cells[3].Value = KhachHang.sdtKH;
            dgvKH.Rows[index - 1].Cells[4].Value = KhachHang.cmtKH;
            dgvKH.Rows[index - 1].Cells[5].Value = KhachHang.GPLX;

            if (KhachHangController.AddKhachHang(KhachHang))
            {
                XtraMessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString(); 
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtCMT.Text = row.Cells[4].Value.ToString();
                txtGPLX.Text = row.Cells[5].Value.ToString();
            }
            GetMaKH = txtMaKH.Text.ToString();
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var dbkh = (from kh in db.KhachHangs
                            where kh.MaKH == GetMaKH
                            select kh).FirstOrDefault();
                dbkh.MaKH = txtMaKH.Text;
                dbkh.TenKH = txtTenKH.Text;
                dbkh.DiaChi = txtDiaChi.Text;
                dbkh.sdtKH = txtSDT.Text;
                dbkh.cmtKH = txtCMT.Text;
                dbkh.GPLX = txtGPLX.Text;
                db.SaveChanges();
                MessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GetMaKH = null;

            CNPMEntities context = new CNPMEntities();
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();
            BindGrid(listKhachHang);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (KhachHangController.RemoveKhachHang(GetMaKH))
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vui lòng chọn khách hàng để xóa");

            CNPMEntities context = new CNPMEntities();
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();
            BindGrid(listKhachHang);
        }
    }
}