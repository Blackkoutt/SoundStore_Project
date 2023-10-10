using Projekt_.NET.Models;

namespace Projekt_.NET.Services.Interfaces
{
    public interface ICategoryService
    {
        public void Add(Category category);
        public void Delete(int id);
        public Category GetOne(int id);
        public List<Category> GetAll();
    }
}
