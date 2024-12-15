namespace Phone_Store
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            txbPass = new TextBox();
            loginbtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            txbUsername = new TextBox();
            inkForgotPass = new LinkLabel();
            groupBox1 = new GroupBox();
            label4 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 153, 153);
            label1.Location = new Point(166, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 80);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txbPass);
            panel2.Location = new Point(6, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 86);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 9);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // txbPass
            // 
            txbPass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPass.Location = new Point(88, 35);
            txbPass.Multiline = true;
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(306, 34);
            txbPass.TabIndex = 2;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(0, 172, 230);
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(94, 236);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(306, 72);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "LOGIN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbUsername);
            panel1.Location = new Point(6, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 77);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 9);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 0;
            label2.Text = "UserName ";
            // 
            // txbUsername
            // 
            txbUsername.BackColor = SystemColors.Window;
            txbUsername.Font = new Font("Times New Roman", 13.8F);
            txbUsername.Location = new Point(88, 35);
            txbUsername.Multiline = true;
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(306, 34);
            txbUsername.TabIndex = 1;
            // 
            // inkForgotPass
            // 
            inkForgotPass.AutoSize = true;
            inkForgotPass.Location = new Point(94, 200);
            inkForgotPass.Name = "inkForgotPass";
            inkForgotPass.Size = new Size(178, 23);
            inkForgotPass.TabIndex = 3;
            inkForgotPass.TabStop = true;
            inkForgotPass.Text = "Forgotten password?";
            inkForgotPass.LinkClicked += inkForgotPass_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(inkForgotPass);
            groupBox1.Controls.Add(loginbtn);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(15, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 436);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(222, 328);
            label4.Name = "label4";
            label4.Size = new Size(40, 28);
            label4.TabIndex = 7;
            label4.Text = "OR";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 183, 42);
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(151, 371);
            button1.Name = "button1";
            button1.Size = new Size(178, 45);
            button1.TabIndex = 5;
            button1.Text = "Create new account";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 883);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox txbPass;
        private Button loginbtn;
        private Panel panel1;
        private Label label2;
        private TextBox txbUsername;
        private LinkLabel inkForgotPass;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
    }
}
