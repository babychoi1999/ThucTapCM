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
    public partial class fmChiTietPN : Form
    {
        string mapn="PN01";
        public fmChiTietPN()
        {
            InitializeComponent();
        }

        private void fmChiTietPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet26.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanlithucungDataSet26.NhaCungCap);
            Data();
        }

        private void Data()
        {
            lvPhieuNhap.Groups.Clear();
            lvPhieuNhap.Items.Clear();
            lvPhieuNhap.Groups.Clear();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<CTNhapThuCung> ds_nhaptc = quanli.CTNhapThuCungs.Where(p => p.MaPN == mapn).ToList();
                List<CTNhapThucPham> ds_nhaptp = quanli.CTNhapThucPhams.Where(p => p.MaPN == mapn).ToList();
                List<CTNhapPhuKien> ds_nhappk = quanli.CTNhapPhuKiens.Where(p => p.MaPN == mapn).ToList();
                if(ds_nhaptc.Count>0)
                {
                    ListViewGroup lvl = new ListViewGroup("Thú Cưng");
                    lvl.Tag = 0;
                    lvPhieuNhap.Groups.Add(lvl);
                }
                if (ds_nhappk.Count > 0)
                {
                    ListViewGroup lvl = new ListViewGroup("Phụ Kiện");
                    lvl.Tag = 1;
                    lvPhieuNhap.Groups.Add(lvl);
                }
                if (ds_nhaptp.Count > 0)
                {
                    ListViewGroup lvl = new ListViewGroup("Thực Phẩm");
                    lvl.Tag = 2;
                    lvPhieuNhap.Groups.Add(lvl);
                }
                foreach (ListViewGroup lvl in lvPhieuNhap.Groups)
                {
                    int stt = 1;
                    if(lvl.Tag.ToString()=="0")
                    {
                        foreach (CTNhapThuCung item in ds_nhaptc)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.SubItems.Add(stt + "");
                            lvi.SubItems.Add(item.TenThuCung.Trim());
                            lvi.SubItems.Add(item.GiaNhap.ToString());
                            lvi.SubItems.Add(item.SoLuong.ToString());
                            lvi.SubItems.Add(item.Donvi.ToString());
                            lvi.SubItems.Add(item.MaThuCung.ToString());
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add("");

                            //lvi.SubItems.Add(item.MaNCC.ToString());
                            lvPhieuNhap.Items.Add(lvi);
                            lvi.Group = lvl;
                            stt++;
                        }
                    }
                    if (lvl.Tag.ToString() == "1")
                    {
                        foreach (CTNhapPhuKien item in ds_nhappk)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.SubItems.Add(stt + "");
                            lvi.SubItems.Add(item.TenPhuKien.Trim());
                            lvi.SubItems.Add(item.GiaNhap.ToString());
                            lvi.SubItems.Add(item.Soluong.ToString());
                            lvi.SubItems.Add(item.Donvi.ToString());
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add(item.MaPhuKien.ToString());
                            lvi.SubItems.Add("");
                            // lvi.SubItems.Add(item.MaNCC.ToString());
                            lvPhieuNhap.Items.Add(lvi);
                            lvi.Group = lvl;
                            stt++;
                        }
                    }
                    if (lvl.Tag.ToString() == "2")
                    {
                        foreach (CTNhapThucPham item in ds_nhaptp)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.SubItems.Add(stt + "");
                            lvi.SubItems.Add(item.TenThucPham.Trim());
                            lvi.SubItems.Add(item.GiaNhap.ToString());
                            lvi.SubItems.Add(item.Soluong.ToString());
                            lvi.SubItems.Add(item.DonVi.ToString());
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add(item.MaThucPham.ToString());

                            // lvi.SubItems.Add(item.MaNCC.ToString());
                            lvPhieuNhap.Items.Add(lvi);
                            lvi.Group = lvl;
                            stt++;
                        }
                    }

                }
            }
        }
        private void themSanPham()
        {
            if(cbDanhMuc.Text=="Thú Cưng")
            {
                string tenthucung = cbTen.Text;
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    ThuCung tc = quanli.ThuCungs.FirstOrDefault(p => p.TenThuCung.ToLower() == tenthucung.ToLower());
                    if(tc==null)
                    {
                        //Console.WriteLine("aaa");
                        quanli.insertCTPN("PN01", int.Parse(txtSoLuong.Text), double.Parse(txtGia.Text), tenthucung, cbLoai.SelectedValue.ToString(), null,txtdonvi.Text);
                        quanli.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else {
                        tc.soluong += int.Parse(txtSoLuong.Text);
                        CTNhapThuCung tcm = new CTNhapThuCung();
                        tcm.MaPN = "PN01";
                        tcm.MaThuCung = tc.MaThuCung;
                        tcm.TenThuCung = tc.TenThuCung;
                        tcm.MaLoai = cbLoai.SelectedValue.ToString();
                        tcm.SoLuong = int.Parse(txtSoLuong.Text);
                        tcm.GiaNhap = double.Parse(txtGia.Text);
                        tcm.Donvi = txtdonvi.Text;
                        quanli.CTNhapThuCungs.Add(tcm);
                        quanli.SaveChanges();
                        MessageBox.Show("Thêm thành công!");

             
                    }
                }
                
            }
            if(cbDanhMuc.Text=="Phụ Kiện")
            {
                themPhuKien();
            }
            if(cbDanhMuc.Text=="Thực Phẩm")
            {
                themThucPham();
            }
        }
        private void suaSanPham()
        {
            //string matc = cbTen.SelectedValue.ToString();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                CTNhapThuCung nhap = quanli.CTNhapThuCungs.FirstOrDefault(p => p.MaThuCung == matc&&p.MaPN=="PN01");
                //nhap.MaPN = "PN01";
                Console.WriteLine(nhap.MaThuCung);
                nhap.MaLoai = cbLoai.SelectedValue.ToString();
                nhap.TenThuCung = cbTen.Text;
                nhap.SoLuong = int.Parse(txtSoLuong.Text);
                nhap.GiaNhap = double.Parse(txtGia.Text);
                nhap.Donvi = txtdonvi.Text;
                quanli.SaveChanges();


                ThuCung tc = quanli.ThuCungs.FirstOrDefault(p => p.MaThuCung == matc);
                
                tc.TenThuCung = cbTen.Text;
                tc.MaLoai = cbLoai.SelectedValue.ToString();
                tc.soluong += int.Parse(txtSoLuong.Text); 
                tc.DonGia = double.Parse(txtGia.Text) + 0.1* double.Parse(txtGia.Text);
                tc.Donvi = txtdonvi.Text;
                if (dem == 1)
                {
                    MemoryStream me = new MemoryStream();
                    byte[] images = null;
                    FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                    tc.Anh = images;
                }

                quanli.SaveChanges();
            }
        }
        private void themThucPham()
        {
            string tenthucpham = cbTen.Text;
            using (quanlithucungEntities1 qlthucpham = new quanlithucungEntities1())
            {
                THUCPHAM tp = qlthucpham.THUCPHAMs.FirstOrDefault(p => p.Tenthucpham.ToLower() == tenthucpham.ToLower());
                if (tp == null)
                {
                    qlthucpham.insertCTTP("PN01", int.Parse(txtSoLuong.Text), double.Parse(txtGia.Text), tenthucpham, cbLoai.SelectedValue.ToString(), null, txtdonvi.Text);
                    qlthucpham.SaveChanges();
                    MessageBox.Show("Thêm thành công!");

                }
                else {
                    tp.SOLUONG += int.Parse(txtSoLuong.Text);
                    CTNhapThucPham tpm = new CTNhapThucPham();
                    tpm.MaPN = "PN01";
                    tpm.MaThucPham = tp.Mathucpham;
                    tpm.TenThucPham = tp.Tenthucpham;
                    tpm.MaLoai = cbLoai.SelectedValue.ToString();
                    tpm.Soluong = int.Parse(txtSoLuong.Text);
                    tpm.GiaNhap = double.Parse(txtGia.Text);
                    tpm.DonVi = txtdonvi.Text;
                    qlthucpham.CTNhapThucPhams.Add(tpm);
                    qlthucpham.SaveChanges();
                    MessageBox.Show("Thêm thành công!");
                }
            }
        }

        private void themPhuKien()
        {
            string tenphukien = cbTen.Text;
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1()) {
                PHUKIEN pk = quanli.PHUKIENs.FirstOrDefault(p => p.Tenphukien.ToLower() == tenphukien.ToLower());
                if (pk == null)
                {
                    Console.WriteLine("aa");
                    quanli.insertCTPK("PN01", int.Parse(txtSoLuong.Text), double.Parse(txtGia.Text), tenphukien, cbLoai.SelectedValue.ToString(), null, txtdonvi.Text);

                    quanli.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                }
                else {
                    pk.Soluong += int.Parse(txtSoLuong.Text);
                    CTNhapPhuKien pkm = new CTNhapPhuKien();
                    pkm.MaPN = "PN01";
                    pkm.MaPhuKien = pk.Maphukien;
                    pkm.TenPhuKien = pk.Tenphukien;
                    pkm.MaLoai = cbLoai.SelectedValue.ToString();
                    pkm.GiaNhap = double.Parse(txtGia.Text);
                    pkm.Soluong = int.Parse(txtSoLuong.Text);
                    pkm.Donvi = txtdonvi.Text;
                    pkm.Anh = pk.HinhAnh;
                    quanli.CTNhapPhuKiens.Add(pkm);
                    quanli.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }

        int i = 0;
        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbLoai.Items.Clear();
            if(i==0)
            {
                txtGia.Text = "";
                txtSoLuong.Text = "";
            }
            if (cbDanhMuc.Text == "Thú Cưng")
            {
                loadLoaiThuCung();
            }
            if (cbDanhMuc.Text == "Phụ Kiện")
            {
                loadLoaiPhuKien();
            }
            if (cbDanhMuc.Text == "Thực Phẩm")
            {
                loadLoaiThucPham();
            }
            cbLoai.SelectedIndex = -1;
            i = 0;
            
        }

        private void loadLoaiThucPham()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {

                cbLoai.DataSource = quanli.LoaiThucPhams.ToList();
                cbLoai.DisplayMember = "tenloai";
                cbLoai.ValueMember = "maloai";
            }
        }

        private void loadLoaiPhuKien()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {

                cbLoai.DataSource = quanli.LoaiPhuKiens.ToList();
                cbLoai.DisplayMember = "tenloai";
                cbLoai.ValueMember = "maloai";
            }
        }

        private void loadLoaiThuCung()
        {
            
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                
                cbLoai.DataSource = quanli.LoaiThuCungs.ToList();
                cbLoai.DisplayMember = "tenloai";
                cbLoai.ValueMember = "maloai";
            }
        }

        private void cbTen_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                hinhanh.Image = null;
                string ma = cbTen.SelectedValue.ToString();
                if (cbDanhMuc.SelectedIndex == 0)
                {

                    loadThongTinTC(ma);
                }
                if (cbDanhMuc.SelectedIndex == 1)
                {

                    loadThongTinPK(ma);
                }
                if (cbDanhMuc.SelectedIndex == 2)
                {

                    loadThongTinTP(ma);
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void loadThuCung()
        {
            
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
               
                string maloai = cbLoai.SelectedValue.ToString();
                cbTen.DataSource = quanli.ThuCungs.Where(p => p.MaLoai == maloai).ToList();
                cbTen.DisplayMember = "tenthucung";
                cbTen.ValueMember = "mathucung";

            }
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbLoai.SelectedIndex == -1)
                return;
            if (cbDanhMuc.Text == "Thú Cưng")
            {
                loadThuCung();
            }
            if (cbDanhMuc.Text == "Phụ Kiện")
            {
                loadPhuKien();
            }
            if (cbDanhMuc.Text == "Thực Phẩm")
            {
                loadThucPham();
            }
            cbTen.SelectedIndex = -1;
        }

        private void loadThucPham()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {

                string maloai = cbLoai.SelectedValue.ToString();
                Console.WriteLine(maloai);
                cbTen.DataSource = quanli.THUCPHAMs.Where(p => p.MaLoai == maloai).ToList();
                cbTen.DisplayMember = "tenthucpham";
                cbTen.ValueMember = "mathucpham";

            }
        }

        private void loadPhuKien()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {

                string maloai = cbLoai.SelectedValue.ToString();
                cbTen.DataSource = quanli.PHUKIENs.Where(p => p.MaLoai == maloai).ToList();
                cbTen.DisplayMember = "tenphukien";
                cbTen.ValueMember = "maphukien";

            }
        }
        string matc;
        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = 1;
            if (lvPhieuNhap.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPhieuNhap.SelectedItems[0];
                txtGia.Text = item.SubItems[3].Text;
                txtSoLuong.Text = item.SubItems[4].Text;
                try
                {
                    
                    string mathucung = item.SubItems[6].Text;
                    matc = mathucung;
                    
                    if (mathucung != "")
                    {
                        
                        loadThongTinTC(mathucung);
                        return;
                    }
                    string maphukien = item.SubItems[7].Text;
                    
                    if (maphukien!="")
                    {
                        loadThongTinPK(maphukien);
                    }
                    string mathucpham = item.SubItems[8].Text;
                    if(mathucpham!="")
                    {
                        loadThongTinTP(mathucpham);
                    }
                }
                catch (Exception e1)
                {

                    return;
                }
                //foreach (DoUong du in ds_douong)
                //{
                //    if (du.TenDoUong.Equals(txtten.Text))
                //    {
                //        madouong = du.MaDU;
                //        Byte[] img = du.HinhAnh;
                //        if (img != null)
                //        {
                //            using (MemoryStream stream = new MemoryStream(img))
                //            {
                //                Image returnImage = Image.FromStream(stream);
                //                hinhanh.Image = returnImage;
                //            }
                //        }
                //        LoadSize(du.MaDU);
                //        if (cbsize.Items.Count != 0)
                //            load_gia(du.MaDU, cbsize.SelectedItem.ToString());
                //        else
                //            txtgia.Text = "";
                //    }
            }
            }

        private void loadThongTinTP(string mathucpham)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                THUCPHAM thucpham = quanli.THUCPHAMs.FirstOrDefault(p => p.Mathucpham == mathucpham);
                cbDanhMuc.SelectedIndex = 2;
                cbLoai.SelectedValue = thucpham.MaLoai;
                cbTen.SelectedValue = thucpham.Mathucpham;
                Byte[] img = thucpham.hinhanh;
                if (img != null)
                {
                    using (MemoryStream stream = new MemoryStream(img))
                    {
                        Image returnImage = Image.FromStream(stream);
                        hinhanh.Image = returnImage;
                    }
                }
            }
        }

        private void loadThongTinPK(string maphukien)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                PHUKIEN phukien = quanli.PHUKIENs.FirstOrDefault(p => p.Maphukien == maphukien);
                cbDanhMuc.SelectedIndex = 1;
                cbLoai.SelectedValue = phukien.MaLoai;
                cbTen.SelectedValue = phukien.Maphukien;
                Byte[] img = phukien.HinhAnh;
                if (img != null)
                {
                    using (MemoryStream stream = new MemoryStream(img))
                    {
                        Image returnImage = Image.FromStream(stream);
                        hinhanh.Image = returnImage;
                    }
                }
            }
        }

        private void loadThongTinTC(string mathucung)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                ThuCung thuCung = quanli.ThuCungs.FirstOrDefault(p => p.MaThuCung == mathucung);
                cbDanhMuc.SelectedIndex = 0;
                cbLoai.SelectedValue = thuCung.MaLoai;
                cbTen.SelectedValue = thuCung.MaThuCung;
                txtdonvi.Text = thuCung.Donvi;
                Byte[] img = thuCung.Anh;
                if (img != null)
                {
                    using (MemoryStream stream = new MemoryStream(img))
                    {
                        Image returnImage = Image.FromStream(stream);
                        hinhanh.Image = returnImage;
                    }
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
           
        }
      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            themSanPham();
           // themThucPham();
            fmChiTietPN_Load(sender, e);
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            suaSanPham();
            fmChiTietPN_Load(sender, e);
        }
        string img = "";
        int dem = 0;
        private void hinhanh_Click(object sender, EventArgs e)
        {
            dem = 1;   
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
    }
}
