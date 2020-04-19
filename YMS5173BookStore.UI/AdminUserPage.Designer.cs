namespace YMS5173BookStore.UI
{
    partial class AdminUserPage
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
			this.btnAdddUser = new System.Windows.Forms.Button();
			this.cmbUser = new System.Windows.Forms.ComboBox();
			this.txtAddFullName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAdddUser);
			this.groupBox1.Controls.Add(this.cmbUser);
			this.groupBox1.Controls.Add(this.txtAddFullName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(302, 172);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add User";
			// 
			// btnAdddUser
			// 
			this.btnAdddUser.Location = new System.Drawing.Point(143, 136);
			this.btnAdddUser.Name = "btnAdddUser";
			this.btnAdddUser.Size = new System.Drawing.Size(75, 23);
			this.btnAdddUser.TabIndex = 3;
			this.btnAdddUser.Text = "Add User";
			this.btnAdddUser.UseVisualStyleBackColor = true;
			this.btnAdddUser.Click += new System.EventHandler(this.btnAdddUser_Click);
			// 
			// cmbUser
			// 
			this.cmbUser.FormattingEnabled = true;
			this.cmbUser.Location = new System.Drawing.Point(83, 98);
			this.cmbUser.Name = "cmbUser";
			this.cmbUser.Size = new System.Drawing.Size(135, 21);
			this.cmbUser.TabIndex = 2;
			// 
			// txtAddFullName
			// 
			this.txtAddFullName.Location = new System.Drawing.Point(78, 32);
			this.txtAddFullName.Name = "txtAddFullName";
			this.txtAddFullName.Size = new System.Drawing.Size(140, 20);
			this.txtAddFullName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Choose A Role:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Full Name:";
			// 
			// AdminUserPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 195);
			this.Controls.Add(this.groupBox1);
			this.Name = "AdminUserPage";
			this.Text = "AdminUserPage";
			this.Load += new System.EventHandler(this.AdminUserPage_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdddUser;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtAddFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}