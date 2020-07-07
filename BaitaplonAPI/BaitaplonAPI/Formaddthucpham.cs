using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class Formaddthucpham : Form
    {
        public Formaddthucpham()
        {
            InitializeComponent();
        }

        private void Formaddthucpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet14.THUCPHAM' table. You can move, or remove it, as needed.
            this.tHUCPHAMTableAdapter3.Fill(this.quanlithucungDataSet14.THUCPHAM);
        }
        string img = "";
        private void hinhanh_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            string file = openFile.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            if (file == "openFileDialog1")
                return;
            else
            {
                img = openFile.FileName.ToString();
                Image myimage = Image.FromFile(file);
                hinhanh.Image = myimage;
            }
        }

        private void dgvThucPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvThucPham.CurrentRow.Cells[0].Value.ToString();
        }
        private  void updateThucPham(string mathucpham)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                THUCPHAM tc = quanli.THUCPHAMs.FirstOrDefault(p => p.Mathucpham == mathucpham);
                MemoryStream me = new MemoryStream();
                byte[] images = null;
                FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                tc.hinhanh = images;
                quanli.SaveChanges();
                MessageBox.Show("Update thanh cong");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateThucPham(txtMa.Text);
        }
    }
}
