namespace shopping.Presentation.Admin
{
    partial class ManageProduct_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct_Admin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cb_category = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            txt_price = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            dgv_Editproducts = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Editproducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cb_category
            // 
            cb_category.DropDownHeight = 190;
            cb_category.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_category.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_category.FormattingEnabled = true;
            cb_category.IntegralHeight = false;
            cb_category.Location = new Point(628, 211);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(160, 25);
            cb_category.TabIndex = 24;
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
            button4.Location = new Point(20, 370);
            button4.Name = "button4";
            button4.Size = new Size(75, 35);
            button4.TabIndex = 23;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(610, 268);
            button3.Name = "button3";
            button3.Size = new Size(80, 35);
            button3.TabIndex = 22;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(713, 268);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 21;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(503, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(503, 209);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 19;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(503, 176);
            label3.Name = "label3";
            label3.Size = new Size(123, 24);
            label3.TabIndex = 18;
            label3.Text = "Product Price";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(632, 169);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(160, 31);
            txt_price.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(497, 133);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 16;
            label2.Text = "Product Name";
            // 
            // txt_name
            // 
            txt_name.ForeColor = SystemColors.ControlText;
            txt_name.Location = new Point(632, 126);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(160, 31);
            txt_name.TabIndex = 15;
            // 
            // dgv_Editproducts
            // 
            dgv_Editproducts.BackgroundColor = Color.LavenderBlush;
            dgv_Editproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Editproducts.GridColor = Color.FromArgb(64, 0, 64);
            dgv_Editproducts.Location = new Point(30, 104);
            dgv_Editproducts.Name = "dgv_Editproducts";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Editproducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Editproducts.Size = new Size(410, 223);
            dgv_Editproducts.TabIndex = 14;
            dgv_Editproducts.CellContentClick += dgv_Editproducts_CellContentClick;
            dgv_Editproducts.RowHeaderMouseDoubleClick += dgv_Editproducts_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 48);
            label1.TabIndex = 13;
            label1.Text = "Manage Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(898, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(20, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(429, 254);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlLightLight;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(491, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(313, 226);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(483, 88);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(328, 254);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // ManageProduct_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 417);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(cb_category);
            Controls.Add(txt_price);
            Controls.Add(txt_name);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(dgv_Editproducts);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ManageProduct_Admin";
            Text = "ManageProduct_Admin";
            Load += ManageProduct_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Editproducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_category;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private TextBox txt_price;
        private Label label2;
        private TextBox txt_name;
        private DataGridView dgv_Editproducts;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}