using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edilzhan.Models
{
    public class UserBook
    {
        public int Id { get; set; }
        public List<Book> Books { get; set; }
    }
}
