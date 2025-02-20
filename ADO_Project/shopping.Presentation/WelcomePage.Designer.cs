namespace shopping.Presentation
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            btn_login = new Button();
            btn_register = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.PowderBlue;
            btn_login.FlatAppearance.BorderSize = 2;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btn_login.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.FromArgb(64, 0, 64);
            btn_login.Location = new Point(392, 329);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 56);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.PowderBlue;
            btn_register.FlatAppearance.BorderSize = 2;
            btn_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btn_register.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.FromArgb(64, 0, 64);
            btn_register.Location = new Point(80, 329);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(152, 56);
            btn_register.TabIndex = 1;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, -115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(620, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(597, 397);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(pictureBox1);
            Name = "WelcomePage";
            Text = "WelcomePage";
            Load += WelcomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login;
        private Button btn_register;
        private PictureBox pictureBox1;
    }
}