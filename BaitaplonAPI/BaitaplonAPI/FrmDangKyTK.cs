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
    public partial class FrmDangKyTK : Form
    {
        public FrmDangKyTK()
        {
            InitializeComponent();
        }
        private bool kiemtra()
        {
            if(txttendn.Text == "" || txtmanv.Text == "" || txtmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin đăng ký!");
                return false;
            }
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.MaNV == txtmanv.Text);
                DangNhap dangNhap = quanli.DangNhaps.FirstOrDefault(p => p.MaNV == txtmanv.Text);
                if (nv == null)
                {
                    MessageBox.Show("Xin lỗi, mã nhân viên bạn nhập không tồn tại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if(dangNhap!= null)
                {
                    MessageBox.Show("Nhân viên này đã có tài khoản, bạn không thể đăng ký thêm. Hãy sử dụng chức năng lấy lại mật khẩu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DangNhap dn = new DangNhap();
                    dn.UserName = txttendn.Text;
                    MD5 mh = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtmk.Text);
                    byte[] hash = mh.ComputeHash(inputBytes);
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                    string pass = sb.ToString();
                    dn.PassWord = pass;
                    dn.MaNV = txtmanv.Text;
                    quanli.DangNhaps.Add(dn);
                    quanli.SaveChanges();
                    MessageBox.Show("Đăng ký thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
