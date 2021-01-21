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
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private int CheckAccount(Account account)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var getaccount = (from ac in db.Accounts
                                  select ac).ToList();

                foreach (var a in getaccount)
                {
                    if (txtTaiKhoan.Text == a.TaiKhoan.Trim() && AccountController.SHA256(txtMatKhau.Text) == a.MatKhau.Trim())
                        return 1;
                }
                return 0;
            }
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {

            Account a = new Account();
            if (CheckAccount(a) == 1)
            {
                ManHinhChinh m = new ManHinhChinh();
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
            else
                XtraMessageBox.Show("Sai tài khoản hoặc mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "DevExpress Style";
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            skin();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            DangKy f = new DangKy();
            f.Show();
        }
    }
}