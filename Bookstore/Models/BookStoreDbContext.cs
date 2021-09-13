using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class BookStoreDbContext : IdentityDbContext<Visitor>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookVolume> BookVolumes { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public BookStoreDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
