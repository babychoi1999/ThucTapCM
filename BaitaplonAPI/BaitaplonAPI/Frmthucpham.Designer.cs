﻿namespace BaitaplonAPI
{
    partial class Frmthucpham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmthucpham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDanhMuc = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAnh = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbchuathanhtoan = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.NumericUpDown();
            this.cbLoaiThucPham = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThucPham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.txtuudai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthanhtoan = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttenthucpham = new System.Windows.Forms.TextBox();
            this.mathucpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthucpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaithucpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.White;
            this.panelDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(586, 49);
            this.panelDanhMuc.TabIndex = 0;
            // 
            // panelAnh
            // 
            this.panelAnh.BackColor = System.Drawing.Color.White;
            this.panelAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnh.Location = new System.Drawing.Point(0, 57);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(586, 590);
            this.panelAnh.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbchuathanhtoan);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.cbLoaiThucPham);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtmahoadon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtuudai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnthanhtoan);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtdongia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txttenthucpham);
            this.panel1.Location = new System.Drawing.Point(601, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 519);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(246, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 76;
            this.label8.Text = "Hóa đơn chưa thanh toán";
            // 
            // cbchuathanhtoan
            // 
            this.cbchuathanhtoan.DisplayMember = "MaHD";
            this.cbchuathanhtoan.FormattingEnabled = true;
            this.cbchuathanhtoan.Location = new System.Drawing.Point(274, 66);
            this.cbchuathanhtoan.Name = "cbchuathanhtoan";
            this.cbchuathanhtoan.Size = new System.Drawing.Size(92, 21);
            this.cbchuathanhtoan.TabIndex = 75;
            this.cbchuathanhtoan.ValueMember = "MaHD";
            this.cbchuathanhtoan.SelectedIndexChanged += new System.EventHandler(this.cbchuathanhtoan_SelectedIndexChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(104, 214);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 74;
            // 
            // cbLoaiThucPham
            // 
            this.cbLoaiThucPham.FormattingEnabled = true;
            this.cbLoaiThucPham.Location = new System.Drawing.Point(105, 114);
            this.cbLoaiThucPham.Name = "cbLoaiThucPham";
            this.cbLoaiThucPham.Size = new System.Drawing.Size(101, 21);
            this.cbLoaiThucPham.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 72;
            this.label7.Text = "Mã hóa đơn:";
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmahoadon.Enabled = false;
            this.txtmahoadon.Location = new System.Drawing.Point(104, 20);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(102, 20);
            this.txtmahoadon.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThucPham);
            this.panel2.Location = new System.Drawing.Point(3, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 215);
            this.panel2.TabIndex = 61;
            // 
            // dgvThucPham
            // 
            this.dgvThucPham.AllowUserToAddRows = false;
            this.dgvThucPham.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThucPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThucPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThucPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThucPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathucpham,
            this.tenthucpham,
            this.loaithucpham,
            this.soluong,
            this.dongia,
            this.thanhtien,
            this.Xoa});
            this.dgvThucPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThucPham.DoubleBuffered = true;
            this.dgvThucPham.EnableHeadersVisualStyles = false;
            this.dgvThucPham.GridColor = System.Drawing.Color.Black;
            this.dgvThucPham.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvThucPham.HeaderForeColor = System.Drawing.Color.White;
            this.dgvThucPham.Location = new System.Drawing.Point(0, 0);
            this.dgvThucPham.Name = "dgvThucPham";
            this.dgvThucPham.ReadOnly = true;
            this.dgvThucPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvThucPham.RowHeadersWidth = 51;
            this.dgvThucPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvThucPham.RowTemplate.Height = 30;
            this.dgvThucPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucPham.ShowCellErrors = false;
            this.dgvThucPham.ShowRowErrors = false;
            this.dgvThucPham.Size = new System.Drawing.Size(388, 215);
            this.dgvThucPham.TabIndex = 61;
            this.dgvThucPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucPham_CellContentClick);
            this.dgvThucPham.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvThucPham_RowStateChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "%";
            // 
            // txtuudai
            // 
            this.txtuudai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtuudai.Enabled = false;
            this.txtuudai.Location = new System.Drawing.Point(286, 214);
            this.txtuudai.Name = "txtuudai";
            this.txtuudai.Size = new System.Drawing.Size(95, 20);
            this.txtuudai.TabIndex = 59;
            this.txtuudai.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Ưu đãi:";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthanhtoan.ImageOptions.Image")));
            this.btnthanhtoan.Location = new System.Drawing.Point(264, 482);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(102, 30);
            this.btnthanhtoan.TabIndex = 56;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.Location = new System.Drawing.Point(152, 482);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(86, 30);
            this.btnluu.TabIndex = 55;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(35, 482);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 30);
            this.btnthem.TabIndex = 54;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Đơn giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Loại thực phẩm:";
            // 
            // txtdongia
            // 
            this.txtdongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdongia.Enabled = false;
            this.txtdongia.Location = new System.Drawing.Point(104, 164);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(102, 20);
            this.txtdongia.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tên thực phẩm:";
            // 
            // txttenthucpham
            // 
            this.txttenthucpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttenthucpham.Enabled = false;
            this.txttenthucpham.Location = new System.Drawing.Point(105, 67);
            this.txttenthucpham.Name = "txttenthucpham";
            this.txttenthucpham.Size = new System.Drawing.Size(101, 20);
            this.txttenthucpham.TabIndex = 45;
            // 
            // mathucpham
            // 
            this.mathucpham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mathucpham.DataPropertyName = "xoa";
            this.mathucpham.HeaderText = "Mã thực phẩm";
            this.mathucpham.Name = "mathucpham";
            this.mathucpham.ReadOnly = true;
            this.mathucpham.Visible = false;
            // 
            // tenthucpham
            // 
            this.tenthucpham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenthucpham.HeaderText = "Tên thực phẩm";
            this.tenthucpham.Name = "tenthucpham";
            this.tenthucpham.ReadOnly = true;
            // 
            // loaithucpham
            // 
            this.loaithucpham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaithucpham.HeaderText = "Loại thực phẩm";
            this.loaithucpham.Name = "loaithucpham";
            this.loaithucpham.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Xoa.DataPropertyName = "xoa";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = "Xóa";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle7;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            // 
            // Frmthucpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAnh);
            this.Controls.Add(this.panelDanhMuc);
            this.Name = "Frmthucpham";
            this.Size = new System.Drawing.Size(1000, 537);
            this.Load += new System.EventHandler(this.Formbanhthuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDanhMuc;
        private System.Windows.Forms.FlowLayoutPanel panelAnh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvThucPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuudai;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnthanhtoan;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttenthucpham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.ComboBox cbLoaiThucPham;
        private System.Windows.Forms.NumericUpDown txtsoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbchuathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathucpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthucpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaithucpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}
