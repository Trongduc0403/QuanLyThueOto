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
    public partial class NguoiDung : DevExpress.XtraEditors.XtraForm
    {
        string GetAccount { get; set; }
        public NguoiDung()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DangKy f = new DangKy();
            f.Show();
            CNPMEntities context = new CNPMEntities();
            List<Account> accounts = context.Accounts.ToList();
            BindGrid(accounts);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BindGrid(List<Account> accounts)
        {
            dgvND.Rows.Clear();
            foreach (var item in accounts)
            {
                int index = dgvND.Rows.Add();
                dgvND.Rows[index].Cells[0].Value = item.TaiKhoan;
                dgvND.Rows[index].Cells[1].Value = item.MatKhau;
            }
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            CNPMEntities context = new CNPMEntities();
            List<Account> accounts = context.Accounts.ToList();
            BindGrid(accounts);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (AccountController.RemoveAccount(GetAccount))
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("vui long chon hang de xoa");

            CNPMEntities context = new CNPMEntities();
            List<Account> accounts = context.Accounts.ToList();
            BindGrid(accounts);
        }

        private void dgvND_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btXoa.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvND.Rows[e.RowIndex];
                GetAccount = row.Cells[0].Value.ToString();
            }
        }
    }
}