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
    public partial class AdminUserPage : Form
    {
        public AdminUserPage()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        AppUser user = new AppUser();
        private void btnAdddUser_Click(object sender, EventArgs e)
        {
            user.FullName = txtAddFullName.Text;
            user.Role = (Role)Enum.Parse(typeof(Role), cmbUser.Text);
            db.Users.Add(user);
            db.SaveChanges();
        }

        private void AdminUserPage_Load(object sender, EventArgs e)
        {
            cmbUser.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbUser.SelectedIndex = 0;
        }
    }
}
