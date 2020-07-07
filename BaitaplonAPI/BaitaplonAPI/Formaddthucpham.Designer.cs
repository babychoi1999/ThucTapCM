namespace BaitaplonAPI
{
    partial class Formaddthucpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formaddthucpham));
            this.dgvThucPham = new System.Windows.Forms.DataGridView();
            this.mathucphamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthucphamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tHUCPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlithucungDataSet14 = new BaitaplonAPI.quanlithucungDataSet14();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSua = new System.Windows.Forms.Button();
            this.tHUCPHAMTableAdapter3 = new BaitaplonAPI.quanlithucungDataSet14TableAdapters.THUCPHAMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThucPham
            // 
            this.dgvThucPham.AllowUserToAddRows = false;
            this.dgvThucPham.AllowUserToDeleteRows = false;
            this.dgvThucPham.AutoGenerateColumns = false;
            this.dgvThucPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathucphamDataGridViewTextBoxColumn,
            this.tenthucphamDataGridViewTextBoxColumn,
            this.donviDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.dataGridViewImageColumn1});
            this.dgvThucPham.DataSource = this.tHUCPHAMBindingSource;
            this.dgvThucPham.Location = new System.Drawing.Point(38, 188);
            this.dgvThucPham.Name = "dgvThucPham";
            this.dgvThucPham.ReadOnly = true;
            this.dgvThucPham.Size = new System.Drawing.Size(557, 150);
            this.dgvThucPham.TabIndex = 1;
            this.dgvThucPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucPham_CellContentClick);
            // 
            // mathucphamDataGridViewTextBoxColumn
            // 
            this.mathucphamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mathucphamDataGridViewTextBoxColumn.DataPropertyName = "Mathucpham";
            this.mathucphamDataGridViewTextBoxColumn.HeaderText = "Mã thực phẩm";
            this.mathucphamDataGridViewTextBoxColumn.Name = "mathucphamDataGridViewTextBoxColumn";
            this.mathucphamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenthucphamDataGridViewTextBoxColumn
            // 
            this.tenthucphamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenthucphamDataGridViewTextBoxColumn.DataPropertyName = "Tenthucpham";
            this.tenthucphamDataGridViewTextBoxColumn.HeaderText = "Tên thực phẩm";
            this.tenthucphamDataGridViewTextBoxColumn.Name = "tenthucphamDataGridViewTextBoxColumn";
            this.tenthucphamDataGridViewTextBoxColumn.ReadOnly = true;
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
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "hinhanh";
            this.dataGridViewImageColumn1.HeaderText = "Hình ảnh";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // tHUCPHAMBindingSource
            // 
            this.tHUCPHAMBindingSource.DataMember = "THUCPHAM";
            this.tHUCPHAMBindingSource.DataSource = this.quanlithucungDataSet14;
            // 
            // quanlithucungDataSet14
            // 
            this.quanlithucungDataSet14.DataSetName = "quanlithucungDataSet14";
            this.quanlithucungDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hinhanh
            // 
            this.hinhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hinhanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hinhanh.Image = ((System.Drawing.Image)(resources.GetObject("hinhanh.Image")));
            this.hinhanh.Location = new System.Drawing.Point(435, 9);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(160, 173);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 37;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(95, 66);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 35;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(259, 159);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tHUCPHAMTableAdapter3
            // 
            this.tHUCPHAMTableAdapter3.ClearBeforeFill = true;
            // 
            // Formaddthucpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 350);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.dgvThucPham);
            this.Name = "Formaddthucpham";
            this.Text = "Formaddthucpham";
            this.Load += new System.EventHandler(this.Formaddthucpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThucPham;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnSua;
        private quanlithucungDataSet14 quanlithucungDataSet14;
        private System.Windows.Forms.BindingSource tHUCPHAMBindingSource;
        private quanlithucungDataSet14TableAdapters.THUCPHAMTableAdapter tHUCPHAMTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathucphamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthucphamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}