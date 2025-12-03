namespace Project.Entities.Entities.Models
{
    public class BookTag : BaseEntity
        {
            public int BookID { get; set; }
            public int TagID { get; set; }

            public virtual Book Book { get; set; }
            public virtual Tag Tag { get; set; }
    }
    


}
