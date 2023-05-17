﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuchatlieu_Click(object sender, EventArgs e)
        {
            frmDMChatlieu frmChatlieu = new frmDMChatlieu(); //Khởi tạo đối tượng
            frmChatlieu.ShowDialog(); //Hiển thị
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            frmDMNhanvien frmNhanvien = new frmDMNhanvien();
            frmNhanvien.ShowDialog();
        }
    }
}
