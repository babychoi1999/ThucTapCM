using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class Formnhanvien : UserControl
    {
        string manv = null;
        public Formnhanvien()
        {
            InitializeComponent();
        }
        private void bnthem_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien them = new FrmThemNhanVien();
            them.ShowDialog();

        }
        public void loadnhanvien()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<NhanVien> ds_nhanvien = quanli.NhanViens.ToList();
                DataTable table = new DataTable();
                table.Columns.Add("MaNV");
                table.Columns.Add("tennv");
                table.Columns.Add("diachi");
                table.Columns.Add("cmnd");
                table.Columns.Add("sdt");
                table.Columns.Add("chucvu");
                table.Columns.Add("gmail");
                foreach (NhanVien item in ds_nhanvien)
                {
                    string chucvu = "";
                    if (item.MaCV == null)
                        chucvu = "rỗng";
                    else
                        chucvu = quanli.ChucVus.FirstOrDefault(p => p.MaCV == item.MaCV).TenCV;
                    table.Rows.Add(item.MaNV, item.TenNV, item.CMND, item.DiaChi, item.sodienthoai, chucvu,item.Gmail);
                }
                dgvnhanvien.AutoGenerateColumns = false;
                dgvnhanvien.DataSource = table;
            }
        }
        public void loadtp() {
            dgvThuongPhat.AutoGenerateColumns = false;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1()) 
            {
                dgvThuongPhat.DataSource = quanli.ThuongPhats.ToList();
            }
        }
        private void loadluongnhanvien(int thang, int nam)
        {
            DataTable table = new DataTable();
            table.Columns.Add("manv");
            table.Columns.Add("tennv");
            table.Columns.Add("thuongphat");
            table.Columns.Add("luong");
            table.Columns.Add("tongluong");
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<LuongTungThang> luongThangs = quanli.LuongTungThangs.Where(p => p.Thang == thang && nam == DateTime.Now.Year).ToList();
                foreach (var item in luongThangs)
                {
                    string tennv = quanli.NhanViens.FirstOrDefault(p => p.MaNV == item.MaNV).TenNV;
                    string macv = quanli.NhanViens.FirstOrDefault(p => p.MaNV == item.MaNV).MaCV;
                    int luong = (int)quanli.ChucVus.FirstOrDefault(p => p.MaCV == macv).Luongcoban;
                    int tongluong = (int)item.ThuongPhat + luong;
                    table.Rows.Add(item.MaNV, tennv, item.ThuongPhat, luong, tongluong);
                }
                dgvLuong.DataSource = table;
            }
        }
        private void txtlydo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }
        string loai = "";
        private void btnthemtp_Click(object sender, EventArgs e)
        {
            using(quanlithucungEntities1 quanli =new quanlithucungEntities1())
            {
                if(rbthuong.Checked == true)
                {
                    loai = rbthuong.Text;
                }
                if(rbphat.Checked == true)
                {
                    loai = rbphat.Text;
                }
                quanli.insertThuongPhat(cbnhanvien.SelectedValue.ToString(),DateTime.Now,loai, int.Parse(txttien.Text),txtlydo.Text);
                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                Formnhanvien_Load(sender, e);
            }
        }

        private void Formnhanvien_Load(object sender, EventArgs e)
        {
            loadnhanvien();
            loadtp();
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1()) 
            {
                List<NhanVien> dsnhanvien = quanli.NhanViens.ToList();
                cbnhanvien.DataSource = dsnhanvien;
                cbnhanvien.DisplayMember = "TenNV";
                cbnhanvien.ValueMember = "MaNV";
            }
            loadLuongThang();
            
            
        }

        private void loadLuongThang()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                dgvLuong.AutoGenerateColumns = false;
                dgvLuong.DataSource = quanli.LuongTungThangs.ToList();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                quanli.deleteNhanVien(manv);
                quanli.SaveChanges();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int thang = dtpthangluong.Value.Month;
            int nam = dtpthangluong.Value.Year;
            loadluongnhanvien(thang, nam);
        }
    
        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            manv = dgvnhanvien.CurrentRow.Cells[0].Value.ToString();
            if (manv == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần sửa");
                return;
            }
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("bạn có muốn xóa nhân viên này không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        quanli.deleteNhanVien(manv);
                        MessageBox.Show("đã xóa");
                        Formnhanvien_Load(sender, e);

                    }
                }
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            FrmSuaNhanVien suaNhanVien = new FrmSuaNhanVien();
            suaNhanVien.manv = manv;
            suaNhanVien.ShowDialog();
        }

        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvThuongPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                if(MessageBox.Show("bạn có muốn xóa thưởng phạt này không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        string matp = dgvThuongPhat.CurrentRow.Cells[1].Value.ToString();
                        quanli.deleteTP(matp);
                        MessageBox.Show("đã xóa");
                        Formnhanvien_Load(sender, e);

                    }
                }
            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            int thang = dtpthangluong.Value.Month;
            int nam = dtpthangluong.Value.Year;
            loadluongnhanvien(thang, nam);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                if (txttimkiem.Text.Trim() == "" || txttimkiem.Text.Trim() == null)
                {
                    dgvnhanvien.DataSource = quanli.HoaDons.ToList();
                }
                else if (txttimkiem.Text.Trim() != "")
                {
                    dgvnhanvien.AutoGenerateColumns = false;
                    dgvnhanvien.DataSource = quanli.timkiemnhanvien(txttimkiem.Text);

                }
            }
        }
    }
}
