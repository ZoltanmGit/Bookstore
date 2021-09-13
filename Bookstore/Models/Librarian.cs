using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Librarian
    {
        [Key]
        public Int32 LibrarianId { get; set; }
        [Required]
        [MaxLength(50)]
        public String LibrarianName { get; set; }
        [Required]
        public String LibrarianPassword { get; set; }
    }
}
