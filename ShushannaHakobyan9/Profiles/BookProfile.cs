using AutoMapper;
using ShushannaHakobyan9.Models;
using ShushannaHakobyan9.ViewModels;

namespace Books.MapperProfiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<BookViewModel, BookModel>();
            CreateMap<BookModel, BookModel>()
                .ForMember(x => x.TotalCount,
                opts => opts.MapFrom(x => x.TotalCount > 0 ? $"There are {x.TotalCount} availible books" : "Not found"));
        }
    }
}