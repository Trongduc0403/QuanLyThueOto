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
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        public DangKy()
        {
            InitializeComponent();
        }


        private void btDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtXacNhan.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    Account a = new Account();
                    if (txtXacNhan.Text != txtMatKhau.Text)
                    {
                        MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        a.TaiKhoan = txtTaiKhoan.Text;
                        a.MatKhau = AccountController.SHA256(txtXacNhan.Text);
                        if (AccountController.AddAccount(a))                        
                            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);            
                        else
                            MessageBox.Show("Đăng ký fail");
                    }
                }    
            }
            catch
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}