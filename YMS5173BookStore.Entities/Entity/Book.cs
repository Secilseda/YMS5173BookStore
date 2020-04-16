using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5173BookStore.Entities.Entity
{
    [Table("Books")]
    public class Book:BaseEntity
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; }
        [Required]
        [MaxLength(256)]
        public string Content { get; set; }
        public string ISNB_No { get; set; }
    }
}
