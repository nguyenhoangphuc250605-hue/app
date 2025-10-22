using System;
using System.Windows.Forms;

namespace app
{
    public partial class FormRegister : Form
    {
        // ✅ Thuộc tính để Form1 đọc dữ liệu
        public string Username => txtUsername.Text.Trim();
        public string Password => txtPassword.Text.Trim();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Username == "" || Password == "" || txtConfirm.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Password != txtConfirm.Text.Trim())
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Trả kết quả OK để Form1 biết đã nhập hợp lệ
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // ✅ Trả về Cancel nếu nhấn quay lại
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
