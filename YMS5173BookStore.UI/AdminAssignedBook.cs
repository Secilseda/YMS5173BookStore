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
    public partial class AdminAssignedBook : Form
    {
        public AdminAssignedBook()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        private void AdminAssignedBook_Load(object sender, EventArgs e)
        {
            cmbBook.DataSource = db.Books.Where(x=> x.Status != Status.Passive).ToList();
            cmbBook.DisplayMember = "Title";
            cmbBook.ValueMember = "Id";
            cmbBook.SelectedIndex = -1;

            cmbAuthor.DataSource = db.Users.Where(x => x.Status != Status.Passive && x.Role == Role.Author).ToList();
            cmbAuthor.DisplayMember = "FullName";
            cmbAuthor.ValueMember = "Id";
            cmbAuthor.SelectedIndex = -1;
        }

        private void btnAssignedBook_Click(object sender, EventArgs e)
        {
            AssignedBook assignedBook = new AssignedBook();
            assignedBook.BookId = (int)(cmbBook.SelectedValue);
            assignedBook.AppUserId = (int)(cmbAuthor.SelectedValue);
            db.AssignedBooks.Add(assignedBook);
            db.SaveChanges();
        }
    }
}
