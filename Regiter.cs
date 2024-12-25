using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class Regiter : Form
    {
        public Regiter()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Regiter_KeyDown;
        }
        Data data = new Data();


        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Regiter_Load(object sender, EventArgs e)
        {
            cbbRole.Items.Clear();

            // Tạo list để chứa roles từ database
            List<string> roles = new List<string>();
            data.Loadrole(roles);               // Gọi hàm Loadrole từ class Data

            roles.Sort();
            //sap xep role theo thu tu abc

            // Thêm các role vào combobox
            foreach (string role in roles)
            {
                cbbRole.Items.Add(role);
            }

            // Set index mặc định  ( 0 = Admin, 1 = Nhân viên)
            if (cbbRole.Items.Count > 0)
            {
                cbbRole.SelectedIndex = 1;
            }

            toolTip1.SetToolTip(Caplocks, "CapsLock is on");

            Caplocks.Visible = false; //mac dinh an caplocks

            tbxPass.KeyDown += tbxPass_KeyDown; // Khi nhấn phím trong textbox password

            txbUsername.Focus();
        }

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra trạng thái Caps Lock
            bool capsLock = (Control.IsKeyLocked(Keys.CapsLock));

            // Hiển thị/ẩn biểu tượng Caps Lock
            if (capsLock)
            {
                Caplocks.Visible = true;
                Caplocks.BringToFront();
            }
            else
            {
                Caplocks.Visible = false;
            }
        }

        private void Regiter_KeyDown(object sender, KeyEventArgs e)
        {
            bool capsLock = (Control.IsKeyLocked(Keys.CapsLock));
            Caplocks.Visible = capsLock;
            if (capsLock)
            {
                Caplocks.BringToFront();
            }
        }

        private void Regiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                // Nếu người dùng chọn "No", hủy việc đóng form
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
