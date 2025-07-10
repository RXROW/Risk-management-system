using ABPCourse.Demo1.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;
using MyApiApp;

namespace MyApiApp.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();
            
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            // Configure string length constraints
            builder.Property(x => x.NameAr)
                .HasMaxLength(MyApiAppConsts.GeneralTextMaxLength)
                .IsRequired();
                
            builder.Property(x => x.NameEn)
                .HasMaxLength(MyApiAppConsts.GeneralTextMaxLength)
                .IsRequired();
                
            builder.Property(x => x.DescriptionAr)
                .HasMaxLength(MyApiAppConsts.DescriptionMaxLength);
                
            builder.Property(x => x.DescriptionEn)
                .HasMaxLength(MyApiAppConsts.DescriptionMaxLength);

            builder.ToTable("Categories");
        }
    }
}