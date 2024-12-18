namespace Phone_Store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }




        private void inkForgotPass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetP resetP = new ResetP();

            resetP.ShowDialog();
            this.Hide();

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }
    }
}

