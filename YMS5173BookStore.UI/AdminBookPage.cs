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
    public partial class AdminBookPage : Form
    {
        public AdminBookPage()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        Book book = new Book();

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            book.Title = txtAddTitle.Text;
            book.Content = txtAddContent.Text;
            book.ISNB_No = txtAddISBN.Text;
            book.CategoryId = (int)(cmbCategory.SelectedValue);
            db.Books.Add(book);
            db.SaveChanges();

            dataGridView1.DataSource = db.Books.Join(db.Categories, b => b.CategoryId, c => c.Id, (b, c) => new { b, c }).Select(x=> new {
                x.b.Id,
                x.b.Title,
                x.c.Name,
                x.b.Status,
                x.b.ISNB_No
            }).ToList();
            AdminAssignedBook adminAssignedBook = new AdminAssignedBook();
            adminAssignedBook.ShowDialog();
        }

        private void AdminBookPage_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;

            dataGridView1.DataSource = db.Books.Where(x => x.Status != Status.Passive).ToList();
        }
    }
}
