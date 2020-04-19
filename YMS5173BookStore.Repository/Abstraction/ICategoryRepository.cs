using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5173BookStore.Entities.Entity;

namespace YMS5173BookStore.Repository.Abstraction
{
	public interface ICategoryRepository
	{
		void CreateCategory(string name, string decription);
		void UpdateCategory(int id, string name, string decription);
		void DeleteCategory(int id);
		List<Category> GetActiveCategory();
		List<Category> FindByName(string name);
		List<Category> GetAll();
		void TextBoxEraser(GroupBox groupBox);

	}
}
