namespace BaitaplonAPI
{
    partial class Formthemnhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formthemnhanvien));
            this.txtten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.btntrove = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.lblT = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblÊ = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblÂ = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblÊ2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(243, 48);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(153, 20);
            this.txtten.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(243, 95);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(153, 20);
            this.txtdiachi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CMND";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(243, 138);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(153, 20);
            this.txtcmnd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SĐT";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(243, 185);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(153, 20);
            this.txtsdt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chức vụ";
            // 
            // cbchucvu
            // 
            this.cbchucvu.DataSource = this.chucVuBindingSource;
            this.cbchucvu.DisplayMember = "TenCV";
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(243, 229);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(153, 21);
            this.cbchucvu.TabIndex = 12;
            this.cbchucvu.ValueMember = "MaCV";
            // 
            // btntrove
            // 
            this.btntrove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btntrove.Location = new System.Drawing.Point(305, 277);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 30);
            this.btntrove.TabIndex = 53;
            this.btntrove.Text = "Trở về";
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(150, 277);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(80, 30);
            this.btnthem.TabIndex = 52;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(134, 9);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(22, 24);
            this.lblT.TabIndex = 54;
            this.lblT.Text = "T";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(151, 9);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(24, 24);
            this.lblH.TabIndex = 55;
            this.lblH.Text = "H";
            // 
            // lblÊ
            // 
            this.lblÊ.AutoSize = true;
            this.lblÊ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÊ.Location = new System.Drawing.Point(171, 9);
            this.lblÊ.Name = "lblÊ";
            this.lblÊ.Size = new System.Drawing.Size(23, 24);
            this.lblÊ.TabIndex = 56;
            this.lblÊ.Text = "Ê";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(185, 9);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(26, 24);
            this.lblM.TabIndex = 57;
            this.lblM.Text = "M";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(217, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(24, 24);
            this.lblN.TabIndex = 58;
            this.lblN.Text = "N";
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH2.Location = new System.Drawing.Point(239, 9);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(24, 24);
            this.lblH2.TabIndex = 59;
            this.lblH2.Text = "H";
            // 
            // lblÂ
            // 
            this.lblÂ.AutoSize = true;
            this.lblÂ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÂ.Location = new System.Drawing.Point(259, 9);
            this.lblÂ.Name = "lblÂ";
            this.lblÂ.Size = new System.Drawing.Size(23, 24);
            this.lblÂ.TabIndex = 60;
            this.lblÂ.Text = "Â";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(278, 9);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(24, 24);
            this.lblN2.TabIndex = 61;
            this.lblN2.Text = "N";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(308, 9);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(23, 24);
            this.lblV.TabIndex = 62;
            this.lblV.Text = "V";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(327, 9);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(14, 24);
            this.lblI.TabIndex = 63;
            this.lblI.Text = "I";
            // 
            // lblÊ2
            // 
            this.lblÊ2.AutoSize = true;
            this.lblÊ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÊ2.Location = new System.Drawing.Point(337, 9);
            this.lblÊ2.Name = "lblÊ2";
            this.lblÊ2.Size = new System.Drawing.Size(23, 24);
            this.lblÊ2.TabIndex = 64;
            this.lblÊ2.Text = "Ê";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(356, 9);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(24, 24);
            this.lblN3.TabIndex = 65;
            this.lblN3.Text = "N";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // quanlithucungDataSet28
            // 
            
            // chucVuBindingSource
            // 
            
            // 
            // chucVuTableAdapter
            // 
           
            // 
            // Formthemnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 319);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblÊ2);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblÂ);
            this.Controls.Add(this.lblH2);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblÊ);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbchucvu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtten);
            this.Name = "Formthemnhanvien";
            this.Text = "Formthemnhanvien";
            this.Load += new System.EventHandler(this.Formthemnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbchucvu;
        private DevExpress.XtraEditors.SimpleButton btntrove;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblÊ;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblÂ;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblÊ2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        
    }
}