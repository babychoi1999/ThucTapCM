using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace BaitaplonAPI
{
    public partial class FrmHoaDon : UserControl
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        private void loadhd()
        {

            dgvHoaDon.AutoGenerateColumns = false;
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                dgvHoaDon.DataSource = quanli.HoaDons.ToList();
            }
        }
        private void btnthemHD_Click(object sender, EventArgs e)
        {
            if (!kiemtra()) {
                return;
            }
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                quanli.themHD(cbkhachhang.Text, cbmaud.Text, cbuser.Text);
                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công hóa đơn!");
                FrmHoaDon_Load(sender, e);
            }
        }
        private void loaduser()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<DangNhap> user = quanli.DangNhaps.ToList();
                cbuser.DataSource = user;
                cbuser.DisplayMember = "UserName";
                cbuser.ValueMember = "UserName";
            }
        }
        public void loadkh()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<KhachHang> ds_kh = quanli.KhachHangs.ToList();
                cbkhachhang.DataSource = ds_kh;
                cbkhachhang.DisplayMember = "TênKH";
                cbkhachhang.ValueMember = "MaKH";
            }
        }
        public void loadud()
        {
            using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
            {
                List<UuDaiHD> ds_ud = quanli.UuDaiHDs.ToList();
                cbmaud.DataSource = ds_ud;
                cbmaud.DisplayMember = "TênUD";
                cbmaud.ValueMember = "MaUD";
            }
        }
        public bool kiemtra()
        {
            if(cbkhachhang.Text == "" || cbuser.Text == "" || cbmaud.Text == "") {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            loadhd();
            loaduser();
            loadud();
            loadkh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("bạn có muốn xóa hoa dơn này không?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                    {
                        string mahd = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                        quanli.deleHD(mahd);
                        MessageBox.Show("đã xóa");
                        FrmHoaDon_Load(sender, e);
                    }
                }
            }
        }
        String img = "";
        private void btnsuaHD_Click(object sender, EventArgs e)
        {
            moFile.ShowDialog();
            string file = moFile.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            if (file == "openFileDialog1")
                return;
            else
            {
                img = moFile.FileName.ToString();
            }
            Console.WriteLine(img);
            try
            {
                string saveExcelFile = img;

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "E1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Thống kê hóa đơn";

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2");//Cột A dòng 2 và dòng 3
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaSP = ws.get_Range("B2");//Cột B dòng 2 và dòng 3
                row23_MaSP.Font.Size = fontSizeTenTruong;
                row23_MaSP.Font.Name = fontName;
                row23_MaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaSP.Value2 = "Mã Hóa Đơn";
                row23_MaSP.ColumnWidth = 20;

                //Tạo Ô Tên Sản phẩm :
                Range row23_TenSP = ws.get_Range("C2");//Cột C dòng 2 và dòng 3
                row23_TenSP.Font.Size = fontSizeTenTruong;
                row23_TenSP.Font.Name = fontName;
                row23_TenSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenSP.ColumnWidth = 20;
                row23_TenSP.Value2 = "Ngày Lập";

                //Tạo Ô Giá Nhập:
                Range row3_GiaNhap = ws.get_Range("D2");//Ô D3
                row3_GiaNhap.Font.Size = fontSizeTenTruong;
                row3_GiaNhap.Font.Name = fontName;
                row3_GiaNhap.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_GiaNhap.Value2 = "Nhân Viên";
                row3_GiaNhap.ColumnWidth = 20;

                //Tạo Ô Giá Xuất:
                Range row3_GiaXuat = ws.get_Range("E2");//Ô E3
                row3_GiaXuat.Font.Size = fontSizeTenTruong;
                row3_GiaXuat.Font.Name = fontName;
                row3_GiaXuat.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_GiaXuat.Value2 = "Tổng Tiền";
                row3_GiaXuat.ColumnWidth = 20;
                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "E2");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 2;
                using (quanlithucungEntities1 quanli = new quanlithucungEntities1())
                {
                    foreach (HoaDon hd in quanli.HoaDons)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, hd.MaHD.Trim(), Convert.ToDateTime(hd.ThoiGianLap), hd.UserName.Trim(), hd.TongTien };
                        Range rowData = ws.get_Range("A" + row, "E" + row);
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        rowData.Value2 = arr;
                    }
                }

                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "E" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
        public void xuatPDF(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dgv.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void btnxuatpdf_Click(object sender, EventArgs e)
        {
            xuatPDF(dgvHoaDon, "Danh sach Hoa Don");
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            SqlConnection connect;
            string con = @"data source=DESKTOP-QEN4LJI\SQLEXPRESS;initial catalog=quanlithucung";
            connect = new SqlConnection(con);
            SqlCommand command;
            command = new SqlCommand(@"Backup database qlthucung to disk ='c:\BackUp.bak'", connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
