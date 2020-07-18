namespace BaitaplonAPI
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnxem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpthang = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataSet6 = new BaitaplonAPI.DataSet6();
            this.tctonkhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tctonkhoTableAdapter = new BaitaplonAPI.DataSet6TableAdapters.tctonkhoTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mathucung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthucung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sltrongkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctonkhoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnxem.Location = new System.Drawing.Point(490, 62);
            this.btnxem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnxem.Name = "btnxem";
            this.btnxem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnxem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnxem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnxem.selected = false;
            this.btnxem.Size = new System.Drawing.Size(88, 28);
            this.btnxem.TabIndex = 69;
            this.btnxem.Text = "Xem";
            this.btnxem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxem.Textcolor = System.Drawing.Color.White;
            this.btnxem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // dtpthang
            // 
            this.dtpthang.AllowDrop = true;
            this.dtpthang.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpthang.CustomFormat = "MM/yyyy";
            this.dtpthang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpthang.Location = new System.Drawing.Point(267, 70);
            this.dtpthang.Name = "dtpthang";
            this.dtpthang.Size = new System.Drawing.Size(182, 20);
            this.dtpthang.TabIndex = 68;
            this.dtpthang.Value = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
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
            this.mathucung,
            this.tenthucung,
            this.slnhap,
            this.slban,
            this.sltrongkho,
            this.ngaylap});
            this.bunifuCustomDataGrid1.DataSource = this.tctonkhoBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Navy;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(64, 128);
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
            this.bunifuCustomDataGrid1.TabIndex = 70;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tctonkhoBindingSource
            // 
            this.tctonkhoBindingSource.DataMember = "tctonkho";
            this.tctonkhoBindingSource.DataSource = this.dataSet6;
            // 
            // tctonkhoTableAdapter
            // 
            this.tctonkhoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 71;
            // 
            // mathucung
            // 
            this.mathucung.DataPropertyName = "Mathucung";
            this.mathucung.HeaderText = "Mathucung";
            this.mathucung.Name = "mathucung";
            // 
            // tenthucung
            // 
            this.tenthucung.DataPropertyName = "Tenthucung";
            this.tenthucung.HeaderText = "Tenthucung";
            this.tenthucung.Name = "tenthucung";
            // 
            // slnhap
            // 
            this.slnhap.DataPropertyName = "slnhap";
            this.slnhap.HeaderText = "slnhap";
            this.slnhap.Name = "slnhap";
            // 
            // slban
            // 
            this.slban.DataPropertyName = "slban";
            this.slban.HeaderText = "slban";
            this.slban.Name = "slban";
            // 
            // sltrongkho
            // 
            this.sltrongkho.DataPropertyName = "sltrongkho";
            this.sltrongkho.HeaderText = "số lượng trong kho";
            this.sltrongkho.Name = "sltrongkho";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "Ngaylap";
            this.ngaylap.HeaderText = "Ngaylap";
            this.ngaylap.Name = "ngaylap";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 460);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.dtpthang);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctonkhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnxem;
        private System.Windows.Forms.DateTimePicker dtpthang;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.BindingSource tctonkhoBindingSource;
        private DataSet6 dataSet6;
        private DataSet6TableAdapters.tctonkhoTableAdapter tctonkhoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathucung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthucung;
        private System.Windows.Forms.DataGridViewTextBoxColumn slnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn slban;
        private System.Windows.Forms.DataGridViewTextBoxColumn sltrongkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
    }
}