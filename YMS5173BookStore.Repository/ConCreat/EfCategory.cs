using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5173BookStore.Entities.Entity;
using YMS5173BookStore.Repository.Abstraction;

namespace YMS5173BookStore.Repository.ConCreat
{
	public class EfCategory : EfBaseRepository, ICategoryRepository
	{
		Category category = new Category();

		public void CreateCategory(string name, string decription)
		{
			category.Name = name;
			category.Description = decription;
			db.Categories.Add(category);
			db.SaveChanges();

		}

		public void DeleteCategory(int id)
		{
			try
			{
				category = db.Categories.FirstOrDefault(x => x.Id == id);
				category.DeleteDate = DateTime.Now;
				category.Status = Status.Passive;
				db.SaveChanges();
			}
			catch (Exception)
			{
				MessageBox.Show("Lütfen Id alanına silmek istediğiniz categorini ıd bilgisini yazınız..!");
			}
		}
	
		public List<Category> FindByName(string name)
		{
			return db.Categories.Where(x => x.Name.ToLower() == name.ToLower()).ToList();
		}

		public List<Category> GetActiveCategory()
		{
			return db.Categories.Where(x => x.Status != Status.Passive).ToList();
		}

		public List<Category> GetAll()
		{
			return db.Categories.ToList();
		}

		/*public void TextBoxEraser()
		{
			
		}*/

		public void TextBoxEraser(GroupBox groupBox)
		{
			foreach (Control item in groupBox.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";

				}

			}
		}

		public void UpdateCategory(int id, string name, string decription)
		{
			category = db.Categories.FirstOrDefault(x => x.Id == id);
			category.Name = name;
			category.Description = decription;
			category.Status = Status.Modified;
			category.UpdateDate = DateTime.Now;
			db.SaveChanges();
		}
	}
}
