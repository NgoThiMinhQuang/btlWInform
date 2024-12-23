using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            tbxPass.PasswordChar = '\0';
            Showpassword.Visible = false;
            Caplocks.Visible = false;
            CheckCapsLock();
            txbUser.Focus();

        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            Showpassword.Visible = true;
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (!Showpassword.ClientRectangle.Contains(Showpassword.PointToClient(Control.MousePosition)))
            {
                Showpassword.Visible = false;
            }
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
           
        }


        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            CheckCapsLock();
        }
        private bool showpass = false;
        private void Showpassword_Click(object sender, EventArgs e)
        {
            showpass = !showpass;
            tbxPass.PasswordChar = showpass ? '\0' : '*';
            Showpassword.Image = showpass ? Properties.Resources.eye_open : Properties.Resources.eye_close;
        }
        private void CheckCapsLock()
        {
            // Thêm debug để kiểm tra
            bool isCapsLockOn = Control.IsKeyLocked(Keys.CapsLock);
            Console.WriteLine($"Caps Lock is: {isCapsLockOn}");  // Debug line

            Caplocks.Visible = isCapsLockOn;

            // Đảm bảo PictureBox được hiển thị đúng
            if (isCapsLockOn)
            {
                Caplocks.BringToFront();
            }
        }


    }
}
