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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Diagnostics;

namespace QuanLyChoThueOto
{
    public partial class ThongTinBBGN : DevExpress.XtraEditors.XtraForm
    {
        CNPMEntities dbcnpm = new CNPMEntities();
        public ThongTinBBGN()
        {
            InitializeComponent();
        }
        string GetMaBBGN { set; get; }

        private void BindGrid(List<BBGN> lstBBGN)
        {
            dgvBBGN.Rows.Clear();
            int i = 0;
            foreach (var item in lstBBGN)
            {
                using (CNPMEntities db = new CNPMEntities())
                {
                    var getxe = (from bb in db.BBGNs
                                 join xe in db.Xes on bb.idXe equals xe.idXe
                                 select xe).ToList();
                    var getkh = (from bb in db.BBGNs
                                 join kh in db.KhachHangs on bb.idKH equals kh.idKH
                                 select kh).ToList();
                    var getnv = (from bb in db.BBGNs
                                 join nv in db.NhanViens on bb.idNV equals nv.idNV
                                 select nv).ToList();


                    int index = dgvBBGN.Rows.Add();

                    dgvBBGN.Rows[index].Cells[0].Value = item.MaBBGN;
                    dgvBBGN.Rows[index].Cells[1].Value = getxe[i].Biensoxe;
                    dgvBBGN.Rows[index].Cells[2].Value = getkh[i].MaKH;
                    dgvBBGN.Rows[index].Cells[3].Value = getnv[i].MaNV;
                    dgvBBGN.Rows[index].Cells[4].Value = item.NgayGiao;
                    dgvBBGN.Rows[index].Cells[5].Value = item.KmDi;
                    dgvBBGN.Rows[index].Cells[6].Value = item.XangDi;
                    dgvBBGN.Rows[index].Cells[7].Value = item.TrangThaiDi;
                    dgvBBGN.Rows[index].Cells[8].Value = item.NgayNhan; 
                    dgvBBGN.Rows[index].Cells[9].Value = item.KmVe;
                    dgvBBGN.Rows[index].Cells[10].Value = item.XangVe;
                    dgvBBGN.Rows[index].Cells[11].Value = item.TrangThaiVe;
                    i++;
                }
                
            }
        }

        private void ThongTinBBGN_Load(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var getxe = (from xe in db.Xes
                             select xe).ToList();
                var getkh = (from kh in db.KhachHangs
                             select kh).ToList();
                var getnv = (from nv in db.NhanViens
                             select nv).ToList();
                this.cbbSoXe.DataSource = getxe;
                this.cbbSoXe.ValueMember = "idXe";
                this.cbbSoXe.DisplayMember = "Biensoxe";
                this.cbbMaKH.DataSource = getkh;
                this.cbbMaKH.ValueMember = "idKH";
                this.cbbMaKH.DisplayMember = "MaKH";
                this.cbbMaNV.DataSource = getnv;
                this.cbbMaNV.ValueMember = "idNV";
                this.cbbMaNV.DisplayMember = "MaNV";
            }
            CNPMEntities context = new CNPMEntities();
            List<BBGN> lstBBGn = context.BBGNs.ToList();
            BindGrid(lstBBGn);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            BBGN bbgn = new BBGN();
            bbgn.MaBBGN = txtMaBBGN.Text;
            bbgn.NgayGiao = DateTime.Parse(mskNgayGiao.Text.ToString());
            bbgn.idXe = (int)cbbSoXe.SelectedValue;
            bbgn.idKH = (int)cbbMaKH.SelectedValue;
            bbgn.idNV = (int)cbbMaNV.SelectedValue;
            bbgn.KmDi = int.Parse(txtKmDi.Text);
            bbgn.XangDi = txtXangDi.Text;
            bbgn.TrangThaiDi = txtTTDi.Text;
            bbgn.NgayNhan = DateTime.Parse(mskNgayNhan.Text.ToString());
            bbgn.KmVe = int.Parse(txtKmVe.Text);
            bbgn.XangVe= txtXangVe.Text;
            bbgn.TrangThaiVe= txtTTVe.Text;
            if (BBGNController.AddBBGN(bbgn))
            {
                XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("Nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CNPMEntities context = new CNPMEntities();
            List<BBGN> lstBBGn = context.BBGNs.ToList();
            BindGrid(lstBBGn);
        }

        private void dgvBBGN_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btIn.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBBGN.Rows[e.RowIndex];
                txtMaBBGN.Text = row.Cells[0].Value.ToString();
                cbbSoXe.Text = row.Cells[1].Value.ToString();
                cbbMaKH.Text = row.Cells[2].Value.ToString();
                cbbMaNV.Text = row.Cells[3].Value.ToString();
                mskNgayGiao.Text = row.Cells[4].Value.ToString();
                txtKmDi.Text = row.Cells[5].Value.ToString();
                txtXangDi.Text = row.Cells[6].Value.ToString();
                txtTTDi.Text = row.Cells[7].Value.ToString();
                mskNgayNhan.Text = row.Cells[8].Value.ToString();
                txtKmVe.Text = row.Cells[9].Value.ToString();
                txtXangVe.Text = row.Cells[10].Value.ToString();
                txtTTVe.Text = row.Cells[11].Value.ToString();
            }
            GetMaBBGN = txtMaBBGN.Text.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var bbgn = (from bb in db.BBGNs
                            where bb.MaBBGN == GetMaBBGN
                            select bb).FirstOrDefault();


