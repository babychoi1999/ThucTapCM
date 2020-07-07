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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void Formđổimậtkhẩu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public bool kiemtra()
        {
            if(txtmkcu.Text != password)
            {
                MessageBox.Show("Mật khẩu bạn nhập không trùng với mật khẩu cũ!");
                return false;
            }
            if(txtmkmoi.Text != txtnhaplaimatkhaumoi.Text)
            {
                MessageBox.Show("Hai mật khẩu bạn nhập không trùng nhau!");
                return false;
            }
            return true;

        }
        public string user;
        public string password;

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            else{
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1()) 
                {
                    MD5 mh = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtmkmoi.Text);
                    byte[] hash = mh.ComputeHash(inputBytes);
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                        string pass = sb.ToString();
                        DangNhap lg = quanli.DangNhaps.FirstOrDefault(p => p.UserName == user);
                    lg.PassWord = pass;
                    quanli.SaveChanges();
                    MessageBox.Show("Đổi thành công!");
                }
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
