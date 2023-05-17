﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using QuanLyBanHang.Class; //Sử dụng class Functions.cs


namespace QuanLyBanHang
{
    public partial class frmDMChatlieu : Form
    {
        //Khai báo biến toàn cục
        DataTable tblCL; //Chứa dữ liệu bảng Chất liệu
        public frmDMChatlieu()
        {
            InitializeComponent();
        }
        //LoadDataGridView có tác dụng lấy dữ liệu từ bảng tblChatlieu đổ vào DataGridView
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT Machatlieu, Tenchatlieu FROM tblChatlieu";
            tblCL = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng - GetDatatable đc viết trong Funtions.cs
            dataGridView.DataSource = tblCL; //Nguồn dữ liệu            
            dataGridView.Columns[0].HeaderText = "Mã chất liệu";
            dataGridView.Columns[1].HeaderText = "Mã chất liệu";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 300;
            dataGridView.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void frmDMChatlieu_Load(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatlieu
        }
        //----------------------------------------------------------------------------------
       

        //----------------------------------------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMachatlieu.Enabled = true; //cho phép nhập mới
            txtMachatlieu.Focus();
        }
        private void ResetValue()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }
        //-------------------------------------------------------------------------------
        //Phương thức Lưu có tác dụng kiểm tra thông tin người dùng nhập vào các điều khiển trên Form trong trường hợp thêm mới và lưu các thông tin đó vào CSDL.
        //Với CheckKey và RunSQL là các phương thức được viết trong lớp Functions.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMachatlieu.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMachatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenchatlieu.Focus();
                return;
            }
            sql = "Select MaChatlieu From tblChatlieu where MaChatlieu=N'" + txtMachatlieu.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachatlieu.Focus();
                return;
            }

            sql = "INSERT INTO tblChatlieu VALUES(N'" +
                txtMachatlieu.Text + "',N'" + txtTenchatlieu.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachatlieu.Enabled = false;
        }
        //--------------------------------------------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblChatlieu WHERE Machatlieu=N'" + txtMachatlieu.Text + "'";
                Class.Functions.RunSqlDel(sql);//RunSqlDel được viết trong hàm Function.cs
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMachatlieu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMachatlieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenchatlieu.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblChatlieu SET Tenchatlieu=N'" +
                txtTenchatlieu.Text.ToString() +
                "' WHERE Machatlieu=N'" + txtMachatlieu.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnBoqua.Enabled = false;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("đây là sự kiện datagridview_click");
            //if (btnThem.Enabled == false)
            //{
            //    MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtMachatlieu.Focus();
            //    return;
            //}
            //if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            //{
            //    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //txtMachatlieu.Text = dataGridView.CurrentRow.Cells["Machatlieu"].Value.ToString();
            //txtTenchatlieu.Text = dataGridView.CurrentRow.Cells["Tenchatlieu"].Value.ToString();
            //btnSua.Enabled = true;
            //btnXoa.Enabled = true;
            //btnBoqua.Enabled = true;
           
        }

    }
}
