namespace shopping.Presentation.Admin
{
    partial class ManageGategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGategory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            txt_name = new TextBox();
            btn_add = new Button();
            label4 = new Label();
            dgv_Editcategory = new DataGridView();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Editcategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 52);
            label1.TabIndex = 1;
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
            btn_delete.Location = new Point(497, 248);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 35);
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
            btn_update.Location = new Point(497, 192);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 35);
            btn_update.TabIndex = 38;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(186, 304);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(160, 31);
            txt_name.TabIndex = 33;
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
            btn_add.Location = new Point(497, 137);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 35);
            btn_add.TabIndex = 36;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(186, 277);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 35;
            label4.Text = "Category";
            // 
            // dgv_Editcategory
            // 
            dgv_Editcategory.BackgroundColor = Color.LavenderBlush;
            dgv_Editcategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Editcategory.GridColor = Color.FromArgb(64, 0, 64);
            dgv_Editcategory.Location = new Point(186, 127);
            dgv_Editcategory.Name = "dgv_Editcategory";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Editcategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Editcategory.Size = new Size(267, 134);
            dgv_Editcategory.TabIndex = 30;
            dgv_Editcategory.RowHeaderMouseDoubleClick += dgv_Editcategory_RowHeaderMouseDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(142, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(515, 254);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(17, 384);
            button4.Name = "button4";
            button4.Size = new Size(102, 35);
            button4.TabIndex = 39;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(243, 14);
            label5.Name = "label5";
            label5.Size = new Size(346, 48);
            label5.TabIndex = 29;
            label5.Text = "Manage Categories";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-14, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(901, 443);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(130, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(539, 283);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ManageGategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 431);
            Controls.Add(label4);
            Controls.Add(txt_name);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(dgv_Editcategory);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ManageGategory";
            Text = "Form1";
            Load += ManageGategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Editcategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_delete;
        private Button btn_update;
        private TextBox txt_name;
        private Button btn_add;
        private Label label4;
        private DataGridView dgv_Editcategory;
        private PictureBox pictureBox2;
        private Button button4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}