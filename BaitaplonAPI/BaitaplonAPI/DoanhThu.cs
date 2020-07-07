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
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DataTable table = new DataTable();
                table.Columns.Add("ngaylap");
                table.Columns.Add("banhang");
                table.Columns.Add("nhaphang");
                table.Columns.Add("luongnv");
                table.Columns.Add("doanhthu");

                List<DoanhThuTheoThang_Result> ds_hoadon = quanli.DoanhThuTheoThang(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year).ToList();
                foreach (var item in ds_hoadon)
                {
                    table.Rows.Add(item.ngaylap, item.banhang, item.nhaphang, item.luongnv, item.doanhthu);
                }
                RPDoanhThu1.SetDataSource(table);
                crystalReportViewer1.ReportSource = RPDoanhThu1;
                crystalReportViewer1.Show();
            }
        }
    }
}
