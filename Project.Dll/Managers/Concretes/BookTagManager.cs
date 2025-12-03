using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstracts;
using Project.Entities.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class BookTagManager : BaseManager<BookTag, BookTagDto>, IBookTagManager
    {
        public BookTagManager(IBookTagRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

}
