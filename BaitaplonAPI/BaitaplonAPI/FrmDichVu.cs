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
    public partial class FrmDichVu : UserControl
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }    
        private void loaddichvu()
        {
            panelAnh.Controls.Clear();
            int i = 0;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<DichVu> ds_dichvu = quanli.DichVus.ToList();
                int dem = ds_dichvu.Count % 3;
                int count = ds_dichvu.Count / 3;
                foreach (var item in ds_dichvu)
                {
                    BunifuImageButton img = new BunifuImageButton();
                    img.Name = item.MaDV.ToString();
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
                            tb.Text = ds_dichvu[j].TenDichVu;
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
                        tb.Enabled = false;
                        tb.BackColor = Color.White;
                        tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                        tb.Text = ds_dichvu[3 * count + j].TenDichVu;
                        panelAnh.Controls.Add(tb);
                    }
                }
            }
        }
        string madv = "";
        private void chonhinhanh(object sender, EventArgs e)
        {

            BunifuImageButton img = sender as BunifuImageButton;
            madv = img.Name.ToString();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DichVu dv = quanli.DichVus.FirstOrDefault(p => p.MaDV == madv);
                txttendichvu.Text = dv.TenDichVu;
                txtdongia.Text = dv.DonGia.ToString();
            }
        }
        private void loadhoadon()
        {
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                cbHoaDon.DataSource = quanli.HoaDons.ToList();
                cbHoaDon.DisplayMember = "MaHD";
            }
        }
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
                        return;
                    }
                }
            }
        }
        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            loaddichvu();
            loaduudai();
            loadhoadon();
            cbHoaDon.SelectedIndex = -1;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtsoluong.Value == 0)
            {
                MessageBox.Show("Số lượng không thể là 0");
                return;
            }
            int dongia = int.Parse(txtdongia.Text);
            int soluong = int.Parse(txtsoluong.Value.ToString());
            int uudai = int.Parse(txtuudai.Text.ToString());
            for (int i = 0; i < dgvDichvu.Rows.Count; i++)
            {
                string tendichvu = dgvDichvu.Rows[i].Cells["tendichvu"].Value.ToString();

                if (tendichvu == txttendichvu.Text)
                {
                    int sl = int.Parse(dgvDichvu.Rows[i].Cells["soluong"].Value.ToString()) + soluong;
                    dgvDichvu.Rows[i].Cells["soluong"].Value = sl;
                    dgvDichvu.Rows[i].Cells["thanhtien"].Value = (sl * dongia) - (sl * dongia * uudai / 100);
                    return;
                }

            }
            int tongtien = (soluong * dongia) - (soluong * dongia * uudai / 100);
            dgvDichvu.Rows.Add(new object[] { madv, txttendichvu.Text, txtsoluong.Value.ToString(), txtdongia.Text, tongtien });
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (dgvDichvu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có thông tin để lưu");
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == cbHoaDon.Text);
                hd.TrangThai = false;
                foreach (DataGridView rows in dgvDichvu.Rows)
                {
                    CTDichVu ct = new CTDichVu();
                    ct.MaHD = cbHoaDon.Text;
                    ct.MaDV = madv;
                    ct.SoDV = int.Parse(txtsoluong.Value.ToString());
                    quanli.CTDichVus.Add(ct);
                    quanli.SaveChanges();
                }
                MessageBox.Show("Lưu thành công!");
                return;
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {

            if (dgvDichvu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hóa đơn để thanh toán");
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == cbHoaDon.Text);
                hd.TrangThai = true;
                quanli.SaveChanges();
                MessageBox.Show("Thanh toán thành công!");
                FrmDichVu_Load(sender, e);
                cbchuathanhtoan.Text = null;
                return;
            }
        }
    }
}

