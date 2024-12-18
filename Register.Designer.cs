namespace Phone_Store
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label3 = new Label();
            txbPass = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            txbUsername = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbUsername);
            panel1.Location = new Point(6, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 77);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(100, 40);
            label5.Name = "label5";
            label5.Size = new Size(185, 23);
            label5.TabIndex = 8;
            label5.Text = " Enter your user name";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(5, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 436);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 836);
            Controls.Add(groupBox1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private TextBox txbPass;
        private Panel panel1;
        private Label label5;
        private Label label2;
        private TextBox txbUsername;
        private GroupBox groupBox1;
        private Button button1;
    }
}