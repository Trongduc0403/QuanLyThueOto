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


namespace QuanLyChoThueOto
{
    public partial class ManHinhChinh : DevExpress.XtraEditors.XtraForm
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }



        private void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "DevExpress Style";
        }

        private void BindGrid(List<Xe> lstXe)
        {
            dgvXe.Rows.Clear();
            int i = 0;
            foreach (var item in lstXe)
            {
                using (CNPMEntities db = new CNPMEntities())
                {
                    int index = dgvXe.Rows.Add();

                    dgvXe.Rows[index].Cells[0].Value = item.Biensoxe;
                    dgvXe.Rows[index].Cells[1].Value = item.TenXe;
                    dgvXe.Rows[index].Cells[2].Value = item.PhiXang;
                    dgvXe.Rows[index].Cells[3].Value = item.PhiQuaKm;
                    dgvXe.Rows[index].Cells[4].Value = item.DonGia;
                    dgvXe.Rows[index].Cells[5].Value = item.MoTaTT;
                    dgvXe.Rows[index].Cells[6].Value = item.TrangThai;
                    i++;
                }

            }
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlythueotoDataSet5.XE' table. You can move, or remove it, as needed.
            skin();
            CNPMEntities context = new CNPMEntities();
            List<Xe> lstXe = context.Xes.ToList();
            BindGrid(lstXe);


        }

        private void btDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }


        private void btXeDaThue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CNPMEntities db = new CNPMEntities();
            var getxe = (from xe in db.Xes
                         where xe.TrangThai == 1
                         select xe).ToList();
            BindGrid(getxe);
        }


        private void btHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HopDongThueXe formHDThueXe = new HopDongThueXe();
            this.Hide();
            formHDThueXe.ShowDialog();
            this.Show();
        }

        private void btBBGiaoNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinBBGN f = new ThongTinBBGN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btXeRanh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CNPMEntities db = new CNPMEntities();
            var getxe = (from xe in db.Xes
                         where xe.TrangThai == 0
                         select xe).ToList();
            BindGrid(getxe);
        }





        private void btKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinKhachHang f = new ThongTinKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinNhanVien f = new ThongTinNhanVien();
            f.ShowDialog();
        }

        private void btLoaiXe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinLoaiXe f = new ThongTinLoaiXe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btXe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinXe f = new ThongTinXe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NguoiDung f = new NguoiDung();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btSuCo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachSuCocs f = new DanhSachSuCocs();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThanhToanHopDong f = new ThanhToanHopDong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btXeSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CNPMEntities db = new CNPMEntities();
            var getxe = (from xe in db.Xes
                         where xe.TrangThai == 2
                         select xe).ToList();
            BindGrid(getxe);
        }
    }
}