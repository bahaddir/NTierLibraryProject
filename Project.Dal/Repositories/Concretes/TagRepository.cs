using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstracts;
using Project.Entities.Entities.Models;

namespace Project.Dal.Repositories.Concretes
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(MyContext context) : base(context)
        {
        }

    }
}
