namespace BaitaplonAPI
{
    partial class ThongTinHoaDon
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
            this.rpHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.HoaDonBan1 = new BaitaplonAPI.HoaDonBan();
            this.SuspendLayout();
            // 
            // rpHoaDon
            // 
            this.rpHoaDon.ActiveViewIndex = 0;
            this.rpHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpHoaDon.DisplayStatusBar = false;
            this.rpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpHoaDon.Name = "rpHoaDon";
            this.rpHoaDon.ReportSource = this.HoaDonBan1;
            this.rpHoaDon.Size = new System.Drawing.Size(802, 509);
            this.rpHoaDon.TabIndex = 0;
            this.rpHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 509);
            this.Controls.Add(this.rpHoaDon);
            this.Name = "ThongTinHoaDon";
            this.Text = "ThongTinHoaDon";
            this.Load += new System.EventHandler(this.ThongTinHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpHoaDon;
        private HoaDonBan HoaDonBan1;
    }
}