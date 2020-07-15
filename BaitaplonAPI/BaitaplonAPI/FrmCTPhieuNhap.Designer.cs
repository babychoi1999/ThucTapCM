using DevExpress.XtraEditors;

namespace BaitaplonAPI
{
    partial class FrmCTPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCTPhieuNhap));
            this.lvPhieuNhap = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donvi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mathucung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maphukien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mathucpham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTen = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlithucungDataSet26 = new BaitaplonAPI.quanlithucungDataSet26();
            this.nhaCungCapTableAdapter = new BaitaplonAPI.quanlithucungDataSet26TableAdapters.NhaCungCapTableAdapter();
            this.txtdonvi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet26)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPhieuNhap
            // 
            this.lvPhieuNhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.dongia,
            this.soluong,
            this.donvi,
            this.mathucung,
            this.maphukien,
            this.mathucpham});
            this.lvPhieuNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvPhieuNhap.FullRowSelect = true;
            this.lvPhieuNhap.GridLines = true;
            this.lvPhieuNhap.HideSelection = false;
            this.lvPhieuNhap.Location = new System.Drawing.Point(536, 2);
            this.lvPhieuNhap.Name = "lvPhieuNhap";
            this.lvPhieuNhap.Scrollable = false;
            this.lvPhieuNhap.Size = new System.Drawing.Size(439, 352);
            this.lvPhieuNhap.TabIndex = 26;
            this.lvPhieuNhap.UseCompatibleStateImageBehavior = false;
            this.lvPhieuNhap.View = System.Windows.Forms.View.Details;
            this.lvPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.lvPhieuNhap_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "maloai";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TÊN";
            this.columnHeader2.Width = 162;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn giá";
            // 
            // soluong
            // 
            this.soluong.Text = "Số Lượng";
            // 
            // donvi
            // 
            this.donvi.Text = "Đơn vị";
            // 
            // mathucung
            // 
            this.mathucung.Text = "Mã thú cưng";
            // 
            // maphukien
            // 
            this.maphukien.Text = "Mã phụ kiện";
            // 
            // mathucpham
            // 
            this.mathucpham.Text = "Mã thực phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Giá nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Số Lượng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Loại :";
            // 
            // cbTen
            // 
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(152, 100);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(121, 21);
            this.cbTen.TabIndex = 32;
            this.cbTen.SelectedIndexChanged += new System.EventHandler(this.cbTen_SelectedIndexChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(151, 140);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(121, 20);
            this.txtGia.TabIndex = 34;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(152, 178);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuong.TabIndex = 35;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ảnh minh họa";
            // 
            // hinhanh
            // 
            this.hinhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hinhanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hinhanh.Image = ((System.Drawing.Image)(resources.GetObject("hinhanh.Image")));
            this.hinhanh.Location = new System.Drawing.Point(293, 30);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(224, 210);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 37;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Items.AddRange(new object[] {
            "Thú Cưng",
            "Phụ Kiện",
            "Thực Phẩm"});
            this.cbDanhMuc.Location = new System.Drawing.Point(151, 30);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(121, 21);
            this.cbDanhMuc.TabIndex = 40;
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Danh Mục :";
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(151, 65);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(121, 21);
            this.cbLoai.TabIndex = 41;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanlithucungDataSet26;
            // 
            // quanlithucungDataSet26
            // 
            this.quanlithucungDataSet26.DataSetName = "quanlithucungDataSet26";
            this.quanlithucungDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // txtdonvi
            // 
            this.txtdonvi.Location = new System.Drawing.Point(152, 217);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.Size = new System.Drawing.Size(121, 20);
            this.txtdonvi.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Đơn vị:";
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(29, 280);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(80, 30);
            this.btnthem.TabIndex = 49;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(151, 280);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 30);
            this.btnsua.TabIndex = 50;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(262, 280);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 51;
            this.btnxoa.Text = "Xóa";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(383, 280);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 30);
            this.btnthoat.TabIndex = 52;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FrmCTPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 353);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdonvi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.cbTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPhieuNhap);
            this.Name = "FrmCTPhieuNhap";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.fmChiTietPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet26)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPhieuNhap;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLoai;
        private quanlithucungDataSet26 quanlithucungDataSet26;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private quanlithucungDataSet26TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.TextBox txtdonvi;
        private System.Windows.Forms.Label label8;
        private SimpleButton btnthem;
        private SimpleButton btnsua;
        private SimpleButton btnxoa;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ColumnHeader donvi;
        private System.Windows.Forms.ColumnHeader mathucung;
        private System.Windows.Forms.ColumnHeader maphukien;
        private System.Windows.Forms.ColumnHeader mathucpham;
        private SimpleButton btnthoat;
    }
}