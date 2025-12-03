using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstracts;
using Project.Entities.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class AuthorManager : BaseManager<Author, AuthorDto>, IAuthorManager
    {
        public AuthorManager(IAuthorRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

}
