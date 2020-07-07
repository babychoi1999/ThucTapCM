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
    public partial class Form1 : Form
    {
        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void slide()
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //BTN THU CUNG
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Husky());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //KHACH HÀNG
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void panelslidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelDanhMucCon.Height += 10;
                if (panelDanhMucCon.Size == panelDanhMucCon.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;

                }
            }
            else
            {
                panelDanhMucCon.Height -= 10;
                if (panelDanhMucCon.Size == panelDanhMucCon.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelNhânViênCon.Height += 10;
                if (panelNhânViênCon.Size == panelNhânViênCon.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;

                }
            }
            else
            {
                panelNhânViênCon.Height -= 10;
                if (panelNhânViênCon.Size == panelNhânViênCon.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panelNhânViênCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelThongKeCon.Height += 10;
                if (panelThongKeCon.Size == panelThongKeCon.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;

                }
            }
            else
            {
                panelThongKeCon.Height -= 10;
                if (panelThongKeCon.Size == panelThongKeCon.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelHangHoaCon.Height += 10;
                if (panelHangHoaCon.Size == panelHangHoaCon.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed = false;

                }
            }
            else
            {
                panelHangHoaCon.Height -= 10;
                if (panelHangHoaCon.Size == panelHangHoaCon.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void panelHangHoaCon_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLienHeCon.Height += 10;
                if (panelLienHeCon.Size == panelLienHeCon.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsed = false;

                }
            }
            else
            {
                panelLienHeCon.Height -= 10;
                if (panelLienHeCon.Size == panelLienHeCon.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add( new Formnhanvien());
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnBanChay_Click(object sender, EventArgs e)
        {

        }

        private void btnBanCham_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {

        }

        private void btnLHNhaCungCap_Click(object sender, EventArgs e)
        {

        }

        private void btnLienHeKhachHang_Click(object sender, EventArgs e)
        {

        }
        int Num = 0;
        private void timer6_Tick(object sender, EventArgs e)
        {
            Num++;

            switch (Num)
            {
                case 1:
                    lblQ.ForeColor = Color.Green;
                    lblU.ForeColor = Color.Gold;
                    lblA.ForeColor = Color.Red;
                    lblN.ForeColor = Color.Blue;
                    lblL.ForeColor = Color.DeepPink;
                    lblY.ForeColor = Color.IndianRed;
                    lblS.ForeColor = Color.Magenta;
                    lblH.ForeColor = Color.Lime;
                    lblO.ForeColor = Color.Cyan;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Lime;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Violet;
                    lblƯ.ForeColor = Color.Cyan;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Yellow;
                    break;

                case 2:
                    lblQ.ForeColor = Color.Lime;
                    lblU.ForeColor = Color.Green;
                    lblA.ForeColor = Color.Gold;
                    lblN.ForeColor = Color.Red;
                    lblL.ForeColor = Color.Blue;
                    lblY.ForeColor = Color.DeepPink;
                    lblS.ForeColor = Color.IndianRed;
                    lblH.ForeColor = Color.Magenta;
                    lblO.ForeColor = Color.Azure;
                    lblP.ForeColor = Color.AliceBlue;
                    lblT.ForeColor = Color.Aqua;
                    lblH.ForeColor = Color.OrangeRed;
                    lblÚ.ForeColor = Color.Red;
                    lblC.ForeColor = Color.Lime;
                    lblƯ.ForeColor = Color.Blue;
                    lblN2.ForeColor = Color.GreenYellow;
                    lblG.ForeColor = Color.Red;
                    break;


                case 3:
                    lblQ.ForeColor = Color.Magenta;
                    lblU.ForeColor = Color.Lime;
                    lblA.ForeColor = Color.Green;
                    lblN.ForeColor = Color.Gold;
                    lblL.ForeColor = Color.Red;
                    lblY.ForeColor = Color.Blue;
                    lblS.ForeColor = Color.Magenta;
                    lblH.ForeColor = Color.IndianRed;
                    lblO.ForeColor = Color.HotPink;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Green;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Pink;
                    lblƯ.ForeColor = Color.Azure;
                    lblN2.ForeColor = Color.Lime;
                    lblG.ForeColor = Color.Yellow;
                    break;

                case 4:
                    lblQ.ForeColor = Color.IndianRed;
                    lblU.ForeColor = Color.Magenta;
                    lblA.ForeColor = Color.Lime;
                    lblN.ForeColor = Color.Green;
                    lblL.ForeColor = Color.Gold;
                    lblY.ForeColor = Color.Red;
                    lblS.ForeColor = Color.IndianRed;
                    lblH.ForeColor = Color.DeepPink;
                    lblO.ForeColor = Color.Lavender;
                    lblP.ForeColor = Color.AliceBlue;
                    lblT.ForeColor = Color.Aqua;
                    lblH2.ForeColor = Color.Violet;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Lime;
                    lblƯ.ForeColor = Color.Red;
                    lblN2.ForeColor = Color.Yellow;
                    lblG.ForeColor = Color.Blue;
                    break;

                case 5:
                    lblQ.ForeColor = Color.DeepPink;
                    lblU.ForeColor = Color.IndianRed;
                    lblA.ForeColor = Color.Magenta;
                    lblN.ForeColor = Color.Lime;
                    lblL.ForeColor = Color.Green;
                    lblY.ForeColor = Color.Gold;
                    lblS.ForeColor = Color.Magenta;
                    lblH.ForeColor = Color.Blue;
                    lblO.ForeColor = Color.Moccasin;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Lime;
                    lblH2.ForeColor = Color.Pink;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Gold;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Orange;
                    break;

                case 6:
                    lblQ.ForeColor = Color.Blue;
                    lblU.ForeColor = Color.DeepPink;
                    lblA.ForeColor = Color.IndianRed;
                    lblN.ForeColor = Color.Magenta;
                    lblL.ForeColor = Color.Lime;
                    lblY.ForeColor = Color.Green;
                    lblS.ForeColor = Color.Gold;
                    lblH.ForeColor = Color.Red;
                    lblO.ForeColor = Color.DarkCyan;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Red;
                    lblH2.ForeColor = Color.Yellow;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Lime;
                    lblƯ.ForeColor = Color.DeepPink;
                    lblN2.ForeColor = Color.Magenta;
                    lblG.ForeColor = Color.Yellow;
                    break;


                case 7:
                    lblQ.ForeColor = Color.Red;
                    lblU.ForeColor = Color.Blue;
                    lblA.ForeColor = Color.DeepPink;
                    lblN.ForeColor = Color.IndianRed;
                    lblL.ForeColor = Color.Magenta;
                    lblY.ForeColor = Color.Lime;
                    lblS.ForeColor = Color.IndianRed;
                    lblH.ForeColor = Color.Magenta;
                    lblO.ForeColor = Color.Azure;
                    lblP.ForeColor = Color.AliceBlue;
                    lblT.ForeColor = Color.Magenta;
                    lblH2.ForeColor = Color.Magenta;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.LightSteelBlue;
                    lblƯ.ForeColor = Color.Aqua;
                    lblN2.ForeColor = Color.Azure;
                    lblG.ForeColor = Color.Violet;
                    break;

                case 8:
                    lblQ.ForeColor = Color.Gold;
                    lblU.ForeColor = Color.Red;
                    lblA.ForeColor = Color.Blue;
                    lblN.ForeColor = Color.DeepPink;
                    lblL.ForeColor = Color.IndianRed;
                    lblY.ForeColor = Color.Magenta;
                    lblS.ForeColor = Color.Gold;
                    lblH.ForeColor = Color.Green;
                    lblO.ForeColor = Color.Chocolate;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Blue;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Lime;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Yellow;
                    break;
                case 9:
                    lblQ.ForeColor = Color.Red;
                    lblU.ForeColor = Color.Blue;
                    lblA.ForeColor = Color.DeepPink;
                    lblN.ForeColor = Color.IndianRed;
                    lblL.ForeColor = Color.Magenta;
                    lblY.ForeColor = Color.Lime;
                    lblS.ForeColor = Color.IndianRed;
                    lblH.ForeColor = Color.Magenta;
                    lblO.ForeColor = Color.Azure;
                    lblP.ForeColor = Color.AliceBlue;
                    lblT.ForeColor = Color.Aqua;
                    lblH2.ForeColor = Color.Orange;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Lime;
                    lblƯ.ForeColor = Color.Orange;
                    lblN2.ForeColor = Color.Yellow;
                    lblG.ForeColor = Color.Magenta;
                    break;
                case 10:
                    lblQ.ForeColor = Color.Magenta;
                    lblU.ForeColor = Color.Lime;
                    lblA.ForeColor = Color.Green;
                    lblN.ForeColor = Color.Gold;
                    lblL.ForeColor = Color.Red;
                    lblY.ForeColor = Color.Blue;
                    lblS.ForeColor = Color.Magenta;
                    lblH.ForeColor = Color.LightBlue;
                    lblO.ForeColor = Color.HotPink;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Pink;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.LightBlue;
                    lblC.ForeColor = Color.LightGreen;
                    lblƯ.ForeColor = Color.Red;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Yellow;
                    break;
                case 11:
                    lblQ.ForeColor = Color.GreenYellow;
                    lblU.ForeColor = Color.Red;
                    lblA.ForeColor = Color.Blue;
                    lblN.ForeColor = Color.DeepPink;
                    lblL.ForeColor = Color.IndianRed;
                    lblY.ForeColor = Color.Magenta;
                    lblS.ForeColor = Color.Gold;
                    lblH2.ForeColor = Color.Green;
                    lblO.ForeColor = Color.Chocolate;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Lime;
                    lblH.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Green;
                    lblN2.ForeColor = Color.Pink;
                    lblG.ForeColor = Color.Red;
                    break;
                case 12:
                    lblQ.ForeColor = Color.Firebrick;
                    lblU.ForeColor = Color.Lime;
                    lblA.ForeColor = Color.Green;
                    lblN.ForeColor = Color.Gold;
                    lblL.ForeColor = Color.Red;
                    lblY.ForeColor = Color.Blue;
                    lblS.ForeColor = Color.Magenta;
                    lblH.ForeColor = Color.IndianRed;
                    lblO.ForeColor = Color.HotPink;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Gold;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.Violet;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Lime;
                    lblN2.ForeColor = Color.Gold;
                    lblG.ForeColor = Color.Yellow;
                    break;
                case 13:
                    lblQ.ForeColor = Color.Gold;
                    lblU.ForeColor = Color.Red;
                    lblA.ForeColor = Color.Blue;
                    lblN.ForeColor = Color.DeepPink;
                    lblL.ForeColor = Color.IndianRed;
                    lblY.ForeColor = Color.Magenta;
                    lblS.ForeColor = Color.Gold;
                    lblH.ForeColor = Color.Green;
                    lblO.ForeColor = Color.Chocolate;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Cyan;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Gold;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Yellow;
                    break;
                case 14:
                    lblQ.ForeColor = Color.Magenta;
                    lblU.ForeColor = Color.Lime;
                    lblA.ForeColor = Color.Green;
                    lblN.ForeColor = Color.Gold;
                    lblL.ForeColor = Color.Red;
                    lblY.ForeColor = Color.Blue;
                    lblS.ForeColor = Color.Magenta;
                    lblH.ForeColor = Color.IndianRed;
                    lblO.ForeColor = Color.HotPink;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Lime;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.Red;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Pink;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Yellow;
                    break;
                case 15:
                    lblQ.ForeColor = Color.Red;
                    lblU.ForeColor = Color.Blue;
                    lblA.ForeColor = Color.DeepPink;
                    lblN.ForeColor = Color.IndianRed;
                    lblL.ForeColor = Color.Magenta;
                    lblY.ForeColor = Color.Lime;
                    lblS.ForeColor = Color.IndianRed;
                    lblH.ForeColor = Color.Magenta;
                    lblO.ForeColor = Color.Azure;
                    lblP.ForeColor = Color.AliceBlue;
                    lblT.ForeColor = Color.Aqua;
                    lblH2.ForeColor = Color.OrangeRed;
                    lblÚ.ForeColor = Color.Coral;
                    lblC.ForeColor = Color.Lime;
                    lblƯ.ForeColor = Color.Yellow;
                    lblN2.ForeColor = Color.Yellow;
                    lblG.ForeColor = Color.Violet;
                    break;
                case 16:
                    lblQ.ForeColor = Color.Coral;
                    lblU.ForeColor = Color.Red;
                    lblA.ForeColor = Color.Blue;
                    lblN.ForeColor = Color.DeepPink;
                    lblL.ForeColor = Color.IndianRed;
                    lblY.ForeColor = Color.Magenta;
                    lblS.ForeColor = Color.Gold;
                    lblH.ForeColor = Color.Green;
                    lblO.ForeColor = Color.Chocolate;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Lime;
                    lblH2.ForeColor = Color.AliceBlue;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Cyan;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Yellow;
                    break;
                case 17:
                    lblQ.ForeColor = Color.Magenta;
                    lblU.ForeColor = Color.Lime;
                    lblA.ForeColor = Color.Green;
                    lblN.ForeColor = Color.Gold;
                    lblL.ForeColor = Color.Red;
                    lblY.ForeColor = Color.Blue;
                    lblS.ForeColor = Color.Magenta;
                    lblH.ForeColor = Color.IndianRed;
                    lblO.ForeColor = Color.HotPink;
                    lblP.ForeColor = Color.OrangeRed;
                    lblT.ForeColor = Color.Lime;
                    lblH2.ForeColor = Color.Coral;
                    lblÚ.ForeColor = Color.MediumPurple;
                    lblC.ForeColor = Color.Aquamarine;
                    lblƯ.ForeColor = Color.Coral;
                    lblN2.ForeColor = Color.Violet;
                    lblG.ForeColor = Color.Yellow;
                    break;

            }
            if (Num == 17)
                Num = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnPhuKien_Click(object sender, EventArgs e)
        {

        }

        private void btnThucPham_Click(object sender, EventArgs e)
        {

        }
    }
}
