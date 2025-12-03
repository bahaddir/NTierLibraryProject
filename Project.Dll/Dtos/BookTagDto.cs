namespace Project.Bll.Dtos
{
    public class BookTagDto : BaseDto
    {
        public int BookID { get; set; }
        public int TagID { get; set; }

        public virtual BookDto Book { get; set; }
        public virtual TagDto Tag { get; set; }
    }
}
