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
    public partial class FormNhapPhuKien : Form
    {
        public FormNhapPhuKien()
        {
            InitializeComponent();
        }

        private void FormNhapPhuKien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet25.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanlithucungDataSet25.NhaCungCap);
            // TODO: This line of code loads data into the 'quanlithucungDataSet13.CTNhapPhuKien' table. You can move, or remove it, as needed.
            this.cTNhapPhuKienTableAdapter1.Fill(this.quanlithucungDataSet13.CTNhapPhuKien);

        }
        public void loaddulieu()
        {
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                dataGridView1.DataSource = quanli.CTNhapPhuKiens.ToList();
            }
        }
        public void reset()
        {
            txtGianhap.Text = null;
            cbmanhacungcap = null;
            //txtmaphukien.Text = null;
            txtSoluong.Text = null;
            txttenphukien = null;
            txtmaphieunhap = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                CTNhapPhuKien them = new CTNhapPhuKien();
                them.MaPN = txtmaphieunhap.Text;
                //them.MaPhuKien = txtmaphukien.Text;
                //them.LoaiPhuKien = cbLoaiPhuKien.Text;
                them.TenPhuKien = txttenphukien.Text;
                them.Soluong = int.Parse(txtSoluong.Text);
                them.GiaNhap = double.Parse(txtGianhap.Text);
                quanli.CTNhapPhuKiens.Add(them);
                quanli.SaveChanges();
                loaddulieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                CTNhapPhuKien sua = quanli.CTNhapPhuKiens.FirstOrDefault(p => p.MaPN == txtmaphieunhap.Text);
                sua.MaPN = txtmaphieunhap.Text;
                //sua.MaPhuKien = txtmaphukien.Text;
                sua.TenPhuKien = txttenphukien.Text;
                //sua.LoaiPhuKien = cbLoaiPhuKien.Text;
                sua.Soluong = int.Parse(txtSoluong.Text);
                sua.GiaNhap = double.Parse(txtGianhap.Text);
                quanli.SaveChanges();
                loaddulieu();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphieunhap.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttenphukien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //txtmaphukien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtGianhap.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }
    }
}
