using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstracts;
using Project.Entities.Entities.Models;

namespace Project.Dal.Repositories.Concretes
{
    public class BookTagRepository : BaseRepository<BookTag>, IBookTagRepository
    {
        public BookTagRepository(MyContext context) : base(context)
        {
        }

    }

}
