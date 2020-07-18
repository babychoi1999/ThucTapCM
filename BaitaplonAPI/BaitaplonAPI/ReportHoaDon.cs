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
    public partial class ReportHoaDon : Form
    {
        public ReportHoaDon()
        {
            InitializeComponent();
        }

        private void ReportHoaDon_Load(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<HoaDon> hd = quanli.HoaDons.ToList();
                comboBox1.DataSource = hd;
                comboBox1.DisplayMember = "MaHD";
                comboBox1.ValueMember = "MaHD";
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DataTable table = new DataTable();
                table.Columns.Add("mahd");
                table.Columns.Add("ngaylap");
                table.Columns.Add("nhanvien");
                table.Columns.Add("tensanpham");
                table.Columns.Add("soluong");
                table.Columns.Add("dongia");
                table.Columns.Add("thanhtien");
               

                List<reportHD_Result> ds_hoadon = quanli.reportHD(comboBox1.SelectedValue.ToString()).ToList();
                foreach (var item in ds_hoadon)
                {
                    table.Rows.Add(item.mahd, item.ngaylap,item.nhanvien, item.tensanpham, item.soluong, item.dongia, item.thanhtien);
                }
                HoaDonBan1.SetDataSource(table);
                crystalReportViewer1.ReportSource = HoaDonBan1;
                crystalReportViewer1.Show();
            }
        }
    }
}
