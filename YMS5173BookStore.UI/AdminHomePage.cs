using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5173BookStore.DataAccess.Context;
using YMS5173BookStore.Entities.Entity;

namespace YMS5173BookStore.UI
{
	public partial class AdminHomePage : Form
	{
		public AdminHomePage()
		{
			InitializeComponent();
		}
		ProjectContext db = new ProjectContext();

		AdminPage adminPage = new AdminPage();
		private void AdminHomePage_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.AdminPages.Where(x => x.Status != Status.Passive).ToList();
		}

		private void btn_giris_Click(object sender, EventArgs e)
		{
			
			adminPage.Name = txt_admin_name.Text;
			adminPage.Password = int.Parse(ttx_password.Text);
			db.AdminPages.Add(adminPage);
			db.SaveChanges();
			dataGridView1.DataSource = db.AdminPages.Where(x => x.Status != Status.Passive).ToList();
			AdminCategoryPage adminCategory = new AdminCategoryPage();
			adminCategory.ShowDialog();
		}
	}
}
