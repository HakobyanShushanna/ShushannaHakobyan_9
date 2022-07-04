using AutoMapper;
using ShushannaHakobyan9.Models;
using ShushannaHakobyan9.Repositories;
using ShushannaHakobyan9.ViewModels;
using System.Collections.Generic;

namespace ShushannaHakobyan9.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepo;
        private readonly BookRepository _bookRepo;
        private readonly IMapper _mapper;

        public UserService(UserRepository userRepo,
                            BookRepository bookRepo,
                            IMapper mapper)
        {
            this._userRepo = userRepo;
            this._bookRepo = bookRepo;
            this._mapper = mapper;
        }

        public List<UserModel> GetAll()
        {
            return _userRepo.GetAll();
        }

        public void Add(UserViewModel userViewModel)
        {
            UserModel user = _mapper.Map<UserModel>(userViewModel);
            _userRepo.Add(user);
        }
    }
}
