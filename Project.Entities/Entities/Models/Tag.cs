namespace Project.Entities.Entities.Models
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }

        public virtual ICollection<BookTag> BookTags { get; set; }
    }
    


}
