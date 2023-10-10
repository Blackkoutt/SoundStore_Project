using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository _categoryRepository)
        {
            this._categoryRepository = _categoryRepository;
        }
        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetOne(int id)
        {
            return _categoryRepository.GetOne(id);
        }

    }
}
