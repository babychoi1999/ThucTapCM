using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BaitaplonAPI
{
    public partial class FrmQuanly : UserControl
    {
        public FrmQuanly()
        {
            InitializeComponent();
        }
        public void loaduudai()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<UuDaiHD> ds_ud = quanli.UuDaiHDs.ToList();
                DataTable table = new DataTable();
                table.Columns.Add("mauudai");
                table.Columns.Add("tenud");
                table.Columns.Add("ngaybatdau");
                table.Columns.Add("ngayketthuc");
                table.Columns.Add("uudai");
                foreach (var item in ds_ud)
                {
                    table.Rows.Add(item.MaUD, item.TenUD, item.NgayBD, item.NgayKT, item.GiamGia);

                }
                dgvuudai.DataSource = table;
            }
        }
        public bool kiemtraud()
        {
            if (tgbdud.Value > tgktud.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!");
                return false;
            }
            if (tgbdud.Value.Year < DateTime.Now.Year || tgbdud.Value.Month < DateTime.Now.Month || tgbdud.Value.Day < DateTime.Now.Day)
            {
                MessageBox.Show("Ngày bắt đầu không thể nhỏ hơn ngày hôm nay!");
                return false;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<UuDaiHD> ds_uudai = quanli.UuDaiHDs.ToList();
                foreach (var item in ds_uudai)
                {
                    if (tgbdud.Value.Year == item.NgayBD.Value.Year && tgbdud.Value.Month == item.NgayBD.Value.Month && tgbdud.Value.Day == item.NgayBD.Value.Day)
                    {
                        MessageBox.Show("Ngày bắt đầu đã có khuyến mãi rồi!!");
                        return false;
                    }
                    if (tgbdud.Value.Day <= item.NgayKT.Value.Day && tgbdud.Value.Day >= item.NgayBD.Value.Day)
                    {
                        MessageBox.Show("Ngày bắt đầu đã có khuyến mãi rồi!!");
                        return false;
                    }
                }
            }
            try
            {
                int giamgia = int.Parse(txtgiamgia.Text);
                if (giamgia <= 0)
                {
                    MessageBox.Show("Tỉ lệ giảm giá phải lớn hơn 0!");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tỉ lệ giảm giá phải là số!");
                return false;

            }
            return true;
        }

        private void dgvkhuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void resetud()
        {
            txttenud.Text = "";
            tgbdud.Value = DateTime.Now;
            tgktud.Value = DateTime.Now;
            txtgiamgia.Text = "0";
            btnluu.Enabled = false;
        }

        private void luuud_Click(object sender, EventArgs e)
        {

        }

        private void themud_Click(object sender, EventArgs e)
        {

        }

        private void dgvuudai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnluu.Enabled = true;
            makm = dgvuudai.Rows[e.RowIndex].Cells["mauudai"].Value.ToString();
            txttenud.Text = dgvuudai.Rows[e.RowIndex].Cells["tenud"].Value.ToString();
            tgbdud.Value = Convert.ToDateTime(dgvuudai.Rows[e.RowIndex].Cells["ngaybatdau"].Value.ToString());
            tgktud.Value = Convert.ToDateTime(dgvuudai.Rows[e.RowIndex].Cells["ngayketthuc"].Value.ToString());
            txtgiamgia.Text = dgvuudai.Rows[e.RowIndex].Cells["uudai"].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa khuyến mại này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        UuDaiHD uudai = quanli.UuDaiHDs.FirstOrDefault(p => p.MaUD == makm);
                        uudai.NgayBD = Convert.ToDateTime("06/05/2020");
                        quanli.SaveChanges();
                        List<HoaDon> ds_hd = quanli.HoaDons.Where(p => p.MaUD == makm).ToList();
                        foreach (var item in ds_hd)
                        {
                            HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == item.MaHD);
                            hd.MaUD = null;
                            quanli.SaveChanges();
                        }

                        quanli.UuDaiHDs.Remove(uudai);
                        quanli.SaveChanges();
                        MessageBox.Show(this, "Xóa thành công !!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetud();
                        loaduudai();
                    }
                }

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!kiemtraud())
                return;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                int giamgia = int.Parse(txtgiamgia.Text);
                quanli.insertudhd(txttenud.Text, tgbdud.Value, tgktud.Value, giamgia, null);
                quanli.SaveChanges();
                MessageBox.Show("Đã thêm !!");
                loaduudai();
            }
            resetud();
        }
        string makm = "";
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!kiemtraud())
            {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                UuDaiHD ud = quanli.UuDaiHDs.FirstOrDefault(p => p.MaUD == makm);
                ud.TenUD = txttenud.Text;
                ud.NgayBD = tgbdud.Value;
                ud.NgayKT = tgktud.Value;
                ud.GiamGia = int.Parse(txtgiamgia.Text);
                quanli.SaveChanges();
                MessageBox.Show("Đã sửa");
                loaduudai();
                resetud();
            }
        }

        private void FrmQuanly_Load(object sender, EventArgs e)
        {

            luu.Enabled = false;
            loadcalam();
            loaduudai();
            loadchucvu();
            loadtaikhoan();
            loadcbnhanvien();
            btn_luu.Enabled = false;
            btnxoa.Enabled = false;
        }

        

        List<dstaikhoan_Result> ds_nhanvien = new List<dstaikhoan_Result>();
        private void loadcbnhanvien()
        {
            cbnhanvien.Items.Clear();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                ds_nhanvien = quanli.dstaikhoan().ToList();
                foreach (var item in ds_nhanvien)
                {
                    cbnhanvien.Items.Add(item.manv);
                }
            }
        }
        public void loadtaikhoan()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<DangNhap> ds_taikhoan = quanli.DangNhaps.ToList();
                DataTable table = new DataTable();
                table.Columns.Add("Username");
                table.Columns.Add("password");
                table.Columns.Add("tennv");
                table.Columns.Add("MaNV");
                foreach (DangNhap item in ds_taikhoan)
                {
                    string tennv = "";
                    NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.MaNV == item.MaNV);
                    if (nv != null)
                    {
                        tennv = nv.TenNV;
                    }
                    string password = "**********";
                    table.Rows.Add(item.UserName, password, tennv, item.MaNV);
                }
                dgvtaikhoan.DataSource = table;
            }
        }

        private void themtk_Click(object sender, EventArgs e)
        {
            if (cbnhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn nhân viên cần thêm tài khoản!!");
                return;
            }
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                MessageBox.Show("Bạn cần nhập tên đăng nhập ! ");
                txtuser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Bạn cần nhập mật khẩu ! ");
                txtpass.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtnhaplai.Text))
            {
                MessageBox.Show("Bạn cần nhập lại mật khẩu ! ");
                txtnhaplai.Focus();
                return;
            }
            if (txtnhaplai.Text != txtpass.Text)
            {
                MessageBox.Show(this, "Mật khẩu không khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtpass.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                string pass = sb.ToString();
                DangNhap lg = new DangNhap();
                lg.UserName = txtuser.Text;
                lg.PassWord = pass;
                lg.MaNV = cbnhanvien.SelectedItem.ToString();
                quanli.DangNhaps.Add(lg);
                quanli.SaveChanges();
                loadtaikhoan();
                loadcbnhanvien();
                lammoidangnhap();
                MessageBox.Show(this, "Thêm thành công!!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void lammoidangnhap()
        {
            txtuser.Text = "";
            txtpass.Text = "";
            txttennv.Text = "";
            txtnhaplai.Text = "";
        }
        public string user;
        private void dgvtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = dgvtaikhoan.Rows[e.RowIndex].Cells["username"].Value.ToString();
            if (username == "ngoctuan")
            {
                MessageBox.Show(this, "Tài khoản này không thể xóa !!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.ColumnIndex == 0)
            {
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    if (username == user.Trim())
                    {
                        if (MessageBox.Show(this, "Bạn có muốn xóa tài khoản của bạn không ? \n Sau khi xóa hệ thống sẽ khởi động lại!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DangNhap lg = quanli.DangNhaps.FirstOrDefault(p => p.UserName == username);
                            List<HoaDon> ds_hoadon = quanli.HoaDons.Where(p => p.UserName == username).ToList();
                            foreach (var item in ds_hoadon)
                            {
                                HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == item.MaHD);
                                hd.UserName = null;
                                quanli.SaveChanges();
                            }
                            quanli.DangNhaps.Remove(lg);
                            quanli.SaveChanges();
                            Application.Restart();
                        }
                        return;
                    }
                    if (MessageBox.Show(this, "Bạn có muốn xóa tài khoản này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DangNhap lg = quanli.DangNhaps.FirstOrDefault(p => p.UserName == username);
                        List<HoaDon> ds_hoadon = quanli.HoaDons.Where(p => p.UserName == username).ToList();
                        foreach (var item in ds_hoadon)
                        {
                            HoaDon hd = quanli.HoaDons.FirstOrDefault(p => p.MaHD == item.MaHD);
                            hd.UserName = null;
                            quanli.SaveChanges();
                        }
                        quanli.DangNhaps.Remove(lg);
                        quanli.SaveChanges();
                        loadtaikhoan();
                        loadcbnhanvien();
                        MessageBox.Show(this, "Đã Xóa!!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ckbanhang_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void loadchucvu()
        {
            dgvChucvu.AutoGenerateColumns = false;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<ChucVu> dscv = quanli.ChucVus.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaCV");
                dt.Columns.Add("TenCV");
                dt.Columns.Add("Luongcoban");
                dt.Columns.Add("BanHang");
                dt.Columns.Add("Quanlynhanvien");
                dt.Columns.Add("Thongke");
                dt.Columns.Add("Quanlykho");
                foreach (var item in dscv)
                {
                    dt.Rows.Add(item.MaCV, item.TenCV, item.Luongcoban, item.BanHang, item.Quanlynhanvien, item.Thongke, item.Quanlykho);

                }
                dgvChucvu.DataSource = dt;
            }
           
        }
        
        private void dgvChucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            them.Text = "Làm mới";
            luu.Enabled = true;
            

            txtmacv.Text = dgvChucvu.CurrentRow.Cells[0].Value.ToString();
            txttencv.Text = dgvChucvu.CurrentRow.Cells[1].Value.ToString();
            txtluong.Text = dgvChucvu.CurrentRow.Cells[2].Value.ToString();
            ckbbanhang.Checked = Convert.ToBoolean(dgvChucvu.CurrentRow.Cells[3].Value);
            ckbquanlynhanvien.Checked = Convert.ToBoolean(dgvChucvu.CurrentRow.Cells[4].Value);
            ckbthongke.Checked = Convert.ToBoolean(dgvChucvu.CurrentRow.Cells[5].Value);
            cbkquanlykho.Checked = Convert.ToBoolean(dgvChucvu.CurrentRow.Cells[6].Value);
            if(e.ColumnIndex == 7)
            {
                if (MessageBox.Show("bạn có muốn xóa phiếu nhập này không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        ChucVu cv = quanli.ChucVus.FirstOrDefault(p => p.MaCV == txtmacv.Text);
                        quanli.ChucVus.Remove(cv);
                        quanli.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                        FrmQuanly_Load(sender, e);
                    }
                }
            }
        }
        private void lammoi()
        {
            txtmacv.Text = "";
            txtluong.Text = "";
            txttencv.Text = "";
            ckbbanhang.Checked = false;
            ckbquanlynhanvien.Checked = false;
            ckbthongke.Checked = false;
            cbkquanlykho.Checked = false;
            luu.Enabled = false;
      
        }
        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                them.Text = them.Text == "Thêm" ? them.Text = "Làm mới" : them.Text = "Thêm";
                if (them.Text == "Thêm")
                {
                    luu.Enabled = false;
                    lammoi();
                }
                else if (them.Text == "Làm mới")
                {
                    if (string.IsNullOrEmpty(txtmacv.Text))
                    {
                        MessageBox.Show("Bạn cần phải nhập mã chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtmacv.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(txttencv.Text))
                    {
                        MessageBox.Show("Bạn cần phải nhập tên chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txttencv.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(txtluong.Text))
                    {
                        MessageBox.Show("Bạn cần phải nhập lương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtluong.Focus();
                        return;
                    }
                    try
                    {
                        double a = double.Parse(txtluong.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Kiểu dữ liệu lương không hợp lệ!!!");
                        return;
                    }
                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        string machucVu = quanli.ChucVus.FirstOrDefault(p => p.MaCV == txtmacv.Text).MaCV;
                        ChucVu cv = new ChucVu();
                        cv.MaCV = txtmacv.Text;
                        cv.TenCV = txttencv.Text;
                        cv.Luongcoban = double.Parse(txtluong.Text);
                        cv.BanHang = ckbbanhang.Checked;
                        cv.Quanlynhanvien = ckbquanlynhanvien.Checked;
                        cv.Thongke = ckbthongke.Checked;
                        cv.Quanlykho = cbkquanlykho.Checked;
                        if (cv.MaCV == machucVu)
                        {
                            MessageBox.Show("Chức vụ này đã tồn tại");
                            return;
                        }
                        quanli.ChucVus.Add(cv);

                        quanli.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        FrmQuanly_Load(sender, e);
                    }
                }
            }
            catch
            {

                MessageBox.Show("Không thêm được! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvChucvu_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void luu_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtmacv.Text))
            {
                MessageBox.Show("Bạn cần phải nhập mã chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttencv.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txttencv.Text))
            {
                MessageBox.Show("Bạn cần phải nhập tên chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttencv.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtluong.Text))
            {
                MessageBox.Show("Bạn cần phải nhập lương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttencv.Focus();
                return;
            }
            try
            {
                double a = double.Parse(txtluong.Text);
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu lương không hợp lệ!!!");
                return;
            }
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                ChucVu cv = quanli.ChucVus.FirstOrDefault(p => p.MaCV == txtmacv.Text);
                cv.TenCV = txttencv.Text;
                //cv.MaCV = txtmacv.Text;
                cv.Luongcoban = double.Parse(txtluong.Text);
                cv.BanHang = ckbbanhang.Checked;
                cv.Quanlynhanvien = ckbquanlynhanvien.Checked;
                cv.Thongke = ckbthongke.Checked;
                cv.Quanlykho = cbkquanlykho.Checked;
                quanli.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                FrmQuanly_Load(sender, e);
            }
        }
        private void loadcalam()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<Calamviec> ca = quanli.Calamviecs.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("tenca");
                dt.Columns.Add("maca");
                dt.Columns.Add("thoigianbd");
                dt.Columns.Add("thoigiankt");
                foreach (var item in ca)
                {
                    dt.Rows.Add(item.TenCa, item.Maca, item.Thoigianbatdau, item.Thoigianketthuc);
                }
                dgvca.DataSource = dt;
                

                
            }
        }
        public bool ktthoigian(string thoigian)
        {
            string[] time = thoigian.Split(':');
            int gio = int.Parse(time[0]);
            int phut = int.Parse(time[1]);
            if (gio >= 24 || phut >= 60)
            {
                return false;
            }
            return true;
        }
        private void themcalam_Click(object sender, EventArgs e)
        {
            string tgbd = mtxtbd.Text.Trim();
            string tgktcl = mtxtkt.Text.Trim();
            if (string.IsNullOrEmpty(txttenca.Text))
            {
                MessageBox.Show("Bạn cần nhập tên ca làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenca.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tgbd))
            {
                MessageBox.Show("Bạn cần nhập thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtbd.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tgktcl))
            {
                MessageBox.Show("Bạn cần nhập thời gian kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtkt.Focus();
                return;
            }
            if (!ktthoigian(mtxtbd.Text))
            {
                MessageBox.Show("Kiểu dữ liệu thời gian bắt đầu không đúng (00:00 - 23:59)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtbd.Focus();
                return;
            }
            if (!ktthoigian(mtxtkt.Text))
            {
                MessageBox.Show("Kiểu dữ liệu thời gian kết thúc không đúng (00:00 - 23:59)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtkt.Focus();
                return;
               
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                Calamviec ca = quanli.Calamviecs.FirstOrDefault(p => p.TenCa == txttenca.Text);
                if (ca != null)
                {
                    MessageBox.Show("Đã có ca làm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                quanli.insertcalam(txttenca.Text, mtxtbd.Text, mtxtkt.Text);
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmQuanly_Load(sender, e);
            }
        }
        string macalam = "";
        private void btn_luu_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrEmpty(txttenca.Text))
            {
                MessageBox.Show("Bạn cần nhập tên ca làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenca.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mtxtbd.Text))
            {
                MessageBox.Show("Bạn cần nhập thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtbd.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mtxtkt.Text))
            {
                MessageBox.Show("Bạn cần nhập thời gian kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtkt.Focus();
                return;
            }
            if (!ktthoigian(mtxtbd.Text))
            {
                MessageBox.Show("Kiểu dữ liệu thời gian bắt đầu không đúng (00:00 - 23:59)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtbd.Focus();
                return;
            }
            if (!ktthoigian(mtxtkt.Text))
            {
                MessageBox.Show("Kiểu dữ liệu thời gian kết thúc không đúng (00:00 - 23:59)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtkt.Focus();
                return;

            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())

            {
                
                quanli.updatecalam(macalam,txttenca.Text,mtxtbd.Text,mtxtkt.Text);
                quanli.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                FrmQuanly_Load(sender, e);
            }
        }

        private void dgvca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            btn_luu.Enabled = true;
            btnxoa.Enabled = true;
            if (r >= 0)
            {
                macalam = dgvca.Rows[r].Cells["maca"].Value.ToString();
                txttenca.Text = dgvca.Rows[r].Cells["tenca"].Value.ToString();
                mtxtbd.Text = dgvca.Rows[r].Cells["thoigianbd"].Value.ToString();
                mtxtkt.Text = dgvca.Rows[r].Cells["thoigiankt"].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                if (macalam == "")
                {
                    MessageBox.Show("Yêu cầu chọn ca làm cần xóa");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn xóa ca làm này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    quanli.deletecalam(macalam);
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    FrmQuanly_Load(sender, e);
                }
            }
        }
    }
}
