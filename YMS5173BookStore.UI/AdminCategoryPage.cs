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
using YMS5173BookStore.Repository.ConCreat;

namespace YMS5173BookStore.UI
{
    public partial class AdminCategoryPage : Form
    {
        public AdminCategoryPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        EfCategory efCategory = new EfCategory();
        private void AdminCategoryPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
            dataGridView1.DataSource = efCategory.GetActiveCategory();
        }

        Category category = new Category();

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            category.Name = txtAddName.Text;
            category.Description = txtAddDescription.Text;
            db.Categories.Add(category);
            db.SaveChanges();

            dataGridView1.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
            AdminBookPage adminBookPage = new AdminBookPage();
            adminBookPage.ShowDialog();
        }
        int id;
        private void btn_update_category_Click(object sender, EventArgs e)
        {
            efCategory.UpdateCategory((int.Parse(txt_id.Text)), txtAddName.Text, txtAddDescription.Text);
            dataGridView1.DataSource = efCategory.GetActiveCategory();
            efCategory.TextBoxEraser(grp_update);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            txt_id.Text = id.ToString();
            txt_name.Text=dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txt_description.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txt_delete.Text = id.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            efCategory.DeleteCategory(id);
            efCategory.TextBoxEraser(groupBox3);
            dataGridView1.DataSource = efCategory.GetActiveCategory();
        }

        private void btn_findyname_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efCategory.FindByName(txt_findbyname.Text);
        }

        private void btn_getall_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efCategory.GetAll();
        }
    }
}
