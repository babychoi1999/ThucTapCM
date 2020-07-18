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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                DataTable table = new DataTable();
                table.Columns.Add("mathucung");
                table.Columns.Add("tenthucung");
                table.Columns.Add("slnhap");
                table.Columns.Add("slban");
                table.Columns.Add("sltrongkho");
                table.Columns.Add("ngaylap");

                List<tctonkho_Result> ds_hoadon = quanli.tctonkho(dtpthang.Value.Month, dtpthang.Value.Year, comboBox1.SelectedValue.ToString()).ToList();
                foreach (var item in ds_hoadon)
                {
                    table.Rows.Add(item.Mathucung, item.Tenthucung, item.slnhap, item.slban, item.sltrongkho, item.Ngaylap);
                }
                bunifuCustomDataGrid1.DataSource = table;

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                comboBox1.DataSource = quanli.ThuCungs.ToList();
                comboBox1.DisplayMember = "TenThuCung";
                comboBox1.ValueMember = "MaThuCung";
            }
        }
    }
}
