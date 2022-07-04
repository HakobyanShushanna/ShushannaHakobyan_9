using AutoMapper;
using ShushannaHakobyan9.Data;
using ShushannaHakobyan9.Models;
using ShushannaHakobyan9.Repositories;
using ShushannaHakobyan9.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ShushannaHakobyan9.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepo;
        private readonly IMapper _mapper;
        public BookService(BookRepository _bookRepo,
                            IMapper _mapper)
        {
            this._bookRepo = _bookRepo;
            this._mapper = _mapper;
        }

        //HttpGet GetAll()
        public List<BookModel> GetAll()
        {
            List<BookModel> books = _bookRepo.GetAll();
            return _mapper.Map<List<BookModel>>(books);
        }



        // HttpPost
        public void Add(BookViewModel bookViewModel)
        {
            BookModel book = _mapper.Map<BookModel>(bookViewModel);
            _bookRepo.Add(book);
        }
    }
}