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
    public partial class FrmPhieuNhap : Form
    {
        public FrmPhieuNhap()
        {
            InitializeComponent();
        }
        public string user;
        private void loadncc()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                cbncc.DataSource = quanli.NhaCungCaps.ToList();
                cbncc.DisplayMember = "TenNCC";
                cbncc.ValueMember = "MaNCC";
            }
        }
        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            loadncc();
            dgvPhieuNhap.AutoGenerateColumns = false;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                dgvPhieuNhap.DataSource = quanli.PhieuNhaps.ToList();
                
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                
                    DangNhap dn = quanli.DangNhaps.FirstOrDefault(p => p.UserName == user);
                    quanli.insertPN(dn.MaNV, cbncc.SelectedValue.ToString());
                MessageBox.Show("Thêm thành công!");
                FrmPhieuNhap_Load(sender, e);
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==6)
            {
                if(MessageBox.Show("bạn có muốn xóa phiếu nhập này không ?","xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        string mapn = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
                        quanli.deletePN(mapn);
                        MessageBox.Show("đã xóa");
                        FrmPhieuNhap_Load(sender, e);
                    }
                }
            }
            if (e.ColumnIndex == 5)
            {
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    string mapn = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
                    FrmCTPhieuNhap ct = new FrmCTPhieuNhap();
                    ct.mapn = mapn;
                    ct.FormClosed += thoat;
                    ct.ShowDialog();
                   
                        
                }
            }
        }

        private void thoat(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }
    }
}
