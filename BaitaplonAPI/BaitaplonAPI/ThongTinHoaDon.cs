using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class ThongTinHoaDon : Form
    {
        public ThongTinHoaDon()
        {
            InitializeComponent();
        }

        private void ThongTinHoaDon_Load(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                RPHoaDon report = new RPHoaDon();
                DataTable table = new DataTable();
                table.Columns.Add("mahd");
                table.Columns.Add("ngaylap");
                table.Columns.Add("nhanvien");
                table.Columns.Add("tensanpham");
                table.Columns.Add("soluong");
                table.Columns.Add("dongia");
                table.Columns.Add("thanhtien");
                table.Columns.Add("TongTien");
                List<reportHD_Result> ds_hoadon = quanli.reportHD("HD001").ToList();
                foreach (var item in ds_hoadon)
                {
                    table.Rows.Add(item.mahd,item.ngaylap,item.nhanvien,item.tensanpham,item.soluong,item.dongia,item.thanhtien,item.tongtien);
                }
                HoaDonBan1.SetDataSource(table);
                rpHoaDon.ReportSource = HoaDonBan1;
                rpHoaDon.Show();
            }
        }
    }
}
