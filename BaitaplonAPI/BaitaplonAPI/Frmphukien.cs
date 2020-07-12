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
    public partial class Frmphukien : UserControl
    {
        public Frmphukien()
        {
            InitializeComponent();
        }
        private void LoadPhuKien(string v)
        {
            panelAnh.Controls.Clear();

            int i = 0;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<PHUKIEN> ds_phukien = quanli.PHUKIENs.Where(p => p.MaLoai == v).ToList();
                int dem = ds_phukien.Count % 3;
                int count = ds_phukien.Count / 3;
                foreach (var item in ds_phukien)
                {

                    BunifuImageButton img = new BunifuImageButton();
                    img.Name = item.Maphukien.ToString();
                    img.Size = new System.Drawing.Size(182, 138);
                    img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    Byte[] hinhanh = item.HinhAnh;
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
                            tb.Size = new System.Drawing.Size(182, 30);
                            tb.Enabled = false;
                            tb.BackColor = Color.White;
                            tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                            tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                            tb.Text = ds_phukien[j].Tenphukien;
                            panelAnh.Controls.Add(tb);
                        }
                    }
                }
                if (dem < 3)
                {
                    for (int k = 0; k < 3 - dem; k++)
                    {
                        Label tb = new Label();
                        tb.Size = new System.Drawing.Size(182, 30);
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
                        tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                        tb.Size = new System.Drawing.Size(182, 30);
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Text = ds_phukien[3 * count + j].Tenphukien;
                        panelAnh.Controls.Add(tb);

                    }
                }
            }
        }
        string mapk = "";
        private void chonhinhanh(object sender, EventArgs e)
        {
            BunifuImageButton img = sender as BunifuImageButton;
            mapk = img.Name.ToString();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                PHUKIEN phukien = quanli.PHUKIENs.FirstOrDefault(p => p.Maphukien == mapk);
                cbLoaiPhuKien.SelectedValue = phukien.MaLoai;
                txttenphukien.Text = phukien.Tenphukien;
                txtdongia.Text = phukien.dongia.ToString();
            }
        }
        void LoadDanhMuc()
        {
            panelDanhMuc.Controls.Clear();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<LoaiPhuKien> ds_loaipk = quanli.LoaiPhuKiens.ToList();
                int i = 0;
                foreach (var item in ds_loaipk)
                {
                    BunifuThinButton2 bt = new BunifuThinButton2();
                    bt.Size = new System.Drawing.Size(98, 45);
                    bt.TabIndex = i;
                    bt.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
                    bt.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
                    bt.IdleFillColor = Color.White;
                    bt.IdleForecolor = Color.MidnightBlue;
                    bt.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
                    bt.Text = item.TenLoai.ToUpper();
                    bt.Name = item.MaLoai;
                    bt.Click += clickChonDanhMuc;
                    bt.ButtonText = item.TenLoai.Trim();
                    bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    panelDanhMuc.Controls.Add(bt);
                    i++;
                }
            }

            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<LoaiPhuKien> ds_phukien = quanli.LoaiPhuKiens.ToList();
            }
        }
        private void clickChonDanhMuc(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;
            if (btn.Name.Trim() == "LPK01")
            {
                LoadPhuKien("LPK01");
            }
            if (btn.Name.Trim() == "LPK02")
            {
                LoadPhuKien("LPK02");
            }
            if (btn.Name.Trim() == "LPK03")
            {
                LoadPhuKien("LPK03");
            }
            if (btn.Name.Trim() == "LPK04")
            {
                LoadPhuKien("LPK04");
            }
            if (btn.Name.Trim() == "LPK05")
            {
                LoadPhuKien("LPK05");
            }
            if (btn.Name.Trim() == "LPK06")
            {
                LoadPhuKien("LPK06");
            }
        }
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
                        return;
                    }
                }
            }
        }
        private void loadloaiphukien()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<LoaiPhuKien> ds_pk = quanli.LoaiPhuKiens.ToList();
                cbLoaiPhuKien.DataSource = ds_pk;
                cbLoaiPhuKien.DisplayMember = "TenLoai";
                cbLoaiPhuKien.ValueMember = "MaLoai";
            }
        }
        public void loadhdchuathanhtoan()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<hdphukienchuathanhtoan_Result> hd = quanli.hdphukienchuathanhtoan().ToList();
                cbchuathanhtoan.DataSource = hd;
                cbchuathanhtoan.DisplayMember = "MaHD";
                cbchuathanhtoan.ValueMember = "MaHD";
            }
        }
        private void Formbalo_Load(object sender, EventArgs e)
        {
            loadloaiphukien();
            LoadDanhMuc();
            LoadPhuKien("LPK01");
            loaduudai();
            dgvPhuKien.Rows.Clear();
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            if (txtsoluong.Value == 0)
            {
                MessageBox.Show("Số lượng không thể là 0");
                return;
            }
            int dongia = int.Parse(txtdongia.Text);
            int soluong = int.Parse(txtsoluong.Value.ToString());
            int uudai = int.Parse(txtuudai.Text.ToString());
            for (int i = 0; i < dgvPhuKien.Rows.Count; i++)
            {
                string loaiphukien = dgvPhuKien.Rows[i].Cells["loaiphukien"].Value.ToString();
                string tenphukien = dgvPhuKien.Rows[i].Cells["tenphukien"].Value.ToString();
                if (tenphukien == txttenphukien.Text && cbLoaiPhuKien.Text == loaiphukien)
                {
                    int sl = int.Parse(dgvPhuKien.Rows[i].Cells["soluong"].Value.ToString()) + soluong;
                    dgvPhuKien.Rows[i].Cells["soluong"].Value = sl;
                    dgvPhuKien.Rows[i].Cells["thanhtien"].Value = (sl * dongia) - (sl * dongia * uudai / 100); ;
                    return;
                }

            }
            int tongtien = dongia * soluong - (soluong * dongia * uudai / 100) ;
            dgvPhuKien.Rows.Add(new object[] { mapk, txttenphukien.Text, cbLoaiPhuKien.Text, txtsoluong.Value.ToString(), txtdongia.Text, tongtien });
        }
        public void reset()
        {
            dgvPhuKien.Rows.Clear();
            cbLoaiPhuKien.SelectedIndex = -1;
            txtdongia.Text = "0";
            txttenphukien.Text = "";
        }
        private void btnluu_Click(object sender, EventArgs e)
        {

            if (dgvPhuKien.Rows.Count == 0)
            {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == txtmahoadon.Text);
                if (hd != null)
                {
                    List<CTPHUKIEN> ds_ctpk = quanli.CTPHUKIENs.Where(p => p.MaHD == txtmahoadon.Text).ToList();
                    foreach (var item in ds_ctpk)
                    {
                        quanli.CTPHUKIENs.Remove(item);
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
                foreach (DataGridViewRow rows in dgvPhuKien.Rows)
                {
                    CTPHUKIEN ct = new CTPHUKIEN();
                    string mapk = rows.Cells["maphukien"].Value.ToString();
                    string tenphukien = rows.Cells["tenphukien"].Value.ToString();
                    int sl = int.Parse(rows.Cells["soluong"].Value.ToString());
                    ct.MaHD = txtmahoadon.Text;
                    ct.Maphukien = mapk;
                    ct.Tenphukien = tenphukien;
                    ct.soluong = sl;
                    quanli.CTPHUKIENs.Add(ct);
                    quanli.SaveChanges();
                }
                MessageBox.Show("Lưu thành công!");
                loadhdchuathanhtoan();
                return;
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvPhuKien.Rows.Count == 0)
            {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == txtmahoadon.Text);
                hd.TrangThai = true;
                quanli.SaveChanges();
                MessageBox.Show("Thanh toán thành công!");
                Formbalo_Load(sender, e);
                cbchuathanhtoan.Text = null;
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show("Đã xóa!");
                dgvPhuKien.Rows.Remove(dgvPhuKien.Rows[e.RowIndex]);
            }
        }

        private void cbchuathanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPhuKien.Rows.Clear();
            txtmahoadon.Text = cbchuathanhtoan.Text;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<CTPHUKIEN> ds_hd = quanli.CTPHUKIENs.Where(p => p.MaHD == txtmahoadon.Text).ToList();
                foreach (var item in ds_hd)
                {
                    string maloai = quanli.PHUKIENs.FirstOrDefault(p => p.Maphukien == item.Maphukien).MaLoai.ToString();
                    string loaiphukien = quanli.LoaiPhuKiens.FirstOrDefault(p => p.MaLoai == maloai).TenLoai;
                    double dongia = (double)quanli.PHUKIENs.FirstOrDefault(p => p.Maphukien == item.Maphukien).dongia;
                    double thanhtien = dongia * item.soluong;

                    dgvPhuKien.Rows.Add(item.Maphukien, item.Tenphukien, loaiphukien, item.soluong, dongia, thanhtien);

                }
            }
        }
    }
}
