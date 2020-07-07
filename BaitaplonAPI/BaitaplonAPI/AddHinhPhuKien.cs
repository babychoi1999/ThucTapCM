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
    public partial class AddHinhPhuKien : Form
    {
        public AddHinhPhuKien()
        {
            InitializeComponent();
        }

        private void AddHinhPhuKien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet15.PHUKIEN' table. You can move, or remove it, as needed.
            this.pHUKIENTableAdapter.Fill(this.quanlithucungDataSet15.PHUKIEN);

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

        private void dgvPhuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvPhuKien.CurrentRow.Cells[0].Value.ToString();
        }
        private void updatePhuKien(string maphukien)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                PHUKIEN tc = quanli.PHUKIENs.FirstOrDefault(p => p.Maphukien == maphukien);
                MemoryStream me = new MemoryStream();
                byte[] images = null;
                FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                tc.HinhAnh = images;
                quanli.SaveChanges();
                MessageBox.Show("Update thanh cong");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updatePhuKien(txtMa.Text);
        }
    }
}
