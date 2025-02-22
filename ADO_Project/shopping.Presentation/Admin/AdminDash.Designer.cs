namespace shopping.Presentation.Admin
{
    partial class AdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 48);
            label1.TabIndex = 0;
            label1.Text = "Admin DashBoard";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Plum;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(356, 127);
            button1.Name = "button1";
            button1.Size = new Size(238, 43);
            button1.TabIndex = 2;
            button1.Text = "Manage Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.Plum;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.MidnightBlue;
            button2.Location = new Point(356, 190);
            button2.Name = "button2";
            button2.Size = new Size(238, 46);
            button2.TabIndex = 3;
            button2.Text = "Manage Categories";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.Thistle;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.MidnightBlue;
            button3.Location = new Point(356, 314);
            button3.Name = "button3";
            button3.Size = new Size(238, 44);
            button3.TabIndex = 4;
            button3.Text = "Edit Profile\r\n";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSteelBlue;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.Thistle;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.MidnightBlue;
            button4.Location = new Point(356, 254);
            button4.Name = "button4";
            button4.Size = new Size(238, 45);
            button4.TabIndex = 5;
            button4.Text = "Manage Users";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-127, -48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(924, 534);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(356, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 293);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.AliceBlue;
            btn_exit.FlatAppearance.MouseDownBackColor = Color.Thistle;
            btn_exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Red;
            btn_exit.Location = new Point(613, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(34, 35);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // AdminDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 434);
            Controls.Add(btn_exit);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "AdminDash";
            Text = "AdminDash";
            Load += AdminDash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btn_exit;
    }
}