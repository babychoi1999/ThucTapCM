using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaitaplonAPI
{
    public partial class kh1 : Form
    {
        public string makhachhang = "";
        public kh1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            makhachhang= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenkh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void kh1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using (quanlithucungEntities1 thucung = new quanlithucungEntities1())
            {
                dataGridView1.DataSource = thucung.KhachHangs.ToList();
            }
        }
        
        
        private void btxoa1_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 thucung = new quanlithucungEntities1())
            {
                string makh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                thucung.deleteKH(makh);
                thucung.SaveChanges();
                MessageBox.Show("Xóa thành công");
                kh1_Load(sender, e);
            }
        }

        private void btthem1_Click(object sender, EventArgs e)
        {
            if (!kt())
                return;
          
            using (quanlithucungEntities1 thucung = new quanlithucungEntities1())
            {
                thucung.insertKH(txttenkh.Text, int.Parse(txtsdt.Text), txtdiachi.Text, txtemail.Text);
                thucung.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                kh1_Load(sender, e);
            }
        }

       

        private void btsua1_Click(object sender, EventArgs e)
        {
            if (!kt())
                return;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
               KhachHang kh = quanli.KhachHangs.FirstOrDefault(p => p.MaKH == makhachhang);
                kh.TenKH = txttenkh.Text;
                kh.DiaChi = txtdiachi.Text;
                kh.SDT = int.Parse(txtsdt.Text);
                kh.Email = txtemail.Text;
                quanli.SaveChanges();
                MessageBox.Show("Đã sửa");
                kh1_Load(sender, e);
            }
        }

        private static object GetKhachHangs(quanlithucungEntities1 thucung)
        {
            return thucung.KhachHangs;
        }

        private void btthoat1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chọn Yes No?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

      

        private void bttrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttimkiem1_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 thucung = new quanlithucungEntities1())
            {
                List<KhachHang> kh = thucung.KhachHangs.Where(p => p.MaKH == txtnhapmatim.Text).ToList();
                if (kh.Count == 0)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại !!");
                    return;
                }
                dataGridView1.DataSource = kh;
            }
        }
        public bool kt()
        {
            if ( txttenkh.Text == "" ||txtsdt.Text == "" || txtdiachi.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Bạn Chưa điền đủ thông tin.Vui lòng nhập đủ thông tin!");
                return false;
            }
           
            try
            {
                int sdt = Int32.Parse(txtsdt.Text);
               
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu không đúng. Nó là kiểu số nguyên!");
                return false;
            }
            return true;
        }
       

        private void btfile_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\PC\Documents\NhanVien.txt");
            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                writer.Write(dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n");
            }
            writer.Close();
            MessageBox.Show("Đã nhập vào ok");
        }
    }
}
