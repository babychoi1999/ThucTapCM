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
    public partial class Mèotaicụp : UserControl
    {
        public Mèotaicụp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mèotaicụp_Load(object sender, EventArgs e)
        {
            using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
               // label1.Text = quanli.ThuCungs.Where(p => p.MaThuCung == );

            }
        }
    }
}
