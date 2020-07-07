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
    public partial class Formaddhinh : Form
    {
        public Formaddhinh()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet36.ThuCung' table. You can move, or remove it, as needed.
            this.thuCungTableAdapter1.Fill(this.quanlithucungDataSet36.ThuCung);
            // TODO: This line of code loads data into the 'quanlithucungDataSet9.ThuCung' table. You can move, or remove it, as needed.
            

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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            updateThuCung(txtMa.Text);
        }

        private void updateThuCung(string mathucung)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                ThuCung tc = quanli.ThuCungs.FirstOrDefault(p => p.MaThuCung == mathucung);
                MemoryStream me = new MemoryStream();
                byte[] images = null;
                FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                tc.Anh = images;
                quanli.SaveChanges();
                MessageBox.Show("Update thanh cong");
            }
        }
    }
}
