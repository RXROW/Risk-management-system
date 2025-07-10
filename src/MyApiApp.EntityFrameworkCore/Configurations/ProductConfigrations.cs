using ABPCourse.Demo1.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;
using MyApiApp;

namespace MyApiApp.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention(); 
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
            
            // Configure relationship with Category
            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();

            builder.ToTable("Products");
        }
    }
}