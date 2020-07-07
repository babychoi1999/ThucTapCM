namespace BaitaplonAPI
{
    partial class dangnhapkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhapkhachhang));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btdangnhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Checkbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Đăng Nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtten
            // 
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtten.HintForeColor = System.Drawing.Color.Empty;
            this.txtten.HintText = "";
            this.txtten.isPassword = false;
            this.txtten.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtten.LineIdleColor = System.Drawing.Color.Gray;
            this.txtten.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtten.LineThickness = 3;
            this.txtten.Location = new System.Drawing.Point(102, 46);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(220, 33);
            this.txtten.TabIndex = 3;
            this.txtten.Text = "Nhập tên khách hàng vào";
            this.txtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btdangnhap);
            this.groupBox1.Controls.Add(this.Checkbox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập tài khoản khách hàng ";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtemail.Location = new System.Drawing.Point(102, 88);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '*';
            this.txtemail.Size = new System.Drawing.Size(220, 32);
            this.txtemail.TabIndex = 29;
            this.txtemail.Text = "Nhập mật khẩu ";
            // 
            // btthoat
            // 
            this.btthoat.ActiveBorderThickness = 1;
            this.btthoat.ActiveCornerRadius = 20;
            this.btthoat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btthoat.ActiveForecolor = System.Drawing.Color.White;
            this.btthoat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.ButtonText = "Exit";
            this.btthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btthoat.IdleBorderThickness = 1;
            this.btthoat.IdleCornerRadius = 20;
            this.btthoat.IdleFillColor = System.Drawing.Color.White;
            this.btthoat.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btthoat.IdleLineColor = System.Drawing.Color.Blue;
            this.btthoat.Location = new System.Drawing.Point(154, 163);
            this.btthoat.Margin = new System.Windows.Forms.Padding(5);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(76, 37);
            this.btthoat.TabIndex = 28;
            this.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.ActiveBorderThickness = 1;
            this.btdangnhap.ActiveCornerRadius = 20;
            this.btdangnhap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btdangnhap.ActiveForecolor = System.Drawing.Color.White;
            this.btdangnhap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btdangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btdangnhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdangnhap.BackgroundImage")));
            this.btdangnhap.ButtonText = "Login";
            this.btdangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdangnhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btdangnhap.IdleBorderThickness = 1;
            this.btdangnhap.IdleCornerRadius = 20;
            this.btdangnhap.IdleFillColor = System.Drawing.Color.White;
            this.btdangnhap.IdleForecolor = System.Drawing.Color.Blue;
            this.btdangnhap.IdleLineColor = System.Drawing.Color.Blue;
            this.btdangnhap.Location = new System.Drawing.Point(68, 163);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(5);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(76, 37);
            this.btdangnhap.TabIndex = 27;
            this.btdangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // Checkbox1
            // 
            this.Checkbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.Checked = false;
            this.Checkbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox1.ForeColor = System.Drawing.Color.White;
            this.Checkbox1.Location = new System.Drawing.Point(102, 128);
            this.Checkbox1.Name = "Checkbox1";
            this.Checkbox1.Size = new System.Drawing.Size(20, 20);
            this.Checkbox1.TabIndex = 26;
            this.Checkbox1.OnChange += new System.EventHandler(this.Checkbox1_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Show password!";
            // 
            // dangnhapkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "dangnhapkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dangnhapkhachhang";
            this.Load += new System.EventHandler(this.dangnhapkhachhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btthoat;
        private Bunifu.Framework.UI.BunifuThinButton2 btdangnhap;
        private System.Windows.Forms.TextBox txtemail;
    }
}