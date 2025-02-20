namespace shopping.Presentation
{
    partial class Registeration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registeration));
            txt_password = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_back = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_username = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_address = new TextBox();
            cb_role = new ComboBox();
            txt_agee = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_agee).BeginInit();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.Location = new Point(259, 212);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(180, 25);
            txt_password.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-282, -163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1099, 938);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(69, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(396, 334);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.SaddleBrown;
            btn_back.FlatAppearance.BorderSize = 2;
            btn_back.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_back.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.Transparent;
            btn_back.Location = new Point(327, 455);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 37);
            btn_back.TabIndex = 7;
            btn_back.Text = "Register";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(97, 212);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(97, 255);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(259, 255);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(180, 25);
            txt_email.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(97, 171);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(259, 171);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(180, 25);
            txt_username.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(105, 296);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 13;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(105, 379);
            label5.Name = "label5";
            label5.Size = new Size(56, 28);
            label5.TabIndex = 15;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(105, 339);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 17;
            label6.Text = "Address";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(259, 342);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(180, 25);
            txt_address.TabIndex = 16;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "User" });
            cb_role.Location = new Point(262, 386);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(180, 23);
            cb_role.TabIndex = 18;
            // 
            // txt_agee
            // 
            txt_agee.Location = new Point(259, 296);
            txt_agee.Name = "txt_agee";
            txt_agee.Size = new Size(180, 23);
            txt_agee.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(105, 455);
            button1.Name = "button1";
            button1.Size = new Size(73, 37);
            button1.TabIndex = 21;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registeration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 549);
            Controls.Add(button1);
            Controls.Add(txt_agee);
            Controls.Add(cb_role);
            Controls.Add(label6);
            Controls.Add(txt_address);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Controls.Add(txt_email);
            Controls.Add(btn_back);
            Controls.Add(label2);
            Controls.Add(txt_password);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Registeration";
            Text = "Registeration";
            Load += Registeration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_agee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_password;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_back;
        private Label label2;
        private Label label1;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_username;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_address;
        private ComboBox cb_role;
        private NumericUpDown txt_agee;
        private Button button1;
    }
}