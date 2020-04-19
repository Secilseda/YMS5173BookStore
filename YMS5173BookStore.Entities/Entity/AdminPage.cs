using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5173BookStore.Entities.Entity
{
	[Table("AdminPage")]
	public class AdminPage:BaseEntity
	{
		[Required]
		public string Name { get; set; }
		public int Password { get; set; }
	}
}
