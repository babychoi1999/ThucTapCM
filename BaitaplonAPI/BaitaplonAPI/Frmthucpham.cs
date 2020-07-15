using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.IO;

namespace BaitaplonAPI
{
    public partial class Frmthucpham : UserControl
    {
        public Frmthucpham()
        {
            InitializeComponent();
        }
        private void loaddanhmuc()
        {
            panelDanhMuc.Controls.Clear();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<LoaiThucPham> ds_loaitc = quanli.LoaiThucPhams.ToList();
                int i = 0;
                foreach (var item in ds_loaitc)
                {
                    BunifuThinButton2 bt = new BunifuThinButton2();
                    bt.Size = new System.Drawing.Size(98, 45);
                    bt.TabIndex = i;
                    bt.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
                    bt.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
                    bt.IdleForecolor = Color.MidnightBlue;
                    bt.IdleFillColor = Color.White;
                    bt.IdleLineColor = System.Drawing.Color.LightSkyBlue;


                    bt.Name = item.MaLoai;
                    bt.Click += clickChonDanhMuc;
                    bt.ButtonText = item.TenLoai.Trim();
                    bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    panelDanhMuc.Controls.Add(bt);
                    i++;
                }
            }

            //using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            //{
            //    List<LoaiThuCung> ds_loaithucung = quanli.LoaiThuCungs.ToList();
            //}
        }

        private void clickChonDanhMuc(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;
            if (btn.Name.Trim() == "LTP01")
            {
                loadthucpham("LTP01");
            }
            if (btn.Name.Trim() == "LTP02")
            {
                loadthucpham("LTP02");
            }
            if (btn.Name.Trim() == "LTP03")
            {
                loadthucpham("LTP03");
            }
            if (btn.Name.Trim() == "LTP04")
            {
                loadthucpham("LTP04");
            }
            if (btn.Name.Trim() == "LTP05")
            {
                loadthucpham("LTP05");
            }
        }

