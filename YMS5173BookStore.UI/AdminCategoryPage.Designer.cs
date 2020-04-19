namespace YMS5173BookStore.UI
{
    partial class AdminCategoryPage
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.txtAddDescription = new System.Windows.Forms.TextBox();
			this.txtAddName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.grp_update = new System.Windows.Forms.GroupBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_update_category = new System.Windows.Forms.Button();
			this.txt_description = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.txt_delete = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btn_findyname = new System.Windows.Forms.Button();
			this.txt_findbyname = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btn_getall = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.grp_update.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddCategory);
			this.groupBox1.Controls.Add(this.txtAddDescription);
			this.groupBox1.Controls.Add(this.txtAddName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(393, 153);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Category";
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Location = new System.Drawing.Point(290, 38);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(97, 45);
			this.btnAddCategory.TabIndex = 2;
			this.btnAddCategory.Text = "Add";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// txtAddDescription
			// 
			this.txtAddDescription.Location = new System.Drawing.Point(74, 69);
			this.txtAddDescription.Name = "txtAddDescription";
			this.txtAddDescription.Size = new System.Drawing.Size(188, 20);
			this.txtAddDescription.TabIndex = 1;
			// 
			// txtAddName
			// 
			this.txtAddName.Location = new System.Drawing.Point(74, 29);
			this.txtAddName.Name = "txtAddName";
			this.txtAddName.Size = new System.Drawing.Size(188, 20);
			this.txtAddName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Description:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(2, 178);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(626, 260);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Category List";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(2, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(613, 221);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// grp_update
			// 
			this.grp_update.Controls.Add(this.txt_id);
			this.grp_update.Controls.Add(this.label5);
			this.grp_update.Controls.Add(this.btn_update_category);
			this.grp_update.Controls.Add(this.txt_description);
			this.grp_update.Controls.Add(this.txt_name);
			this.grp_update.Controls.Add(this.label3);
			this.grp_update.Controls.Add(this.label4);
			this.grp_update.Location = new System.Drawing.Point(425, 12);
			this.grp_update.Name = "grp_update";
			this.grp_update.Size = new System.Drawing.Size(546, 141);
			this.grp_update.TabIndex = 2;
			this.grp_update.TabStop = false;
			this.grp_update.Text = "Update Category";
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(83, 26);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(259, 20);
			this.txt_id.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Id:";
			// 
			// btn_update_category
			// 
			this.btn_update_category.Location = new System.Drawing.Point(373, 41);
			this.btn_update_category.Name = "btn_update_category";
			this.btn_update_category.Size = new System.Drawing.Size(142, 41);
			this.btn_update_category.TabIndex = 7;
			this.btn_update_category.Text = "Add";
			this.btn_update_category.UseVisualStyleBackColor = true;
			this.btn_update_category.Click += new System.EventHandler(this.btn_update_category_Click);
			// 
			// txt_description
			// 
			this.txt_description.Location = new System.Drawing.Point(83, 78);
			this.txt_description.Name = "txt_description";
			this.txt_description.Size = new System.Drawing.Size(259, 20);
			this.txt_description.TabIndex = 5;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(83, 52);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(259, 20);
			this.txt_name.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Description:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Name:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn_delete);
			this.groupBox3.Controls.Add(this.txt_delete);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(634, 160);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(337, 64);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Delete Category";
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(246, 18);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 2;
			this.btn_delete.Text = "Submit";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// txt_delete
			// 
			this.txt_delete.Location = new System.Drawing.Point(32, 23);
			this.txt_delete.Name = "txt_delete";
			this.txt_delete.Size = new System.Drawing.Size(208, 20);
			this.txt_delete.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Id:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btn_findyname);
			this.groupBox4.Controls.Add(this.txt_findbyname);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Location = new System.Drawing.Point(639, 230);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(337, 82);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Find By Name";
			// 
			// btn_findyname
			// 
			this.btn_findyname.Location = new System.Drawing.Point(246, 31);
			this.btn_findyname.Name = "btn_findyname";
			this.btn_findyname.Size = new System.Drawing.Size(75, 23);
			this.btn_findyname.TabIndex = 12;
			this.btn_findyname.Text = "Submit";
			this.btn_findyname.UseVisualStyleBackColor = true;
			this.btn_findyname.Click += new System.EventHandler(this.btn_findyname_Click);
			// 
			// txt_findbyname
			// 
			this.txt_findbyname.Location = new System.Drawing.Point(52, 33);
			this.txt_findbyname.Name = "txt_findbyname";
			this.txt_findbyname.Size = new System.Drawing.Size(188, 20);
			this.txt_findbyname.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Name:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btn_getall);
			this.groupBox5.Location = new System.Drawing.Point(645, 318);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(331, 120);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Gett All Category";
			// 
			// btn_getall
			// 
			this.btn_getall.Location = new System.Drawing.Point(16, 36);
			this.btn_getall.Name = "btn_getall";
			this.btn_getall.Size = new System.Drawing.Size(309, 64);
			this.btn_getall.TabIndex = 0;
			this.btn_getall.Text = "Get All";
			this.btn_getall.UseVisualStyleBackColor = true;
			this.btn_getall.Click += new System.EventHandler(this.btn_getall_Click);
			// 
			// AdminCategoryPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 450);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.grp_update);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "AdminCategoryPage";
			this.Text = "AdminCategoryPage";
			this.Load += new System.EventHandler(this.AdminCategoryPage_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.grp_update.ResumeLayout(false);
			this.grp_update.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grp_update;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_update_category;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.TextBox txt_delete;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btn_findyname;
		private System.Windows.Forms.TextBox txt_findbyname;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btn_getall;
	}
}