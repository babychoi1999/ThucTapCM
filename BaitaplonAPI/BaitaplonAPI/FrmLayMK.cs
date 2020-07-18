using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class FrmLayMK : Form
    {
        public FrmLayMK()
        {
            InitializeComponent();
        }
        public string maxm;
        public string manv;
        private void FrmLayMK_Load(object sender, EventArgs e)
        {
            
        }
        private bool kiemtra()
        {
            if(txtmaxacminh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã xác minh");
                return false;
            }
            if(txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                return false;
            }
            if(txtmaxacminh.Text != maxm) {
                MessageBox.Show("Mã xác minh chưa chính xác bạn hãy kiểm tra lại");
                return false;
            }
            return true;
        }
        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtMatKhauMoi.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                string pass = sb.ToString();
                DangNhap dn = quanli.DangNhaps.FirstOrDefault(p => p.MaNV == manv);
                dn.PassWord = pass;
                quanli.SaveChanges();
                MessageBox.Show("Đặt lại mật khẩu thành công! Mật khẩu của bạn là: " + txtMatKhauMoi.Text);
                this.Close();
            }
        }
    }
}
