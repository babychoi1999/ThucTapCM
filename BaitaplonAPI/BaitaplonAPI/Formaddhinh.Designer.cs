namespace BaitaplonAPI
{
    partial class Formaddhinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formaddhinh));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.maThuCungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuCungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlithucungDataSet36 = new BaitaplonAPI.quanlithucungDataSet36();
            this.thuCungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thuCungTableAdapter1 = new BaitaplonAPI.quanlithucungDataSet36TableAdapters.ThuCungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuCungBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuCungDataGridViewTextBoxColumn,
            this.tenThuCungDataGridViewTextBoxColumn,
            this.anhDataGridViewImageColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thuCungBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(557, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(79, 69);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(241, 148);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
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
            this.hinhanh.Location = new System.Drawing.Point(419, 12);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(160, 173);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 34;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // maThuCungDataGridViewTextBoxColumn
            // 
            this.maThuCungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maThuCungDataGridViewTextBoxColumn.DataPropertyName = "MaThuCung";
            this.maThuCungDataGridViewTextBoxColumn.HeaderText = "MaThuCung";
            this.maThuCungDataGridViewTextBoxColumn.Name = "maThuCungDataGridViewTextBoxColumn";
            this.maThuCungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenThuCungDataGridViewTextBoxColumn
            // 
            this.tenThuCungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenThuCungDataGridViewTextBoxColumn.DataPropertyName = "TenThuCung";
            this.tenThuCungDataGridViewTextBoxColumn.HeaderText = "TenThuCung";
            this.tenThuCungDataGridViewTextBoxColumn.Name = "tenThuCungDataGridViewTextBoxColumn";
            this.tenThuCungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anhDataGridViewImageColumn
            // 
            this.anhDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anhDataGridViewImageColumn.DataPropertyName = "Anh";
            this.anhDataGridViewImageColumn.HeaderText = "Anh";
            this.anhDataGridViewImageColumn.Name = "anhDataGridViewImageColumn";
            this.anhDataGridViewImageColumn.ReadOnly = true;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quanlithucungDataSet36
            // 
            this.quanlithucungDataSet36.DataSetName = "quanlithucungDataSet36";
            this.quanlithucungDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuCungBindingSource1
            // 
            this.thuCungBindingSource1.DataMember = "ThuCung";
            this.thuCungBindingSource1.DataSource = this.quanlithucungDataSet36;
            // 
            // thuCungTableAdapter1
            // 
            this.thuCungTableAdapter1.ClearBeforeFill = true;
            // 
            // Formaddhinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 350);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Formaddhinh";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuCungBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuCungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuCungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn anhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private quanlithucungDataSet36 quanlithucungDataSet36;
        private System.Windows.Forms.BindingSource thuCungBindingSource1;
        private quanlithucungDataSet36TableAdapters.ThuCungTableAdapter thuCungTableAdapter1;
    }
}