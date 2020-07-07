using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class dangnhapkhachhang : Form
    {
        public dangnhapkhachhang()
        {
            InitializeComponent();
        }
        public class tenquaform{
            static public string tenkh;
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 thucung = new quanlithucungEntities1())
            {
                List<KhachHang> list = thucung.KhachHangs.ToList();
                KhachHang kh = thucung.KhachHangs.FirstOrDefault(p => p.TenKH.Trim() == txtten.Text && p.Email.Trim() == txtemail.Text);
                               
                if (kh != null)
                {
                    MessageBox.Show("Đăng nhập thành công.");
                    tenquaform.tenkh = txtten.Text;
                    Client f = new Client();
                    this.Hide();
                    f.ShowDialog();
                    
                    //f.Ten = tbtk.Text;
                    //this.Hide();
                    //f.ShowDialog();


                }
                else
                    MessageBox.Show("tài khoản mật khẩu không chính xác.Vui lòng nhập lại!");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {

            DialogResult drl = MessageBox.Show("Chọn Yes No?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dangnhapkhachhang_Load(object sender, EventArgs e)
        {
            txtten.Select();
        }

        private void Checkbox1_OnChange(object sender, EventArgs e)
        {
            if (Checkbox1.Checked ==false)
            {
                txtemail.UseSystemPasswordChar = true;
                
            }
            else
            {
                txtemail.UseSystemPasswordChar = false;
            }
        }

       
    }
}
