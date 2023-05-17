namespace QuanLyBanHang
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuchatlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnukhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadonban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufindhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufindhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufindkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhangton = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile,
            this.mnudanhmuc,
            this.mnuhoadon,
            this.mnutimkiem,
            this.mnubaocao,
            this.mnutrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuthoat});
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(56, 20);
            this.mnufile.Text = "Tập tin";
            // 
            // mnuthoat
            // 
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(152, 22);
            this.mnuthoat.Text = "Thoát";
            this.mnuthoat.Click += new System.EventHandler(this.mnuthoat_Click);
            // 
            // mnudanhmuc
            // 
            this.mnudanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuchatlieu,
            this.mnunhanvien,
            this.mnukhachhang,
            this.mnuhanghoa});
            this.mnudanhmuc.Name = "mnudanhmuc";
            this.mnudanhmuc.Size = new System.Drawing.Size(74, 20);
            this.mnudanhmuc.Text = "Danh Mục";
            // 
            // mnuchatlieu
            // 
            this.mnuchatlieu.Name = "mnuchatlieu";
            this.mnuchatlieu.Size = new System.Drawing.Size(152, 22);
            this.mnuchatlieu.Text = "Chất liệu";
            this.mnuchatlieu.Click += new System.EventHandler(this.mnuchatlieu_Click);
            // 
            // mnunhanvien
            // 
            this.mnunhanvien.Name = "mnunhanvien";
            this.mnunhanvien.Size = new System.Drawing.Size(152, 22);
            this.mnunhanvien.Text = "Nhân Viên";
            this.mnunhanvien.Click += new System.EventHandler(this.mnunhanvien_Click);
            // 
            // mnukhachhang
            // 
            this.mnukhachhang.Name = "mnukhachhang";
            this.mnukhachhang.Size = new System.Drawing.Size(152, 22);
            this.mnukhachhang.Text = "Khách Hàng";
            // 
            // mnuhanghoa
            // 
            this.mnuhanghoa.Name = "mnuhanghoa";
            this.mnuhanghoa.Size = new System.Drawing.Size(152, 22);
            this.mnuhanghoa.Text = "Hàng hóa";
            // 
            // mnuhoadon
            // 
            this.mnuhoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhoadonban});
            this.mnuhoadon.Name = "mnuhoadon";
            this.mnuhoadon.Size = new System.Drawing.Size(65, 20);
            this.mnuhoadon.Text = "Hóa đơn";
            // 
            // mnuhoadonban
            // 
            this.mnuhoadonban.Name = "mnuhoadonban";
            this.mnuhoadonban.Size = new System.Drawing.Size(152, 22);
            this.mnuhoadonban.Text = "Hóa đơn bán";
            // 
            // mnutimkiem
            // 
            this.mnutimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufindhoadon,
            this.mnufindhang,
            this.mnufindkhachhang});
            this.mnutimkiem.Name = "mnutimkiem";
            this.mnutimkiem.Size = new System.Drawing.Size(69, 20);
            this.mnutimkiem.Text = "Tìm kiếm";
            // 
            // mnufindhoadon
            // 
            this.mnufindhoadon.Name = "mnufindhoadon";
            this.mnufindhoadon.Size = new System.Drawing.Size(152, 22);
            this.mnufindhoadon.Text = "Hóa đơn";
            // 
            // mnufindhang
            // 
            this.mnufindhang.Name = "mnufindhang";
            this.mnufindhang.Size = new System.Drawing.Size(152, 22);
            this.mnufindhang.Text = "Hàng";
            // 
            // mnufindkhachhang
            // 
            this.mnufindkhachhang.Name = "mnufindkhachhang";
            this.mnufindkhachhang.Size = new System.Drawing.Size(152, 22);
            this.mnufindkhachhang.Text = "Khách hàng";
            // 
            // mnubaocao
            // 
            this.mnubaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhangton,
            this.mnudoanhthu});
            this.mnubaocao.Name = "mnubaocao";
            this.mnubaocao.Size = new System.Drawing.Size(61, 20);
            this.mnubaocao.Text = "Báo cáo";
            // 
            // mnuhangton
            // 
            this.mnuhangton.Name = "mnuhangton";
            this.mnuhangton.Size = new System.Drawing.Size(152, 22);
            this.mnuhangton.Text = "Hàng tồn";
            // 
            // mnudoanhthu
            // 
            this.mnudoanhthu.Name = "mnudoanhthu";
            this.mnudoanhthu.Size = new System.Drawing.Size(152, 22);
            this.mnudoanhthu.Text = "Doanh thu ";
            // 
            // mnutrogiup
            // 
            this.mnutrogiup.Name = "mnutrogiup";
            this.mnutrogiup.Size = new System.Drawing.Size(64, 20);
            this.mnutrogiup.Text = "Trợ giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 285);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnufile;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuchatlieu;
        private System.Windows.Forms.ToolStripMenuItem mnunhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnukhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuhanghoa;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadonban;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnufindhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnufindhang;
        private System.Windows.Forms.ToolStripMenuItem mnufindkhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnubaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuhangton;
        private System.Windows.Forms.ToolStripMenuItem mnudoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnutrogiup;
    }
}