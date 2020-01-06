using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edilzhan.Models
{
    public class ApplicationUser : IdentityUser
    {
        public UserBook UserBook { get; set; }
    }
}