        private void loadthucpham(string v)
        {
            panelAnh.Controls.Clear();
            int i = 0;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<THUCPHAM> ds_thucpham = quanli.THUCPHAMs.Where(p => p.MaLoai == v).ToList();
                int dem = ds_thucpham.Count % 3;
                int count = ds_thucpham.Count / 3;
                foreach (var item in ds_thucpham)
                {
                    BunifuImageButton img = new BunifuImageButton();
                    img.Name = item.Mathucpham.ToString();
                    img.Size = new System.Drawing.Size(182, 138);
                    img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    Byte[] hinhanh = item.hinhanh;
                    if (hinhanh != null)
                    {
                        using (MemoryStream stream = new MemoryStream(hinhanh))
                        {
                            Image returnImage = Image.FromStream(stream);
                            img.Image = returnImage;
                        }
                    }
                    img.BorderStyle = BorderStyle.FixedSingle;
                    img.TabIndex = i;
                    img.TabStop = false;
                    img.Zoom = 10;
                    panelAnh.Controls.Add(img);
                    img.Click += new EventHandler(chonhinhanh);
                    i++;
                    if (i % 3 == 0)
                    {
                        for (int j = i - 3; j < i; j++)
                        {
                            TextBox tb = new TextBox();
                            tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                            tb.Size = new System.Drawing.Size(182, 13);
                            tb.Enabled = false;
                            tb.BackColor = Color.White;

                            tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                            tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                            tb.Text = ds_thucpham[j].Tenthucpham;
                            panelAnh.Controls.Add(tb);
                        }
                    }

                }
                if (dem < 3)
                {
                    for (int k = 0; k < 3 - dem; k++)
                    {
                        Label tb = new Label();
                        tb.Size = new System.Drawing.Size(182, 13);
                        tb.BackColor = Color.White;
                        panelAnh.Controls.Add(tb);
                        tb.Enabled = false;
                    }
                    for (int j = 0; j < dem; j++)
                    {
                        TextBox tb = new TextBox();
                        tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        tb.Enabled = false;
                        tb.BackColor = Color.White;
                        tb.Size = new System.Drawing.Size(182, 13);
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                        tb.Text = ds_thucpham[3 * count + j].Tenthucpham;
                        panelAnh.Controls.Add(tb);

                    }
                }
            }
        }
        string matp = "";

        private void chonhinhanh(object sender, EventArgs e)
        {
            BunifuImageButton img = sender as BunifuImageButton;
            matp = img.Name.ToString();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                THUCPHAM thucpham = quanli.THUCPHAMs.FirstOrDefault(p => p.Mathucpham == matp);
                cbLoaiThucPham.SelectedValue = thucpham.MaLoai;
                txttenthucpham.Text = thucpham.Tenthucpham;
                txtdongia.Text = thucpham.dongia.ToString();
            }
        }


        private void loadloaithucpham()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<LoaiThucPham> ds_thucpham = quanli.LoaiThucPhams.ToList();
                cbLoaiThucPham.DataSource = ds_thucpham;
                cbLoaiThucPham.DisplayMember = "TenLoai";
                cbLoaiThucPham.ValueMember = "MaLoai";
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {

        }



        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }
        string maud = "";
        public void loaduudai()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<UuDaiHD> uudai = quanli.UuDaiHDs.ToList();
                foreach (var item in uudai)
                {
                    DateTime ngaybd = (DateTime)item.NgayBD;
                    DateTime ngaykt = (DateTime)item.NgayKT;
                    if (DateTime.Now.Day >= ngaybd.Day && DateTime.Now.Day <= ngaykt.Day && DateTime.Now.Year == ngaybd.Year && DateTime.Now.Month == ngaybd.Month)
                    {
                        txtuudai.Text = item.GiamGia.ToString();
                        maud = item.MaUD;
                        return;
                    }
                }
               
            }
        }
        public void loadhdchuathanhtoan()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1()) 
            {
                List<hdchuathanhtoan_Result> hd = quanli.hdchuathanhtoan().ToList();
                cbchuathanhtoan.DataSource = hd;
                cbchuathanhtoan.DisplayMember = "MaHD";
                cbchuathanhtoan.ValueMember = "MaHD";
            }
        }
        private void Formbanhthuong_Load(object sender, EventArgs e)
        {
            loadloaithucpham();
            loaddanhmuc();
            loadthucpham("LTP01");
            loaduudai();
            dgvThucPham.Rows.Clear();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<getmahd_Result> ds_kq = quanli.getmahd().ToList();
                foreach (var item in ds_kq)
                {
                    txtmahoadon.Text = ds_kq[0].MaHD;
                }
            }
            loadhdchuathanhtoan();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            if (txtsoluong.Value == 0)
            {
                MessageBox.Show("Số lượng không thể là 0");
                return;
            }
            int dongia = int.Parse(txtdongia.Text);
            int soluong = int.Parse(txtsoluong.Value.ToString());
            int uudai = int.Parse(txtuudai.Text.ToString());
            for (int i = 0; i < dgvThucPham.Rows.Count; i++)
            {
                string loaithucpham = dgvThucPham.Rows[i].Cells["loaithucpham"].Value.ToString();
                string tenthucpham = dgvThucPham.Rows[i].Cells["tenthucpham"].Value.ToString();
              
                if (tenthucpham == txttenthucpham.Text && cbLoaiThucPham.Text == loaithucpham)
                {
                    int sl = int.Parse(dgvThucPham.Rows[i].Cells["soluong"].Value.ToString()) + soluong;
                    dgvThucPham.Rows[i].Cells["soluong"].Value = sl;
                    dgvThucPham.Rows[i].Cells["thanhtien"].Value = (sl * dongia) - (sl * dongia * uudai / 100); 
                    return;
                }

            }
            int tongtien = (soluong * dongia) - (soluong * dongia * uudai / 100);
            dgvThucPham.Rows.Add(new object[] { matp, txttenthucpham.Text, cbLoaiThucPham.Text, txtsoluong.Value.ToString(), txtdongia.Text, tongtien });
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (dgvThucPham.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có thông tin để lưu");
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == txtmahoadon.Text);
                if (hd != null)
                {
                   
                    List<CTTHUCPHAM> ds_cttp = quanli.CTTHUCPHAMs.Where(p => p.MaHD == txtmahoadon.Text).ToList();
                    foreach (var item in ds_cttp)
                    {
                        quanli.CTTHUCPHAMs.Remove(item);
                        quanli.SaveChanges();
                    }
                   
                }
                else
                {
                    hd = new HoaDon();
                    hd.MaHD = txtmahoadon.Text;
                    hd.UserName = "ngoctuan";
                    hd.ThoiGianLap = DateTime.Now.Date;
                    hd.TrangThai = false;
                    quanli.HoaDons.Add(hd);
                    quanli.SaveChanges();
                }
                if (txtuudai.Text != "")
                {
                    CTUuDai ud = new CTUuDai();
                    ud.MaHD = txtmahoadon.Text;
                    ud.MaUD = maud;
                    Console.WriteLine(maud);
                    quanli.CTUuDais.Add(ud);
                    quanli.SaveChanges();
                }

                foreach (DataGridViewRow rows in dgvThucPham.Rows)
                {
                    CTTHUCPHAM ct = new CTTHUCPHAM();
                    string matp = rows.Cells["mathucpham"].Value.ToString();
                    string tenthucpham = rows.Cells["tenthucpham"].Value.ToString();
                    int sl = int.Parse(rows.Cells["soluong"].Value.ToString());
                    ct.MaHD = txtmahoadon.Text;
                    ct.Mathucpham = matp;
                    ct.Tenthucpham = tenthucpham;
                    ct.soluong = sl;
                    quanli.CTTHUCPHAMs.Add(ct);
                    quanli.SaveChanges();
                }
                
                MessageBox.Show("Lưu thành công!");
                loadhdchuathanhtoan();
                return;
            }
        }
        public void reset()
        {
            dgvThucPham.Rows.Clear();
            cbLoaiThucPham.SelectedIndex = -1;
            txtdongia.Text = "0";
            txttenthucpham.Text = "";
        }

        private void dgvThucPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            if (e.ColumnIndex==6)
            {
                MessageBox.Show("Đã xóa!");
                dgvThucPham.Rows.Remove(dgvThucPham.Rows[e.RowIndex]);
            }
        }

        private void dgvThucPham_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //int tongtien = 0;
            //for (int i = 0; i < dgvThucPham.Rows.Count; i++)
            //{
            //    tongtien += int.Parse(dgvThucPham.Rows[i].Cells["thanhtien"].Value.ToString());
            //    tongtien = tongtien * (100 - (int.Parse(txtuudai.Text))) / 100;

            //}
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvThucPham.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hóa đơn để thanh toán");
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == txtmahoadon.Text);
                     hd.TrangThai = true;
                    quanli.SaveChanges();
                    MessageBox.Show("Thanh toán thành công!");
                Formbanhthuong_Load(sender, e);
                cbchuathanhtoan.Text = null;
                return;
            }
        }

        private void hdchuathanhtoanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbchuathanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvThucPham.Rows.Clear();
            txtmahoadon.Text = cbchuathanhtoan.Text;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<CTTHUCPHAM> ds_hd = quanli.CTTHUCPHAMs.Where(p=>p.MaHD == txtmahoadon.Text).ToList();
                foreach(var item in ds_hd)
                {
                    string maloai = quanli.THUCPHAMs.FirstOrDefault(p => p.Mathucpham == item.Mathucpham).MaLoai.ToString();
                    string loaithucpham = quanli.LoaiThucPhams.FirstOrDefault(p => p.MaLoai == maloai).TenLoai;
                    double dongia = (double)quanli.THUCPHAMs.FirstOrDefault(p => p.Mathucpham == item.Mathucpham).dongia;
                    int uudai = int.Parse(txtuudai.Text);
                    double thanhtien = dongia *item.soluong - (item.soluong * dongia * uudai / 100);
                    dgvThucPham.Rows.Add(item.Mathucpham,item.Tenthucpham,loaithucpham,item.soluong,dongia,thanhtien);
                   
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
