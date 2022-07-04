using ShushannaHakobyan9.Models;
using Microsoft.EntityFrameworkCore;

namespace ShushannaHakobyan9.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}