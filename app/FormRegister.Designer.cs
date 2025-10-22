namespace app
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirm;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Button btnRegister;
        private Button btnBack;
        private Panel panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirm = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblUsername);
            panelMain.Controls.Add(lblPassword);
            panelMain.Controls.Add(lblConfirm);
            panelMain.Controls.Add(txtUsername);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(txtConfirm);
            panelMain.Controls.Add(btnRegister);
            panelMain.Controls.Add(btnBack);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 4, 4, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(625, 500);
            panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(625, 112);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(52, 73, 94);
            lblUsername.Location = new Point(23, 144);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(174, 32);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên tài khoản:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(52, 73, 94);
            lblPassword.Location = new Point(23, 206);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(128, 32);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.FromArgb(52, 73, 94);
            lblConfirm.Location = new Point(23, 269);
            lblConfirm.Margin = new Padding(4, 0, 4, 0);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(239, 32);
            lblConfirm.TabIndex = 3;
            lblConfirm.Text = "Xác nhận mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(300, 144);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 39);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(300, 206);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(224, 39);
            txtPassword.TabIndex = 5;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 12F);
            txtConfirm.Location = new Point(300, 269);
            txtConfirm.Margin = new Padding(4, 4, 4, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '•';
            txtConfirm.Size = new Size(224, 39);
            txtConfirm.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(52, 152, 219);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(162, 350);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(138, 56);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(231, 76, 60);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(325, 350);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 56);
            btnBack.TabIndex = 8;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 500);
            Controls.Add(panelMain);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }
    }
}
