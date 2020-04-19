namespace YMS5173BookStore.UI
{
    partial class AdminAssignedBook
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
			this.btnAssignedBook = new System.Windows.Forms.Button();
			this.cmbAuthor = new System.Windows.Forms.ComboBox();
			this.cmbBook = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAssignedBook);
			this.groupBox1.Controls.Add(this.cmbAuthor);
			this.groupBox1.Controls.Add(this.cmbBook);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(309, 166);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Assigned Book";
			// 
			// btnAssignedBook
			// 
			this.btnAssignedBook.Location = new System.Drawing.Point(218, 120);
			this.btnAssignedBook.Name = "btnAssignedBook";
			this.btnAssignedBook.Size = new System.Drawing.Size(75, 23);
			this.btnAssignedBook.TabIndex = 3;
			this.btnAssignedBook.Text = "Assigned";
			this.btnAssignedBook.UseVisualStyleBackColor = true;
			this.btnAssignedBook.Click += new System.EventHandler(this.btnAssignedBook_Click);
			// 
			// cmbAuthor
			// 
			this.cmbAuthor.FormattingEnabled = true;
			this.cmbAuthor.Location = new System.Drawing.Point(109, 79);
			this.cmbAuthor.Name = "cmbAuthor";
			this.cmbAuthor.Size = new System.Drawing.Size(184, 21);
			this.cmbAuthor.TabIndex = 2;
			// 
			// cmbBook
			// 
			this.cmbBook.FormattingEnabled = true;
			this.cmbBook.Location = new System.Drawing.Point(109, 34);
			this.cmbBook.Name = "cmbBook";
			this.cmbBook.Size = new System.Drawing.Size(184, 21);
			this.cmbBook.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Author:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Book Name:";
			// 
			// AdminAssignedBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 212);
			this.Controls.Add(this.groupBox1);
			this.Name = "AdminAssignedBook";
			this.Text = "AdminAssignedBook";
			this.Load += new System.EventHandler(this.AdminAssignedBook_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAssignedBook;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}