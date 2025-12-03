namespace Project.Entities.Entities.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
    


}
