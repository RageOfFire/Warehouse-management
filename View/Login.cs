using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(UsernameBox.Text))
            {
                PoisonMessageBox.Show(this, "Cần nhập tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameBox.Focus();
            }
            else if(string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                PoisonMessageBox.Show(this, "Cần nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(UsernameBox.Text == "admin" && PasswordBox.Text == "123")
                {
                    PoisonMessageBox.Show(this, "Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Warehouse wh = new Warehouse();
                    wh.ShowDialog();
                    this.Close();
                }
                else
                {
                    PoisonMessageBox.Show(this, "Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
