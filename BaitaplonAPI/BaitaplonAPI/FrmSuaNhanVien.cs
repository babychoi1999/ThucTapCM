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
    public partial class FrmSuaNhanVien : Form
    {
        int Num;
        public FrmSuaNhanVien()
        {
            
            InitializeComponent();
        }
        public string manv;
        private string tennv;
        private string diachi;
        private string sdt;
        private string cmnd;
        private string chucvu;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public FrmSuaNhanVien(int num, string manv, string tennv, string diachi, string sdt, string cmnd, string chucvu)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.diachi = diachi;
            this.sdt = sdt;
            this.cmnd = cmnd;
            this.chucvu = chucvu;
        }
        public bool kiemtra()
        {
            if (txtten.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "" || txtcmnd.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!!!");
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Num++;
            switch (Num)
            {
                case 0:
                    lblS.ForeColor = Color.Red;
                    lblƯ.ForeColor = Color.Yellow;
                    lblA.ForeColor = Color.Aqua;
                   
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
                    lblS.ForeColor = Color.Yellow;
                    lblƯ.ForeColor = Color.Aqua;
                    lblA.ForeColor = Color.Red;
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
                    lblS.ForeColor = Color.Aqua;
                    lblƯ.ForeColor = Color.Red;
                    lblA.ForeColor = Color.Magenta;
                    
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
                    lblS.ForeColor = Color.Pink;
                    lblƯ.ForeColor = Color.Green;
                    lblA.ForeColor = Color.Yellow;
                  
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            try
            {
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.MaNV == manv);

                    nv.MaCV = cbchucvu.SelectedValue.ToString();
                    nv.TenNV = txtten.Text;
                    nv.sodienthoai = int.Parse(txtsdt.Text);
                    nv.DiaChi = txtdiachi.Text;
                    nv.CMND = int.Parse(txtcmnd.Text);
                    nv.Gmail = txtemail.Text;
                    quanli.SaveChanges();
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể sửa, vui lòng kiểm tra lại");
                return;
            }
            
        }
        public DevExpress.XtraEditors.SimpleButton getsua()
        {
            return btnluu;
        }
        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSuaNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlithucungDataSet30.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.quanlithucungDataSet30.ChucVu);
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                NhanVien nv = quanli.NhanViens.FirstOrDefault(P => P.MaNV == manv);
                if(nv!=null)
                {
                    txtten.Text = nv.TenNV;
                    txtcmnd.Text = nv.CMND.ToString();
                    txtdiachi.Text = nv.DiaChi.ToString();
                    txtsdt.Text = nv.sodienthoai.ToString();
                    txtemail.Text = nv.Gmail;
                    cbchucvu.SelectedValue = nv.MaCV;
                }

            }
        }
    }
}
