namespace shopping.Presentation.Admin
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_delete = new Button();
            btn_update = new Button();
            txt_name = new TextBox();
            btn_add = new Button();
            label4 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            dgv_users = new DataGridView();
            pictureBox2 = new PictureBox();
            btn_back = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_address = new TextBox();
            cb_role = new ComboBox();
            num_age = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_age).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 192, 255);
            btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
            btn_delete.BackgroundImageLayout = ImageLayout.Stretch;
            btn_delete.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_delete.FlatAppearance.BorderSize = 2;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            btn_delete.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(246, 362);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 35);
            btn_delete.TabIndex = 37;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
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
            btn_update.Location = new Point(144, 362);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(80, 35);
            btn_update.TabIndex = 38;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // txt_name
            // 
            txt_name.ForeColor = SystemColors.ControlText;
            txt_name.Location = new Point(169, 125);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(160, 23);
            txt_name.TabIndex = 31;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 192, 255);
            btn_add.BackgroundImage = (Image)resources.GetObject("btn_add.BackgroundImage");
            btn_add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_add.FlatAppearance.BorderSize = 2;
            btn_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            btn_add.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.ControlText;
            btn_add.Location = new Point(46, 362);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 35);
            btn_add.TabIndex = 36;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 201);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 35;
            label4.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 125);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 32;
            label2.Text = "User Name";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlLightLight;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(28, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(313, 304);
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(328, 323);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // dgv_users
            // 
            dgv_users.BackgroundColor = Color.LavenderBlush;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.GridColor = Color.FromArgb(64, 0, 64);
            dgv_users.Location = new Point(377, 143);
            dgv_users.Name = "dgv_users";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_users.Size = new Size(400, 223);
            dgv_users.TabIndex = 30;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(364, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(424, 254);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(192, 192, 255);
            btn_back.BackgroundImage = (Image)resources.GetObject("btn_back.BackgroundImage");
            btn_back.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_back.FlatAppearance.BorderSize = 2;
            btn_back.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btn_back.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(21, 436);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 35);
            btn_back.TabIndex = 39;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 48);
            label1.TabIndex = 29;
            label1.Text = "Manage Users";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(898, 482);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // txt_email
            // 
            txt_email.ForeColor = SystemColors.ControlText;
            txt_email.Location = new Point(169, 201);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(160, 23);
            txt_email.TabIndex = 46;
            // 
            // txt_pass
            // 
            txt_pass.ForeColor = SystemColors.ControlText;
            txt_pass.Location = new Point(169, 166);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(160, 23);
            txt_pass.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(46, 318);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 48;
            label3.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 277);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 49;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 238);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 50;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 166);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 51;
            label7.Text = "Password";
            // 
            // txt_address
            // 
            txt_address.ForeColor = SystemColors.ControlText;
            txt_address.Location = new Point(169, 277);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(160, 23);
            txt_address.TabIndex = 52;
            // 
            // cb_role
            // 
            cb_role.DisplayMember = "User";
            cb_role.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_role.FormattingEnabled = true;
            cb_role.ImeMode = ImeMode.Off;
            cb_role.Items.AddRange(new object[] { "User", "Admin" });
            cb_role.Location = new Point(169, 318);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(160, 23);
            cb_role.TabIndex = 53;
            // 
            // num_age
            // 
            num_age.Location = new Point(169, 242);
            num_age.Name = "num_age";
            num_age.Size = new Size(160, 23);
            num_age.TabIndex = 54;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(num_age);
            Controls.Add(cb_role);
            Controls.Add(txt_address);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(txt_name);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(dgv_users);
            Controls.Add(pictureBox2);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ManageUsers";
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_update;
        private TextBox txt_name;
        private Button btn_add;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DataGridView dgv_users;
        private PictureBox pictureBox2;
        private Button btn_back;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_address;
        private ComboBox cb_role;
        private NumericUpDown num_age;
    }
}