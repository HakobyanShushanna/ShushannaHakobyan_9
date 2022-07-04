using AutoMapper;
using ShushannaHakobyan9.Models;
using ShushannaHakobyan9.ViewModels;

namespace Books.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, UserModel>();
            CreateMap<UserViewModel, UserModel>().
                ForMember(d => d.LastName,
                           opts => opts.MapFrom(s => s.LastName));
        }
    }
}