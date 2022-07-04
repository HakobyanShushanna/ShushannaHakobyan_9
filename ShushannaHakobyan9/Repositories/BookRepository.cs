using ShushannaHakobyan9.Data;
using ShushannaHakobyan9.Models;
using ShushannaHakobyan9.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ShushannaHakobyan9.Repositories
{
    public class BookRepository
    {
        private readonly LibraryDbContext context;

        public BookRepository(LibraryDbContext _context)
        {
            context = _context;
        }

        public List<BookModel> GetAll()
        {
            return context.Books.ToList();
        }

        public void Add(BookModel newBook)
        {
            context.Add(newBook);
            context.SaveChanges();
        }

        public BookModel GetById(int bookId)
        {
            return context.Books.FirstOrDefault(x => x.Id == bookId);
        }
    }
}