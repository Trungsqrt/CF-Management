namespace Cafe_Management
{
    partial class frm_Table_mgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Table_mgmt));
            this.menuStrip_Cfmgmt = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_CFmgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.numeric_Add = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Discount = new System.Windows.Forms.Button();
            this.btn_TbSwitch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip_Cfmgmt.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Add)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Cfmgmt
            // 
            this.menuStrip_Cfmgmt.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_Cfmgmt.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_Cfmgmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.ToolStripMenu_CFmgmt});
            this.menuStrip_Cfmgmt.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Cfmgmt.Name = "menuStrip_Cfmgmt";
            this.menuStrip_Cfmgmt.Size = new System.Drawing.Size(1229, 33);
            this.menuStrip_Cfmgmt.TabIndex = 0;
            this.menuStrip_Cfmgmt.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // ToolStripMenu_CFmgmt
            // 
            this.ToolStripMenu_CFmgmt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.ToolStripMenu_CFmgmt.Name = "ToolStripMenu_CFmgmt";
            this.ToolStripMenu_CFmgmt.Size = new System.Drawing.Size(93, 29);
            this.ToolStripMenu_CFmgmt.Text = "Account";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logoutToolStripMenuItem.Text = "Log out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 601);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.numeric_Add);
            this.panel2.Location = new System.Drawing.Point(717, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 100);
            this.panel2.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(18, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(328, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(18, 15);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(328, 28);
            this.comboBox.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Add.Location = new System.Drawing.Point(361, 47);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(118, 34);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // numeric_Add
            // 
            this.numeric_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numeric_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numeric_Add.Location = new System.Drawing.Point(361, 15);
            this.numeric_Add.Name = "numeric_Add";
            this.numeric_Add.Size = new System.Drawing.Size(118, 26);
            this.numeric_Add.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(717, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 389);
            this.panel3.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(461, 354);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.btn_Discount);
            this.panel4.Controls.Add(this.btn_TbSwitch);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.btn_Payment);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Location = new System.Drawing.Point(717, 550);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 100);
            this.panel4.TabIndex = 4;
            // 
            // btn_Discount
            // 
            this.btn_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btn_Discount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Discount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Discount.Location = new System.Drawing.Point(228, 49);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Size = new System.Drawing.Size(118, 34);
            this.btn_Discount.TabIndex = 7;
            this.btn_Discount.Text = "Discount";
            this.btn_Discount.UseVisualStyleBackColor = false;
            // 
            // btn_TbSwitch
            // 
            this.btn_TbSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btn_TbSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TbSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TbSwitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TbSwitch.Location = new System.Drawing.Point(18, 49);
            this.btn_TbSwitch.Name = "btn_TbSwitch";
            this.btn_TbSwitch.Size = new System.Drawing.Size(192, 34);
            this.btn_TbSwitch.TabIndex = 6;
            this.btn_TbSwitch.Text = "Switch table";
            this.btn_TbSwitch.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btn_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Payment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Payment.Location = new System.Drawing.Point(361, 17);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(118, 66);
            this.btn_Payment.TabIndex = 3;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericUpDown1.Location = new System.Drawing.Point(230, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(116, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // frm_Table_mgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1229, 662);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip_Cfmgmt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Cfmgmt;
            this.Name = "frm_Table_mgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe management system";
            this.menuStrip_Cfmgmt.ResumeLayout(false);
            this.menuStrip_Cfmgmt.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Add)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Cfmgmt;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_CFmgmt;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.NumericUpDown numeric_Add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Discount;
        private System.Windows.Forms.Button btn_TbSwitch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}