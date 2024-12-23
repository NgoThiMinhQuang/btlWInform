using System;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class Login : Form

    {
        Data data = new Data();
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbbRole.Items.Clear();
            cbbRole.Items.Add("Nhân viên");
            cbbRole.Items.Add("Admin");
            cbbRole.SelectedIndex = 0;

            txbPass.PasswordChar = '*';
            Showpassword.Visible = false;

            txbUser.Focus();

        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            Showpassword.Visible = true;
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            Showpassword.Visible = false;
        }

        private void inkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPass rs = new ResetPass();
            rs.Show();
            this.Hide();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            Regiter rg = new Regiter();
            rg.Show();
            this.Hide();
        }
        private bool loginfail = false;
        private void Loginbtnn_Click(object sender, EventArgs e)
        {
            if (txbUser.Text != "" && txbPass.Text != "")
            {
                if (data.checklogin(txbUser.Text, txbPass.Text, cbbRole.Text))
                {
                    loginfail = false;
                    MessageBox.Show("Đăng nhập thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    loginfail = true;
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUser.Focus();
                return;
            }
        }


        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (loginfail && e.KeyCode == Keys.Back)
            {
                txbPass.Clear();
                e.Handled = true; // Ngăn chặn xử lý mặc định của phím Backspace
                loginfail = false; // Reset trạng thái
            }
        }
        private bool showpass = true;
        private void Showpassword_Click(object sender, EventArgs e)
        {
            showpass = !showpass;
            if(showpass)
            {
                MessageBox.Show("Mật khẩu của bạn là: " + txbPass.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbPass.PasswordChar = '\0';
            }
            else
            {
                txbPass.UseSystemPasswordChar = true;
                txbPass.PasswordChar = '*';
            }
            Showpassword.Image = showpass ? Properties.Resources.eye_open : Properties.Resources.eye_close;
        }
    }
}
