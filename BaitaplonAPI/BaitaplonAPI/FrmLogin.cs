using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


        }
        public string mahoa(string matkhau)
        {

            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(matkhau);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string pass = sb.ToString();
            return pass;
        }
        private bool KiemTraDangNhap()
        {

            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                string pass = mahoa(txtMatKhau.Text.Trim());
                DangNhap account = quanli.DangNhaps.FirstOrDefault(p => p.UserName == txtTenDangNhap.Text.Trim() && p.PassWord == pass);
                if (account == null)
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Console.WriteLine(mahoa("1234"));
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap())
            {
                this.Hide();
                FrmMain main = new FrmMain();
                main.user = txtTenDangNhap.Text;
                main.password = txtMatKhau.Text;
                main.Show();
            }
        }

        private void cbshowmk_Click(object sender, EventArgs e)
        {

        }

        private void cbshowmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowmk.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txtTenDangNhap.Text.Trim();
                string password = txtMatKhau.Text.Trim();

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDangNhap.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {

                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                    return;
                }
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    string pass = mahoa(txtMatKhau.Text.Trim());
                    DangNhap account = quanli.DangNhaps.FirstOrDefault(p => p.UserName == txtTenDangNhap.Text.Trim() && p.PassWord == pass);
                    if (account == null)
                    {
                        MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        this.Hide();
                        FrmMain main = new FrmMain();
                        main.user = txtTenDangNhap.Text;
                        main.password = txtMatKhau.Text;
                        main.Show();
                    }
                }
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txtTenDangNhap.Text.Trim();
                string password = txtMatKhau.Text.Trim();

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDangNhap.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {

                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                    return;
                }
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    string pass = mahoa(txtMatKhau.Text.Trim());
                    DangNhap account = quanli.DangNhaps.FirstOrDefault(p => p.UserName == txtTenDangNhap.Text.Trim() && p.PassWord == pass);
                    if (account == null)
                    {
                        MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        this.Hide();
                        FrmMain main = new FrmMain();
                        main.user = txtTenDangNhap.Text;
                        main.password = txtMatKhau.Text;
                        main.Show();
                    }
                }
            }
        }
    }
}
