using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Visitor : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }
        [Required]
        [MaxLength(50)]
        public String Address { get; set; }
    }
}
