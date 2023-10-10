using Projekt_.NET.Models;

namespace Projekt_.NET.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public void Add(Category category);
        public void Delete(int id);
        public Category GetOne(int id);
        public List<Category> GetAll();
    }
}
