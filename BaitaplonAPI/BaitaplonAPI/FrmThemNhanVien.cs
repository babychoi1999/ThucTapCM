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
    public partial class FrmThemNhanVien : Form
    {
        int Num;
        public FrmThemNhanVien()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Num++;
            switch (Num)
            {
                case 0:
                    lblT.ForeColor = Color.Red;
                    lblH.ForeColor = Color.Yellow;
                    lblÊ.ForeColor = Color.Aqua;
                    lblM.ForeColor = Color.Pink;
                    lblN.ForeColor = Color.Magenta;
                    lblH2.ForeColor = Color.Red;
                    lblÂ.ForeColor = Color.Purple;
                    lblN2.ForeColor = Color.Green;
                    lblV.ForeColor = Color.Yellow;
                    lblI.ForeColor = Color.Violet;
                    lblÊ2.ForeColor = Color.Pink;
                    lblN3.ForeColor = Color.Teal;
                    break;
                case 1:
                    lblT.ForeColor = Color.Yellow;
                    lblH.ForeColor = Color.Aqua;
                    lblÊ.ForeColor = Color.Red;
                    lblM.ForeColor = Color.Magenta;
                    lblN.ForeColor = Color.Purple;
                    lblH2.ForeColor = Color.Violet;
                    lblÂ.ForeColor = Color.Red;
                    lblN2.ForeColor = Color.RosyBrown;
                    lblV.ForeColor = Color.LightSkyBlue;
                    lblI.ForeColor = Color.Pink;
                    lblÊ2.ForeColor = Color.Green;
                    lblN3.ForeColor = Color.Aqua;
                    break;

                case 2:
                    lblT.ForeColor = Color.Aqua;
                    lblH.ForeColor = Color.Red;
                    lblÊ.ForeColor = Color.Magenta;
                    lblM.ForeColor = Color.Green;
                    lblN.ForeColor = Color.Lavender;
                    lblH2.ForeColor = Color.Pink;
                    lblÂ.ForeColor = Color.Orange;
                    lblN2.ForeColor = Color.Green;
                    lblV.ForeColor = Color.DarkBlue;
                    lblI.ForeColor = Color.LightCoral;
                    lblÊ2.ForeColor = Color.Red;
                    lblN3.ForeColor = Color.Purple;
                    break;
                case 3:
                    lblT.ForeColor = Color.Pink;
                    lblH.ForeColor = Color.Green;
                    lblÊ.ForeColor = Color.Yellow;
                    lblM.ForeColor = Color.DarkBlue;
                    lblN.ForeColor = Color.Red;
                    lblH2.ForeColor = Color.Orange;
                    lblÂ.ForeColor = Color.Pink;
                    lblN2.ForeColor = Color.LightSkyBlue;
                    lblV.ForeColor = Color.YellowGreen;
                    lblI.ForeColor = Color.Gold;
                    lblÊ2.ForeColor = Color.PaleTurquoise;
                    lblN3.ForeColor = Color.Violet;
                    break;

            }
            if (Num == 3)
            {
                Num = 0;
            }
        }
        private bool Kiemtra()
        {
            if (txtten.Text == "" || txtcmnd.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void FrmThemNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet27.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.quanlithucungDataSet27.ChucVu);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!Kiemtra())
            {
                return;
            }
            else
            {
                using(quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    quanli.insertnhanvien(txtten.Text, int.Parse(txtcmnd.Text), txtdiachi.Text, int.Parse(txtsdt.Text), cbchucvu.SelectedValue.ToString());
                    quanli.SaveChanges();
                    MessageBox.Show("Thêm thành công!");
                }
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
