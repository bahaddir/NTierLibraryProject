namespace Project.Entities.Entities.Models
{
    public class Book : BaseEntity
        {
            public string Title { get; set; }
            public short PageCount { get; set; }

            public int AuthorID { get; set; } 
            public int CategoryID { get; set; } 

            public virtual Author Author { get; set; }
            public virtual Category Category { get; set; }

            public virtual ICollection<BookTag> BookTags { get; set; }
        }
    


}
