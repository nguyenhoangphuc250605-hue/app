namespace app
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnAccount;
        private Button btnExit;
        private Label lblUser;
        private Label lblPass;
        private Panel pnlCard;
        private Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlCard = new Panel();
            button1 = new Button();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnAccount = new Button();
            btnExit = new Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(687, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WORDLE";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(button1);
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblPass);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(btnAccount);
            pnlCard.Location = new Point(122, 73);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(394, 259);
            pnlCard.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(138, 218);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Chơi game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(30, 30);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(120, 23);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nhập tên đăng nhập";
            txtUsername.Size = new Size(350, 31);
            txtUsername.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.Location = new Point(30, 95);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(100, 23);
            lblPass.TabIndex = 2;
            lblPass.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Nhập mật khẩu";
            txtPassword.Size = new Size(350, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(86, 153, 255);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 165);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(102, 204, 153);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(150, 165);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(255, 193, 7);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(270, 165);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(100, 35);
            btnAccount.TabIndex = 6;
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(240, 80, 80);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(420, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 30);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(687, 372);
            Controls.Add(lblTitle);
            Controls.Add(pnlCard);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game - Form Đăng Nhập";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        // ✅ Sự kiện khi bấm "Quên mật khẩu"
        private void btnForgot_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập trước khi khôi phục mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!accounts.ContainsKey(user))
            {
                MessageBox.Show("Tên đăng nhập không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ở đây: bạn có thể cho người dùng nhập email hoặc gửi mã, hoặc đặt lại mật khẩu.
            // Mẫu đơn giản: hỏi người dùng nhập mật khẩu mới rồi lưu lại.
            string newPass = Microsoft.VisualBasic.Interaction.InputBox(
                $"Nhập mật khẩu mới cho tài khoản \"{user}\":",
                "Đặt lại mật khẩu",
                "");

            if (string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Mật khẩu mới không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật mật khẩu
            accounts[user] = newPass;
            SaveAccounts();

            MessageBox.Show("Đặt lại mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
