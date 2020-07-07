namespace BaitaplonAPI
{
    partial class FrmThemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemNhanVien));
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlithucungDataSet27 = new BaitaplonAPI.quanlithucungDataSet27();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntrove = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.lblT = new System.Windows.Forms.Label();
            this.lblÊ = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblÂ = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblÊ2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chucVuTableAdapter = new BaitaplonAPI.quanlithucungDataSet27TableAdapters.ChucVuTableAdapter();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet27)).BeginInit();
            this.SuspendLayout();
            // 
            // cbchucvu
            // 
            this.cbchucvu.DataSource = this.chucVuBindingSource;
            this.cbchucvu.DisplayMember = "TenCV";
            this.cbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(261, 200);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(121, 23);
            this.cbchucvu.TabIndex = 61;
            this.cbchucvu.ValueMember = "MaCV";
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.quanlithucungDataSet27;
            // 
            // quanlithucungDataSet27
            // 
            this.quanlithucungDataSet27.DataSetName = "quanlithucungDataSet27";
            this.quanlithucungDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Chức vụ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "CMND :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sdt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên nhân viên :";
            // 
            // btntrove
            // 
            this.btntrove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntrove.ImageOptions.Image")));
            this.btntrove.Location = new System.Drawing.Point(307, 258);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 30);
            this.btntrove.TabIndex = 63;
            this.btntrove.Text = "Trở về";
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(151, 258);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(80, 30);
            this.btnthem.TabIndex = 62;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(146, 13);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(25, 25);
            this.lblT.TabIndex = 64;
            this.lblT.Text = "T";
            // 
            // lblÊ
            // 
            this.lblÊ.AutoSize = true;
            this.lblÊ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÊ.Location = new System.Drawing.Point(185, 13);
            this.lblÊ.Name = "lblÊ";
            this.lblÊ.Size = new System.Drawing.Size(26, 25);
            this.lblÊ.TabIndex = 65;
            this.lblÊ.Text = "Ê";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(326, 13);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(26, 25);
            this.lblV.TabIndex = 66;
            this.lblV.Text = "V";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(236, 13);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(27, 25);
            this.lblN.TabIndex = 67;
            this.lblN.Text = "N";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(165, 13);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(27, 25);
            this.lblH.TabIndex = 68;
            this.lblH.Text = "H";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(298, 13);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(27, 25);
            this.lblN2.TabIndex = 69;
            this.lblN2.Text = "N";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(201, 13);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(30, 25);
            this.lblM.TabIndex = 70;
            this.lblM.Text = "M";
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH2.Location = new System.Drawing.Point(255, 13);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(27, 25);
            this.lblH2.TabIndex = 71;
            this.lblH2.Text = "H";
            // 
            // lblÂ
            // 
            this.lblÂ.AutoSize = true;
            this.lblÂ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÂ.Location = new System.Drawing.Point(277, 13);
            this.lblÂ.Name = "lblÂ";
            this.lblÂ.Size = new System.Drawing.Size(26, 25);
            this.lblÂ.TabIndex = 72;
            this.lblÂ.Text = "Â";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(346, 13);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(17, 25);
            this.lblI.TabIndex = 73;
            this.lblI.Text = "I";
            // 
            // lblÊ2
            // 
            this.lblÊ2.AutoSize = true;
            this.lblÊ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÊ2.Location = new System.Drawing.Point(357, 13);
            this.lblÊ2.Name = "lblÊ2";
            this.lblÊ2.Size = new System.Drawing.Size(26, 25);
            this.lblÊ2.TabIndex = 74;
            this.lblÊ2.Text = "Ê";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(373, 13);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(27, 25);
            this.lblN3.TabIndex = 75;
            this.lblN3.Text = "N";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(260, 53);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(122, 20);
            this.txtten.TabIndex = 76;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(260, 88);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(122, 20);
            this.txtdiachi.TabIndex = 77;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(261, 125);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(122, 20);
            this.txtsdt.TabIndex = 78;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(260, 165);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(122, 20);
            this.txtcmnd.TabIndex = 79;
            // 
            // FrmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 317);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblÊ2);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblÂ);
            this.Controls.Add(this.lblH2);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblÊ);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbchucvu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmThemNhanVien";
            this.Text = "FrmThemNhanVien";
            this.Load += new System.EventHandler(this.FrmThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlithucungDataSet27)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btntrove;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblÊ;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblÂ;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblÊ2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Timer timer1;
        private quanlithucungDataSet27 quanlithucungDataSet27;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private quanlithucungDataSet27TableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcmnd;
    }
}