namespace shopping.Presentation.User
{
    partial class UserView
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_back = new Button();
            btn_Add = new Button();
            dgv_products = new DataGridView();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            button1 = new Button();
            dgv_favourite = new DataGridView();
            pictureBox2 = new PictureBox();
            tabPage3 = new TabPage();
            checkBox1 = new CheckBox();
            label1 = new Label();
            btn_update = new Button();
            txt_confirm = new TextBox();
            txt_newpass = new TextBox();
            txt_oldpass = new TextBox();
            pictureBox3 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_favourite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(55, 3);
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(778, 585);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btn_back);
            tabPage1.Controls.Add(btn_Add);
            tabPage1.Controls.Add(dgv_products);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(770, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.SteelBlue;
            btn_back.ForeColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(659, 479);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(77, 44);
            btn_back.TabIndex = 4;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SteelBlue;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = SystemColors.Control;
            btn_Add.Location = new Point(21, 444);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(367, 83);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "+Add to favorite";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // dgv_products
            // 
            dgv_products.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgv_products.DefaultCellStyle = dataGridViewCellStyle10;
            dgv_products.Location = new Point(21, 83);
            dgv_products.Margin = new Padding(3, 4, 3, 4);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.Size = new Size(367, 367);
            dgv_products.TabIndex = 0;
            dgv_products.CellContentClick += dataGridView1_CellContentClick;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-541, -89);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1470, 685);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dgv_favourite);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(770, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Favourite";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(310, 445);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(80, 51);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgv_favourite
            // 
            dgv_favourite.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_favourite.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgv_favourite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgv_favourite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgv_favourite.DefaultCellStyle = dataGridViewCellStyle12;
            dgv_favourite.Location = new Point(179, 195);
            dgv_favourite.Margin = new Padding(3, 4, 3, 4);
            dgv_favourite.Name = "dgv_favourite";
            dgv_favourite.RowHeadersWidth = 51;
            dgv_favourite.Size = new Size(346, 243);
            dgv_favourite.TabIndex = 0;
            dgv_favourite.RowHeaderMouseDoubleClick += dgv_favourite_RowHeaderMouseDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-50, -61);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(806, 687);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkBox1);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(btn_update);
            tabPage3.Controls.Add(txt_confirm);
            tabPage3.Controls.Add(txt_newpass);
            tabPage3.Controls.Add(txt_oldpass);
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 44);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(770, 537);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Profile";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightBlue;
            checkBox1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(282, 248);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(309, 125);
            label1.Name = "label1";
            label1.Size = new Size(242, 39);
            label1.TabIndex = 5;
            label1.Text = "Reset Password";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SteelBlue;
            btn_update.Location = new Point(282, 416);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(286, 47);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // txt_confirm
            // 
            txt_confirm.Location = new Point(282, 348);
            txt_confirm.Margin = new Padding(3, 4, 3, 4);
            txt_confirm.Multiline = true;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.PasswordChar = '*';
            txt_confirm.PlaceholderText = "Confirm New Password";
            txt_confirm.Size = new Size(283, 40);
            txt_confirm.TabIndex = 3;
            // 
            // txt_newpass
            // 
            txt_newpass.Location = new Point(282, 285);
            txt_newpass.Margin = new Padding(3, 4, 3, 4);
            txt_newpass.Multiline = true;
            txt_newpass.Name = "txt_newpass";
            txt_newpass.PasswordChar = '*';
            txt_newpass.PlaceholderText = "Enter New Password";
            txt_newpass.Size = new Size(283, 40);
            txt_newpass.TabIndex = 2;
            // 
            // txt_oldpass
            // 
            txt_oldpass.Location = new Point(282, 200);
            txt_oldpass.Margin = new Padding(3, 4, 3, 4);
            txt_oldpass.Multiline = true;
            txt_oldpass.Name = "txt_oldpass";
            txt_oldpass.PasswordChar = '*';
            txt_oldpass.PlaceholderText = "Enter Old Password";
            txt_oldpass.Size = new Size(283, 40);
            txt_oldpass.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-177, -136);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1075, 868);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 583);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserView";
            Text = "UserView";
            Load += UserView_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_favourite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgv_products;
        private TabPage tabPage3;
        private Button btn_Add;
        private PictureBox pictureBox1;
        private DataGridView dgv_favourite;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
        private Button btn_update;
        private TextBox txt_confirm;
        private TextBox txt_newpass;
        private TextBox txt_oldpass;
        private CheckBox checkBox1;
        private Label label1;
        private Button btn_back;
    }
}