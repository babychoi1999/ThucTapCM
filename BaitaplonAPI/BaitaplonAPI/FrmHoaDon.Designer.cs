namespace BaitaplonAPI
{
    partial class FrmHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnthemHD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnxuatexcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.cbmaud = new System.Windows.Forms.ComboBox();
            this.cbuser = new System.Windows.Forms.ComboBox();
            this.dgvHoaDon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlithucungDataSet31 = new BaitaplonAPI.quanlithucungDataSet31();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hoaDonTableAdapter = new BaitaplonAPI.quanlithucungDataSet31TableAdapters.HoaDonTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.moFile = new System.Windows.Forms.SaveFileDialog();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet31)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthemHD
            // 
            this.btnthemHD.Activecolor = System.Drawing.Color.Transparent;
            this.btnthemHD.BackColor = System.Drawing.Color.Navy;
            this.btnthemHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthemHD.BorderRadius = 0;
            this.btnthemHD.ButtonText = "Thêm hóa đơn";
            this.btnthemHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemHD.DisabledColor = System.Drawing.Color.Gray;
            this.btnthemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthemHD.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthemHD.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnthemHD.Iconimage")));
            this.btnthemHD.Iconimage_right = null;
            this.btnthemHD.Iconimage_right_Selected = null;
            this.btnthemHD.Iconimage_Selected = null;
            this.btnthemHD.IconMarginLeft = 0;
            this.btnthemHD.IconMarginRight = 0;
            this.btnthemHD.IconRightVisible = true;
            this.btnthemHD.IconRightZoom = 0D;
            this.btnthemHD.IconVisible = true;
            this.btnthemHD.IconZoom = 90D;
            this.btnthemHD.IsTab = false;
            this.btnthemHD.Location = new System.Drawing.Point(91, 130);
            this.btnthemHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemHD.Name = "btnthemHD";
            this.btnthemHD.Normalcolor = System.Drawing.Color.Navy;
            this.btnthemHD.OnHovercolor = System.Drawing.Color.Navy;
            this.btnthemHD.OnHoverTextColor = System.Drawing.Color.White;
            this.btnthemHD.selected = false;
            this.btnthemHD.Size = new System.Drawing.Size(155, 48);
            this.btnthemHD.TabIndex = 65;
            this.btnthemHD.Text = "Thêm hóa đơn";
            this.btnthemHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemHD.Textcolor = System.Drawing.Color.White;
            this.btnthemHD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemHD.Click += new System.EventHandler(this.btnthemHD_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(115, 96);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(162, 20);
            this.txttongtien.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(374, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Mã ưu đãi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(13, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Tổng tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(13, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Mã khách hàng";
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Activecolor = System.Drawing.Color.Transparent;
            this.btnxuatexcel.BackColor = System.Drawing.Color.Navy;
            this.btnxuatexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxuatexcel.BorderRadius = 0;
            this.btnxuatexcel.ButtonText = "In";
            this.btnxuatexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxuatexcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnxuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatexcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnxuatexcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnxuatexcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnxuatexcel.Iconimage")));
            this.btnxuatexcel.Iconimage_right = null;
            this.btnxuatexcel.Iconimage_right_Selected = null;
            this.btnxuatexcel.Iconimage_Selected = null;
            this.btnxuatexcel.IconMarginLeft = 0;
            this.btnxuatexcel.IconMarginRight = 0;
            this.btnxuatexcel.IconRightVisible = true;
            this.btnxuatexcel.IconRightZoom = 0D;
            this.btnxuatexcel.IconVisible = true;
            this.btnxuatexcel.IconZoom = 90D;
            this.btnxuatexcel.IsTab = false;
            this.btnxuatexcel.Location = new System.Drawing.Point(578, 130);
            this.btnxuatexcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Normalcolor = System.Drawing.Color.Navy;
            this.btnxuatexcel.OnHovercolor = System.Drawing.Color.Navy;
            this.btnxuatexcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnxuatexcel.selected = false;
            this.btnxuatexcel.Size = new System.Drawing.Size(130, 48);
            this.btnxuatexcel.TabIndex = 50;
            this.btnxuatexcel.Text = "In";
            this.btnxuatexcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxuatexcel.Textcolor = System.Drawing.Color.White;
            this.btnxuatexcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatexcel.Click += new System.EventHandler(this.btnsuaHD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.cbkhachhang);
            this.panel1.Controls.Add(this.cbmaud);
            this.panel1.Controls.Add(this.cbuser);
            this.panel1.Controls.Add(this.btnthemHD);
            this.panel1.Controls.Add(this.txttongtien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnxuatexcel);
            this.panel1.Location = new System.Drawing.Point(87, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 182);
            this.panel1.TabIndex = 53;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(374, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(447, 93);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(162, 20);
            this.txttimkiem.TabIndex = 70;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(115, 3);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(162, 21);
            this.cbkhachhang.TabIndex = 68;
            // 
            // cbmaud
            // 
            this.cbmaud.FormattingEnabled = true;
            this.cbmaud.Location = new System.Drawing.Point(447, 3);
            this.cbmaud.Name = "cbmaud";
            this.cbmaud.Size = new System.Drawing.Size(162, 21);
            this.cbmaud.TabIndex = 67;
            // 
            // cbuser
            // 
            this.cbuser.FormattingEnabled = true;
            this.cbuser.Location = new System.Drawing.Point(115, 50);
            this.cbuser.Name = "cbuser";
            this.cbuser.Size = new System.Drawing.Size(162, 21);
            this.cbuser.TabIndex = 66;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.thoiGianLapDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.maUDDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.dgvHoaDon.DataSource = this.hoaDonBindingSource;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.DoubleBuffered = true;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.HeaderBgColor = System.Drawing.Color.Navy;
            this.dgvHoaDon.HeaderForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.Size = new System.Drawing.Size(798, 306);
            this.dgvHoaDon.TabIndex = 54;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanlithucungDataSet31;
            // 
            // quanlithucungDataSet31
            // 
            this.quanlithucungDataSet31.DataSetName = "quanlithucungDataSet31";
            this.quanlithucungDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHoaDon);
            this.panel2.Location = new System.Drawing.Point(87, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 306);
            this.panel2.TabIndex = 55;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(404, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // mahd
            // 
            this.mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahd.DataPropertyName = "MaHD";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            this.mahd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // thoiGianLapDataGridViewTextBoxColumn
            // 
            this.thoiGianLapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thoiGianLapDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianLap";
            this.thoiGianLapDataGridViewTextBoxColumn.HeaderText = "Thời gian lập";
            this.thoiGianLapDataGridViewTextBoxColumn.Name = "thoiGianLapDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // maUDDataGridViewTextBoxColumn
            // 
            this.maUDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maUDDataGridViewTextBoxColumn.DataPropertyName = "MaUD";
            this.maUDDataGridViewTextBoxColumn.HeaderText = "Mã ưu đãi";
            this.maUDDataGridViewTextBoxColumn.Name = "maUDDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewCheckBoxColumn
            // 
            this.trangThaiDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangThaiDataGridViewCheckBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.HeaderText = "Đã thanh toán";
            this.trangThaiDataGridViewCheckBoxColumn.Name = "trangThaiDataGridViewCheckBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.Transparent;
            this.btnSua.BackColor = System.Drawing.Color.Navy;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSua.Iconimage")));
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = true;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = true;
            this.btnSua.IconZoom = 90D;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(330, 130);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Navy;
            this.btnSua.OnHovercolor = System.Drawing.Color.Navy;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(130, 48);
            this.btnSua.TabIndex = 72;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoaDon";
            this.Size = new System.Drawing.Size(998, 535);
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet31)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnthemHD;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton btnxuatexcel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvHoaDon;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private quanlithucungDataSet31 quanlithucungDataSet31;
        private System.Windows.Forms.Panel panel2;
        private quanlithucungDataSet31TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbuser;
        private System.Windows.Forms.ComboBox cbmaud;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.SaveFileDialog moFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
    }
}
