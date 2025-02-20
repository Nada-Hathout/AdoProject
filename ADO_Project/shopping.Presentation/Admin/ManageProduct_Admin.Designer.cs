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
            ((System.ComponentModel.ISupportInitialize)dgv_Editproducts).BeginInit();
            SuspendLayout();
            // 
            // cb_category
            // 
            cb_category.DropDownHeight = 190;
            cb_category.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_category.FormattingEnabled = true;
            cb_category.IntegralHeight = false;
            cb_category.Location = new Point(598, 226);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(160, 25);
            cb_category.TabIndex = 24;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(683, 408);
            button4.Name = "button4";
            button4.Size = new Size(75, 35);
            button4.TabIndex = 23;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(572, 292);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 22;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(683, 292);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 21;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 10;
            button1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(463, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(463, 225);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 19;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(463, 161);
            label3.Name = "label3";
            label3.Size = new Size(123, 24);
            label3.TabIndex = 18;
            label3.Text = "Product Price";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(598, 154);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(160, 31);
            txt_price.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(463, 101);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 16;
            label2.Text = "Product Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(598, 94);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(160, 31);
            txt_name.TabIndex = 15;
            // 
            // dgv_Editproducts
            // 
            dgv_Editproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Editproducts.Location = new Point(42, 65);
            dgv_Editproducts.Name = "dgv_Editproducts";
            dgv_Editproducts.Size = new Size(360, 357);
            dgv_Editproducts.TabIndex = 14;
            dgv_Editproducts.RowHeaderMouseDoubleClick += dgv_Editproducts_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 7);
            label1.Name = "label1";
            label1.Size = new Size(213, 35);
            label1.TabIndex = 13;
            label1.Text = "Edit PRODUCTS";
            // 
            // ManageProduct_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_category);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(dgv_Editproducts);
            Controls.Add(label1);
            Name = "ManageProduct_Admin";
            Text = "ManageProduct_Admin";
            Load += ManageProduct_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Editproducts).EndInit();
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
    }
}