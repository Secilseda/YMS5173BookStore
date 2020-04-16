using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5173BookStore.Entities.Entity
{
    public enum Role
    {
        Admin=1,
        Employee=2,
        Customer=3,
        Author=4
    }

    public class AppUser:BaseEntity
    {

    }
}
