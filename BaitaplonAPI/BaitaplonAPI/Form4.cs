using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                var result = from hd in quanli.HoaDons
                             join kh in quanli.KhachHangs on hd.MaKH equals kh.MaKH
                             join tk in quanli.DangNhaps on hd.UserName equals tk.UserName


                             select new
                             {
                                 hd.MaHD,
                                 kh.TenKH,
                                 tk.UserName,


                             };
                dataGridView1.DataSource = result.ToList();
               
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                
            }
                  
        }
    }
}
