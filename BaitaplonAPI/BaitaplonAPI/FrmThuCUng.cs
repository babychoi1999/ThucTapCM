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
    public partial class FrmThuCUng : UserControl
    {
        public FrmThuCUng()
        {
            InitializeComponent();
        }

      
        private void LoadThuCung(string v)
        {
            panelAnh.Controls.Clear();

            int i = 0;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<ThuCung> ds_thucung = quanli.ThuCungs.Where(p => p.MaLoai == v).ToList();
                int dem = ds_thucung.Count % 3;
                int count = ds_thucung.Count / 3;
                foreach (var item in ds_thucung)
                {

                    BunifuImageButton img = new BunifuImageButton();
                    img.Name = item.MaThuCung.ToString();
                    img.Size = new System.Drawing.Size(182, 138);
                    img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    Byte[] hinhanh = item.Anh;
                    if (hinhanh != null)
                    {
                        using (MemoryStream stream = new MemoryStream(hinhanh))
                        {
                            Image returnImage = Image.FromStream(stream);
                            img.Image = returnImage;
                        }
                    }
                    img.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
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
                            tb.Text = ds_thucung[j].TenThuCung;
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
                        tb.Size = new System.Drawing.Size(182, 13);
                        tb.Enabled = false;
                        tb.BackColor = Color.White;
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                        tb.Text = ds_thucung[3 * count + j].TenThuCung;
                        panelAnh.Controls.Add(tb);

                    }
                }
            }
        }
        string matc = "";

        private void chonhinhanh(object sender, EventArgs e)
        {
            BunifuImageButton img = sender as BunifuImageButton;
            matc = img.Name.ToString();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                ThuCung thucung = quanli.ThuCungs.FirstOrDefault(p => p.MaThuCung == matc);
                cbLoaiThuCung.SelectedValue = thucung.MaLoai;
                txttenthucung.Text = thucung.TenThuCung;
                txtdongia.Text = thucung.DonGia.ToString();
            }
        }
        private void loadLoaiThuCung()
        {
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                cbLoaiThuCung.DataSource  = quanli.LoaiThuCungs.ToList();
                cbLoaiThuCung.DisplayMember = "TenLoai";
                cbLoaiThuCung.ValueMember = "MaLoai";
            }
        }

        void LoadDanhMuc()
        {
            panelDanhMuc.Controls.Clear();         
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<LoaiThuCung> ds_loaitc = quanli.LoaiThuCungs.ToList();
                int i = 0;
                foreach (var item in ds_loaitc)
                {
                    BunifuThinButton2 bt = new BunifuThinButton2();                                     
                    bt.Size = new System.Drawing.Size(80, 45);
                    bt.TabIndex = i;
                    bt.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
                    bt.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
                    bt.IdleFillColor = Color.White;
                    bt.IdleForecolor = Color.MidnightBlue ;
                    bt.IdleLineColor = System.Drawing.Color.LightSkyBlue;
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
                List<LoaiThuCung> ds_loaithucung = quanli.LoaiThuCungs.ToList();
            }
        }

        private void clickChonDanhMuc(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;
            if(btn.Name.Trim()=="LTC01")
            {
                LoadThuCung("LTC01");
            }
            if (btn.Name.Trim() == "LTC02")
            {
                LoadThuCung("LTC02");
            }
            if (btn.Name.Trim() == "LTC03")
            {
                LoadThuCung("LTC03");
            }
            if(btn.Name.Trim() == "LTC04")
            {
                LoadThuCung("LTC04");
            }
            if(btn.Name.Trim() == "LTC05")
            {
                LoadThuCung("LTC05");
            }
            if (btn.Name.Trim() == "LTC06")
            {
                LoadThuCung("LTC06");
            }
            if (btn.Name.Trim() == "LTC07")
            {
                LoadThuCung("LTC07");
            }
        }
        string maud = "";
        private void loaduudai()
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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void Husky_Load(object sender, EventArgs e)

        {
            
            
            loadLoaiThuCung();
            cbLoaiThuCung.SelectedIndex = -1;
            // loadHoaDonThuCung();
            LoadDanhMuc();
            LoadThuCung("LTC01");
            loaduudai();
            dgvThuCung.Rows.Clear();
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

        private void loadHoaDonThuCung()
        {
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                var result = from hd in quanli.HoaDons
                             join cthd in quanli.CTHoaDons on hd.MaHD equals cthd.MaHD
                             join tc in quanli.ThuCungs on cthd.MaThuCung equals tc.MaThuCung
                             select new
                             {
                                 cthd.MaThuCung,
                                 tc.TenThuCung,
                                 hd.MaUD,
                                 hd.TongTien,
                                 hd.TrangThai
                             };
                dgvThuCung.DataSource = result.ToList();
            }

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txtsoluong.Value == 0)
            {
                MessageBox.Show("Số lượng thú cưng không thể là 0");
                return;

            }

             int dongia= int.Parse(txtdongia.Text);
            int soluong = int.Parse(txtsoluong.Value.ToString());
            int     uudai = int.Parse(txtuudai.Text);
            for (int i = 0; i < dgvThuCung.Rows.Count; i++)
            {
                
                string loaithucung = dgvThuCung.Rows[i].Cells["loaithucung"].Value.ToString();
                string tenthucung = dgvThuCung.Rows[i].Cells["tenthucung"].Value.ToString(); 
                if (tenthucung == txttenthucung.Text && cbLoaiThuCung.Text == loaithucung)
                {             
  
                    int sl = int.Parse(dgvThuCung.Rows[i].Cells["soluong"].Value.ToString()) + soluong;
                    dgvThuCung.Rows[i].Cells["soluong"].Value = sl;
                    dgvThuCung.Rows[i].Cells["thanhtien"].Value = (sl * dongia) - (sl * dongia * uudai/100);
                    return;
                }
                    
            }
                 int  tongtien = (soluong * dongia) - (soluong * dongia * uudai/100);
                dgvThuCung.Rows.Add(new object[] { matc, txttenthucung.Text, cbLoaiThuCung.Text,
                    txtsoluong.Value.ToString(), txtdongia.Text, tongtien });
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void reset() {
            dgvThuCung.Rows.Clear();
            cbLoaiThuCung.SelectedIndex = -1;
            txtdongia.Text = "0";
            txttenthucung.Text = "";
        }
        public void loadhdchuathanhtoan()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<hdthucungchuathanhtoan_Result> hd = quanli.hdthucungchuathanhtoan().ToList();
                cbchuathanhtoan.DataSource = hd;
                cbchuathanhtoan.DisplayMember = "MaHD";
                cbchuathanhtoan.ValueMember = "MaHD";
            }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (dgvThuCung.Rows.Count == 0)
            {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == txtmahoadon.Text);
                if (hd != null)
                {

                    List<CTHoaDon> ds_cttc = quanli.CTHoaDons.Where(p => p.MaHD == txtmahoadon.Text).ToList();
                    foreach (var item in ds_cttc)
                    {
                        quanli.CTHoaDons.Remove(item);
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
                foreach (DataGridViewRow rows in dgvThuCung.Rows)
                {
                    CTHoaDon ct = new CTHoaDon();
                    string matc = rows.Cells["mathucung"].Value.ToString();
                    string tentc = rows.Cells["tenthucung"].Value.ToString();
                    int sl = int.Parse(rows.Cells["soluong"].Value.ToString());
                    ct.MaHD = txtmahoadon.Text;
                    ct.MaThuCung = matc;
                    ct.tenthucung = tentc;
                    ct.SoLuong = sl;
                    quanli.CTHoaDons.Add(ct);
                    quanli.SaveChanges();
                }
                MessageBox.Show("Lưu thành công!");
                loadhdchuathanhtoan();
                return;
            }
        }

        private void dgvThuCung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show("Đã xóa!");
                dgvThuCung.Rows.Remove(dgvThuCung.Rows[e.RowIndex]);
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvThuCung.Rows.Count == 0)
            {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == txtmahoadon.Text);
                hd.TrangThai = true;
                quanli.SaveChanges();
                MessageBox.Show("Thanh toán thành công!");
                Husky_Load(sender, e);
                cbchuathanhtoan.Text = null;
                return;
            }
        }

        private void cbchuathanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvThuCung.Rows.Clear();
            txtmahoadon.Text = cbchuathanhtoan.Text;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<CTHoaDon> ds_hd = quanli.CTHoaDons.Where(p => p.MaHD == txtmahoadon.Text).ToList();
                foreach (var item in ds_hd)
                {
                    string maloai = quanli.ThuCungs.FirstOrDefault(p => p.MaThuCung == item.MaThuCung).MaLoai.ToString();
                    string loaithucung = quanli.LoaiThuCungs.FirstOrDefault(p => p.MaLoai == maloai).TenLoai;
                    double dongia = (double)quanli.ThuCungs.FirstOrDefault(p => p.MaThuCung == item.MaThuCung).DonGia;
                    double thanhtien = dongia * (double)item.SoLuong;

                    dgvThuCung.Rows.Add(item.MaThuCung, item.tenthucung, loaithucung, item.SoLuong, dongia, thanhtien);

                }
            }
        }
        private void cbDichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void panelDanhMuc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
