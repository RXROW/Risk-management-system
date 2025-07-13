using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;
using MyApiApp.Domain;

namespace MyApiApp.Configurations
{
    internal class EntityConfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.ConfigureByConvention();
            
            builder.Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();
                
            builder.Property(x => x.Description)
                .HasMaxLength(1000)
                .IsRequired();
                
            builder.Property(x => x.OwnerId)
                .IsRequired(false);

            builder.ToTable("Entities");
        }
    }
} 