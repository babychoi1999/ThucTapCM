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
    public partial class Formnhapthucung : Form
    {
        public Formnhapthucung()
        {
            InitializeComponent();
        }
        String img;

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void loaddulieu()
        {
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                dgvNhapThuCung.DataSource = quanli.CTNhapThuCungs.ToList();
            }
        }

        private void Formnhapthucung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet23.ThuCung' table. You can move, or remove it, as needed.
            this.thuCungTableAdapter.Fill(this.quanlithucungDataSet23.ThuCung);
            // TODO: This line of code loads data into the 'quanlithucungDataSet22.LoaiThuCung' table. You can move, or remove it, as needed.
            this.loaiThuCungTableAdapter.Fill(this.quanlithucungDataSet22.LoaiThuCung);
            // TODO: This line of code loads data into the 'quanlithucungDataSet21.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanlithucungDataSet21.NhaCungCap);
            // TODO: This line of code loads data into the 'quanlithucungDataSet20.CTNhapThuCung' table. You can move, or remove it, as needed.
            this.cTNhapThuCungTableAdapter.Fill(this.quanlithucungDataSet20.CTNhapThuCung);
            // TODO: This line of code loads data into the 'quanlithucungDataSet19.CTNhapThuCung' table. You can move, or remove it, as needed.

        }

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
        String mathucung;
        private void btnThem_Click(object sender, EventArgs e)
        { 
            if(cbtenthucung.SelectedIndex==-1)
            {
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    MemoryStream me = new MemoryStream();
                    byte[] images = null;
                    FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                   // quanli.insertCTPN( cbmanhacungcap.Text, Convert.ToInt16(txtSoluong.Text), float.Parse(txtGianhap.Text), cbtenthucung.Text, cbLoaiThuCung.SelectedValue.ToString(),images,0);
                    quanli.SaveChanges();
                    Formnhapthucung_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhapThuCung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphieunhap.Text = dgvNhapThuCung.CurrentRow.Cells[0].Value.ToString();
            //txttenthucung.Text = dgvNhapThuCung.CurrentRow.Cells[3].Value.ToString();
            txtmathucung.Text = dgvNhapThuCung.CurrentRow.Cells[2].Value.ToString();
            txtSoluong.Text = dgvNhapThuCung.CurrentRow.Cells[5].Value.ToString();
            cbLoaiThuCung.Text = dgvNhapThuCung.CurrentRow.Cells[4].Value.ToString();
            cbmanhacungcap.Text = dgvNhapThuCung.CurrentRow.Cells[1].Value.ToString();
            txtGianhap.Text = dgvNhapThuCung.CurrentRow.Cells[6].Value.ToString();
            cbLoaiThuCung.Enabled = false;
        }
    }
}
