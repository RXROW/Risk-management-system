using System.Linq;
using System.Threading.Tasks;
using ABPCourse.Demo1.Categories;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Data
{
    public class CategoryDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, int> _categoryRepository;

        public CategoryDataSeedContributor(IRepository<Category, int> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _categoryRepository.GetCountAsync() > 0)
            {
                return;
            }

            var categories = new[]
            {
                new Category
                {
                    NameAr = "الكترونيات",
                    NameEn = "Electronics",
                    DescriptionAr = "قسم الإلكترونيات",
                    DescriptionEn = "Electronics section"
                },
                new Category
                {
                    NameAr = "ملابس",
                    NameEn = "Clothing",
                    DescriptionAr = "قسم الملابس",
                    DescriptionEn = "Clothing section"
                },
                new Category
                {
                    NameAr = "كتب",
                    NameEn = "Books",
                    DescriptionAr = "قسم الكتب",
                    DescriptionEn = "Books section"
                }
            };

            foreach (var category in categories)
            {
                await _categoryRepository.InsertAsync(category, autoSave: true);
            }
        }
    }
} 