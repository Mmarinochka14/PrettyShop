namespace Db3
{
    partial class RegisterForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.regPanel = new System.Windows.Forms.Panel();
            this.RegBtn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LogiBtn = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.regPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 71);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Lavender;
            this.CloseButton.Location = new System.Drawing.Point(1166, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Minecraft 1.1", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogBox
            // 
            this.LogBox.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogBox.Location = new System.Drawing.Point(402, 218);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(257, 64);
            this.LogBox.TabIndex = 2;
            this.LogBox.MouseEnter += new System.EventHandler(this.LogBox_Enter);
            this.LogBox.MouseLeave += new System.EventHandler(this.LogBox_Leave);
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(402, 304);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(257, 64);
            this.PassBox.TabIndex = 2;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneBox.Location = new System.Drawing.Point(332, 395);
            this.PhoneBox.Multiline = true;
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(327, 64);
            this.PhoneBox.TabIndex = 2;
            this.PhoneBox.Enter += new System.EventHandler(this.PhoneBox_Enter);
            this.PhoneBox.Leave += new System.EventHandler(this.PhoneBox_Leave);
            this.PhoneBox.MouseEnter += new System.EventHandler(this.PhoneBox_Enter);
            this.PhoneBox.MouseLeave += new System.EventHandler(this.PhoneBox_Leave);
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.SystemColors.Window;
            this.AddressBox.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressBox.ForeColor = System.Drawing.Color.Lavender;
            this.AddressBox.Location = new System.Drawing.Point(332, 482);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(327, 64);
            this.AddressBox.TabIndex = 2;
            this.AddressBox.UseSystemPasswordChar = true;
            this.AddressBox.MouseEnter += new System.EventHandler(this.AddressBox_Enter);
            this.AddressBox.MouseLeave += new System.EventHandler(this.AddressBox_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Lavender;
            this.BtnLogin.Location = new System.Drawing.Point(332, 584);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(547, 84);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Зарегистрироваться";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // regPanel
            // 
            this.regPanel.AutoSize = true;
            this.regPanel.BackColor = System.Drawing.Color.Lavender;
            this.regPanel.Controls.Add(this.LogiBtn);
            this.regPanel.Controls.Add(this.pictureBox3);
            this.regPanel.Controls.Add(this.RegBtn);
            this.regPanel.Controls.Add(this.BtnLogin);
            this.regPanel.Controls.Add(this.AddressBox);
            this.regPanel.Controls.Add(this.PhoneBox);
            this.regPanel.Controls.Add(this.PassBox);
            this.regPanel.Controls.Add(this.LogBox);
            this.regPanel.Controls.Add(this.pictureBox2);
            this.regPanel.Controls.Add(this.pictureBox1);
            this.regPanel.Controls.Add(this.panel2);
            this.regPanel.Location = new System.Drawing.Point(0, 0);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(1200, 800);
            this.regPanel.TabIndex = 1;
            // 
            // RegBtn
            // 
            this.RegBtn.AutoSize = true;
            this.RegBtn.Font = new System.Drawing.Font("Minecraft 1.1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.Color.Lavender;
            this.RegBtn.Location = new System.Drawing.Point(198, 442);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(61, 17);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Sign in";
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Db3.Properties.Resources._1790670_access_key_lock_safe_safety_icon;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(332, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Db3.Properties.Resources._4043272_avatar_lazybones_sloth_sluggard_icon1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(332, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(690, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 241);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // LogiBtn
            // 
            this.LogiBtn.AutoSize = true;
            this.LogiBtn.Font = new System.Drawing.Font("Minecraft 1.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogiBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LogiBtn.Location = new System.Drawing.Point(494, 695);
            this.LogiBtn.Name = "LogiBtn";
            this.LogiBtn.Size = new System.Drawing.Size(253, 20);
            this.LogiBtn.TabIndex = 7;
            this.LogiBtn.Text = "У меня уже есть аккаунт";
            this.LogiBtn.Click += new System.EventHandler(this.LogiBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.regPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Label RegBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LogiBtn;
    }
}