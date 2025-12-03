using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstracts;
using Project.Entities.Entities.Models;

namespace Project.Dal.Repositories.Concretes
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(MyContext context) : base(context)
        {
        }

    }
}
