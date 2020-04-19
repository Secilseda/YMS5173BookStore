using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5173BookStore.DataAccess.Context;

namespace YMS5173BookStore.Repository.ConCreat
{
	public class EfBaseRepository
	{
		public ProjectContext db;
		public EfBaseRepository()
		{
			db = new ProjectContext();
		}
	}
}
