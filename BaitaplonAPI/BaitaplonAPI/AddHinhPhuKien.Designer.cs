namespace BaitaplonAPI
{
    partial class AddHinhPhuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHinhPhuKien));
            this.btnSua = new System.Windows.Forms.Button();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.dgvPhuKien = new System.Windows.Forms.DataGridView();
            this.quanlithucungDataSet15 = new BaitaplonAPI.quanlithucungDataSet15();
            this.pHUKIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUKIENTableAdapter = new BaitaplonAPI.quanlithucungDataSet15TableAdapters.PHUKIENTableAdapter();
            this.maphukienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphukienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhuKienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(258, 211);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // hinhanh
            // 
            this.hinhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hinhanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hinhanh.Image = ((System.Drawing.Image)(resources.GetObject("hinhanh.Image")));
            this.hinhanh.Location = new System.Drawing.Point(434, 61);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(160, 173);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 42;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(94, 118);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 40;
            // 
            // dgvPhuKien
            // 
            this.dgvPhuKien.AllowUserToAddRows = false;
            this.dgvPhuKien.AllowUserToDeleteRows = false;
            this.dgvPhuKien.AutoGenerateColumns = false;
            this.dgvPhuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphukienDataGridViewTextBoxColumn,
            this.tenphukienDataGridViewTextBoxColumn,
            this.donviDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.loaiPhuKienDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn});
            this.dgvPhuKien.DataSource = this.pHUKIENBindingSource;
            this.dgvPhuKien.Location = new System.Drawing.Point(37, 240);
            this.dgvPhuKien.Name = "dgvPhuKien";
            this.dgvPhuKien.ReadOnly = true;
            this.dgvPhuKien.Size = new System.Drawing.Size(557, 150);
            this.dgvPhuKien.TabIndex = 39;
            this.dgvPhuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuKien_CellContentClick);
            // 
            // quanlithucungDataSet15
            // 
            this.quanlithucungDataSet15.DataSetName = "quanlithucungDataSet15";
            this.quanlithucungDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHUKIENBindingSource
            // 
            this.pHUKIENBindingSource.DataMember = "PHUKIEN";
            this.pHUKIENBindingSource.DataSource = this.quanlithucungDataSet15;
            // 
            // pHUKIENTableAdapter
            // 
            this.pHUKIENTableAdapter.ClearBeforeFill = true;
            // 
            // maphukienDataGridViewTextBoxColumn
            // 
            this.maphukienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maphukienDataGridViewTextBoxColumn.DataPropertyName = "Maphukien";
            this.maphukienDataGridViewTextBoxColumn.HeaderText = "Mã phụ kiện";
            this.maphukienDataGridViewTextBoxColumn.Name = "maphukienDataGridViewTextBoxColumn";
            this.maphukienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenphukienDataGridViewTextBoxColumn
            // 
            this.tenphukienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenphukienDataGridViewTextBoxColumn.DataPropertyName = "Tenphukien";
            this.tenphukienDataGridViewTextBoxColumn.HeaderText = "Tên phụ kiện";
            this.tenphukienDataGridViewTextBoxColumn.Name = "tenphukienDataGridViewTextBoxColumn";
            this.tenphukienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donviDataGridViewTextBoxColumn
            // 
            this.donviDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donviDataGridViewTextBoxColumn.DataPropertyName = "donvi";
            this.donviDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            this.donviDataGridViewTextBoxColumn.Name = "donviDataGridViewTextBoxColumn";
            this.donviDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            this.dongiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            this.dongiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            this.dongiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiPhuKienDataGridViewTextBoxColumn
            // 
            this.loaiPhuKienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiPhuKienDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhuKien";
            this.loaiPhuKienDataGridViewTextBoxColumn.HeaderText = "Loại phụ kiện";
            this.loaiPhuKienDataGridViewTextBoxColumn.Name = "loaiPhuKienDataGridViewTextBoxColumn";
            this.loaiPhuKienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "Hình ảnh";
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            this.hinhAnhDataGridViewImageColumn.ReadOnly = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // AddHinhPhuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.dgvPhuKien);
            this.Name = "AddHinhPhuKien";
            this.Text = "AddHinhPhuKien";
            this.Load += new System.EventHandler(this.AddHinhPhuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView dgvPhuKien;
        private quanlithucungDataSet15 quanlithucungDataSet15;
        private System.Windows.Forms.BindingSource pHUKIENBindingSource;
        private quanlithucungDataSet15TableAdapters.PHUKIENTableAdapter pHUKIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphukienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphukienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhuKienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}