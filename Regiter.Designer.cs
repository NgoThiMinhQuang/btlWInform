﻿namespace Phone_Store
{
    partial class Regiter
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Caplocks = new System.Windows.Forms.PictureBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Createbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caplocks)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.Createbtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 436);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Caplocks);
            this.panel5.Controls.Add(this.tbxPass);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(6, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 77);
            this.panel5.TabIndex = 4;
            // 
            // Caplocks
            // 
            this.Caplocks.BackColor = System.Drawing.SystemColors.Window;
            this.Caplocks.Image = global::Phone_Store.Properties.Resources.capslock_icon;
            this.Caplocks.Location = new System.Drawing.Point(358, 35);
            this.Caplocks.Name = "Caplocks";
            this.Caplocks.Size = new System.Drawing.Size(32, 30);
            this.Caplocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Caplocks.TabIndex = 67;
            this.Caplocks.TabStop = false;
            // 
            // tbxPass
            // 
            this.tbxPass.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.tbxPass.Location = new System.Drawing.Point(88, 35);
            this.tbxPass.Multiline = true;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(306, 34);
            this.tbxPass.TabIndex = 1;
            this.tbxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPass_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Password";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbRole);
            this.panel4.Location = new System.Drawing.Point(6, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 77);
            this.panel4.TabIndex = 3;
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(88, 25);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(302, 29);
            this.cbbRole.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbUsername);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(469, 77);
            this.panel6.TabIndex = 0;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(88, 35);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(306, 34);
            this.txbUsername.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "UserName ";
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createbtn.ForeColor = System.Drawing.Color.White;
            this.Createbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Createbtn.Location = new System.Drawing.Point(160, 304);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(178, 45);
            this.Createbtn.TabIndex = 2;
            this.Createbtn.Text = "Create new account";
            this.Createbtn.UseVisualStyleBackColor = false;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(165, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Regiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 836);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Regiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regiter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Regiter_FormClosing);
            this.Load += new System.EventHandler(this.Regiter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Regiter_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caplocks)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox Caplocks;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}