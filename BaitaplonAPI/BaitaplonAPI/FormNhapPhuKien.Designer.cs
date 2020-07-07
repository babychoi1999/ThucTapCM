namespace BaitaplonAPI
{
    partial class FormNhapPhuKien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbmanhacungcap = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlithucungDataSet25 = new BaitaplonAPI.quanlithucungDataSet25();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaphieunhap = new System.Windows.Forms.TextBox();
            this.cbLoaiPhuKien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhuKienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhuKienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhuKienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cTNhapPhuKienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlithucungDataSet13 = new BaitaplonAPI.quanlithucungDataSet13();
            this.cTNhapPhuKienTableAdapter = new BaitaplonAPI.quanlithucungDataSet6TableAdapters.CTNhapPhuKienTableAdapter();
            this.pHUKIENTableAdapter = new BaitaplonAPI.quanlithucungDataSet7TableAdapters.PHUKIENTableAdapter();
            this.loaiPhuKienTableAdapter = new BaitaplonAPI.quanlithucungDataSet8TableAdapters.LoaiPhuKienTableAdapter();
            this.cTNhapPhuKienTableAdapter1 = new BaitaplonAPI.quanlithucungDataSet13TableAdapters.CTNhapPhuKienTableAdapter();
            this.nhaCungCapTableAdapter = new BaitaplonAPI.quanlithucungDataSet25TableAdapters.NhaCungCapTableAdapter();
            this.txttenphukien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet25)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNhapPhuKienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttenphukien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbmanhacungcap);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtGianhap);
            this.panel1.Controls.Add(this.txtSoluong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmaphieunhap);
            this.panel1.Controls.Add(this.cbLoaiPhuKien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 341);
            this.panel1.TabIndex = 0;
            // 
            // cbmanhacungcap
            // 
            this.cbmanhacungcap.DataSource = this.nhaCungCapBindingSource;
            this.cbmanhacungcap.DisplayMember = "TenNCC";
            this.cbmanhacungcap.FormattingEnabled = true;
            this.cbmanhacungcap.Location = new System.Drawing.Point(114, 142);
            this.cbmanhacungcap.Name = "cbmanhacungcap";
            this.cbmanhacungcap.Size = new System.Drawing.Size(150, 21);
            this.cbmanhacungcap.TabIndex = 57;
            this.cbmanhacungcap.ValueMember = "MaNCC";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanlithucungDataSet25;
            // 
            // quanlithucungDataSet25
            // 
            this.quanlithucungDataSet25.DataSetName = "quanlithucungDataSet25";
            this.quanlithucungDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mã nhà cung cấp:";
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = null;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(204, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(72, 36);
            this.btnReset.TabIndex = 55;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = null;
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
            this.btnSua.Location = new System.Drawing.Point(103, 261);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(78, 36);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = null;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 90D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(11, 261);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(70, 36);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Location = new System.Drawing.Point(114, 216);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(150, 20);
            this.txtGianhap.TabIndex = 52;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(114, 180);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(150, 20);
            this.txtSoluong.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Giá nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // txtmaphieunhap
            // 
            this.txtmaphieunhap.Location = new System.Drawing.Point(115, 25);
            this.txtmaphieunhap.Name = "txtmaphieunhap";
            this.txtmaphieunhap.Size = new System.Drawing.Size(150, 20);
            this.txtmaphieunhap.TabIndex = 42;
            // 
            // cbLoaiPhuKien
            // 
            this.cbLoaiPhuKien.DisplayMember = "MaLoai";
            this.cbLoaiPhuKien.FormattingEnabled = true;
            this.cbLoaiPhuKien.Location = new System.Drawing.Point(115, 60);
            this.cbLoaiPhuKien.Name = "cbLoaiPhuKien";
            this.cbLoaiPhuKien.Size = new System.Drawing.Size(150, 21);
            this.cbLoaiPhuKien.TabIndex = 44;
            this.cbLoaiPhuKien.ValueMember = "MaLoai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Loại phụ kiện:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(306, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 341);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPNDataGridViewTextBoxColumn,
            this.maPhuKienDataGridViewTextBoxColumn,
            this.tenPhuKienDataGridViewTextBoxColumn,
            this.loaiPhuKienDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.Xoa});
            this.dataGridView1.DataSource = this.cTNhapPhuKienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maPNDataGridViewTextBoxColumn
            // 
            this.maPNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPNDataGridViewTextBoxColumn.DataPropertyName = "MaPN";
            this.maPNDataGridViewTextBoxColumn.HeaderText = "Mã phiếu nhập";
            this.maPNDataGridViewTextBoxColumn.Name = "maPNDataGridViewTextBoxColumn";
            // 
            // maPhuKienDataGridViewTextBoxColumn
            // 
            this.maPhuKienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhuKienDataGridViewTextBoxColumn.DataPropertyName = "MaPhuKien";
            this.maPhuKienDataGridViewTextBoxColumn.HeaderText = "Mã phụ kiện";
            this.maPhuKienDataGridViewTextBoxColumn.Name = "maPhuKienDataGridViewTextBoxColumn";
            // 
            // tenPhuKienDataGridViewTextBoxColumn
            // 
            this.tenPhuKienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenPhuKienDataGridViewTextBoxColumn.DataPropertyName = "TenPhuKien";
            this.tenPhuKienDataGridViewTextBoxColumn.HeaderText = "Tên phụ kiện";
            this.tenPhuKienDataGridViewTextBoxColumn.Name = "tenPhuKienDataGridViewTextBoxColumn";
            // 
            // loaiPhuKienDataGridViewTextBoxColumn
            // 
            this.loaiPhuKienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiPhuKienDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhuKien";
            this.loaiPhuKienDataGridViewTextBoxColumn.HeaderText = "Loại phụ kiện";
            this.loaiPhuKienDataGridViewTextBoxColumn.Name = "loaiPhuKienDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            this.maNCCDataGridViewTextBoxColumn.Visible = false;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Xoa.DataPropertyName = "MaPN";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "Xóa";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            // 
            // cTNhapPhuKienBindingSource
            // 
            this.cTNhapPhuKienBindingSource.DataMember = "CTNhapPhuKien";
            this.cTNhapPhuKienBindingSource.DataSource = this.quanlithucungDataSet13;
            // 
            // quanlithucungDataSet13
            // 
            this.quanlithucungDataSet13.DataSetName = "quanlithucungDataSet13";
            this.quanlithucungDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTNhapPhuKienTableAdapter
            // 
            this.cTNhapPhuKienTableAdapter.ClearBeforeFill = true;
            // 
            // pHUKIENTableAdapter
            // 
            this.pHUKIENTableAdapter.ClearBeforeFill = true;
            // 
            // loaiPhuKienTableAdapter
            // 
            this.loaiPhuKienTableAdapter.ClearBeforeFill = true;
            // 
            // cTNhapPhuKienTableAdapter1
            // 
            this.cTNhapPhuKienTableAdapter1.ClearBeforeFill = true;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // txttenphukien
            // 
            this.txttenphukien.Location = new System.Drawing.Point(115, 101);
            this.txttenphukien.Name = "txttenphukien";
            this.txttenphukien.Size = new System.Drawing.Size(150, 20);
            this.txttenphukien.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tên phụ kiện:";
            // 
            // FormNhapPhuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhapPhuKien";
            this.Text = "FormNhapPhuKien";
            this.Load += new System.EventHandler(this.FormNhapPhuKien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet25)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNhapPhuKienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaphieunhap;
        private System.Windows.Forms.ComboBox cbLoaiPhuKien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private System.Windows.Forms.Label label8;
        private quanlithucungDataSet6TableAdapters.CTNhapPhuKienTableAdapter cTNhapPhuKienTableAdapter;
        private quanlithucungDataSet7TableAdapters.PHUKIENTableAdapter pHUKIENTableAdapter;
        private quanlithucungDataSet8TableAdapters.LoaiPhuKienTableAdapter loaiPhuKienTableAdapter;
        private quanlithucungDataSet13 quanlithucungDataSet13;
        private System.Windows.Forms.BindingSource cTNhapPhuKienBindingSource;
        private quanlithucungDataSet13TableAdapters.CTNhapPhuKienTableAdapter cTNhapPhuKienTableAdapter1;
        private System.Windows.Forms.ComboBox cbmanhacungcap;
        private quanlithucungDataSet25 quanlithucungDataSet25;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private quanlithucungDataSet25TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhuKienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhuKienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhuKienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.TextBox txttenphukien;
        private System.Windows.Forms.Label label5;
    }
}