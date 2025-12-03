using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Entities.Models;

namespace Project.Conf.Options
{
    public class BookTagConfiguration : BaseConfiguration<BookTag>
    {
        public override void Configure(EntityTypeBuilder<BookTag> builder)
        {
            base.Configure(builder);

            builder.HasKey(bt => new { bt.BookID, bt.TagID });

            builder.Ignore(bt => bt.ID);

            builder.HasOne(bt => bt.Book)
                   .WithMany(b => b.BookTags)
                   .HasForeignKey(bt => bt.BookID);

            builder.HasOne(bt => bt.Tag)
                   .WithMany(t => t.BookTags)
                   .HasForeignKey(bt => bt.TagID);
        }
    }
}
