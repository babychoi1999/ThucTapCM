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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {

            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DataTable table = new DataTable();
                table.Columns.Add("mahang");
                table.Columns.Add("tenhang");
                table.Columns.Add("slnhap");
                table.Columns.Add("slban");
                table.Columns.Add("tonkho");
                table.Columns.Add("ngaylap");

                List<Tonkho_Result> ds_hoadon = quanli.Tonkho(dtpthang.Value.Month, dtpthang.Value.Year).ToList();
                foreach (var item in ds_hoadon)
                {
                    table.Rows.Add(item.MaHang, item.TenHang, item.SlNhap, item.SLBan, item.TonKho, item.NgayLap);
                }
                bunifuCustomDataGrid1.DataSource = table;

            }
        }
    }
}   
