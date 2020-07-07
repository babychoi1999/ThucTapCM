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
    public partial class Formbánhàng : UserControl
    {
        public Formbánhàng()
        {
            InitializeComponent();
        }

        private void Formbánhàng_Load(object sender, EventArgs e)
        {

            /*using (quanlithucungEntities quanli = new quanlithucungEntities())
            {
                var result = from thucpham in quanli.THUCPHAMs
                             join ctthucpham in quanli.CTTHUCPHAMs on thucpham.Mathucpham equals ctthucpham.Mathucpham
                             select new
                             {
                                 thucpham.Mathucpham,
                                 thucpham.Tenthucpham,
                                 thucpham.donvi,
                                 thucpham.dongia,
                                 ctthucpham.soluong
                             };
                Console.WriteLine(result.ToList().Count);
                dtgvthucpham.DataSource = result.ToList();
            }*/
        }

        private void dtgvthucpham_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
