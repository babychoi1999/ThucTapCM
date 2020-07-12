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
    public partial class Formaddhinhdichvu : Form
    {
        public Formaddhinhdichvu()
        {
            InitializeComponent();
        }

        private void Formaddhinhdichvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet39.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.quanlithucungDataSet39.DichVu);

            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                
                dataGridView1.DataSource = quanli.DichVus.ToList();
                

            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[3].Value);
            hinhanh.Image = Image.FromStream(ms);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateDichvu(txtMa.Text);
        }

        private void updateDichvu(string madichvu)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DichVu dv = quanli.DichVus.FirstOrDefault(p => p.MaDV == madichvu);
                MemoryStream me = new MemoryStream();
                byte[] images = null;
                FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                dv.Anh = images;
                quanli.SaveChanges();
                MessageBox.Show("Update thanh cong");
            }
        }
    }
}
