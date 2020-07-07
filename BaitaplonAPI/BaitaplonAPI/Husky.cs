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
    public partial class Husky : UserControl
    {
        public Husky()
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
                    img.BorderStyle = BorderStyle.FixedSingle;
                    img.TabIndex = i;
                    img.TabStop = false;
                    img.Zoom = 10;
                    panelAnh.Controls.Add(img);
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
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Text = ds_thucung[3 * count + j].TenThuCung;
                        panelAnh.Controls.Add(tb);

                    }
                }
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
        private void loadHoaDon()
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void Husky_Load(object sender, EventArgs e)

        {
            loadHoaDonThuCung();
            LoadDanhMuc();
            LoadThuCung("LTC01");
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
                                 hd.MaHD,
                                 cthd.MaThuCung,
                                 tc.TenThuCung,
                                 hd.MaUD,
                                 hd.TongTien,
                                 hd.TrangThai
                             };
                dgvThuCung.DataSource = result.ToList();
            }

        }
    }
}
