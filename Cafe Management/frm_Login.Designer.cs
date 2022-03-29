using System.Drawing;

namespace Cafe_Management
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 215);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.cb_ShowPass);
            this.panel3.Controls.Add(this.txt_Password);
            this.panel3.Controls.Add(this.lbl_Pass);
            this.panel3.Location = new System.Drawing.Point(14, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 76);
            this.panel3.TabIndex = 2;
            // 
            // cb_ShowPass
            // 
            this.cb_ShowPass.AutoSize = true;
            this.cb_ShowPass.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cb_ShowPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_ShowPass.Location = new System.Drawing.Point(448, 31);
            this.cb_ShowPass.Name = "cb_ShowPass";
            this.cb_ShowPass.Size = new System.Drawing.Size(147, 24);
            this.cb_ShowPass.TabIndex = 2;
            this.cb_ShowPass.Text = "Show password";
            this.cb_ShowPass.UseVisualStyleBackColor = true;
            this.cb_ShowPass.CheckedChanged += new System.EventHandler(this.cb_ShowPass_CheckedChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.AcceptsTab = true;
            this.txt_Password.Location = new System.Drawing.Point(159, 26);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(283, 26);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Text = "Input password";
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Pass.Location = new System.Drawing.Point(18, 29);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(78, 20);
            this.lbl_Pass.TabIndex = 0;
            this.lbl_Pass.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.txt_Account);
            this.panel2.Controls.Add(this.lbl_Account);
            this.panel2.Location = new System.Drawing.Point(14, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 76);
            this.panel2.TabIndex = 0;
            // 
            // txt_Account
            // 
            this.txt_Account.AcceptsTab = true;
            this.txt_Account.Location = new System.Drawing.Point(159, 26);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(283, 26);
            this.txt_Account.TabIndex = 0;
            this.txt_Account.Text = "Input username";
            this.txt_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Account.Location = new System.Drawing.Point(18, 29);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(89, 20);
            this.lbl_Account.TabIndex = 0;
            this.lbl_Account.Text = "User Name";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Login.Image = global::Cafe_Management.Properties.Resources.icon_login;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(149, 249);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(142, 58);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Image = global::Cafe_Management.Properties.Resources.icon_exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(397, 249);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(142, 58);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(696, 319);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cb_ShowPass;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
    }
}