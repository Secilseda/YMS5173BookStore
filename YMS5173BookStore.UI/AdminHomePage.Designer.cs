namespace YMS5173BookStore.UI
{
	partial class AdminHomePage
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
			this.btn_giris = new System.Windows.Forms.Button();
			this.ttx_password = new System.Windows.Forms.TextBox();
			this.txt_admin_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_giris);
			this.groupBox1.Controls.Add(this.ttx_password);
			this.groupBox1.Controls.Add(this.txt_admin_name);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Admin Home Page";
			// 
			// btn_giris
			// 
			this.btn_giris.Location = new System.Drawing.Point(93, 83);
			this.btn_giris.Name = "btn_giris";
			this.btn_giris.Size = new System.Drawing.Size(75, 23);
			this.btn_giris.TabIndex = 5;
			this.btn_giris.Text = "Submit";
			this.btn_giris.UseVisualStyleBackColor = true;
			this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
			// 
			// ttx_password
			// 
			this.ttx_password.Location = new System.Drawing.Point(68, 57);
			this.ttx_password.Name = "ttx_password";
			this.ttx_password.Size = new System.Drawing.Size(100, 20);
			this.ttx_password.TabIndex = 4;
			this.ttx_password.UseSystemPasswordChar = true;
			// 
			// txt_admin_name
			// 
			this.txt_admin_name.Location = new System.Drawing.Point(68, 32);
			this.txt_admin_name.Name = "txt_admin_name";
			this.txt_admin_name.Size = new System.Drawing.Size(100, 20);
			this.txt_admin_name.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 162);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(713, 109);
			this.dataGridView1.TabIndex = 1;
			// 
			// AdminHomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 277);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "AdminHomePage";
			this.Text = "AdminHomePage";
			this.Load += new System.EventHandler(this.AdminHomePage_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_giris;
		private System.Windows.Forms.TextBox ttx_password;
		private System.Windows.Forms.TextBox txt_admin_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}