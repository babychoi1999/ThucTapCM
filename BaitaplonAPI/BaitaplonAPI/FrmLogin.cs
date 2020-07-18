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
using System.Net.Mail;
using System.Net;

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
        string maxacminh = "";
        string manv = "";
        private void btnquenmk_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản");
                return;
            }
            
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DangNhap dang = quanli.DangNhaps.FirstOrDefault(p=>p.UserName == txtTenDangNhap.Text);
                if (dang == null)
                {
                    MessageBox.Show("Xin lỗi tài khoản của bạn không chính xác, vui lòng kiểm tra lại");
                    return;
                }
                manv = quanli.DangNhaps.FirstOrDefault(p => p.UserName == txtTenDangNhap.Text).MaNV;
                NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.MaNV == manv);
                DangNhap dn = quanli.DangNhaps.FirstOrDefault(p => p.MaNV == manv);
                maxacminh = dn.PassWord.Remove(6, 26);
                string bodyemail = "Xin chào " + nv.TenNV + " Mã xác minh của bạn là: " + dn.PassWord.Remove(6, 26);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("babychoi1999@gmail.com");
                mail.To.Add(nv.Gmail);
                mail.Subject = " PETSHOP TNT - SĐT: 012323324 - 20 DUBAI";
                mail.Body = bodyemail;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                System.Net.NetworkCredential credential = new NetworkCredential();
                credential.UserName = "babychoi1999@gmail.com";
                credential.Password = "babychoi";
                smtpClient.Credentials = credential;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                if(MessageBox.Show("Đã gửi mã xác minh về Email\nMời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    FrmLayMK mk = new FrmLayMK();
                    mk.maxm = maxacminh;
                    mk.manv = manv;
                    mk.Show();
                    
                }

            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            FrmDangKyTK dk = new FrmDangKyTK();
            dk.Show();
        }
    }
}
