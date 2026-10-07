using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyVatTu
{
    public partial class Form1 : Form
    {
        private Panel panelLeft;
        private Panel panelRight;
        private Label lblTitleBrand;
        private Label lblTitleLogin;
        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnShowHidePass;
        private Button btnLogin;
        private Button btnExit;

        public Form1()
        {
            InitializeComponent();
            SetupModernUI();
        }

        private void SetupModernUI()
        {
            // 1. Cấu hình Form chính
            this.Size = new Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            // ==========================================
            // 2. PANEL TRÁI (Khu vực Logo)
            // ==========================================
            panelLeft = new Panel();
            panelLeft.Size = new Size(350, 450);
            panelLeft.Location = new Point(0, 0);
            panelLeft.BackColor = Color.FromArgb(28, 43, 77);

            lblTitleBrand = new Label();
            lblTitleBrand.Text = "HỆ THỐNG\nQUẢN LÝ KHO VẬT TƯ";
            lblTitleBrand.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitleBrand.ForeColor = Color.White;
            lblTitleBrand.AutoSize = true;
            // Đã đẩy tọa độ Y từ 150 lên 100 để chữ dịch lên trên, tạo sự cân đối
            lblTitleBrand.Location = new Point(50, 100);
            panelLeft.Controls.Add(lblTitleBrand);

            // ==========================================
            // 3. PANEL PHẢI (Khu vực Đăng nhập)
            // ==========================================
            panelRight = new Panel();
            panelRight.Size = new Size(450, 450);
            panelRight.Location = new Point(350, 0);
            panelRight.BackColor = Color.FromArgb(37, 37, 38);

            lblTitleLogin = new Label();
            lblTitleLogin.Text = "ĐĂNG NHẬP";
            lblTitleLogin.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitleLogin.ForeColor = Color.White;
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.Location = new Point(130, 50);

            // TÀI KHOẢN
            lblUser = new Label();
            lblUser.Text = "Tên đăng nhập:";
            lblUser.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblUser.ForeColor = Color.LightGray;
            lblUser.Location = new Point(60, 130);
            lblUser.AutoSize = true;

            txtUser = new TextBox();
            txtUser.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtUser.Location = new Point(60, 160);
            txtUser.Width = 330;
            txtUser.BackColor = Color.FromArgb(50, 50, 52);
            txtUser.ForeColor = Color.White;
            txtUser.BorderStyle = BorderStyle.FixedSingle;

            // MẬT KHẨU
            lblPass = new Label();
            lblPass.Text = "Mật khẩu:";
            lblPass.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblPass.ForeColor = Color.LightGray;
            lblPass.Location = new Point(60, 220);
            lblPass.AutoSize = true;

            txtPass = new TextBox();
            txtPass.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtPass.Location = new Point(60, 250);
            txtPass.Width = 270;
            txtPass.BackColor = Color.FromArgb(50, 50, 52);
            txtPass.ForeColor = Color.White;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.PasswordChar = '•';

            // NÚT HIỆN/ẨN MẬT KHẨU (CON MẮT)
            btnShowHidePass = new Button();
            btnShowHidePass.Text = "Hiện";
            btnShowHidePass.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnShowHidePass.Location = new Point(335, 250);
            btnShowHidePass.Size = new Size(55, 33);
            btnShowHidePass.FlatStyle = FlatStyle.Flat;
            btnShowHidePass.FlatAppearance.BorderColor = Color.Gray;
            btnShowHidePass.BackColor = Color.FromArgb(50, 50, 52);
            btnShowHidePass.ForeColor = Color.LightGray;
            btnShowHidePass.Cursor = Cursors.Hand;
            btnShowHidePass.Click += BtnShowHidePass_Click;

            // NÚT ĐĂNG NHẬP
            btnLogin = new Button();
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnLogin.Location = new Point(60, 320);
            btnLogin.Size = new Size(330, 45);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(0, 190, 150);
            btnLogin.ForeColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Click += BtnLogin_Click;

            // NÚT THOÁT
            btnExit = new Button();
            btnExit.Text = "THOÁT";
            btnExit.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnExit.Location = new Point(60, 380);
            btnExit.Size = new Size(330, 45);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderColor = Color.Gray;
            btnExit.BackColor = Color.Transparent;
            btnExit.ForeColor = Color.LightGray;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Click += BtnExit_Click;

            // Nạp các phần tử vào Panel Phải
            panelRight.Controls.Add(lblTitleLogin);
            panelRight.Controls.Add(lblUser);
            panelRight.Controls.Add(txtUser);
            panelRight.Controls.Add(lblPass);
            panelRight.Controls.Add(txtPass);
            panelRight.Controls.Add(btnShowHidePass);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(btnExit);

            // Nạp 2 Panel vào Form
            this.Controls.Add(panelLeft);
            this.Controls.Add(panelRight);
        }

        // ==========================================
        // CÁC HÀM XỬ LÝ SỰ KIỆN (CLICK)
        // ==========================================

        private void BtnShowHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                btnShowHidePass.Text = "Ẩn";
            }
            else
            {
                txtPass.PasswordChar = '•';
                btnShowHidePass.Text = "Hiện";
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user == "admin" && pass == "123")
            {
                // 1. Ẩn form đăng nhập hiện tại
                this.Hide();

                // 2. Khởi tạo form trang chủ
                frmTrangChu fTrangChu = new frmTrangChu();

                // 3. Đảm bảo khi tắt form trang chủ thì tắt hẳn phần mềm trong Task Manager
                fTrangChu.FormClosed += (s, args) => this.Close();

                // 4. Mở form trang chủ lên
                fTrangChu.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại hỏi người dùng với 2 nút Yes / No
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát phần mềm không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kiểm tra nếu người dùng bấm nút Yes (Đồng ý) thì mới tắt phần mềm
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}