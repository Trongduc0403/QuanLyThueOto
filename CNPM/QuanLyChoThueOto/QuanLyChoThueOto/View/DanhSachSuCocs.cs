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
    public partial class DanhSachSuCocs : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachSuCocs()
        {
            InitializeComponent();
        }

        string GetMaBBSC { get; set; }

        private void BindGrid(List<BBSC> lstBBSC)
        {
            dgvSC.Rows.Clear();
            int i = 0;
            foreach (var item in lstBBSC)
            {
                using (CNPMEntities db = new CNPMEntities())
                {
                    var getnv = (from hd in db.BBSCs
                                 join nv in db.NhanViens on hd.idNV equals nv.idNV
                                 select nv).ToList();
                    var getkh = (from hd in db.BBSCs
                                 join kh in db.KhachHangs on hd.idKH equals kh.idKH
                                 select kh).ToList();
                    var xe = (from hd in db.BBSCs
                              join x in db.Xes on hd.idXe equals x.idXe
                              select x).ToList();

                    int index = dgvSC.Rows.Add();

                    dgvSC.Rows[index].Cells[0].Value = item.MaBBSC;
                    dgvSC.Rows[index].Cells[1].Value = xe[i].Biensoxe;
                    dgvSC.Rows[index].Cells[2].Value = getnv[i].MaNV;
                    dgvSC.Rows[index].Cells[3].Value = getkh[i].MaKH;
                    dgvSC.Rows[index].Cells[4].Value = item.NgayBBSC;
                    dgvSC.Rows[index].Cells[5].Value = item.TenSC;
                    dgvSC.Rows[index].Cells[6].Value = item.NoiDungSC;
                    dgvSC.Rows[index].Cells[7].Value = item.TienPhat;
                    i++;
                }

            }
        }

        private void DanhSachSuCocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlythueotoDataSet1.SUCO' table. You can move, or remove it, as needed.
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
            List<BBSC> lstBBSC = context.BBSCs.ToList();
            BindGrid(lstBBSC);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btSua_Click(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var bbsc = (from sc in db.BBSCs
                            where sc.MaBBSC == GetMaBBSC
                            select sc).FirstOrDefault();
                bbsc.MaBBSC = txtSoBBSC.Text;
                bbsc.idXe = (int)cbbSoXe.SelectedValue;
                bbsc.idKH = (int)cbbMaKH.SelectedValue;
                bbsc.idNV = (int)cbbMaNV.SelectedValue;
                bbsc.NgayBBSC = DateTime.Parse(msktbNgayLap.Text.ToString());
                bbsc.TenSC = txtTenSC.Text;
                bbsc.NoiDungSC = txtNoiDung.Text;
                bbsc.TienPhat = txtTienPhat.Text;
                if (BBSCController.AddBBSC(bbsc))
                    db.SaveChanges();
                XtraMessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetMaBBSC = null;
            CNPMEntities context = new CNPMEntities();
            List<BBSC> lstBBSC = context.BBSCs.ToList();
            BindGrid(lstBBSC);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                BBSC bbsc = new BBSC();
                bbsc.MaBBSC = txtSoBBSC.Text;
                bbsc.idXe = (int)cbbSoXe.SelectedValue;
                bbsc.idKH = (int)cbbMaKH.SelectedValue;
                bbsc.idNV = (int)cbbMaNV.SelectedValue;
                bbsc.NgayBBSC = DateTime.Parse(msktbNgayLap.Text.ToString());
                bbsc.TenSC = txtTenSC.Text;
                bbsc.NoiDungSC = txtNoiDung.Text;
                bbsc.TienPhat = txtTienPhat.Text;
                if (BBSCController.AddBBSC(bbsc))
                {
                    XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CNPMEntities context = new CNPMEntities();
                List<BBSC> lstBBSC = context.BBSCs.ToList();
                BindGrid(lstBBSC);
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (BBSCController.RemoveBBSC(GetMaBBSC))
                MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("vui long chon hang de xoa");

            CNPMEntities context = new CNPMEntities();
            List<BBSC> lstBBSC = context.BBSCs.ToList();
            BindGrid(lstBBSC);
        }

        private void dgvSC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSC.Rows[e.RowIndex];
                txtSoBBSC.Text = row.Cells[0].Value.ToString();
                cbbSoXe.Text = row.Cells[1].Value.ToString();
                cbbMaKH.Text = row.Cells[2].Value.ToString();
                cbbMaNV.Text = row.Cells[3].Value.ToString();
                msktbNgayLap.Text = row.Cells[4].Value.ToString();
                txtTenSC.Text = row.Cells[5].Value.ToString();
                txtNoiDung.Text = row.Cells[6].Value.ToString();
                txtTienPhat.Text = row.Cells[7].Value.ToString();
            }
            GetMaBBSC = txtSoBBSC.Text.ToString();
        }
    }
}