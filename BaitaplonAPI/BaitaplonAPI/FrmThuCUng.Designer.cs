namespace BaitaplonAPI
{
    partial class FrmThuCUng
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAnh = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDanhMuc = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbchuathanhtoan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttenthucung = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.NumericUpDown();
            this.cbLoaiThuCung = new System.Windows.Forms.ComboBox();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThuCung = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.txtuudai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.mathucung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthucung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaithucung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAnh
            // 
            this.panelAnh.AutoScroll = true;
            this.panelAnh.BackColor = System.Drawing.Color.White;
            this.panelAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnh.Location = new System.Drawing.Point(3, 80);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(628, 454);
            this.panelAnh.TabIndex = 28;
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.AutoScroll = true;
            this.panelDanhMuc.BackColor = System.Drawing.Color.White;
            this.panelDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDanhMuc.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.panelDanhMuc.Location = new System.Drawing.Point(3, 0);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(628, 74);
            this.panelDanhMuc.TabIndex = 0;
            this.panelDanhMuc.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDanhMuc_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbchuathanhtoan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtmahoadon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txttenthucung);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.cbLoaiThuCung);
            this.panel1.Controls.Add(this.btnthanhtoan);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtuudai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtdongia);
            this.panel1.Location = new System.Drawing.Point(637, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 531);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(256, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 78;
            this.label8.Text = "HD chưa thanh toán:";
            // 
            // cbchuathanhtoan
            // 
            this.cbchuathanhtoan.DisplayMember = "MaHD";
            this.cbchuathanhtoan.FormattingEnabled = true;
            this.cbchuathanhtoan.Location = new System.Drawing.Point(266, 65);
            this.cbchuathanhtoan.Name = "cbchuathanhtoan";
            this.cbchuathanhtoan.Size = new System.Drawing.Size(98, 21);
            this.cbchuathanhtoan.TabIndex = 77;
            this.cbchuathanhtoan.ValueMember = "MaHD";
            this.cbchuathanhtoan.SelectedIndexChanged += new System.EventHandler(this.cbchuathanhtoan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmahoadon.Enabled = false;
            this.txtmahoadon.Location = new System.Drawing.Point(86, 3);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(110, 20);
            this.txtmahoadon.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tên thú cưng:";
            // 
            // txttenthucung
            // 
            this.txttenthucung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttenthucung.Enabled = false;
            this.txttenthucung.Location = new System.Drawing.Point(86, 47);
            this.txttenthucung.Name = "txttenthucung";
            this.txttenthucung.Size = new System.Drawing.Size(110, 20);
            this.txttenthucung.TabIndex = 67;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(86, 180);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(110, 20);
            this.txtsoluong.TabIndex = 66;
            // 
            // cbLoaiThuCung
            // 
            this.cbLoaiThuCung.FormattingEnabled = true;
            this.cbLoaiThuCung.Location = new System.Drawing.Point(86, 90);
            this.cbLoaiThuCung.Name = "cbLoaiThuCung";
            this.cbLoaiThuCung.Size = new System.Drawing.Size(110, 21);
            this.cbLoaiThuCung.TabIndex = 65;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.Color.Navy;
            this.btnthanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnthanhtoan.Location = new System.Drawing.Point(254, 471);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(89, 38);
            this.btnthanhtoan.TabIndex = 64;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Navy;
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Location = new System.Drawing.Point(141, 471);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(89, 38);
            this.btnluu.TabIndex = 63;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Navy;
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(25, 471);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 38);
            this.btnthem.TabIndex = 62;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThuCung);
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 237);
            this.panel2.TabIndex = 61;
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.AllowUserToAddRows = false;
            this.dgvThuCung.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThuCung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvThuCung.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuCung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThuCung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuCung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathucung,
            this.tenthucung,
            this.loaithucung,
            this.soluong,
            this.dongia,
            this.thanhtien,
            this.xoa});
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuCung.DoubleBuffered = true;
            this.dgvThuCung.EnableHeadersVisualStyles = false;
            this.dgvThuCung.GridColor = System.Drawing.Color.Black;
            this.dgvThuCung.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvThuCung.HeaderForeColor = System.Drawing.Color.White;
            this.dgvThuCung.Location = new System.Drawing.Point(0, 0);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.ReadOnly = true;
            this.dgvThuCung.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuCung.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvThuCung.RowHeadersWidth = 51;
            this.dgvThuCung.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvThuCung.RowTemplate.Height = 30;
            this.dgvThuCung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuCung.ShowCellErrors = false;
            this.dgvThuCung.ShowRowErrors = false;
            this.dgvThuCung.Size = new System.Drawing.Size(369, 237);
            this.dgvThuCung.TabIndex = 61;
            this.dgvThuCung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellContentClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "%";
            // 
            // txtuudai
            // 
            this.txtuudai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtuudai.Location = new System.Drawing.Point(279, 181);
            this.txtuudai.Name = "txtuudai";
            this.txtuudai.Size = new System.Drawing.Size(85, 20);
            this.txtuudai.TabIndex = 59;
            this.txtuudai.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Ưu đãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 180);
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
            this.label2.Location = new System.Drawing.Point(2, 135);
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
            this.label1.Location = new System.Drawing.Point(4, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Loại thú cưng:";
            // 
            // txtdongia
            // 
            this.txtdongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdongia.Enabled = false;
            this.txtdongia.Location = new System.Drawing.Point(86, 135);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(110, 20);
            this.txtdongia.TabIndex = 47;
            // 
            // mathucung
            // 
            this.mathucung.DataPropertyName = "mathucung";
            this.mathucung.HeaderText = "Mã thú cưng";
            this.mathucung.Name = "mathucung";
            this.mathucung.ReadOnly = true;
            this.mathucung.Visible = false;
            // 
            // tenthucung
            // 
            this.tenthucung.DataPropertyName = "tenthucung";
            this.tenthucung.HeaderText = "Tên thú cưng";
            this.tenthucung.Name = "tenthucung";
            this.tenthucung.ReadOnly = true;
            this.tenthucung.Width = 64;
            // 
            // loaithucung
            // 
            this.loaithucung.DataPropertyName = "loaithucung";
            this.loaithucung.HeaderText = "Loại thú cưng";
            this.loaithucung.Name = "loaithucung";
            this.loaithucung.ReadOnly = true;
            this.loaithucung.Width = 63;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 64;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.dongia.Width = 63;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Width = 64;
            // 
            // xoa
            // 
            this.xoa.DataPropertyName = "xoa";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.NullValue = "Xóa";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xoa.DefaultCellStyle = dataGridViewCellStyle11;
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            // 
            // FrmThuCUng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDanhMuc);
            this.Controls.Add(this.panelAnh);
            this.Name = "FrmThuCUng";
            this.Size = new System.Drawing.Size(1030, 537);
            this.Load += new System.EventHandler(this.Husky_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelAnh;
        private System.Windows.Forms.FlowLayoutPanel panelDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuudai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvThuCung;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ComboBox cbLoaiThuCung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttenthucung;
        private System.Windows.Forms.NumericUpDown txtsoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbchuathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathucung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthucung;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaithucung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}
