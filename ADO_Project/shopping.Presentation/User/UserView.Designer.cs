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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            button2 = new Button();
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
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(55, 3);
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(681, 439);
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
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(673, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.SteelBlue;
            btn_back.ForeColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(577, 359);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(67, 33);
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
            btn_Add.Location = new Point(18, 333);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(321, 62);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "+Add to favorite";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // dgv_products
            // 
            dgv_products.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_products.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_products.Location = new Point(18, 62);
            dgv_products.Name = "dgv_products";
            dgv_products.Size = new Size(321, 275);
            dgv_products.TabIndex = 0;
            dgv_products.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-473, -67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1286, 514);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dgv_favourite);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(673, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Favourite";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(271, 334);
            button1.Name = "button1";
            button1.Size = new Size(70, 38);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgv_favourite
            // 
            dgv_favourite.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_favourite.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_favourite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_favourite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_favourite.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_favourite.Location = new Point(157, 146);
            dgv_favourite.Name = "dgv_favourite";
            dgv_favourite.Size = new Size(303, 182);
            dgv_favourite.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-44, -46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(705, 515);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkBox1);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(txt_confirm);
            tabPage3.Controls.Add(txt_newpass);
            tabPage3.Controls.Add(txt_oldpass);
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(673, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Profile";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightBlue;
            checkBox1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(247, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 22);
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
            label1.Location = new Point(270, 94);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 5;
            label1.Text = "Reset Password";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(247, 312);
            button2.Name = "button2";
            button2.Size = new Size(250, 35);
            button2.TabIndex = 4;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // txt_confirm
            // 
            txt_confirm.Location = new Point(247, 261);
            txt_confirm.Multiline = true;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.PasswordChar = '*';
            txt_confirm.PlaceholderText = "Confirm New Password";
            txt_confirm.Size = new Size(248, 31);
            txt_confirm.TabIndex = 3;
            // 
            // txt_newpass
            // 
            txt_newpass.Location = new Point(247, 214);
            txt_newpass.Multiline = true;
            txt_newpass.Name = "txt_newpass";
            txt_newpass.PasswordChar = '*';
            txt_newpass.PlaceholderText = "Enter New Password";
            txt_newpass.Size = new Size(248, 31);
            txt_newpass.TabIndex = 2;
            // 
            // txt_oldpass
            // 
            txt_oldpass.Location = new Point(247, 150);
            txt_oldpass.Multiline = true;
            txt_oldpass.Name = "txt_oldpass";
            txt_oldpass.PasswordChar = '*';
            txt_oldpass.PlaceholderText = "Enter Old Password";
            txt_oldpass.Size = new Size(248, 31);
            txt_oldpass.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-155, -102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(941, 651);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 437);
            Controls.Add(tabControl1);
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
        private Button button2;
        private TextBox txt_confirm;
        private TextBox txt_newpass;
        private TextBox txt_oldpass;
        private CheckBox checkBox1;
        private Label label1;
        private Button btn_back;
    }
}