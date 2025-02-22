namespace shopping.Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txt_username = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(535, 349);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(143, 71);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(157, 33);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 3;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 64);
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.MidnightBlue;
            button2.Location = new Point(41, 349);
            button2.Name = "button2";
            button2.Size = new Size(92, 43);
            button2.TabIndex = 5;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-142, -123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(177, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 139);
            panel1.TabIndex = 10;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(143, 27);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(157, 32);
            txt_username.TabIndex = 9;
            txt_username.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 417);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form2";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txt_username;
    }
}