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
    public partial class Formbalo : UserControl
    {
        public Formbalo()
        {
            InitializeComponent();
        }
        private void LoadPhuKien(string v)
        {
            panelAnh.Controls.Clear();

            int i = 0;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<PHUKIEN> ds_phukien = quanli.PHUKIENs.ToList();
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
                        tb.Size = new System.Drawing.Size(182, 30);
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Text = ds_phukien[3 * count + j].Tenphukien;
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
                    bt.IdleLineColor = System.Drawing.Color.White;
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

        private void Formbalo_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadPhuKien("LPK01");
        }
    }
}
