using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5173BookStore.Entities.Entity;

namespace YMS5173BookStore.Repository.Abstraction
{
	public interface IBookRepository
	{
		void AddBook(int id, string title, string content, string isb_no, int categoryId);
		void UpdateBook(int id, string title, string content, string isb_no, int categoryId);
		void DeleteBook(int id);
		List<Book> TakeList();
		List<Book> FindByName(string title);
		List<Book> TakeCategoryList();
		Book BookDetail(int id);
	}
}
