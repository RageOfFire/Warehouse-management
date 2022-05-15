using System;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using Controller;
using System.Data;

namespace View
{
    public partial class Login : Form
    {
        ControllerLogin login = new ControllerLogin();
        public Login()
        {
            InitializeComponent();
        }

        //Thực hiện đăng nhập khi người dùng ấn nút đăng nhập
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameBox.Text))
            {
                PoisonMessageBox.Show(this, "Cần nhập tên người dùng", "Quản lý kho hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                PoisonMessageBox.Show(this, "Cần nhập mật khẩu", "Quản lý kho hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DataTable dt = login.Login(this.UsernameBox.Text, this.PasswordBox.Text);
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        Warehouse wh = new Warehouse();
                        wh.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        PoisonMessageBox.Show(this, "Đăng nhập thất bại!\nKiểm tra lại tài khoản và mật khẩu", "Quản lý kho hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    PoisonMessageBox.Show(this, "Error" + ex, "Quản lý kho hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
