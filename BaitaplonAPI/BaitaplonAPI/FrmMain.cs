﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitaplonAPI
{
    public partial class FrmMain : Form
    {
        private bool isCollapsed;
        public FrmMain()
        {
            InitializeComponent();
            
        }
        bool banhang = true;
        bool thongke = true;
        bool quanlykho = true;
        bool admin = false;
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
            if (!banhang)
            {
                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new FrmThuCUng());
            }
            
           
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (!banhang)
            {
                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else {
                //KHACH HÀNG
                kh1 kh = new kh1();
                kh.Show();
            }

               
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
            if (!banhang)
            {
                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {


                panelMain.Controls.Clear();
                panelMain.Controls.Add(new FrmHoaDon());
            }
        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            if(!quanlinhanvien)
            {
                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new Formnhanvien());
            }
           
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (!thongke)
            {

                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                DoanhThu dt = new DoanhThu();
                dt.Show();
            }
           
        }

        private void btnBanChay_Click(object sender, EventArgs e)
        {

        }

        private void btnBanCham_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
        {
            if (!quanlykho)
            {
                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new Formnhacungcap());
            }
           
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (!quanlykho)
            {

                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                FrmPhieuNhap phieuNhap = new FrmPhieuNhap();
                phieuNhap.user = user;
                phieuNhap.Show();
            }    
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            if (!quanlykho)
            {

                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UserControl1());
            }
            
        }

        private void btnLHNhaCungCap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLienHeKhachHang_Click(object sender, EventArgs e)
        {
            if (!quanlykho)
            {

                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                guimail gm = new guimail();
                gm.Show();
            }
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
            btnThuCung.Activecolor = Color.White;
            btnThucPham.Activecolor = Color.White;
            btnPhuKien.Activecolor = Color.White;
            btnQuanLy.Activecolor = Color.White;
            btnKhachHang.Activecolor = Color.White;
            btnHoaDon.Activecolor = Color.White;
            btnDoanhThu.Activecolor = Color.White;
            btnThongTinNhanVien.Activecolor = Color.White;
            btnTonKho.Activecolor = Color.White;
            btnNhapKho.Activecolor = Color.White;
            btnNhaCungCap.Activecolor = Color.White;
            btnLienHeKhachHang.Activecolor = Color.White;
            label1.Visible = true;
            
            //phanquyen();
            label1.Text = user;
            
       
        }

        private void btnPhuKien_Click(object sender, EventArgs e)
        {
            if (!banhang)
            {
                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new Frmphukien());
            }
           
        }

        private void btnThucPham_Click(object sender, EventArgs e)
        {
            if (!banhang)
            {
                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {

                panelMain.Controls.Clear();
                panelMain.Controls.Add(new Frmthucpham());
            }
        }
        public string user;
        public string password;
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            
                FrmQuanly quanly = new FrmQuanly();
                quanly.user = user;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(quanly);
            
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau doimk = new FrmDoiMatKhau();
            doimk.user = user;
            doimk.password = password;
            doimk.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pbfb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void pbzalo_Click(object sender, EventArgs e)
        {
            Process.Start("https://id.zalo.me/");
        }
       
        private bool quanlinhanvien = true;

        public void phanquyen()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                
                string manv = quanli.DangNhaps.FirstOrDefault(p => p.UserName == user.Trim()).MaNV;
                string macv = quanli.NhanViens.FirstOrDefault(p => p.MaNV == manv).MaCV;
                ChucVu cv = quanli.ChucVus.FirstOrDefault(p => p.MaCV == macv);
                Console.WriteLine(manv);
                Console.WriteLine(macv);
                Console.WriteLine(cv.BanHang);
                if (cv.BanHang == false)
                {
                    banhang = false;
                }
                if (cv.Thongke == false)
                {

                    thongke = false;

                }
                if(cv.Quanlykho == false)
                {
                    quanlykho = false;
                }
                if(cv.Quanlynhanvien == false)
                {
                    quanlinhanvien = false;
                }
                if(cv.BanHang == true && cv.Quanlynhanvien ==  true && cv.Thongke == true && cv.Quanlykho == true){
                    admin = true;
                }
                //else
                //{
                //    panelMain.Controls.Clear();
                //    panelMain.Controls.Add(new FrmThuCUng());
                //    dem++;dem1++;
                //    if(dem == 0) 
                //    {
                //        panelMain.Controls.Clear();
                //        panelMain.Controls.Add(new Frmthucpham());
                //    }
                //    if (dem1 == 0)
                //    {
                //        panelMain.Controls.Clear();
                //        panelMain.Controls.Add(new Frmphukien());
                //    }
                //}
                //if (cv.Thongke == false)
                //{
                //    btnThongKe.Click += new EventHandler(ttnhanvien);
                //}
                //else
                //{
                //    if (dem == 0)
                //    {

                //    }
                //}
            }
        }

        private void ttnhanvien(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không được cấp quyền!");
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new FrmDichVu());
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            //report phieu nhap
            if (!thongke)
            {

                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new ReportPhieuNhap());
                
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //report hoadon
            if (!thongke)
            {

                MessageBox.Show("Xin lỗi, bạn không được cấp quyền");
                return;
            }
            else
            {
                ReportHoaDon rp = new ReportHoaDon();
                rp.Show();
            }
        }
    }
}
