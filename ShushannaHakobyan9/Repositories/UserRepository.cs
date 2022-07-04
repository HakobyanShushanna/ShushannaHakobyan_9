using ShushannaHakobyan9.Data;
using ShushannaHakobyan9.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShushannaHakobyan9.Repositories
{
    public class UserRepository
    {
        private readonly LibraryDbContext context;

        public UserRepository(LibraryDbContext _context)
        {
            context = _context;
        }

        public List<UserModel> GetAll()
        {
            return context.Users.ToList();
        }

        public List<UserModel> GetAllWithBooksByName(string name)
        {
            return context.Users.Where(x => x.FirstName == name).ToList();
        }

        public void Add(UserModel newUser)
        {
            context.Add(newUser);
            context.SaveChanges();
        }

        public UserModel GetById(int userId)
        {
            return context.Users.FirstOrDefault(x => x.Id == userId);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}