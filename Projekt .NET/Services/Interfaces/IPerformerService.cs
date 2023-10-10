using Projekt_.NET.DTO;
using Projekt_.NET.Models;

namespace Projekt_.NET.Services.Interfaces
{
    public interface IPerformerService
    {
        public void Add(PerformerDto performer);
        public void Delete(int id);
        public Performer GetOne(int id);
        public List<Performer> GetAll();
    }
}
