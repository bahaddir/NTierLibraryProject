namespace Project.Bll.Dtos
{
    public class BookDto : BaseDto
    {
        public string Title { get; set; }
        public short PageCount { get; set; }

        public int AuthorID { get; set; }
        public int CategoryID { get; set; }

        public virtual AuthorDto Author { get; set; }
        public virtual CategoryDto Category { get; set; }
        public virtual List<BookTagDto> BookTags { get; set; }
    }
}
