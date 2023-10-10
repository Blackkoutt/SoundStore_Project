using Projekt_.NET.Models;

namespace Projekt_.NET.Repositories.Interfaces
{
    public interface IPerformerRepository
    {
        public void Add(Performer performer);
        public void Delete(int id);
        public Performer GetOne(int id);
        public List<Performer> GetAll();
    }
}
