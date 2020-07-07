using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class Formnhacungcap : UserControl
    {
        public Formnhacungcap()
        {
            InitializeComponent();
        }

        private void Formnhacungcap_Load(object sender, EventArgs e)
        {
            dgvNhacc.AutoGenerateColumns = false;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                Console.WriteLine(quanli.NhaCungCaps.ToList().Count);
                dgvNhacc.DataSource = quanli.NhaCungCaps.ToList();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                quanli.insertNCC(tenncc, diachi, int.Parse(sdt));
                MessageBox.Show("đã thêm");
                Formnhacungcap_Load(sender, e);
            }
        }
       public string manhacungcap="";
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            manhacungcap = dgvNhacc.CurrentRow.Cells[0].Value.ToString();
            txttenncc.Text = dgvNhacc.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dgvNhacc.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dgvNhacc.CurrentRow.Cells[3].Value.ToString(); ;
            if (e.ColumnIndex==4)
            {
                if(MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                  
                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        quanli.deleteNCC(manhacungcap);
                        MessageBox.Show("đã xóa");
                        Formnhacungcap_Load(sender, e);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(manhacungcap=="")
            {
                MessageBox.Show("Yêu cầu chọn nhà cung cấp cần sửa thông tin!!");
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                NhaCungCap ncc = quanli.NhaCungCaps.FirstOrDefault(p => p.MaNCC == manhacungcap);
                ncc.TenNCC = txttenncc.Text;
                ncc.Diachi = txtdiachi.Text;
                ncc.Sdt = int.Parse(txtsdt.Text);
                quanli.SaveChanges();
                MessageBox.Show("Đã sửa");
                Formnhacungcap_Load(sender, e);
            }
        }
    }
}
