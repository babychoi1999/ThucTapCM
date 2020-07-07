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
    public partial class ThongTinHoaDonNhap : Form
    {
        public ThongTinHoaDonNhap()
        {
            InitializeComponent();
        }

        private void ThongTinHoaDonNhap_Load(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                RPHoaDon report = new RPHoaDon();
                DataTable table = new DataTable();
                table.Columns.Add("mapn");
                table.Columns.Add("ngaylap");
                table.Columns.Add("nhanvien");
                table.Columns.Add("nhacc");
                table.Columns.Add("tensanpham");
                table.Columns.Add("soluong");
                table.Columns.Add("dongia");
                table.Columns.Add("thanhtien");
                table.Columns.Add("TongTien");
                List<reportPhieuNhap_Result> ds_hoadon = quanli.reportPhieuNhap("PN01").ToList();
                foreach (var item in ds_hoadon)
                {
                    table.Rows.Add(item.mapn, item.ngaylap, item.nhanvien,item.nhacc, item.tensanpham, item.soluong, item.dongia, item.thanhtien, item.tongtien);
                }
                RPHoaDonNhap1.SetDataSource(table);
                crystalReportViewer1.ReportSource = RPHoaDonNhap1;
                crystalReportViewer1.Show();
            }
        }
    }
}
