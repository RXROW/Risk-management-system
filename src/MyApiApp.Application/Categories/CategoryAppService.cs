using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ABPCourse.Demo1.Categories;
using MyApiApp.Categories;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Categories
{
    public class CategoryAppService : ApplicationService
    {
        private readonly IRepository<Category, int> _categoryRepository;

        public CategoryAppService(IRepository<Category, int> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDto> GetAsync(int id)
        {
            var category = await _categoryRepository.GetAsync(id);
            return ObjectMapper.Map<Category, CategoryDto>(category);
        }

        public async Task<List<CategoryDto>> GetListAsync()
        {
            var categories = await _categoryRepository.GetListAsync();
            return ObjectMapper.Map<List<Category>, List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> CreateAsync(CreateUpdateCategoryDto input)
        {
            var category = ObjectMapper.Map<CreateUpdateCategoryDto, Category>(input);
            var created = await _categoryRepository.InsertAsync(category, autoSave: true);
            return ObjectMapper.Map<Category, CategoryDto>(created);
        }

        public async Task<CategoryDto> UpdateAsync(int id, CreateUpdateCategoryDto input)
        {
            var category = await _categoryRepository.GetAsync(id);
            ObjectMapper.Map(input, category);
            var updated = await _categoryRepository.UpdateAsync(category, autoSave: true);
            return ObjectMapper.Map<Category, CategoryDto>(updated);
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
} 