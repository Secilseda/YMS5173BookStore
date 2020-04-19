using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5173BookStore.Entities.Entity;

namespace YMS5173BookStore.DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=FATIH_T430;Database=BookStoreDb;Integrated Security=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AssignedBook> AssignedBooks { get; set; }
        public DbSet<AdminPage> AdminPages { get; set; }
    }
}
