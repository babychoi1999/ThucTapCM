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
    public partial class Formbanhthuong : UserControl
    {
        public Formbanhthuong()
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
                    bt.IdleLineColor = System.Drawing.Color.White;
                 
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
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<THUCPHAM> ds_thucpham = quanli.THUCPHAMs.Where(p => p.MaLoai == v).ToList();
                int dem = ds_thucpham.Count % 3;
                int count = ds_thucpham.Count / 3;
                foreach(var item in ds_thucpham)
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
                            tb.Font = new System.Drawing.Font("Microsoft Sans Serif",11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
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
                        tb.Size = new System.Drawing.Size(182, 13);
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Text = ds_thucpham[3 * count + j].Tenthucpham;
                        panelAnh.Controls.Add(tb);

                    }
                }
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

        private void Formbanhthuong_Load(object sender, EventArgs e)
        {
            loaddanhmuc();
            loadthucpham("LTP01");
        }
    }

}
