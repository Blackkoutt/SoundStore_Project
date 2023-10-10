using Projekt_.NET.Models;

namespace Projekt_.NET.Repositories.Interfaces
{
    public interface IProducerRepository
    {
        public void Add(Producer producer);
        public void Delete(int id);
        public Producer GetOne(int id);
        public List<Producer> GetAll();
    }
}
