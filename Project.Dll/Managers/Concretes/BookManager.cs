using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstracts;
using Project.Entities.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class BookManager : BaseManager<Book, BookDto>, IBookManager
    {
        public BookManager(IBookRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

}
