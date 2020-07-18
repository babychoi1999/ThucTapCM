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
    public partial class ReportPhieuNhap : UserControl
    {
        public ReportPhieuNhap()
        {
            InitializeComponent();
        }
        private void loadphieunhap()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<PhieuNhap> pn = quanli.PhieuNhaps.ToList();
                comboBox1.DataSource = pn;
                comboBox1.DisplayMember = "MaPN";
                comboBox1.ValueMember = "MaPN";
            }
        }
        private void ReportPhieuNhap_Load(object sender, EventArgs e)
        {
            loadphieunhap();
          
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DataTable table = new DataTable();
                table.Columns.Add("mapn");
                table.Columns.Add("ngaylap");
                table.Columns.Add("nhanvien");
                table.Columns.Add("nhacc");
                table.Columns.Add("tensanpham");
                table.Columns.Add("soluong");
                table.Columns.Add("dongia");
                table.Columns.Add("thanhtien");
                table.Columns.Add("tongtien");


                List<reportPhieuNhap_Result> ds_hoadon = quanli.reportPhieuNhap(comboBox1.SelectedValue.ToString()).ToList();
                foreach (var item in ds_hoadon)
                {
                    table.Rows.Add(item.mapn, item.ngaylap, item.nhanvien, item.nhacc, item.tensanpham, item.soluong, item.dongia, item.thanhtien, item.tongtien);
                }
                RPHoaDonNhap2.SetDataSource(table);
                crystalReportViewer1.ReportSource = RPHoaDonNhap2;
                crystalReportViewer1.Show();
            }
        }
    }
}
