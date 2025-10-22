using app;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Text.Json;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> accounts = new();
        private string accountsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.json");
        private string? currentUser = null;

        public Form1()
        {
            InitializeComponent();
            LoadAccounts();
            UpdateAccountButton();
        }

        private void LoadAccounts()
        {
            try
            {
                if (File.Exists(accountsFile))
                {
                    var json = File.ReadAllText(accountsFile);
                    accounts = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new();
                }
            }
            catch { accounts = new(); }
        }

        private void SaveAccounts()
        {
            var json = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(accountsFile, json);
        }

        private void UpdateAccountButton()
        {
            btnAccount.Text = currentUser == null ? "Tài khoản" : $"Tài: {currentUser}";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập tên và mật khẩu.", "Thông báo");
                return;
            }
            if (accounts.ContainsKey(user) && accounts[user] == pass)
            {
                currentUser = user;
                UpdateAccountButton();
                MessageBox.Show($"Đăng nhập thành công, chào {user}!", "Thành công");
            }
            else MessageBox.Show("Sai tên hoặc mật khẩu!", "Lỗi");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var reg = new FormRegister())
            {
                if (reg.ShowDialog() == DialogResult.OK)
                {
                    string user = reg.Username;
                    string pass = reg.Password;
                    if (accounts.ContainsKey(user))
                        MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo");
                    else
                    {
                        accounts[user] = pass;
                        SaveAccounts();
                        MessageBox.Show("Đăng ký thành công!", "Thành công");
                    }
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (currentUser == null) MessageBox.Show("Chưa có người đăng nhập!");
            else MessageBox.Show($"Đang đăng nhập: {currentUser}");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi chơi!", "Thông báo");
                return;
            }

            this.Hide();
            FormGame game = new FormGame();
            game.Show();
        }
    }
}

