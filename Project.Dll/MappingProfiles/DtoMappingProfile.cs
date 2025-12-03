using AutoMapper;
using Project.Bll.Dtos;
using Project.Entities.Entities.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project.Bll.MappingProfiles
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Tag, TagDto>().ReverseMap();
            CreateMap<BookTag, BookTagDto>().ReverseMap();

            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ReverseMap();
        }
    }
}