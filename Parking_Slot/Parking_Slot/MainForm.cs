using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Slot
{
    public partial class MainForm : Form
    {

        private InOutLane form ;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the window state to maximized
            this.WindowState = FormWindowState.Maximized;
            // Remove window borders
            //this.FormBorderStyle = FormBorderStyle.None;

            this.Shown += LoginForm_Shown;
            form = new InOutLane();

            quanLyDangNhap1.Hide();
            danhSachTheXe1.Hide();
            xeGuiNhieuNgay1.Hide();
            nhatKyXuLyMatThe1.Hide();
            thietLapLoaiVe1.Hide();
            danhSachKhachHang1.Hide();
            lanXeRaVao1.Hide();
            thongKe1.Hide();
            lichSuRaVao1.Hide();
           
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Access the username property from the login form
                string username = loginForm.User.user_name;
                // Do something with the username
                //MessageBox.Show($"Welcome, {username}!");
                welcome_lb.Text = "Welcome, "+ username;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Update the size of the panel to match the form's width
            //sideMenuPanel.Width = this.ClientSize.Width;

            // You can adjust the height of the panel here if needed
            panel1.Height = this.ClientSize.Height;
            pictureBox1.Width = panel1.Width;
            panel2.Width = this.ClientSize.Width;
            lanXeRaVao1.Height = this.ClientSize.Height;
            lanXeRaVao1.Width = this.ClientSize.Width;

            lichSuRaVao1.Height = this.ClientSize.Height;
            lichSuRaVao1.Width = this.ClientSize.Width;

            thongKe1.Height = this.ClientSize.Height;
            thongKe1.Width = this.ClientSize.Width;

            xeGuiNhieuNgay1.Height = this.ClientSize.Height;
            xeGuiNhieuNgay1.Width = this.ClientSize.Width;

            nhatKyXuLyMatThe1.Height = this.ClientSize.Height;
            nhatKyXuLyMatThe1.Width = this.ClientSize.Width;

            thietLapLoaiVe1.Height = this.ClientSize.Height;
            thietLapLoaiVe1.Width = this.ClientSize.Width;

            danhSachKhachHang1.Height = this.ClientSize.Height;
            danhSachKhachHang1.Width = this.ClientSize.Width;

            danhSachTheXe1.Height = this.ClientSize.Height;
            danhSachTheXe1.Width = this.ClientSize.Width;

            quanLyDangNhap1.Height = this.ClientSize.Height;
            quanLyDangNhap1.Width = this.ClientSize.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (form.IsDisposed)
            {
                form = new InOutLane();
            }
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quanLyDangNhap1.Hide();
            danhSachTheXe1.Hide();
            xeGuiNhieuNgay1.Hide();
            nhatKyXuLyMatThe1.Hide();
            thietLapLoaiVe1.Hide();
            danhSachKhachHang1.Hide();
            lanXeRaVao1.Hide();
            thongKe1.Hide();
            lichSuRaVao1.Show();
            lichSuRaVao1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            quanLyDangNhap1.Hide();
            danhSachTheXe1.Hide();
            xeGuiNhieuNgay1.Hide();
            nhatKyXuLyMatThe1.Hide();
            thietLapLoaiVe1.Hide();
            danhSachKhachHang1.Hide();
            lanXeRaVao1.Hide();
            lichSuRaVao1.Hide();
            thongKe1.Show();
            thongKe1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            quanLyDangNhap1.Hide();
            danhSachTheXe1.Hide();
            thongKe1.Hide();
            nhatKyXuLyMatThe1.Hide();
            thietLapLoaiVe1.Hide();
            danhSachKhachHang1.Hide();
            lanXeRaVao1.Hide();
            lichSuRaVao1.Hide();
            xeGuiNhieuNgay1.Show();
            xeGuiNhieuNgay1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            quanLyDangNhap1.Hide();
            danhSachTheXe1.Hide();
            thongKe1.Hide();
            xeGuiNhieuNgay1.Hide();
            thietLapLoaiVe1.Hide();
            danhSachKhachHang1.Hide();
            lanXeRaVao1.Hide();
            lichSuRaVao1.Hide();
            nhatKyXuLyMatThe1.Show();
            nhatKyXuLyMatThe1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            quanLyDangNhap1.Hide();
            danhSachTheXe1.Hide();
            thongKe1.Hide();
            xeGuiNhieuNgay1.Hide();
            nhatKyXuLyMatThe1.Hide();
            danhSachKhachHang1.Hide();
            lanXeRaVao1.Hide();
            lichSuRaVao1.Hide();
            thietLapLoaiVe1.Show();
            thietLapLoaiVe1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            quanLyDangNhap1.Hide();
            danhSachTheXe1.Hide();
            thongKe1.Hide();
            xeGuiNhieuNgay1.Hide();
            nhatKyXuLyMatThe1.Hide();
            thietLapLoaiVe1.Hide();
            lanXeRaVao1.Hide();
            lichSuRaVao1.Hide();
            danhSachKhachHang1.Show();
            danhSachKhachHang1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            quanLyDangNhap1.Hide();
            danhSachKhachHang1.Hide();
            thongKe1.Hide();
            xeGuiNhieuNgay1.Hide();
            nhatKyXuLyMatThe1.Hide();
            thietLapLoaiVe1.Hide();
            lanXeRaVao1.Hide();
            lichSuRaVao1.Hide();
            danhSachTheXe1.Show();
            danhSachTheXe1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            danhSachTheXe1.Hide();
            danhSachKhachHang1.Hide();
            thongKe1.Hide();
            xeGuiNhieuNgay1.Hide();
            nhatKyXuLyMatThe1.Hide();
            thietLapLoaiVe1.Hide();
            lanXeRaVao1.Hide();
            lichSuRaVao1.Hide();
            quanLyDangNhap1.Show();
            quanLyDangNhap1.BringToFront();
        }
    }
}
