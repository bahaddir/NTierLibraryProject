using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Entities.Models;

namespace Project.Conf.Options
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // Tüm Entity'ler için ortak ayarlar
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }

        
    }
}
