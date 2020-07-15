namespace BaitaplonAPI
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dtpthang = new System.Windows.Forms.DateTimePicker();
            this.btnxem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tonkhothucung = new BaitaplonAPI.Tonkhothucung();
            this.tonkhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tonkhoTableAdapter = new BaitaplonAPI.TonkhothucungTableAdapters.TonkhoTableAdapter();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhothucung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahang,
            this.tenhang,
            this.slnhap,
            this.slban,
            this.tonkho,
            this.ngaylap});
            this.bunifuCustomDataGrid1.DataSource = this.tonkhoBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Navy;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(114, 115);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(733, 285);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // dtpthang
            // 
            this.dtpthang.AllowDrop = true;
            this.dtpthang.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpthang.CustomFormat = "MM/yyyy";
            this.dtpthang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpthang.Location = new System.Drawing.Point(373, 75);
            this.dtpthang.Name = "dtpthang";
            this.dtpthang.Size = new System.Drawing.Size(182, 20);
            this.dtpthang.TabIndex = 66;
            this.dtpthang.Value = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            // 
            // btnxem
            // 
            this.btnxem.Activecolor = System.Drawing.Color.Green;
            this.btnxem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnxem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxem.BorderRadius = 0;
            this.btnxem.ButtonText = "Xem";
            this.btnxem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxem.DisabledColor = System.Drawing.Color.Gray;
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnxem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnxem.Iconimage")));
            this.btnxem.Iconimage_right = null;
            this.btnxem.Iconimage_right_Selected = null;
            this.btnxem.Iconimage_Selected = null;
            this.btnxem.IconMarginLeft = 0;
            this.btnxem.IconMarginRight = 0;
            this.btnxem.IconRightVisible = false;
            this.btnxem.IconRightZoom = 0D;
            this.btnxem.IconVisible = false;
            this.btnxem.IconZoom = 30D;
            this.btnxem.IsTab = false;
            this.btnxem.Location = new System.Drawing.Point(596, 67);
            this.btnxem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnxem.Name = "btnxem";
            this.btnxem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnxem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnxem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnxem.selected = false;
            this.btnxem.Size = new System.Drawing.Size(88, 28);
            this.btnxem.TabIndex = 67;
            this.btnxem.Text = "Xem";
            this.btnxem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxem.Textcolor = System.Drawing.Color.White;
            this.btnxem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // tonkhothucung
            // 
            this.tonkhothucung.DataSetName = "Tonkhothucung";
            this.tonkhothucung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tonkhoBindingSource
            // 
            this.tonkhoBindingSource.DataMember = "Tonkho";
            this.tonkhoBindingSource.DataSource = this.tonkhothucung;
            // 
            // tonkhoTableAdapter
            // 
            this.tonkhoTableAdapter.ClearBeforeFill = true;
            // 
            // mahang
            // 
            this.mahang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahang.DataPropertyName = "MaHang";
            this.mahang.HeaderText = "MaHang";
            this.mahang.Name = "mahang";
            // 
            // tenhang
            // 
            this.tenhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenhang.DataPropertyName = "TenHang";
            this.tenhang.HeaderText = "TenHang";
            this.tenhang.Name = "tenhang";
            // 
            // slnhap
            // 
            this.slnhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.slnhap.DataPropertyName = "SlNhap";
            this.slnhap.HeaderText = "SlNhap";
            this.slnhap.Name = "slnhap";
            // 
            // slban
            // 
            this.slban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.slban.DataPropertyName = "SLBan";
            this.slban.HeaderText = "SLBan";
            this.slban.Name = "slban";
            // 
            // tonkho
            // 
            this.tonkho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tonkho.DataPropertyName = "TonKho";
            this.tonkho.HeaderText = "TonKho";
            this.tonkho.Name = "tonkho";
            // 
            // ngaylap
            // 
            this.ngaylap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaylap.DataPropertyName = "NgayLap";
            this.ngaylap.HeaderText = "NgayLap";
            this.ngaylap.Name = "ngaylap";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.dtpthang);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1000, 537);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhothucung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DateTimePicker dtpthang;
        private Bunifu.Framework.UI.BunifuFlatButton btnxem;
        private System.Windows.Forms.BindingSource tonkhoBindingSource;
        private Tonkhothucung tonkhothucung;
        private TonkhothucungTableAdapters.TonkhoTableAdapter tonkhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn slnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn slban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
    }
}