                bbgn.MaBBGN = txtMaBBGN.Text;
                bbgn.NgayGiao = DateTime.Parse(mskNgayGiao.Text.ToString());
                bbgn.idXe = (int)cbbSoXe.SelectedValue;
                bbgn.idKH = (int)cbbMaKH.SelectedValue;
                bbgn.idNV = (int)cbbMaNV.SelectedValue;
                bbgn.KmDi = int.Parse(txtKmDi.Text);
                bbgn.XangDi = txtXangDi.Text;
                bbgn.TrangThaiDi = txtTTDi.Text;
                bbgn.NgayNhan = DateTime.Parse(mskNgayNhan.Text.ToString());
                bbgn.KmVe = int.Parse(txtKmVe.Text);
                bbgn.XangVe = txtXangVe.Text;
                bbgn.TrangThaiVe = txtTTVe.Text;


                db.SaveChanges();
                XtraMessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetMaBBGN = null;

            CNPMEntities context = new CNPMEntities();
            List<BBGN> lstBBGn = context.BBGNs.ToList();
            BindGrid(lstBBGn);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (BBGNController.RemoveBBGN(GetMaBBGN))
                MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("vui long chon hang de xoa");

            CNPMEntities context = new CNPMEntities();
            List<BBGN> lstBBGn = context.BBGNs.ToList();
            BindGrid(lstBBGn);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            var khachhang = (from kh in dbcnpm.KhachHangs
                             join hd in dbcnpm.BBGNs on kh.idKH equals hd.idKH
                             where kh.MaKH == this.cbbMaKH.Text.ToString()
                             select kh).FirstOrDefault();
            //Create the new PDF document
            PdfDocument document = new PdfDocument();
            //Add a page to the document
            PdfPage page = document.Pages.Add();
            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;
            //Create a new PDF font instance
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);
            string MaBBGN = this.txtMaBBGN.Text.ToString();
            string SoXe = this.cbbSoXe.Text.ToString();
            string MaKH = khachhang.TenKH;
            string MaNV = this.cbbMaNV.Text.ToString();
            string NgayGiao = this.mskNgayGiao.Text.ToString();
            string NgayNhan = this.mskNgayNhan.Text.ToString();
            string kmDi = this.txtKmDi.Text.ToString();
            string kmVe = this.txtKmVe.Text.ToString();
            string XangDi = this.txtXangDi.Text.ToString();
            string XangXe = this.txtXangVe.Text.ToString();
            string motadi = this.txtTTDi.Text.ToString();
            string motave = this.txtTTVe.Text.ToString();
            //Draw string to the PDF page
            graphics.DrawString("Code receipt of delivery:                 " + MaBBGN, font, PdfBrushes.Black, 0, 0);
            graphics.DrawString("Name of customer:                 " + MaKH, font, PdfBrushes.Black, 0, 50);
            graphics.DrawString("Code of employee:                 " + MaNV, font, PdfBrushes.Black, 0, 100);
            graphics.DrawString("Car delivery date:                      " + NgayGiao, font, PdfBrushes.Black, 0, 150);
            graphics.DrawString("the date of receiving the car:                     " + NgayNhan, font, PdfBrushes.Black, 0, 200);
            graphics.DrawString("Number km start:       " + kmDi, font, PdfBrushes.Black, 0, 250);
            graphics.DrawString("Number km finish:             " + kmVe, font, PdfBrushes.Black, 0, 300);
            graphics.DrawString("Gasoline from:                        " + XangDi, font, PdfBrushes.Black, 0, 350);
            graphics.DrawString("Gasoline finish:                       " + XangXe, font, PdfBrushes.Black, 0, 400);
            graphics.DrawString("Description start:                        " + motadi, font, PdfBrushes.Black, 0, 450);
            graphics.DrawString("Description finish:                       " + motave, font, PdfBrushes.Black, 0, 500);
            graphics.DrawString("Customer signature", font, PdfBrushes.Black, 300, 600);
            graphics.DrawString("Employee signature", font, PdfBrushes.Black, 50, 600);
            //Draw rectangle
            //Save the document
            try
            {
                document.Save("BienBanGiaoNhan.pdf");
            }
            catch
            {
                MessageBox.Show("Turn off file exist!!!!!!!!!!!!!1");
            }

            //Close the document
            document.Close(true);
            //This will open the PDF file so, the result will be seen in default PDF Viewer
            Process.Start("BienBanGiaoNhan.pdf");
        }
    }
}