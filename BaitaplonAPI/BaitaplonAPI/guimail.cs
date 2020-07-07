using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using DevExpress.XtraEditors.Filtering.Templates;

namespace BaitaplonAPI
{
    public partial class guimail : Form
    {

        Attachment attachment = null;
        public guimail()
        {
            InitializeComponent();
            btGuiNhieuMail.Enabled = false;
            txtTo.Enabled = true;
        }

        private void btdinhkem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }
        void Guimail(string from , string to, string subject, string message,Attachment file = null)
        {
           try 
            {

                MailMessage mess = new MailMessage(from, to, subject, message);
                if (attachment != null)
                {
                    mess.Attachments.Add(attachment);
                  
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(txttendangnhap.Text, txtmatkhau.Text);
                client.Send(mess);
                MessageBox.Show("đã gửi thành công");

            }
            catch (Exception)
            {

            }


        }

        private void btgui_Click(object sender, EventArgs e)
        {
            attachment = null;
            //lấy cái file đường dẫn của ngta để đưa vào
            try
            {
                FileInfo file = new FileInfo(txtFile.Text);
                attachment = new Attachment(txtFile.Text);
            }
            catch { 
            }
            //doc file danh sách mail
            
            if (rdoGuiMotNguoi.Checked)
            {
                Guimail(txttendangnhap.Text, txtTo.Text.Trim(), txtsubject.Text, richtinnhan.Text, attachment);
            }
            else if (rdoGuiNhieuNguoi.Checked)
            {
                StreamReader hong = new StreamReader(txtTo.Text);
                string email;
                while ((email = hong.ReadLine()) != null)
                {
                    Guimail(txttendangnhap.Text, email, txtsubject.Text, richtinnhan.Text, attachment);
                }
            }
            
        }

        private void btguinhieumail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTo.Text = dialog.FileName;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGuiMotNguoi.Checked)
            {
                btGuiNhieuMail.Enabled = false;
                txtTo.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {     
            if (rdoGuiNhieuNguoi.Checked)
            {
                txtTo.Enabled = false;
                btGuiNhieuMail.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 thucung = new quanlithucungEntities1())
            {
                var r = thucung.uudaimoinhat(comboBox1.SelectedValue.ToString()).FirstOrDefault();
                if (r.NgayBD > DateTime.Now)
                {
                    richtinnhan.Text ="Nhân dịp"+ r.TenUD +"Cửa hàng Thú Cưng chúng tôi tại 74 Lê Văn Việt sẽ giảm :"+ r.GiamGia +"đồng và bắt đầu từ ngày" +
                        r.NgayBD +"đến ngày" + r.NgayKT +"sẽ kết thức chương trình khuyến mãi";
                }
                else
                {
                    lbthongbao.Text = "Đã Thông Báo";
                }
            }           
        }

       
        private void guimail_Load(object sender, EventArgs e)
        {
            using (quanlithucungEntities1 thucung = new quanlithucungEntities1())
            {
                comboBox1.DisplayMember = "TenUD";
                comboBox1.ValueMember = "MaUD";
                comboBox1.DataSource = thucung.selectalluudai();

            }
            
        }
    }
}
