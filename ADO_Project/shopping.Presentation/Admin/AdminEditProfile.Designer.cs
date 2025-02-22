namespace shopping.Presentation.Admin
{
    partial class AdminEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditProfile));
            txt_oldpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_confirmpass = new TextBox();
            show_pass1 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label4 = new Label();
            txt_newPass = new TextBox();
            pictureBox1 = new PictureBox();
            btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_oldpassword
            // 
            txt_oldpassword.BackColor = Color.FromArgb(224, 224, 224);
            txt_oldpassword.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_oldpassword.Location = new Point(134, 120);
            txt_oldpassword.Multiline = true;
            txt_oldpassword.Name = "txt_oldpassword";
            txt_oldpassword.PasswordChar = '*';
            txt_oldpassword.Size = new Size(323, 35);
            txt_oldpassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 43);
            label1.TabIndex = 1;
            label1.Text = "Edit Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 93);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 2;
            label2.Text = "Old Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 312);
            label3.Name = "label3";
            label3.Size = new Size(210, 24);
            label3.TabIndex = 3;
            label3.Text = "Confirm New Password";
            // 
            // txt_confirmpass
            // 
            txt_confirmpass.BackColor = Color.FromArgb(224, 224, 224);
            txt_confirmpass.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txt_confirmpass.Location = new Point(134, 339);
            txt_confirmpass.Multiline = true;
            txt_confirmpass.Name = "txt_confirmpass";
            txt_confirmpass.PasswordChar = '*';
            txt_confirmpass.Size = new Size(323, 35);
            txt_confirmpass.TabIndex = 4;
            // 
            // show_pass1
            // 
            show_pass1.AutoSize = true;
            show_pass1.BackColor = Color.FromArgb(255, 192, 255);
            show_pass1.Location = new Point(134, 161);
            show_pass1.Name = "show_pass1";
            show_pass1.Size = new Size(108, 19);
            show_pass1.TabIndex = 5;
            show_pass1.Text = "Show Password";
            show_pass1.UseVisualStyleBackColor = false;
            show_pass1.CheckedChanged += show_pass1_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(255, 192, 255);
            checkBox1.Location = new Point(134, 380);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.FromArgb(255, 192, 255);
            checkBox2.Location = new Point(134, 272);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Show Password";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 255);
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 204);
            label4.Name = "label4";
            label4.Size = new Size(135, 24);
            label4.TabIndex = 8;
            label4.Text = "New Password";
            // 
            // txt_newPass
            // 
            txt_newPass.BackColor = Color.FromArgb(224, 224, 224);
            txt_newPass.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txt_newPass.Location = new Point(134, 231);
            txt_newPass.Multiline = true;
            txt_newPass.Name = "txt_newPass";
            txt_newPass.PasswordChar = '*';
            txt_newPass.Size = new Size(323, 35);
            txt_newPass.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-14, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(192, 192, 255);
            btn_update.BackgroundImage = (Image)resources.GetObject("btn_update.BackgroundImage");
            btn_update.BackgroundImageLayout = ImageLayout.Stretch;
            btn_update.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_update.FlatAppearance.BorderSize = 2;
            btn_update.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            btn_update.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(276, 409);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(181, 47);
            btn_update.TabIndex = 38;
            btn_update.Text = "Update Password";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // AdminEditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 468);
            Controls.Add(btn_update);
            Controls.Add(checkBox2);
            Controls.Add(label4);
            Controls.Add(txt_newPass);
            Controls.Add(checkBox1);
            Controls.Add(show_pass1);
            Controls.Add(txt_confirmpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_oldpassword);
            Controls.Add(pictureBox1);
            Name = "AdminEditProfile";
            Text = "AdminEditProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_oldpassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_confirmpass;
        private CheckBox show_pass1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label4;
        private TextBox txt_newPass;
        private PictureBox pictureBox1;
        private Button btn_update;
    }
}