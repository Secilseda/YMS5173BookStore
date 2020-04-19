using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5173BookStore.Entities.Entity;
using YMS5173BookStore.Repository.Abstraction;

namespace YMS5173BookStore.Repository.ConCreat
{
	public class EfBookRepository : EfBaseRepository, IBookRepository
	{
		Book Book = new Book();
		public void AddBook(int id, string title, string content, string isb_no, int categoryId)
		{
			Book.Title = title;
			Book.Content = content;
			Book.ISNB_No = isb_no;
			Book.CategoryId = categoryId;
			db.Books.Add(Book);
			db.SaveChanges();

		}

		public Book BookDetail(int id)
		{
			Book = db.Books.Include("Book").FirstOrDefault(x => x.Id == id);
			return Book;
		}

		public void DeleteBook(int id)
		{
			try
			{
				Book = db.Books.FirstOrDefault(x => x.Id == id);
				Book.DeleteDate = DateTime.Now;
				Book.Status = Status.Passive;
				db.SaveChanges();
			}
			catch (Exception)
			{

				MessageBox.Show("Lütfen Id alanına silmek istediğniz Book Id Bilgiisni yazınız.");
			}
		}

		public List<Book> FindByName(string title)
		{
			return db.Books.Where(x => x.Title.ToLower() == title.ToLower()).ToList();
		}

		public List<Book> TakeCategoryList()
		{
			return db.Books.Where(x => x.Status != Status.Passive).ToList();
		}

		public List<Book> TakeList()
		{
			return db.Books.Where(x => x.Status != Status.Passive).Include("Book").ToList();
		}

		public void UpdateBook(int id, string title, string content, string isb_no, int categoryId)
		{
			Book = db.Books.FirstOrDefault(x => x.Id == id);
			Book.Title = title;
			Book.Content = content;
			Book.ISNB_No = isb_no;
			Book.CategoryId = categoryId;
			Book.UpdateDate = DateTime.Now;
			Book.Status = Status.Modified;

		}
	}
}
